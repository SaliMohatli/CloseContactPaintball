using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CloseContactPaintball.Data;
using CloseContactPaintball.Models;
using CloseContactPaintball.Services;

namespace CloseContactPaintball
{
    public partial class MainForm : Form
    {
        private readonly DashboardRepository dashboardRepo = new();
        private readonly GearRepository gearRepo = new();
        private readonly PlayerRepository playerRepo = new();
        private readonly BookingRepository bookingRepo = new();
        private readonly IssuanceRepository issuanceRepo = new();
        private readonly PaymentRepository paymentRepo = new();
        private int selectedGearItemId, selectedPlayerTouristId, selectedBookingEventId;
        private BookingPaymentSummary? currentPaymentSummary;
        private Button? activeNavButton;

        public MainForm()
        {
            InitializeComponent();
            AuthService.Login("j.marshal", "marshal123");
            UpdateUserStatus();
            NavigateToTab(tabDashboard);
        }

        public void NavigateToTab(TabPage targetTab)
        {
            tabControlMain.SelectedTab = targetTab;
            if (activeNavButton != null) { activeNavButton.BackColor = Color.FromArgb(68, 68, 65); activeNavButton.ForeColor = Color.FromArgb(241, 239, 232); }
            activeNavButton = pnlSidebar.Controls.OfType<Button>().FirstOrDefault(b => b.Name == "btnNav_" + targetTab.Name);
            if (activeNavButton != null) { activeNavButton.BackColor = Color.FromArgb(12, 68, 124); activeNavButton.ForeColor = Color.FromArgb(181, 212, 244); }

            if (targetTab == tabDashboard) LoadDashboardData();
            else if (targetTab == tabGear) LoadGear();
            else if (targetTab == tabPlayers) LoadPlayers();
            else if (targetTab == tabBookings) LoadBookings();
            else if (targetTab == tabIssueReturn) LoadIssueReturnData();
            else if (targetTab == tabPayment) LoadPaymentData();
            else if (targetTab == tabArrivals) LoadArrivalsData();
            else if (targetTab == tabReports) LoadReportsData();
        }

        private void UpdateUserStatus()
        {
            lblStatusUser.Text = AuthService.IsAuthenticated ? $"Logged in as: {AuthService.CurrentUsername} ({AuthService.CurrentRole})" : "Logged in as: Guest";
            lblStatusState.Text = "Ready";
        }

        //   TAB 1: LOGIN
        private void btnLoginAction_Click(object? sender, EventArgs e)
        {
            lblLoginError.Text = "";
            if (AuthService.Login(txtUsername.Text.Trim(), txtPassword.Text)) { UpdateUserStatus(); NavigateToTab(tabDashboard); }
            else lblLoginError.Text = "Invalid username or password.";
        }
        private void btnClearLogin_Click(object? sender, EventArgs e) { txtUsername.Clear(); txtPassword.Clear(); lblLoginError.Text = ""; }

        // TAB 2: DASHBOARD 
        public void LoadDashboardData()
        {
            var m = dashboardRepo.GetMetrics();
            lblCardBookingsCount.Text = m.BookingsToday.ToString();
            lblCardGearCount.Text = m.GearReady.ToString();
            lblCardInUseCount.Text = m.GearInUse.ToString();
            dgvTodaySchedule.Rows.Clear();
            foreach (var b in bookingRepo.GetAll().Where(b => b.EventDate.Date == DateTime.Today))
                dgvTodaySchedule.Rows.Add(b.CustomerName, b.EventType, b.FieldAssignment, b.NumberOfPlayers);
        }

