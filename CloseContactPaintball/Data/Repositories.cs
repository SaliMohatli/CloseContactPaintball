using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using CloseContactPaintball.Models;

namespace CloseContactPaintball.Data
{
    public class UserRepository
    {
        public UserAccount? Authenticate(string username, string passwordHash)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            const string sql = "SELECT UserID, Username, PasswordHash, Role FROM dbo.USER_ACCOUNT WHERE Username = @Username AND PasswordHash = @PasswordHash";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new UserAccount
                {
                    UserID = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    PasswordHash = reader.GetString(2),
                    Role = reader.GetString(3)
                };
            }
            return null;
        }

        public List<UserAccount> GetAllUsers()
        {
            var list = new List<UserAccount>();
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            const string sql = "SELECT UserID, Username, PasswordHash, Role FROM dbo.USER_ACCOUNT ORDER BY Username";
            using var cmd = new SqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new UserAccount
                {
                    UserID = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    PasswordHash = reader.GetString(2),
                    Role = reader.GetString(3)
                });
            }
            return list;
        }
    }

    public class PlayerRepository
    {
        public List<Tourist> GetAll()
        {
            var list = new List<Tourist>();
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            const string sql = "SELECT TouristID, FirstName, Surname, WaiverSigned FROM dbo.TOURIST ORDER BY Surname, FirstName";
            using var cmd = new SqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Tourist
                {
                    TouristID = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    Surname = reader.GetString(2),
                    WaiverSigned = reader.GetBoolean(3)
                });
            }
            return list;
        }

        public List<Tourist> Search(string query)
        {
            var list = new List<Tourist>();
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            const string sql = @"
                SELECT TouristID, FirstName, Surname, WaiverSigned 
                FROM dbo.TOURIST 
                WHERE FirstName LIKE @Query OR Surname LIKE @Query
                ORDER BY Surname, FirstName";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Query", $"%{query}%");
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Tourist
                {
                    TouristID = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    Surname = reader.GetString(2),
                    WaiverSigned = reader.GetBoolean(3)
                });
            }
            return list;
        }

        public int Insert(Tourist tourist)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            const string sql = @"
                INSERT INTO dbo.TOURIST (FirstName, Surname, WaiverSigned)
                VALUES (@FirstName, @Surname, @WaiverSigned);
                SELECT SCOPE_IDENTITY();";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@FirstName", tourist.FirstName.Trim());
            cmd.Parameters.AddWithValue("@Surname", tourist.Surname.Trim());
            cmd.Parameters.AddWithValue("@WaiverSigned", tourist.WaiverSigned);

            tourist.TouristID = Convert.ToInt32(cmd.ExecuteScalar());
            return tourist.TouristID;
        }

        public void Update(Tourist tourist)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            const string sql = @"
                UPDATE dbo.TOURIST 
                SET FirstName = @FirstName, Surname = @Surname, WaiverSigned = @WaiverSigned
                WHERE TouristID = @TouristID";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@FirstName", tourist.FirstName.Trim());
            cmd.Parameters.AddWithValue("@Surname", tourist.Surname.Trim());
            cmd.Parameters.AddWithValue("@WaiverSigned", tourist.WaiverSigned);
            cmd.Parameters.AddWithValue("@TouristID", tourist.TouristID);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int touristId)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            const string sql = "DELETE FROM dbo.TOURIST WHERE TouristID = @TouristID";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TouristID", touristId);
            cmd.ExecuteNonQuery();
        }
    }

    public class GearRepository
    {
        public List<InventoryItem> GetAll()
        {
            var list = new List<InventoryItem>();
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            const string sql = "SELECT ItemID, SerialNumber, ItemType, Size, Status, PurchaseCost FROM dbo.INVENTORY_ITEM ORDER BY ItemType, SerialNumber";
            using var cmd = new SqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new InventoryItem
                {
                    ItemID = reader.GetInt32(0),
                    SerialNumber = reader.GetString(1),
                    ItemType = reader.GetString(2),
                    Size = reader.IsDBNull(3) ? "-" : reader.GetString(3),
                    Status = reader.GetString(4),
                    PurchaseCost = reader.GetDecimal(5)
                });
            }
            return list;
        }

        public List<InventoryItem> GetReadyItems()
        {
            var list = new List<InventoryItem>();
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            const string sql = "SELECT ItemID, SerialNumber, ItemType, Size, Status, PurchaseCost FROM dbo.INVENTORY_ITEM WHERE Status = 'Ready' ORDER BY ItemType, SerialNumber";
            using var cmd = new SqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new InventoryItem
                {
                    ItemID = reader.GetInt32(0),
                    SerialNumber = reader.GetString(1),
                    ItemType = reader.GetString(2),
                    Size = reader.IsDBNull(3) ? "-" : reader.GetString(3),
                    Status = reader.GetString(4),
                    PurchaseCost = reader.GetDecimal(5)
                });
            }
            return list;
        }

        public List<InventoryItem> Search(string serialQuery)
        {
            var list = new List<InventoryItem>();
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            const string sql = "SELECT ItemID, SerialNumber, ItemType, Size, Status, PurchaseCost FROM dbo.INVENTORY_ITEM WHERE SerialNumber LIKE @Query ORDER BY SerialNumber";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Query", $"%{serialQuery}%");
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new InventoryItem
                {
                    ItemID = reader.GetInt32(0),
                    SerialNumber = reader.GetString(1),
                    ItemType = reader.GetString(2),
                    Size = reader.IsDBNull(3) ? "-" : reader.GetString(3),
                    Status = reader.GetString(4),
                    PurchaseCost = reader.GetDecimal(5)
                });
            }
            return list;
        }

        public int Insert(InventoryItem item)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            const string sql = @"
                INSERT INTO dbo.INVENTORY_ITEM (SerialNumber, ItemType, Size, Status, PurchaseCost)
                VALUES (@SerialNumber, @ItemType, @Size, @Status, @PurchaseCost);
                SELECT SCOPE_IDENTITY();";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@SerialNumber", item.SerialNumber.Trim().ToUpper());
            cmd.Parameters.AddWithValue("@ItemType", item.ItemType);
            cmd.Parameters.AddWithValue("@Size", string.IsNullOrWhiteSpace(item.Size) ? (object)DBNull.Value : item.Size);
            cmd.Parameters.AddWithValue("@Status", item.Status);
            cmd.Parameters.AddWithValue("@PurchaseCost", item.PurchaseCost);

            item.ItemID = Convert.ToInt32(cmd.ExecuteScalar());
            return item.ItemID;
        }

        public void Update(InventoryItem item)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            const string sql = @"
                UPDATE dbo.INVENTORY_ITEM 
                SET SerialNumber = @SerialNumber, ItemType = @ItemType, Size = @Size, Status = @Status, PurchaseCost = @PurchaseCost
                WHERE ItemID = @ItemID";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@SerialNumber", item.SerialNumber.Trim().ToUpper());
            cmd.Parameters.AddWithValue("@ItemType", item.ItemType);
            cmd.Parameters.AddWithValue("@Size", string.IsNullOrWhiteSpace(item.Size) ? (object)DBNull.Value : item.Size);
            cmd.Parameters.AddWithValue("@Status", item.Status);
            cmd.Parameters.AddWithValue("@PurchaseCost", item.PurchaseCost);
            cmd.Parameters.AddWithValue("@ItemID", item.ItemID);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int itemId)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            const string sql = "DELETE FROM dbo.INVENTORY_ITEM WHERE ItemID = @ItemID";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ItemID", itemId);
            cmd.ExecuteNonQuery();
        }
    }

    public class BookingRepository
    {
        public List<EventBooking> GetAll()
        {
            var list = new List<EventBooking>();
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            const string sql = @"
                SELECT e.EventID, e.TouristID, e.UserID, e.EventDate, e.EventType, e.FieldAssignment, 
                       e.NumberOfPlayers,
                       (t.FirstName + ' ' + t.Surname) AS CustomerName
                FROM dbo.EVENT e
                INNER JOIN dbo.TOURIST t ON e.TouristID = t.TouristID
                ORDER BY e.EventDate DESC, e.EventID DESC";
            using var cmd = new SqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new EventBooking
                {
                    EventID = reader.GetInt32(0),
                    TouristID = reader.GetInt32(1),
                    UserID = reader.GetInt32(2),
                    EventDate = reader.GetDateTime(3),
                    EventType = reader.GetString(4),
                    FieldAssignment = reader.GetString(5),
                    NumberOfPlayers = reader.GetInt32(6),
                    CustomerName = reader.GetString(7)
                });
            }
            return list;
        }

        public List<EventBooking> Search(string customerQuery)
        {
            var list = new List<EventBooking>();
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            const string sql = @"
                SELECT e.EventID, e.TouristID, e.UserID, e.EventDate, e.EventType, e.FieldAssignment, 
                       e.NumberOfPlayers,
                       (t.FirstName + ' ' + t.Surname) AS CustomerName
                FROM dbo.EVENT e
                INNER JOIN dbo.TOURIST t ON e.TouristID = t.TouristID
                WHERE t.FirstName LIKE @Q OR t.Surname LIKE @Q OR e.FieldAssignment LIKE @Q OR e.EventType LIKE @Q
                ORDER BY e.EventDate DESC, e.EventID DESC";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Q", $"%{customerQuery}%");
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new EventBooking
                {
                    EventID = reader.GetInt32(0),
                    TouristID = reader.GetInt32(1),
                    UserID = reader.GetInt32(2),
                    EventDate = reader.GetDateTime(3),
                    EventType = reader.GetString(4),
                    FieldAssignment = reader.GetString(5),
                    NumberOfPlayers = reader.GetInt32(6),
                    CustomerName = reader.GetString(7)
                });
            }
            return list;
        }

        public int Insert(EventBooking booking)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            const string sql = @"
                INSERT INTO dbo.EVENT (TouristID, UserID, EventDate, EventType, FieldAssignment, NumberOfPlayers)
                VALUES (@TouristID, @UserID, @EventDate, @EventType, @FieldAssignment, @NumberOfPlayers);
                SELECT SCOPE_IDENTITY();";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TouristID", booking.TouristID);
            cmd.Parameters.AddWithValue("@UserID", booking.UserID);
            cmd.Parameters.AddWithValue("@EventDate", booking.EventDate.Date);
            cmd.Parameters.AddWithValue("@EventType", booking.EventType);
            cmd.Parameters.AddWithValue("@FieldAssignment", booking.FieldAssignment);
            cmd.Parameters.AddWithValue("@NumberOfPlayers", Math.Clamp(booking.NumberOfPlayers, 1, 6));

            booking.EventID = Convert.ToInt32(cmd.ExecuteScalar());
            return booking.EventID;
        }

        public void Update(EventBooking booking)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            const string sql = @"
                UPDATE dbo.EVENT 
                SET TouristID = @TouristID, UserID = @UserID, EventDate = @EventDate, EventType = @EventType,
                    FieldAssignment = @FieldAssignment, NumberOfPlayers = @NumberOfPlayers
                WHERE EventID = @EventID";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TouristID", booking.TouristID);
            cmd.Parameters.AddWithValue("@UserID", booking.UserID);
            cmd.Parameters.AddWithValue("@EventDate", booking.EventDate.Date);
            cmd.Parameters.AddWithValue("@EventType", booking.EventType);
            cmd.Parameters.AddWithValue("@FieldAssignment", booking.FieldAssignment);
            cmd.Parameters.AddWithValue("@NumberOfPlayers", Math.Clamp(booking.NumberOfPlayers, 1, 6));
            cmd.Parameters.AddWithValue("@EventID", booking.EventID);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int eventId)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            const string sql = "DELETE FROM dbo.EVENT WHERE EventID = @EventID";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@EventID", eventId);
            cmd.ExecuteNonQuery();
        }
    }

    public class IssuanceRepository
    {
        public int IssueGear(int eventId, int touristId, int itemId)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new SqlCommand("dbo.sp_IssueGear", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EventID", eventId);
            cmd.Parameters.AddWithValue("@TouristID", touristId);
            cmd.Parameters.AddWithValue("@ItemID", itemId);

            var outParam = new SqlParameter("@NewIssuanceID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(outParam);

            cmd.ExecuteNonQuery();
            return (int)outParam.Value;
        }

        public void ReturnGear(int issuanceId, string returnCondition)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new SqlCommand("dbo.sp_ReturnGear", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IssuanceID", issuanceId);
            cmd.Parameters.AddWithValue("@ReturnCondition", returnCondition);
            cmd.ExecuteNonQuery();
        }

        public List<Issuance> GetActiveIssuances(int? eventId = null)
        {
            var list = new List<Issuance>();
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();

            string sql = @"
                SELECT i.IssuanceID, i.EventID, i.TouristID, i.ItemID, i.IssueDateTime, i.ReturnDateTime, i.ReturnCondition,
                       (t.FirstName + ' ' + t.Surname) AS CustomerName,
                       item.ItemType, item.SerialNumber, item.Size
                FROM dbo.ISSUANCE i
                INNER JOIN dbo.TOURIST t ON i.TouristID = t.TouristID
                INNER JOIN dbo.INVENTORY_ITEM item ON i.ItemID = item.ItemID
                WHERE i.ReturnDateTime IS NULL";

            if (eventId.HasValue)
            {
                sql += " AND i.EventID = @EventID";
            }
            sql += " ORDER BY i.IssueDateTime DESC";

            using var cmd = new SqlCommand(sql, conn);
            if (eventId.HasValue)
            {
                cmd.Parameters.AddWithValue("@EventID", eventId.Value);
            }

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Issuance
                {
                    IssuanceID = reader.GetInt32(0),
                    EventID = reader.GetInt32(1),
                    TouristID = reader.GetInt32(2),
                    ItemID = reader.GetInt32(3),
                    IssueDateTime = reader.GetDateTime(4),
                    ReturnDateTime = reader.IsDBNull(5) ? null : reader.GetDateTime(5),
                    ReturnCondition = reader.IsDBNull(6) ? null : reader.GetString(6),
                    CustomerName = reader.GetString(7),
                    ItemType = reader.GetString(8),
                    SerialNumber = reader.GetString(9),
                    ItemSize = reader.IsDBNull(10) ? "-" : reader.GetString(10)
                });
            }
            return list;
        }
    }

    public class PaymentRepository
    {
        public int InsertPayment(Payment payment)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            const string sql = @"
                INSERT INTO dbo.PAYMENT (EventID, PaymentDate, Amount)
                VALUES (@EventID, @PaymentDate, @Amount);
                SELECT SCOPE_IDENTITY();";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@EventID", payment.EventID);
            cmd.Parameters.AddWithValue("@PaymentDate", payment.PaymentDate.Date);
            cmd.Parameters.AddWithValue("@Amount", payment.Amount);

            payment.PaymentID = Convert.ToInt32(cmd.ExecuteScalar());
            return payment.PaymentID;
        }

        public BookingPaymentSummary? GetFinancialSummary(int eventId)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new SqlCommand("dbo.sp_GetBookingPaymentSummary", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EventID", eventId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new BookingPaymentSummary
                {
                    EventID = reader.GetInt32(0),
                    CustomerName = reader.GetString(1),
                    EventDate = reader.GetDateTime(2),
                    EventType = reader.GetString(3),
                    FieldAssignment = reader.GetString(4),
                    NumberOfPlayers = reader.GetInt32(5),
                    TotalPackageCost = reader.GetDecimal(6),
                    TotalPaid = reader.GetDecimal(7),
                    BalanceDue = reader.GetDecimal(8)
                };
            }
            return null;
        }

        public (List<Payment> Payments, int TotalTransactions, decimal GrandTotal) GetRevenueReport(DateTime startDate, DateTime endDate)
        {
            var payments = new List<Payment>();
            int totalCount = 0;
            decimal grandTotal = 0m;

            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new SqlCommand("dbo.sp_GetDateRangeRevenueReport", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DateTime safeStart = startDate < new DateTime(1753, 1, 1) ? new DateTime(1753, 1, 1) : startDate.Date;
            DateTime safeEnd = endDate > new DateTime(9999, 12, 31) ? new DateTime(9999, 12, 31) : endDate.Date;
            cmd.Parameters.Add("@StartDate", SqlDbType.Date).Value = safeStart;
            cmd.Parameters.Add("@EndDate", SqlDbType.Date).Value = safeEnd;

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                payments.Add(new Payment
                {
                    PaymentID = reader.GetInt32(0),
                    PaymentDate = reader.GetDateTime(1),
                    EventID = reader.GetInt32(2),
                    CustomerName = reader.GetString(3),
                    EventType = reader.GetString(4),
                    Amount = reader.GetDecimal(5)
                });
            }

            if (reader.NextResult() && reader.Read())
            {
                totalCount = reader.GetInt32(0);
                grandTotal = reader.GetDecimal(1);
            }

            return (payments, totalCount, grandTotal);
        }
    }

    public class DashboardRepository
    {
        public DashboardMetrics GetMetrics()
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var cmd = new SqlCommand("dbo.sp_GetDashboardMetrics", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new DashboardMetrics
                {
                    BookingsToday = reader.GetInt32(0),
                    GearReady = reader.GetInt32(1),
                    GearInUse = reader.GetInt32(2)
                };
            }
            return new DashboardMetrics();
        }
    }
}
