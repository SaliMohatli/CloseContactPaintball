USE master;
GO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'CloseContactPaintball')
BEGIN
    CREATE DATABASE [CloseContactPaintball];
END
GO

USE [CloseContactPaintball];
GO

DROP PROCEDURE IF EXISTS dbo.sp_GetDashboardMetrics;
DROP PROCEDURE IF EXISTS dbo.sp_GetDateRangeRevenueReport;
DROP PROCEDURE IF EXISTS dbo.sp_GetBookingPaymentSummary;
DROP PROCEDURE IF EXISTS dbo.sp_ReturnGear;
DROP PROCEDURE IF EXISTS dbo.sp_IssueGear;

DROP TABLE IF EXISTS dbo.ISSUANCE;
DROP TABLE IF EXISTS dbo.PAYMENT;
DROP TABLE IF EXISTS dbo.EVENT;
DROP TABLE IF EXISTS dbo.INVENTORY_ITEM;
DROP TABLE IF EXISTS dbo.TOURIST;
DROP TABLE IF EXISTS dbo.USER_ACCOUNT;
GO

CREATE TABLE dbo.USER_ACCOUNT (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    Role VARCHAR(15) NOT NULL
);
GO

CREATE TABLE dbo.TOURIST (
    TouristID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    Surname VARCHAR(50) NOT NULL,
    WaiverSigned BIT NOT NULL DEFAULT 0
);
GO

CREATE TABLE dbo.INVENTORY_ITEM (
    ItemID INT IDENTITY(1,1) PRIMARY KEY,
    SerialNumber VARCHAR(30) NOT NULL UNIQUE,
    ItemType VARCHAR(20) NOT NULL,
    Size VARCHAR(5) NULL,
    Status VARCHAR(20) NOT NULL DEFAULT 'Ready',
    PurchaseCost DECIMAL(8,2) NOT NULL DEFAULT 0.00
);
GO

CREATE TABLE dbo.EVENT (
    EventID INT IDENTITY(1,1) PRIMARY KEY,
    TouristID INT NOT NULL FOREIGN KEY REFERENCES dbo.TOURIST(TouristID),
    UserID INT NOT NULL FOREIGN KEY REFERENCES dbo.USER_ACCOUNT(UserID),
    EventDate DATE NOT NULL,
    EventType VARCHAR(30) NOT NULL,
    FieldAssignment VARCHAR(20) NOT NULL,
    NumberOfPlayers INT NOT NULL CHECK (NumberOfPlayers BETWEEN 1 AND 6)
);
GO

CREATE TABLE dbo.PAYMENT (
    PaymentID INT IDENTITY(1,1) PRIMARY KEY,
    EventID INT NOT NULL FOREIGN KEY REFERENCES dbo.EVENT(EventID) ON DELETE CASCADE,
    PaymentDate DATE NOT NULL,
    Amount DECIMAL(8,2) NOT NULL
);
GO

CREATE TABLE dbo.ISSUANCE (
    IssuanceID INT IDENTITY(1,1) PRIMARY KEY,
    EventID INT NOT NULL FOREIGN KEY REFERENCES dbo.EVENT(EventID),
    TouristID INT NOT NULL FOREIGN KEY REFERENCES dbo.TOURIST(TouristID),
    ItemID INT NOT NULL FOREIGN KEY REFERENCES dbo.INVENTORY_ITEM(ItemID),
    IssueDateTime DATETIME NOT NULL DEFAULT GETDATE(),
    ReturnDateTime DATETIME NULL,
    ReturnCondition VARCHAR(20) NULL
);
GO

-- Stored Procedure 1: sp_IssueGear
-- Issues a gear item to a player for a booking and marks the item as 'In use'
CREATE PROCEDURE dbo.sp_IssueGear
    @EventID INT,
    @TouristID INT,
    @ItemID INT,
    @NewIssuanceID INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.ISSUANCE (EventID, TouristID, ItemID, IssueDateTime)
    VALUES (@EventID, @TouristID, @ItemID, GETDATE());

    SET @NewIssuanceID = SCOPE_IDENTITY();

    UPDATE dbo.INVENTORY_ITEM
    SET Status = 'In use'
    WHERE ItemID = @ItemID;
END;
GO

-- Stored Procedure 2: sp_ReturnGear
-- Records the return timestamp and condition, and updates inventory status
CREATE PROCEDURE dbo.sp_ReturnGear
    @IssuanceID INT,
    @ReturnCondition VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ItemID INT;
    SELECT @ItemID = ItemID FROM dbo.ISSUANCE WHERE IssuanceID = @IssuanceID;

    UPDATE dbo.ISSUANCE
    SET ReturnDateTime = GETDATE(),
        ReturnCondition = @ReturnCondition
    WHERE IssuanceID = @IssuanceID;

    UPDATE dbo.INVENTORY_ITEM
    SET Status = @ReturnCondition
    WHERE ItemID = @ItemID;
