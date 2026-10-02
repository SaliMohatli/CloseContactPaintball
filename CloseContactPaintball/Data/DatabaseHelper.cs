using System;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;

namespace CloseContactPaintball.Data
{
    public static class DatabaseHelper
    {
        // Target SQL Server LocalDB instance: (localdb)\MSSQLLocalDB
        public static string DatabaseName { get; set; } = "CloseContactPaintball";
        public static string ServerName { get; set; } = @"(localdb)\MSSQLLocalDB";

        public static string ConnectionString =>
            $"Server={ServerName};Database={DatabaseName};Trusted_Connection=True;TrustServerCertificate=True;Connection Timeout=15;";

        public static string MasterConnectionString =>
            $"Server={ServerName};Database=master;Trusted_Connection=True;TrustServerCertificate=True;Connection Timeout=15;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public static SqlConnection GetMasterConnection()
        {
            return new SqlConnection(MasterConnectionString);
        }

        /// <summary>
        /// Ensures the database, tables, stored procedures, and initial seed data exist.
        /// Can be called on application startup.
        /// </summary>
        public static void InitializeDatabase()
        {
            try
            {
                // 1. Check if database exists; if not, create it
                using (var masterConn = GetMasterConnection())
                {
                    masterConn.Open();
                    using var checkCmd = new SqlCommand(
                        $"IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'{DatabaseName}') CREATE DATABASE [{DatabaseName}];",
                        masterConn);
                    checkCmd.ExecuteNonQuery();
                }

                // 2. Check if tables exist in the target database
                bool tablesExist = false;
                using (var conn = GetConnection())
                {
                    conn.Open();
                    using var tableCmd = new SqlCommand(
                        "SELECT COUNT(*) FROM sys.tables WHERE name IN ('USER_ACCOUNT', 'TOURIST', 'INVENTORY_ITEM', 'EVENT', 'PAYMENT', 'ISSUANCE');",
                        conn);
                    int count = (int)(tableCmd.ExecuteScalar() ?? 0);
                    tablesExist = (count >= 6);
                }

                if (!tablesExist)
                {
                    ExecuteSetupScript();
                }
                else
                {
                    // Ensure stored procedures exist
                    EnsureStoredProcedures();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Database initialization note: {ex.Message}");
                // Will bubble up if critical or can be handled in UI
                throw;
            }
        }

        private static void ExecuteSetupScript()
        {
            // Try to find DatabaseSetup.sql in parent directories
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string? scriptPath = null;

            string[] possiblePaths = new[]
            {
                Path.Combine(baseDir, "Database", "CloseContactPaintball.sql"),
                Path.Combine(baseDir, "..", "..", "..", "..", "Database", "CloseContactPaintball.sql"),
                Path.Combine(baseDir, "..", "..", "..", "Database", "CloseContactPaintball.sql"),
                Path.Combine(baseDir, "..", "Database", "CloseContactPaintball.sql")
            };

            foreach (var path in possiblePaths)
            {
                if (File.Exists(path))
                {
                    scriptPath = Path.GetFullPath(path);
                    break;
                }
            }

            if (scriptPath != null && File.Exists(scriptPath))
            {
                string script = File.ReadAllText(scriptPath);
                ExecuteSqlScriptBatches(script);
            }
            else
            {
                // Fallback: embedded schema definition
                ExecuteEmbeddedFallbackSetup();
            }
        }

        private static void ExecuteSqlScriptBatches(string fullScript)
        {
            // Split script by GO statements
            string[] batches = Regex.Split(fullScript, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

            using var conn = GetMasterConnection();
            conn.Open();

            foreach (var batch in batches)
            {
                string sql = batch.Trim();
                if (string.IsNullOrWhiteSpace(sql)) continue;

                try
                {
                    using var cmd = new SqlCommand(sql, conn);
                    cmd.CommandTimeout = 60;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Batch execution warning: {ex.Message}");
                }
            }
        }

        private static void EnsureStoredProcedures()
        {
            // Ensure all 5 stored procedures exist
            using var conn = GetConnection();
            conn.Open();

            string checkProcSql = @"
                IF OBJECT_ID(N'dbo.sp_IssueGear', N'P') IS NULL OR 
                   OBJECT_ID(N'dbo.sp_ReturnGear', N'P') IS NULL OR 
                   OBJECT_ID(N'dbo.sp_GetBookingFinancialSummary', N'P') IS NULL OR
                   OBJECT_ID(N'dbo.sp_GetDateRangeRevenueReport', N'P') IS NULL OR
                   OBJECT_ID(N'dbo.sp_GetDashboardMetrics', N'P') IS NULL
                SELECT 0 ELSE SELECT 1;
            ";

            using var checkCmd = new SqlCommand(checkProcSql, conn);
            int exists = (int)(checkCmd.ExecuteScalar() ?? 0);
            if (exists == 0)
            {
                ExecuteSetupScript();
            }
        }

        private static void ExecuteEmbeddedFallbackSetup()
        {
            // Embedded minimal creation if file not found
            using var conn = GetConnection();
            conn.Open();

            string createTables = @"
                IF OBJECT_ID(N'dbo.USER_ACCOUNT', N'U') IS NULL
                CREATE TABLE dbo.USER_ACCOUNT (
                    UserID INT IDENTITY(1,1) PRIMARY KEY,
                    Username VARCHAR(50) NOT NULL UNIQUE,
                    PasswordHash VARCHAR(255) NOT NULL,
                    Role VARCHAR(15) NOT NULL
                );

                IF OBJECT_ID(N'dbo.TOURIST', N'U') IS NULL
                CREATE TABLE dbo.TOURIST (
                    TouristID INT IDENTITY(1,1) PRIMARY KEY,
                    FirstName VARCHAR(50) NOT NULL,
                    Surname VARCHAR(50) NOT NULL,
                    WaiverSigned BIT NOT NULL DEFAULT 0
                );

                IF OBJECT_ID(N'dbo.INVENTORY_ITEM', N'U') IS NULL
                CREATE TABLE dbo.INVENTORY_ITEM (
                    ItemID INT IDENTITY(1,1) PRIMARY KEY,
                    SerialNumber VARCHAR(30) NOT NULL UNIQUE,
                    ItemType VARCHAR(20) NOT NULL,
                    Size VARCHAR(5) NULL,
                    Status VARCHAR(20) NOT NULL DEFAULT 'Ready',
                    PurchaseCost DECIMAL(8,2) NOT NULL DEFAULT 0.00
                );

                IF OBJECT_ID(N'dbo.EVENT', N'U') IS NULL
                CREATE TABLE dbo.EVENT (
                    EventID INT IDENTITY(1,1) PRIMARY KEY,
                    TouristID INT NOT NULL FOREIGN KEY REFERENCES dbo.TOURIST(TouristID),
                    UserID INT NOT NULL FOREIGN KEY REFERENCES dbo.USER_ACCOUNT(UserID),
                    EventDate DATE NOT NULL,
                    EventType VARCHAR(30) NOT NULL,
                    FieldAssignment VARCHAR(20) NOT NULL,
                    NumberOfPlayers INT NOT NULL,
                    DepositAmount DECIMAL(8,2) NOT NULL DEFAULT 0.00,
                    PaymentMethod VARCHAR(10) NOT NULL,
                    SpecialRequirements VARCHAR(255) NULL
                );

                IF OBJECT_ID(N'dbo.PAYMENT', N'U') IS NULL
                CREATE TABLE dbo.PAYMENT (
                    PaymentID INT IDENTITY(1,1) PRIMARY KEY,
                    EventID INT NOT NULL FOREIGN KEY REFERENCES dbo.EVENT(EventID),
                    PaymentDate DATE NOT NULL,
                    Amount DECIMAL(8,2) NOT NULL,
                    PaymentMethod VARCHAR(10) NOT NULL
                );

                IF OBJECT_ID(N'dbo.ISSUANCE', N'U') IS NULL
                CREATE TABLE dbo.ISSUANCE (
                    IssuanceID INT IDENTITY(1,1) PRIMARY KEY,
                    EventID INT NOT NULL FOREIGN KEY REFERENCES dbo.EVENT(EventID),
                    TouristID INT NOT NULL FOREIGN KEY REFERENCES dbo.TOURIST(TouristID),
                    ItemID INT NOT NULL FOREIGN KEY REFERENCES dbo.INVENTORY_ITEM(ItemID),
                    IssueDateTime DATETIME NOT NULL DEFAULT GETDATE(),
                    ReturnDateTime DATETIME NULL,
                    ReturnCondition VARCHAR(20) NULL
                );
            ";

            using var cmd = new SqlCommand(createTables, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
