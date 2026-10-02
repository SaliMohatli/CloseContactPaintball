# Close Contact Paintball Management System

A desktop management application built with **C# (.NET 10 Windows Forms)** and **Microsoft SQL Server** for managing inventory, player safety waivers, bookings, gear checkout/returns, and payments at a paintball venue.

---

## 🎯 Key Features

1. **Dashboard & Live Metrics**:
   - Real-time stat cards displaying bookings today, ready gear count, and gear currently in use.
   - Today's match schedule showing customer name, occasion, field assignment, and player counts.

2. **Gear Inventory Management**:
   - Full CRUD tracking for 4 gear categories: Markers, Masks, Overalls, and Gas Cylinders.
   - Status tracking (`Ready`, `In use`, `Needs cleaning`, `Under repair`).
   - Quick search by serial number.

3. **Player Registration & Waivers**:
   - Player records tracking first name, surname, and signed safety liability waivers.
   - Quick search by player name.

4. **Group Bookings**:
   - Booking events tracking host player, event date, occasion (Birthday, Bachelor, Corporate, etc.), and assigned field.
   - Enforced group size limit (maximum 6 players per booking).

5. **Gear Issue & Return (Stored Procedures)**:
   - Check out available gear items to players for active bookings.
   - Automatic status transition to `'In use'`.
   - Log returns with timestamp and condition assessment (`Ready`, `Needs cleaning`, `Under repair`).

6. **Payments & Official Receipts**:
   - Automated balance calculation: `Total Package Cost (Players * R250.00) - Total Paid = Balance Due`.
   - Records payment amount and generates a formatted receipt with a one-click clipboard copy.

7. **Date-Range Revenue Reports**:
   - Queries payments between customizable dates and calculates grand total revenue.

---

## 🏗️ Architecture & Technology Stack

* **User Interface**: C# .NET 10 Windows Forms
  * Pure separation of concerns: Visual layout, styles, and grid formatting are configured in `MainForm.Designer.cs` (fully compatible with the Visual Studio **Properties Window** `F4` and **Toolbox** `Ctrl+Alt+X`).
  * Pure behavioral event handling in `MainForm.cs` (under 350 lines).
* **Data Access Layer**: Native ADO.NET (`Microsoft.Data.SqlClient`) using the Repository Pattern.
  * All queries use strongly typed parameters to prevent SQL Injection.
* **Database Layer**: Microsoft SQL Server LocalDB (`(localdb)\MSSQLLocalDB`).
  * 6 relational tables with primary and foreign key constraints.
  * 5 Stored Procedures (`sp_IssueGear`, `sp_ReturnGear`, `sp_GetBookingPaymentSummary`, `sp_GetDateRangeRevenueReport`, `sp_GetDashboardMetrics`).

---

## 🚀 Getting Started

### Prerequisites
* [Visual Studio 2022 or 2025](https://visualstudio.microsoft.com/) with the **.NET desktop development** workload.
* [.NET 10 SDK](https://dotnet.microsoft.com/)
* SQL Server LocalDB (included with Visual Studio) or [SQL Server Management Studio (SSMS)](https://aka.ms/ssmsfullsetup).

### 1. Database Setup
1. Open **SSMS** and connect to `(localdb)\MSSQLLocalDB` (Windows Authentication).
2. Open `Database\CloseContactPaintball.sql` and click **Execute**.
3. The database `CloseContactPaintball` will be created with all tables, constraints, sample records, and stored procedures.

### 2. Running the Application
1. Double-click `CloseContactPaintball.sln` to open the solution in Visual Studio.
2. Press **F5** (or click **Start**) to build and run the application.

---

## 📁 Project Structure

```text
CloseContactPaintball/
├── CloseContactPaintball.sln       # Visual Studio Solution
├── Database/
│   ├── CloseContactPaintball.sql   # SQL Server setup script (DDL, Stored Procs, Seed Data)
│   └── CloseContactPaintball.bak   # Standalone SQL Server database backup
└── CloseContactPaintball/
    ├── CloseContactPaintball.csproj
    ├── Program.cs                  # Application entry point
    ├── MainForm.cs                 # UI event handling & behavior
    ├── MainForm.Designer.cs        # Visual layout & DataGridView definitions
    ├── Data/
    │   ├── DatabaseHelper.cs       # SQL connection provider
    │   └── Repositories.cs         # ADO.NET data access layer (CRUD & Stored Procedures)
    ├── Models/
    │   └── Entities.cs             # Strongly-typed data models
    └── Services/
        └── Services.cs             # Authentication (SHA-256) & Receipt printing
```