END;
GO

-- Stored Procedure 3: sp_GetBookingPaymentSummary
-- Calculates package total (NumberOfPlayers * R250), total payments, and balance due
CREATE PROCEDURE dbo.sp_GetBookingPaymentSummary
    @EventID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        e.EventID,
        (t.FirstName + ' ' + t.Surname) AS CustomerName,
        e.EventDate,
        e.EventType,
        e.FieldAssignment,
        e.NumberOfPlayers,
        (e.NumberOfPlayers * 250.00) AS TotalPackageCost,
        ISNULL(SUM(p.Amount), 0.00) AS TotalPaid,
        ((e.NumberOfPlayers * 250.00) - ISNULL(SUM(p.Amount), 0.00)) AS BalanceDue
    FROM dbo.EVENT e
    INNER JOIN dbo.TOURIST t ON e.TouristID = t.TouristID
    LEFT JOIN dbo.PAYMENT p ON e.EventID = p.EventID
    WHERE e.EventID = @EventID
    GROUP BY 
        e.EventID, t.FirstName, t.Surname, e.EventDate, 
        e.EventType, e.FieldAssignment, e.NumberOfPlayers;
END;
GO

-- Stored Procedure 4: sp_GetDateRangeRevenueReport
-- Returns all payment transactions in a date range and the grand total revenue
CREATE PROCEDURE dbo.sp_GetDateRangeRevenueReport
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.PaymentID,
        p.PaymentDate,
        p.EventID,
        (t.FirstName + ' ' + t.Surname) AS BookedBy,
        e.EventType,
        p.Amount
    FROM dbo.PAYMENT p
    INNER JOIN dbo.EVENT e ON p.EventID = e.EventID
    INNER JOIN dbo.TOURIST t ON e.TouristID = t.TouristID
    WHERE p.PaymentDate BETWEEN @StartDate AND @EndDate
    ORDER BY p.PaymentDate DESC;

    SELECT 
        ISNULL(COUNT(p.PaymentID), 0) AS TotalTransactions,
        ISNULL(SUM(p.Amount), 0.00) AS GrandTotalRevenue
    FROM dbo.PAYMENT p
    WHERE p.PaymentDate BETWEEN @StartDate AND @EndDate;
END;
GO

-- Stored Procedure 5: sp_GetDashboardMetrics
-- Returns live KPI counts for today's bookings, ready gear, and gear currently in use
CREATE PROCEDURE dbo.sp_GetDashboardMetrics
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Today DATE = CAST(GETDATE() AS DATE);

    SELECT 
        (SELECT COUNT(*) FROM dbo.EVENT WHERE EventDate = @Today) AS BookingsToday,
        (SELECT COUNT(*) FROM dbo.INVENTORY_ITEM WHERE Status = 'Ready') AS GearReady,
        (SELECT COUNT(*) FROM dbo.INVENTORY_ITEM WHERE Status = 'In use') AS GearInUse;
END;
GO

INSERT INTO dbo.USER_ACCOUNT (Username, PasswordHash, Role)
VALUES 
('j.marshal', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 'Marshal'),
('admin',     '240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 'Admin');

INSERT INTO dbo.TOURIST (FirstName, Surname, WaiverSigned)
VALUES 
('Liam', 'Botha', 1),
('Zanele', 'Dlamini', 0),
('Kobus', 'van der Merwe', 1),
('Thabo', 'Molefe', 1),
('Sarah', 'Jenkins', 1);

INSERT INTO dbo.INVENTORY_ITEM (SerialNumber, ItemType, Size, Status, PurchaseCost)
VALUES 
('MK-0231', 'Marker', '-', 'Ready', 2200.00),
('MK-0232', 'Marker', '-', 'Ready', 2200.00),
('MS-0014', 'Mask', '-', 'Ready', 350.00),
('MS-0015', 'Mask', '-', 'Ready', 350.00),
('OV-0087', 'Overall', 'L', 'Ready', 450.00),
('OV-0088', 'Overall', 'M', 'Ready', 450.00),
('GC-0105', 'Gas cylinder', '-', 'Ready', 500.00),
('GC-0106', 'Gas cylinder', '-', 'Ready', 500.00);

DECLARE @TodayDate DATE = CAST(GETDATE() AS DATE);
DECLARE @TomorrowDate DATE = DATEADD(DAY, 1, @TodayDate);

INSERT INTO dbo.EVENT (TouristID, UserID, EventDate, EventType, FieldAssignment, NumberOfPlayers)
VALUES 
(1, 1, @TodayDate, 'Bachelor', 'Field 2', 6),
(2, 1, @TodayDate, 'Birthday', 'Field 1', 4),
(3, 1, @TomorrowDate, 'Corporate', 'Field 3', 5);

INSERT INTO dbo.PAYMENT (EventID, PaymentDate, Amount)
VALUES 
(1, @TodayDate, 1500.00),
(2, @TodayDate, 500.00);
GO
