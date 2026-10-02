using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using CloseContactPaintball.Models;
using CloseContactPaintball.Data;

namespace CloseContactPaintball.Services
{
    public static class AuthService
    {
        public static UserAccount? CurrentUser { get; private set; }

        public static bool IsAuthenticated => CurrentUser != null;
        public static string CurrentUsername => CurrentUser?.Username ?? "Guest";
        public static string CurrentRole => CurrentUser?.Role ?? "None";

        public static bool Login(string username, string password)
        {
            string hash = HashPassword(password);
            var repo = new UserRepository();
            var user = repo.Authenticate(username, hash);
            if (user != null)
            {
                CurrentUser = user;
                return true;
            }
            return false;
        }

        public static void Logout() => CurrentUser = null;

        public static string HashPassword(string password)
        {
            using var sha = SHA256.Create();
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            var sb = new StringBuilder();
            foreach (var b in bytes) sb.Append(b.ToString("x2"));
            return sb.ToString();
        }
    }

    public static class ReceiptService
    {
        public static string GeneratePaymentReceipt(BookingPaymentSummary summary, decimal paymentAmount)
        {
            var sb = new StringBuilder();
            sb.AppendLine("=================================================");
            sb.AppendLine("         CLOSE CONTACT PAINTBALL VENUE           ");
            sb.AppendLine("           OFFICIAL PAYMENT RECEIPT              ");
            sb.AppendLine("=================================================");
            sb.AppendLine($"Receipt Date   : {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            sb.AppendLine($"Served By      : {AuthService.CurrentUsername} ({AuthService.CurrentRole})");
            sb.AppendLine("-------------------------------------------------");
            sb.AppendLine($"Booking ID     : #{summary.EventID}");
            sb.AppendLine($"Customer Name  : {summary.CustomerName}");
            sb.AppendLine($"Event Date     : {summary.EventDate:yyyy-MM-dd}");
            sb.AppendLine($"Event Type     : {summary.EventType}");
            sb.AppendLine($"Field Assigned : {summary.FieldAssignment}");
            sb.AppendLine($"Player Count   : {summary.NumberOfPlayers} players (Max 6)");
            sb.AppendLine("-------------------------------------------------");
            sb.AppendLine($"Package Total  : R {summary.TotalPackageCost,10:F2}");
            sb.AppendLine($"AMOUNT RECORDED: R {paymentAmount,10:F2}");
            sb.AppendLine($"Total Received : R {(summary.TotalPaid + paymentAmount),10:F2}");
            sb.AppendLine($"REMAINING DUE  : R {Math.Max(0, summary.BalanceDue - paymentAmount),10:F2}");
            sb.AppendLine("=================================================");
            sb.AppendLine("  Safety Notice: Masks MUST remain on at all     ");
            sb.AppendLine("  times inside active zones & chrono fields!     ");
            sb.AppendLine("         Thank you for playing with us!          ");
            sb.AppendLine("=================================================");
            return sb.ToString();
        }

        public static void ShowReceiptDialog(IWin32Window owner, BookingPaymentSummary summary, decimal amount)
        {
            string receipt = GeneratePaymentReceipt(summary, amount);
            using var dlg = new Form
            {
                Text = "Payment Receipt",
                Size = new Size(480, 480),
                StartPosition = FormStartPosition.CenterParent,
                BackColor = Color.FromArgb(44, 44, 42)
            };
            var txt = new TextBox
            {
                Multiline = true, ReadOnly = true, Dock = DockStyle.Top, Height = 380,
                Font = new Font("Consolas", 9.5f), BackColor = Color.FromArgb(58, 58, 56),
                ForeColor = Color.FromArgb(241, 239, 232), Text = receipt
            };
            var btnCopy = new Button
            {
                Text = "📋 Copy to Clipboard", Location = new Point(140, 395), Size = new Size(160, 30),
                BackColor = Color.FromArgb(68, 68, 65), ForeColor = Color.FromArgb(241, 239, 232)
            };
            btnCopy.Click += (s, ev) =>
            {
                Clipboard.SetText(receipt);
                MessageBox.Show("Receipt copied to clipboard!", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            dlg.Controls.AddRange(new Control[] { txt, btnCopy });
            dlg.ShowDialog(owner);
        }
    }
}
