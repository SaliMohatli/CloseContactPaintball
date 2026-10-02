using System;

namespace CloseContactPaintball.Models
{
    public class UserAccount
    {
        public int UserID { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Role { get; set; } = "Marshal"; // Marshal, Admin
    }

    public class Tourist
    {
        public int TouristID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public bool WaiverSigned { get; set; }

        public string FullName => $"{FirstName} {Surname}".Trim();

        public override string ToString() => FullName;
    }

    public class InventoryItem
    {
        public int ItemID { get; set; }
        public string SerialNumber { get; set; } = string.Empty;
        public string ItemType { get; set; } = "Marker"; // Marker, Mask, Overall, Gas cylinder
        public string? Size { get; set; } = "-";
        public string Status { get; set; } = "Ready"; // Ready, In use, Needs cleaning, Under repair, Retired
        public decimal PurchaseCost { get; set; }

        public string DisplayText => $"{ItemType} ({SerialNumber}) - {Status}";

        public override string ToString() => DisplayText;
    }

    public class EventBooking
    {
        public int EventID { get; set; }
        public int TouristID { get; set; }
        public int UserID { get; set; }
        public DateTime EventDate { get; set; } = DateTime.Today;
        public string EventType { get; set; } = "Birthday"; // Birthday, Bachelor, Tour group, Corporate
        public string FieldAssignment { get; set; } = "Field 1";
        public int NumberOfPlayers { get; set; } = 1;

        // Joined fields for display
        public string CustomerName { get; set; } = string.Empty;

        public string DisplayText => $"{CustomerName} - {EventDate:yyyy-MM-dd} ({EventType}, {FieldAssignment}, {NumberOfPlayers} players)";

        public override string ToString() => DisplayText;
    }

    public class Payment
    {
        public int PaymentID { get; set; }
        public int EventID { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Today;
        public decimal Amount { get; set; }

        // Joined display fields
        public string CustomerName { get; set; } = string.Empty;
        public string EventType { get; set; } = string.Empty;
    }

    public class Issuance
    {
        public int IssuanceID { get; set; }
        public int EventID { get; set; }
        public int TouristID { get; set; }
        public int ItemID { get; set; }
        public DateTime IssueDateTime { get; set; } = DateTime.Now;
        public DateTime? ReturnDateTime { get; set; }
        public string? ReturnCondition { get; set; }

        // Joined fields
        public string CustomerName { get; set; } = string.Empty;
        public string ItemType { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public string ItemSize { get; set; } = string.Empty;
        public string GearDescription => $"{ItemType} - {SerialNumber}" + (string.IsNullOrWhiteSpace(ItemSize) || ItemSize == "-" ? "" : $" ({ItemSize})");
    }

    public class DashboardMetrics
    {
        public int BookingsToday { get; set; }
        public int GearReady { get; set; }
        public int GearInUse { get; set; }
    }

    public class BookingPaymentSummary
    {
        public int EventID { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }
        public string EventType { get; set; } = string.Empty;
        public string FieldAssignment { get; set; } = string.Empty;
        public int NumberOfPlayers { get; set; }
        public decimal TotalPackageCost { get; set; }
        public decimal TotalPaid { get; set; }
        public decimal BalanceDue { get; set; }
    }
}