        // TAB 3: GEAR INVENTORY 
        public void LoadGear()
        {
            dgvGear.Rows.Clear();
            foreach (var i in gearRepo.GetAll()) dgvGear.Rows.Add(i.ItemID, i.SerialNumber, i.ItemType, i.Size ?? "-", i.Status);
        }
        private void btnGearFind_Click(object? sender, EventArgs e)
        {
            string q = txtGearSearch.Text.Trim();
            var items = string.IsNullOrWhiteSpace(q) ? gearRepo.GetAll() : gearRepo.Search(q);
            dgvGear.Rows.Clear();
            foreach (var i in items) dgvGear.Rows.Add(i.ItemID, i.SerialNumber, i.ItemType, i.Size ?? "-", i.Status);
        }
        private void dgvGear_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvGear.SelectedRows.Count == 0) return;
            var r = dgvGear.SelectedRows[0];
            selectedGearItemId = Convert.ToInt32(r.Cells["ItemID"].Value);
            txtGearSerial.Text = r.Cells["SerialNumber"].Value?.ToString() ?? "";
            cmbGearType.SelectedItem = r.Cells["ItemType"].Value?.ToString() ?? "Marker";
            cmbGearSize.SelectedItem = r.Cells["Size"].Value?.ToString() ?? "-";
            cmbGearCondition.SelectedItem = r.Cells["Status"].Value?.ToString() ?? "Ready";
        }
        private void btnGearAdd_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGearSerial.Text)) { MessageBox.Show("Serial number is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            gearRepo.Insert(new InventoryItem { SerialNumber = txtGearSerial.Text.Trim().ToUpper(), ItemType = cmbGearType.Text, Size = cmbGearSize.Text, Status = cmbGearCondition.Text, PurchaseCost = 500m });
            btnGearClear_Click(null, EventArgs.Empty);
            LoadGear();
        }
        private void btnGearSave_Click(object? sender, EventArgs e)
        {
            if (selectedGearItemId == 0) return;
            gearRepo.Update(new InventoryItem { ItemID = selectedGearItemId, SerialNumber = txtGearSerial.Text.Trim().ToUpper(), ItemType = cmbGearType.Text, Size = cmbGearSize.Text, Status = cmbGearCondition.Text, PurchaseCost = 500m });
            btnGearClear_Click(null, EventArgs.Empty);
            LoadGear();
        }
        private void btnGearRemove_Click(object? sender, EventArgs e)
        {
            if (selectedGearItemId == 0) return;
            if (MessageBox.Show("Remove selected gear item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { gearRepo.Delete(selectedGearItemId); btnGearClear_Click(null, EventArgs.Empty); LoadGear(); }
        }
        private void btnGearClear_Click(object? sender, EventArgs e)
        {
            selectedGearItemId = 0; txtGearSerial.Clear(); cmbGearType.SelectedIndex = 0; cmbGearSize.SelectedIndex = 0; cmbGearCondition.SelectedIndex = 0; txtGearSearch.Clear(); dgvGear.ClearSelection();
        }

        // TAB 4: PLAYERS 
        public void LoadPlayers()
        {
            dgvPlayers.Rows.Clear();
            foreach (var p in playerRepo.GetAll()) dgvPlayers.Rows.Add(p.TouristID, p.FirstName, p.Surname, p.WaiverSigned ? "Signed" : "Not signed");
        }
        private void btnPlayerFind_Click(object? sender, EventArgs e)
        {
            string q = (txtPlayerFirst.Text + " " + txtPlayerSurname.Text).Trim();
            var players = string.IsNullOrWhiteSpace(q) ? playerRepo.GetAll() : playerRepo.Search(q);
            dgvPlayers.Rows.Clear();
            foreach (var p in players) dgvPlayers.Rows.Add(p.TouristID, p.FirstName, p.Surname, p.WaiverSigned ? "Signed" : "Not signed");
        }
        private void dgvPlayers_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvPlayers.SelectedRows.Count == 0) return;
            var r = dgvPlayers.SelectedRows[0];
            selectedPlayerTouristId = Convert.ToInt32(r.Cells["TouristID"].Value);
            txtPlayerFirst.Text = r.Cells["FirstName"].Value?.ToString() ?? "";
            txtPlayerSurname.Text = r.Cells["Surname"].Value?.ToString() ?? "";
            chkPlayerWaiver.Checked = (r.Cells["Waiver"].Value?.ToString() ?? "") == "Signed";
        }
        private void btnPlayerAdd_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlayerFirst.Text) || string.IsNullOrWhiteSpace(txtPlayerSurname.Text))
            { MessageBox.Show("First name and surname are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            playerRepo.Insert(new Tourist { FirstName = txtPlayerFirst.Text.Trim(), Surname = txtPlayerSurname.Text.Trim(), WaiverSigned = chkPlayerWaiver.Checked });
            btnPlayerClear_Click(null, EventArgs.Empty);
            LoadPlayers();
        }
        private void btnPlayerSave_Click(object? sender, EventArgs e)
        {
            if (selectedPlayerTouristId == 0) return;
            playerRepo.Update(new Tourist { TouristID = selectedPlayerTouristId, FirstName = txtPlayerFirst.Text.Trim(), Surname = txtPlayerSurname.Text.Trim(), WaiverSigned = chkPlayerWaiver.Checked });
            btnPlayerClear_Click(null, EventArgs.Empty);
            LoadPlayers();
        }
        private void btnPlayerClear_Click(object? sender, EventArgs e)
        {
            selectedPlayerTouristId = 0; txtPlayerFirst.Clear(); txtPlayerSurname.Clear(); chkPlayerWaiver.Checked = false; dgvPlayers.ClearSelection();
        }

        // TAB 5: BOOKINGS
        public void LoadBookings()
        {
            cmbBookingCustomer.DataSource = playerRepo.GetAll();
            cmbBookingCustomer.DisplayMember = "FullName";
            cmbBookingCustomer.ValueMember = "TouristID";
            dgvBookings.Rows.Clear();
            foreach (var b in bookingRepo.GetAll())
                dgvBookings.Rows.Add(b.EventID, b.CustomerName, b.EventDate.ToString("yyyy-MM-dd"), b.EventType, b.FieldAssignment, b.NumberOfPlayers);
        }
        private void dgvBookings_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0) return;
            var r = dgvBookings.SelectedRows[0];
            selectedBookingEventId = Convert.ToInt32(r.Cells["EventID"].Value);
            string cust = r.Cells["CustomerName"].Value?.ToString() ?? "";
            foreach (Tourist item in cmbBookingCustomer.Items) { if (item.FullName == cust) { cmbBookingCustomer.SelectedItem = item; break; } }
            if (DateTime.TryParse(r.Cells["EventDate"].Value?.ToString(), out var dt)) dtpBookingDate.Value = dt;
            cmbBookingOccasion.SelectedItem = r.Cells["EventType"].Value?.ToString() ?? "Birthday";
            txtBookingField.Text = r.Cells["FieldAssignment"].Value?.ToString() ?? "Field 1";
            if (int.TryParse(r.Cells["NumberOfPlayers"].Value?.ToString(), out int num)) numBookingPlayers.Value = Math.Clamp(num, 1, 6);
        }
        private void btnBookingAdd_Click(object? sender, EventArgs e)
        {
            if (cmbBookingCustomer.SelectedItem is not Tourist p) { MessageBox.Show("Please select a player.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            int players = (int)numBookingPlayers.Value;
            if (players > 6) { MessageBox.Show("Group bookings are strictly limited to a maximum of 6 players.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            bookingRepo.Insert(new EventBooking { TouristID = p.TouristID, UserID = AuthService.CurrentUser?.UserID ?? 1, EventDate = dtpBookingDate.Value.Date, EventType = cmbBookingOccasion.Text, FieldAssignment = string.IsNullOrWhiteSpace(txtBookingField.Text) ? "Field 1" : txtBookingField.Text.Trim(), NumberOfPlayers = players });
            MessageBox.Show($"Booking created for {p.FullName} ({players} players)!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnBookingClear_Click(null, EventArgs.Empty);
            LoadBookings();
        }
        private void btnBookingSave_Click(object? sender, EventArgs e)
        {
            if (selectedBookingEventId == 0 || cmbBookingCustomer.SelectedItem is not Tourist p) return;
            bookingRepo.Update(new EventBooking { EventID = selectedBookingEventId, TouristID = p.TouristID, UserID = AuthService.CurrentUser?.UserID ?? 1, EventDate = dtpBookingDate.Value.Date, EventType = cmbBookingOccasion.Text, FieldAssignment = string.IsNullOrWhiteSpace(txtBookingField.Text) ? "Field 1" : txtBookingField.Text.Trim(), NumberOfPlayers = (int)numBookingPlayers.Value });
            btnBookingClear_Click(null, EventArgs.Empty);
            LoadBookings();
        }
        private void btnBookingClear_Click(object? sender, EventArgs e)
        {
            selectedBookingEventId = 0; dtpBookingDate.Value = DateTime.Today; cmbBookingOccasion.SelectedIndex = 0; txtBookingField.Text = "Field 1"; numBookingPlayers.Value = 4; dgvBookings.ClearSelection();
        }

        // TAB 6: ISSUE / RETURN 
        public void LoadIssueReturnData()
        {
            cmbIssueBooking.DataSource = bookingRepo.GetAll();
            cmbIssueBooking.DisplayMember = "DisplayText";
            cmbIssueBooking.ValueMember = "EventID";
            cmbIssuePlayer.DataSource = playerRepo.GetAll();
            cmbIssuePlayer.DisplayMember = "FullName";
            cmbIssuePlayer.ValueMember = "TouristID";
            LoadReadyGearList();
            LoadActiveIssuances();
        }
        private void LoadReadyGearList()
        {
            chkListIssueReady.Items.Clear();
            foreach (var i in gearRepo.GetReadyItems())
                chkListIssueReady.Items.Add(new GearCheckItem(i.ItemID, $"{i.ItemType} - {i.SerialNumber}" + (i.Size != "-" && !string.IsNullOrEmpty(i.Size) ? $" ({i.Size})" : "")));
        }
        private void LoadActiveIssuances()
        {
            int? eventId = (cmbIssueBooking.SelectedItem is EventBooking eb) ? eb.EventID : null;
            dgvIssueActive.Rows.Clear();
            foreach (var i in issuanceRepo.GetActiveIssuances(eventId))
                dgvIssueActive.Rows.Add(i.IssuanceID, i.CustomerName, i.GearDescription, i.IssueDateTime.ToString("HH:mm:ss"));
        }
        private void cmbIssueBooking_SelectedIndexChanged(object? sender, EventArgs e) => LoadActiveIssuances();
        private void btnIssueHandOut_Click(object? sender, EventArgs e)
        {
            if (cmbIssueBooking.SelectedItem is not EventBooking b || cmbIssuePlayer.SelectedItem is not Tourist p)
            { MessageBox.Show("Please select a booking and player.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (chkListIssueReady.CheckedItems.Count == 0)
            { MessageBox.Show("Check at least one gear item to hand out.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            foreach (var obj in chkListIssueReady.CheckedItems)
            {
                if (obj is GearCheckItem item) issuanceRepo.IssueGear(b.EventID, p.TouristID, item.ItemID);
            }
            MessageBox.Show("Gear handed out successfully!", "Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadReadyGearList();
            LoadActiveIssuances();
        }
        private void btnIssueTakeBack_Click(object? sender, EventArgs e)
        {
            if (dgvIssueActive.SelectedRows.Count == 0) { MessageBox.Show("Select an issued gear item to take back.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            int issuanceId = Convert.ToInt32(dgvIssueActive.SelectedRows[0].Cells["IssuanceID"].Value);
            string condition = cmbReturnCondition.SelectedItem?.ToString() ?? "Ready";
            issuanceRepo.ReturnGear(issuanceId, condition);
            MessageBox.Show($"Gear returned with condition: '{condition}'", "Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadReadyGearList();
            LoadActiveIssuances();
        }
        private record GearCheckItem(int ItemID, string Label) { public override string ToString() => Label; }

        // TAB 7: PAYMENT
        public void LoadPaymentData()
        {
            cmbPayBooking.DataSource = bookingRepo.GetAll();
            cmbPayBooking.DisplayMember = "DisplayText";
            cmbPayBooking.ValueMember = "EventID";
        }
        private void cmbPayBooking_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbPayBooking.SelectedItem is not EventBooking b) return;
            currentPaymentSummary = paymentRepo.GetFinancialSummary(b.EventID);
            if (currentPaymentSummary != null)
            {
                lblPaySummary.Text = $"Customer: {currentPaymentSummary.CustomerName} ({currentPaymentSummary.NumberOfPlayers} players)\r\nPackage Total: R {currentPaymentSummary.TotalPackageCost:F2}  |  Total Paid: R {currentPaymentSummary.TotalPaid:F2}\r\nBALANCE DUE: R {Math.Max(0, currentPaymentSummary.BalanceDue):F2}";
                numPayAmount.Value = Math.Max(0, currentPaymentSummary.BalanceDue);
            }
            var (payments, _, _) = paymentRepo.GetRevenueReport(new DateTime(2000, 1, 1), DateTime.Today.AddYears(1));
            dgvPayments.Rows.Clear();
            foreach (var p in payments.Where(x => x.EventID == b.EventID))
                dgvPayments.Rows.Add($"RCP-{p.PaymentID:D5}", p.PaymentDate.ToString("yyyy-MM-dd"), $"R {p.Amount:F2}");
        }
        private void btnPayTake_Click(object? sender, EventArgs e)
        {
            if (cmbPayBooking.SelectedItem is not EventBooking b || numPayAmount.Value <= 0)
            { MessageBox.Show("Select a booking and enter an amount > 0.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            paymentRepo.InsertPayment(new Payment { EventID = b.EventID, PaymentDate = DateTime.Today, Amount = numPayAmount.Value });
            MessageBox.Show($"Recorded payment of R {numPayAmount.Value:F2} for {b.CustomerName}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmbPayBooking_SelectedIndexChanged(null, EventArgs.Empty);
        }
        private void btnPayPrint_Click(object? sender, EventArgs e)
        {
            if (currentPaymentSummary != null) ReceiptService.ShowReceiptDialog(this, currentPaymentSummary, numPayAmount.Value);
        }

        // --- TAB 8: ARRIVALS ---
        public void LoadArrivalsData()
        {
            cmbArrBooking.DataSource = bookingRepo.GetAll();
            cmbArrBooking.DisplayMember = "DisplayText";
            cmbArrBooking.ValueMember = "EventID";
        }
        private void cmbArrBooking_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbArrBooking.SelectedItem is not EventBooking b) return;
            var allPlayers = playerRepo.GetAll();
            dgvArrList.Rows.Clear();
            var lead = allPlayers.Find(p => p.TouristID == b.TouristID);
            if (lead != null) dgvArrList.Rows.Add(lead.FullName + " (Host)", lead.WaiverSigned ? "Signed" : "Not signed", true);
            int added = lead != null ? 1 : 0;
            foreach (var p in allPlayers)
            {
                if (lead != null && p.TouristID == lead.TouristID) continue;
                if (added >= b.NumberOfPlayers) break;
                dgvArrList.Rows.Add(p.FullName, p.WaiverSigned ? "Signed" : "Not signed", false);
                added++;
            }
            while (added < b.NumberOfPlayers)
            {
                added++;
                dgvArrList.Rows.Add($"Player #{added} ({b.CustomerName} Group)", "Not signed", false);
            }
            lblArrStatus.Text = $"Group: {b.CustomerName}  |  Total Expected: {b.NumberOfPlayers} players (Max 6)";
        }
        private void btnArrCheckAll_Click(object? sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvArrList.Rows) row.Cells["Here"].Value = true;
        }
        private void btnArrConfirm_Click(object? sender, EventArgs e)
        {
            int count = dgvArrList.Rows.Cast<DataGridViewRow>().Count(r => r.Cells["Here"].Value is true);
            MessageBox.Show($"Attendance confirmed: {count} of {dgvArrList.Rows.Count} present.", "Arrivals", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // TAB 9: REPORTS 
        public void LoadReportsData() => btnRepShowIncome_Click(null, EventArgs.Empty);
        private void btnRepShowIncome_Click(object? sender, EventArgs e)
        {
            var (payments, _, total) = paymentRepo.GetRevenueReport(dtpRepFrom.Value.Date, dtpRepTo.Value.Date);
            dgvRepTransactions.Rows.Clear();
            foreach (var p in payments)
                dgvRepTransactions.Rows.Add(p.PaymentDate.ToString("yyyy-MM-dd"), $"RCP-{p.PaymentID:D5}", p.CustomerName, p.EventType, $"R {p.Amount:F2}");
            lblRepTotal.Text = $"Total: R {total:N2}";
        }
        private void btnRepPrint_Click(object? sender, EventArgs e) =>
            MessageBox.Show($"Revenue Report for {dtpRepFrom.Value:yyyy-MM-dd} to {dtpRepTo.Value:yyyy-MM-dd}\n{lblRepTotal.Text}", "Print Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
