namespace CloseContactPaintball
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null!;

        // Window Frame Controls
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblDotClose;
        private System.Windows.Forms.Label lblDotMax;
        private System.Windows.Forms.Label lblDotMin;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileSwitchUser;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuMaintain;
        private System.Windows.Forms.ToolStripMenuItem menuMaintainGear;
        private System.Windows.Forms.ToolStripMenuItem menuMaintainPlayers;
        private System.Windows.Forms.ToolStripMenuItem menuMaintainBookings;
        private System.Windows.Forms.ToolStripMenuItem menuTransactions;
        private System.Windows.Forms.ToolStripMenuItem menuTransIssueReturn;
        private System.Windows.Forms.ToolStripMenuItem menuTransPayment;
        private System.Windows.Forms.ToolStripMenuItem menuTransArrivals;
        private System.Windows.Forms.ToolStripMenuItem menuReports;
        private System.Windows.Forms.ToolStripMenuItem menuReportsRevenue;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;

        // Sidebar Navigation Buttons
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnNavLogin;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavGear;
        private System.Windows.Forms.Button btnNavPlayers;
        private System.Windows.Forms.Button btnNavBookings;
        private System.Windows.Forms.Button btnNavIssueReturn;
        private System.Windows.Forms.Button btnNavPayment;
        private System.Windows.Forms.Button btnNavArrivals;
        private System.Windows.Forms.Button btnNavReports;

        // Status Strip
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusUser;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusState;

        // Main Tab Control
        private System.Windows.Forms.TabControl tabControlMain;

        // Tab 1: Login
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.Panel pnlLoginCenter;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLoginAction;
        private System.Windows.Forms.Button btnClearLogin;
        private System.Windows.Forms.Label lblLoginError;
        private System.Windows.Forms.Label lblLoginHint;

        // Tab 2: Dashboard
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.Label lblDashTitle;
        private System.Windows.Forms.Panel pnlCardBookings;
        private System.Windows.Forms.Label lblCardBookingsIcon;
        private System.Windows.Forms.Label lblCardBookingsCount;
        private System.Windows.Forms.Label lblCardBookingsText;
        private System.Windows.Forms.Panel pnlCardGear;
        private System.Windows.Forms.Label lblCardGearIcon;
        private System.Windows.Forms.Label lblCardGearCount;
        private System.Windows.Forms.Label lblCardGearText;
        private System.Windows.Forms.Panel pnlCardInUse;
        private System.Windows.Forms.Label lblCardInUseIcon;
        private System.Windows.Forms.Label lblCardInUseCount;
        private System.Windows.Forms.Label lblCardInUseText;
        private System.Windows.Forms.Label lblTodaySchedule;
        private System.Windows.Forms.DataGridView dgvTodaySchedule;

        // Tab 3: Gear
        private System.Windows.Forms.TabPage tabGear;
        private System.Windows.Forms.Label lblGearTitle;
        private System.Windows.Forms.TextBox txtGearSearch;
        private System.Windows.Forms.Button btnGearFind;
        private System.Windows.Forms.Label lblGearSerial;
        private System.Windows.Forms.TextBox txtGearSerial;
        private System.Windows.Forms.Label lblGearType;
        private System.Windows.Forms.ComboBox cmbGearType;
        private System.Windows.Forms.Label lblGearSize;
        private System.Windows.Forms.ComboBox cmbGearSize;
        private System.Windows.Forms.Label lblGearCondition;
        private System.Windows.Forms.ComboBox cmbGearCondition;
        private System.Windows.Forms.Button btnGearAdd;
        private System.Windows.Forms.Button btnGearSave;
        private System.Windows.Forms.Button btnGearRemove;
        private System.Windows.Forms.Button btnGearClear;
        private System.Windows.Forms.DataGridView dgvGear;
        private System.Windows.Forms.Label lblGearCostNote;

        // Tab 4: Players
        private System.Windows.Forms.TabPage tabPlayers;
        private System.Windows.Forms.Label lblPlayersTitle;
        private System.Windows.Forms.Label lblPlayerFirst;
        private System.Windows.Forms.TextBox txtPlayerFirst;
        private System.Windows.Forms.Label lblPlayerSurname;
        private System.Windows.Forms.TextBox txtPlayerSurname;
        private System.Windows.Forms.CheckBox chkPlayerWaiver;
        private System.Windows.Forms.Button btnPlayerAdd;
        private System.Windows.Forms.Button btnPlayerSave;
        private System.Windows.Forms.Button btnPlayerFind;
        private System.Windows.Forms.Button btnPlayerClear;
        private System.Windows.Forms.DataGridView dgvPlayers;

        // Tab 5: Bookings
        private System.Windows.Forms.TabPage tabBookings;
        private System.Windows.Forms.Label lblBookingsTitle;
        private System.Windows.Forms.Label lblBookedBy;
        private System.Windows.Forms.ComboBox cmbBookingCustomer;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.Label lblBookingOccasion;
        private System.Windows.Forms.ComboBox cmbBookingOccasion;
        private System.Windows.Forms.Label lblBookingField;
        private System.Windows.Forms.TextBox txtBookingField;
        private System.Windows.Forms.Label lblBookingNumPlayers;
        private System.Windows.Forms.NumericUpDown numBookingPlayers;
        private System.Windows.Forms.Button btnBookingAdd;
        private System.Windows.Forms.Button btnBookingSave;
        private System.Windows.Forms.Button btnBookingClear;
        private System.Windows.Forms.DataGridView dgvBookings;

        // Tab 6: Issue / Return
        private System.Windows.Forms.TabPage tabIssueReturn;
        private System.Windows.Forms.Label lblIssueTitle;
        private System.Windows.Forms.Label lblIssueBooking;
        private System.Windows.Forms.ComboBox cmbIssueBooking;
        private System.Windows.Forms.Label lblIssuePlayer;
        private System.Windows.Forms.ComboBox cmbIssuePlayer;
        private System.Windows.Forms.Label lblIssueReady;
        private System.Windows.Forms.CheckedListBox chkListIssueReady;
        private System.Windows.Forms.Button btnIssueHandOut;
        private System.Windows.Forms.Label lblIssueActive;
        private System.Windows.Forms.DataGridView dgvIssueActive;
        private System.Windows.Forms.Label lblReturnCondition;
        private System.Windows.Forms.ComboBox cmbReturnCondition;
        private System.Windows.Forms.Button btnIssueTakeBack;

        // Tab 7: Payment
        private System.Windows.Forms.TabPage tabPayment;
        private System.Windows.Forms.Label lblPaymentTitle;
        private System.Windows.Forms.Label lblPayBooking;
        private System.Windows.Forms.ComboBox cmbPayBooking;
        private System.Windows.Forms.Label lblPaySummary;
        private System.Windows.Forms.Label lblPayAmount;
        private System.Windows.Forms.NumericUpDown numPayAmount;
        private System.Windows.Forms.Button btnPayTake;
        private System.Windows.Forms.Button btnPayPrint;
        private System.Windows.Forms.Label lblPayHistory;
        private System.Windows.Forms.DataGridView dgvPayments;

        // Tab 8: Arrivals
        private System.Windows.Forms.TabPage tabArrivals;
        private System.Windows.Forms.Label lblArrTitle;
        private System.Windows.Forms.Label lblArrBooking;
        private System.Windows.Forms.ComboBox cmbArrBooking;
        private System.Windows.Forms.Label lblArrStatus;
        private System.Windows.Forms.DataGridView dgvArrList;
        private System.Windows.Forms.Button btnArrCheckAll;
        private System.Windows.Forms.Button btnArrConfirm;

        // Tab 9: Reports
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.Label lblRepTitle;
        private System.Windows.Forms.Label lblRepFrom;
        private System.Windows.Forms.DateTimePicker dtpRepFrom;
        private System.Windows.Forms.Label lblRepTo;
        private System.Windows.Forms.DateTimePicker dtpRepTo;
        private System.Windows.Forms.Button btnRepShowIncome;
        private System.Windows.Forms.Button btnRepPrint;
        private System.Windows.Forms.Label lblRepTotal;
        private System.Windows.Forms.DataGridView dgvRepTransactions;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // Instantiate Header & Navigation
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblDotClose = new System.Windows.Forms.Label();
            this.lblDotMax = new System.Windows.Forms.Label();
            this.lblDotMin = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSwitchUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMaintain = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMaintainGear = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMaintainPlayers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMaintainBookings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTransactions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTransIssueReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTransPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTransArrivals = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportsRevenue = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();

            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnNavLogin = new System.Windows.Forms.Button();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.btnNavGear = new System.Windows.Forms.Button();
            this.btnNavPlayers = new System.Windows.Forms.Button();
            this.btnNavBookings = new System.Windows.Forms.Button();
            this.btnNavIssueReturn = new System.Windows.Forms.Button();
            this.btnNavPayment = new System.Windows.Forms.Button();
            this.btnNavArrivals = new System.Windows.Forms.Button();
            this.btnNavReports = new System.Windows.Forms.Button();

            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatusUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusState = new System.Windows.Forms.ToolStripStatusLabel();

            this.tabControlMain = new System.Windows.Forms.TabControl();

            // Instantiate Tabs
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.pnlLoginCenter = new System.Windows.Forms.Panel();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLoginAction = new System.Windows.Forms.Button();
            this.btnClearLogin = new System.Windows.Forms.Button();
            this.lblLoginError = new System.Windows.Forms.Label();
            this.lblLoginHint = new System.Windows.Forms.Label();

            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.lblDashTitle = new System.Windows.Forms.Label();
            this.pnlCardBookings = new System.Windows.Forms.Panel();
            this.lblCardBookingsIcon = new System.Windows.Forms.Label();
            this.lblCardBookingsCount = new System.Windows.Forms.Label();
            this.lblCardBookingsText = new System.Windows.Forms.Label();
            this.pnlCardGear = new System.Windows.Forms.Panel();
            this.lblCardGearIcon = new System.Windows.Forms.Label();
            this.lblCardGearCount = new System.Windows.Forms.Label();
            this.lblCardGearText = new System.Windows.Forms.Label();
            this.pnlCardInUse = new System.Windows.Forms.Panel();
            this.lblCardInUseIcon = new System.Windows.Forms.Label();
            this.lblCardInUseCount = new System.Windows.Forms.Label();
            this.lblCardInUseText = new System.Windows.Forms.Label();
            this.lblTodaySchedule = new System.Windows.Forms.Label();
            this.dgvTodaySchedule = new System.Windows.Forms.DataGridView();

            this.tabGear = new System.Windows.Forms.TabPage();
            this.lblGearTitle = new System.Windows.Forms.Label();
            this.txtGearSearch = new System.Windows.Forms.TextBox();
            this.btnGearFind = new System.Windows.Forms.Button();
            this.lblGearSerial = new System.Windows.Forms.Label();
            this.txtGearSerial = new System.Windows.Forms.TextBox();
            this.lblGearType = new System.Windows.Forms.Label();
            this.cmbGearType = new System.Windows.Forms.ComboBox();
            this.lblGearSize = new System.Windows.Forms.Label();
            this.cmbGearSize = new System.Windows.Forms.ComboBox();
            this.lblGearCondition = new System.Windows.Forms.Label();
            this.cmbGearCondition = new System.Windows.Forms.ComboBox();
            this.btnGearAdd = new System.Windows.Forms.Button();
            this.btnGearSave = new System.Windows.Forms.Button();
            this.btnGearRemove = new System.Windows.Forms.Button();
            this.btnGearClear = new System.Windows.Forms.Button();
            this.dgvGear = new System.Windows.Forms.DataGridView();
            this.lblGearCostNote = new System.Windows.Forms.Label();

            this.tabPlayers = new System.Windows.Forms.TabPage();
            this.lblPlayersTitle = new System.Windows.Forms.Label();
            this.lblPlayerFirst = new System.Windows.Forms.Label();
            this.txtPlayerFirst = new System.Windows.Forms.TextBox();
            this.lblPlayerSurname = new System.Windows.Forms.Label();
            this.txtPlayerSurname = new System.Windows.Forms.TextBox();
            this.chkPlayerWaiver = new System.Windows.Forms.CheckBox();
            this.btnPlayerAdd = new System.Windows.Forms.Button();
            this.btnPlayerSave = new System.Windows.Forms.Button();
            this.btnPlayerFind = new System.Windows.Forms.Button();
            this.btnPlayerClear = new System.Windows.Forms.Button();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();

            this.tabBookings = new System.Windows.Forms.TabPage();
            this.lblBookingsTitle = new System.Windows.Forms.Label();
            this.lblBookedBy = new System.Windows.Forms.Label();
            this.cmbBookingCustomer = new System.Windows.Forms.ComboBox();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.lblBookingOccasion = new System.Windows.Forms.Label();
            this.cmbBookingOccasion = new System.Windows.Forms.ComboBox();
            this.lblBookingField = new System.Windows.Forms.Label();
            this.txtBookingField = new System.Windows.Forms.TextBox();
            this.lblBookingNumPlayers = new System.Windows.Forms.Label();
            this.numBookingPlayers = new System.Windows.Forms.NumericUpDown();
            this.btnBookingAdd = new System.Windows.Forms.Button();
            this.btnBookingSave = new System.Windows.Forms.Button();
            this.btnBookingClear = new System.Windows.Forms.Button();
            this.dgvBookings = new System.Windows.Forms.DataGridView();

            this.tabIssueReturn = new System.Windows.Forms.TabPage();
            this.lblIssueTitle = new System.Windows.Forms.Label();
            this.lblIssueBooking = new System.Windows.Forms.Label();
            this.cmbIssueBooking = new System.Windows.Forms.ComboBox();
            this.lblIssuePlayer = new System.Windows.Forms.Label();
            this.cmbIssuePlayer = new System.Windows.Forms.ComboBox();
            this.lblIssueReady = new System.Windows.Forms.Label();
            this.chkListIssueReady = new System.Windows.Forms.CheckedListBox();
            this.btnIssueHandOut = new System.Windows.Forms.Button();
            this.lblIssueActive = new System.Windows.Forms.Label();
            this.dgvIssueActive = new System.Windows.Forms.DataGridView();
            this.lblReturnCondition = new System.Windows.Forms.Label();
            this.cmbReturnCondition = new System.Windows.Forms.ComboBox();
            this.btnIssueTakeBack = new System.Windows.Forms.Button();

            this.tabPayment = new System.Windows.Forms.TabPage();
            this.lblPaymentTitle = new System.Windows.Forms.Label();
            this.lblPayBooking = new System.Windows.Forms.Label();
            this.cmbPayBooking = new System.Windows.Forms.ComboBox();
            this.lblPaySummary = new System.Windows.Forms.Label();
            this.lblPayAmount = new System.Windows.Forms.Label();
            this.numPayAmount = new System.Windows.Forms.NumericUpDown();
            this.btnPayTake = new System.Windows.Forms.Button();
            this.btnPayPrint = new System.Windows.Forms.Button();
            this.lblPayHistory = new System.Windows.Forms.Label();
            this.dgvPayments = new System.Windows.Forms.DataGridView();

            this.tabArrivals = new System.Windows.Forms.TabPage();
            this.lblArrTitle = new System.Windows.Forms.Label();
            this.lblArrBooking = new System.Windows.Forms.Label();
            this.cmbArrBooking = new System.Windows.Forms.ComboBox();
            this.lblArrStatus = new System.Windows.Forms.Label();
            this.dgvArrList = new System.Windows.Forms.DataGridView();
            this.btnArrCheckAll = new System.Windows.Forms.Button();
            this.btnArrConfirm = new System.Windows.Forms.Button();

            this.tabReports = new System.Windows.Forms.TabPage();
            this.lblRepTitle = new System.Windows.Forms.Label();
            this.lblRepFrom = new System.Windows.Forms.Label();
            this.dtpRepFrom = new System.Windows.Forms.DateTimePicker();
            this.lblRepTo = new System.Windows.Forms.Label();
            this.dtpRepTo = new System.Windows.Forms.DateTimePicker();
            this.btnRepShowIncome = new System.Windows.Forms.Button();
            this.btnRepPrint = new System.Windows.Forms.Button();
            this.lblRepTotal = new System.Windows.Forms.Label();
            this.dgvRepTransactions = new System.Windows.Forms.DataGridView();

            // Setup DataGridView Columns and Properties strictly in Designer
            ConfigureAllDataGrids();

            this.tabControlMain.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.pnlLoginCenter.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.pnlCardBookings.SuspendLayout();
            this.pnlCardGear.SuspendLayout();
            this.pnlCardInUse.SuspendLayout();
            this.tabGear.SuspendLayout();
            this.tabPlayers.SuspendLayout();
            this.tabBookings.SuspendLayout();
            this.tabIssueReturn.SuspendLayout();
            this.tabPayment.SuspendLayout();
            this.tabArrivals.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // ==========================================
            // Title Bar Panel & Controls
            // ==========================================
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(138)))), ((int)(((byte)(221)))));
            this.pnlTitleBar.Controls.Add(this.lblDotClose);
            this.pnlTitleBar.Controls.Add(this.lblDotMax);
            this.pnlTitleBar.Controls.Add(this.lblDotMin);
            this.pnlTitleBar.Controls.Add(this.lblAppTitle);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Height = 36;
            this.pnlTitleBar.Name = "pnlTitleBar";

            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(12, 8);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Text = "🎯 Close Contact Paintball Management System";

            this.lblDotClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDotClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(151)))), ((int)(((byte)(224)))));
            this.lblDotClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDotClose.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblDotClose.ForeColor = System.Drawing.Color.White;
            this.lblDotClose.Location = new System.Drawing.Point(972, 10);
            this.lblDotClose.Name = "lblDotClose";
            this.lblDotClose.Size = new System.Drawing.Size(16, 16);
            this.lblDotClose.Text = "x";
            this.lblDotClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDotClose.Click += (s, e) => this.Close();

            this.lblDotMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDotMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(151)))), ((int)(((byte)(224)))));
            this.lblDotMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDotMax.Location = new System.Drawing.Point(950, 10);
            this.lblDotMax.Name = "lblDotMax";
            this.lblDotMax.Size = new System.Drawing.Size(16, 16);
            this.lblDotMax.Click += (s, e) => this.WindowState = this.WindowState == System.Windows.Forms.FormWindowState.Maximized ? System.Windows.Forms.FormWindowState.Normal : System.Windows.Forms.FormWindowState.Maximized;

            this.lblDotMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDotMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(151)))), ((int)(((byte)(224)))));
            this.lblDotMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDotMin.Location = new System.Drawing.Point(928, 10);
            this.lblDotMin.Name = "lblDotMin";
            this.lblDotMin.Size = new System.Drawing.Size(16, 16);
            this.lblDotMin.Click += (s, e) => this.WindowState = System.Windows.Forms.FormWindowState.Minimized;

            // ==========================================
            // Menu Strip
            // ==========================================
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.menuStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuFile, this.menuMaintain, this.menuTransactions, this.menuReports, this.menuHelp
            });
            this.menuStrip.Location = new System.Drawing.Point(0, 36);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1000, 24);

            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuFileSwitchUser, this.menuFileExit });
            this.menuFile.Text = "File";
            this.menuFileSwitchUser.Text = "Switch User / Log in";
            this.menuFileSwitchUser.Click += (s, e) => NavigateToTab(this.tabLogin);
            this.menuFileExit.Text = "Exit";
            this.menuFileExit.Click += (s, e) => this.Close();

            this.menuMaintain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuMaintainGear, this.menuMaintainPlayers, this.menuMaintainBookings });
            this.menuMaintain.Text = "Maintain";
            this.menuMaintainGear.Text = "Gear";
            this.menuMaintainGear.Click += (s, e) => NavigateToTab(this.tabGear);
            this.menuMaintainPlayers.Text = "Players";
            this.menuMaintainPlayers.Click += (s, e) => NavigateToTab(this.tabPlayers);
            this.menuMaintainBookings.Text = "Bookings";
            this.menuMaintainBookings.Click += (s, e) => NavigateToTab(this.tabBookings);

            this.menuTransactions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuTransIssueReturn, this.menuTransPayment, this.menuTransArrivals });
            this.menuTransactions.Text = "Transactions";
            this.menuTransIssueReturn.Text = "Issue / return";
            this.menuTransIssueReturn.Click += (s, e) => NavigateToTab(this.tabIssueReturn);
            this.menuTransPayment.Text = "Payment";
            this.menuTransPayment.Click += (s, e) => NavigateToTab(this.tabPayment);
            this.menuTransArrivals.Text = "Arrivals";
            this.menuTransArrivals.Click += (s, e) => NavigateToTab(this.tabArrivals);

            this.menuReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuReportsRevenue });
            this.menuReports.Text = "Reports";
            this.menuReportsRevenue.Text = "Revenue Report";
            this.menuReportsRevenue.Click += (s, e) => NavigateToTab(this.tabReports);

            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuHelpAbout });
            this.menuHelp.Text = "Help";
            this.menuHelpAbout.Text = "About";
            this.menuHelpAbout.Click += (s, e) => System.Windows.Forms.MessageBox.Show("Close Contact Paintball Management System\nC# Windows Forms & SQL Server", "About");

            // ==========================================
            // Sidebar Navigation Panel
            // ==========================================
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.pnlSidebar.Controls.Add(this.btnNavReports);
            this.pnlSidebar.Controls.Add(this.btnNavArrivals);
            this.pnlSidebar.Controls.Add(this.btnNavPayment);
            this.pnlSidebar.Controls.Add(this.btnNavIssueReturn);
            this.pnlSidebar.Controls.Add(this.btnNavBookings);
            this.pnlSidebar.Controls.Add(this.btnNavPlayers);
            this.pnlSidebar.Controls.Add(this.btnNavGear);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Controls.Add(this.btnNavLogin);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 60);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Padding = new System.Windows.Forms.Padding(8);
            this.pnlSidebar.Size = new System.Drawing.Size(150, 598);

            ConfigureNavButton(this.btnNavReports, "📊 Reports", 8, this.tabReports);
            ConfigureNavButton(this.btnNavArrivals, "🚶 Arrivals", 7, this.tabArrivals);
            ConfigureNavButton(this.btnNavPayment, "💵 Payment", 6, this.tabPayment);
            ConfigureNavButton(this.btnNavIssueReturn, "🔄 Issue / return", 5, this.tabIssueReturn);
            ConfigureNavButton(this.btnNavBookings, "📅 Bookings", 4, this.tabBookings);
            ConfigureNavButton(this.btnNavPlayers, "👥 Players", 3, this.tabPlayers);
            ConfigureNavButton(this.btnNavGear, "📦 Gear", 2, this.tabGear);
            ConfigureNavButton(this.btnNavDashboard, "🏠 Dashboard", 1, this.tabDashboard);
            ConfigureNavButton(this.btnNavLogin, "🔒 Login", 0, this.tabLogin);

            // ==========================================
            // Status Strip
            // ==========================================
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.statusStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(135)))), ((int)(((byte)(128)))));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblStatusUser, this.lblStatusState });
            this.statusStrip.Location = new System.Drawing.Point(150, 636);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(850, 22);

            this.lblStatusUser.Name = "lblStatusUser";
            this.lblStatusUser.Text = "Logged in as: Marshal";

            this.lblStatusState.Name = "lblStatusState";
            this.lblStatusState.Spring = true;
            this.lblStatusState.Text = "Ready";
            this.lblStatusState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // ==========================================
            // Main Tab Control
            // ==========================================
            this.tabControlMain.Controls.Add(this.tabLogin);
            this.tabControlMain.Controls.Add(this.tabDashboard);
            this.tabControlMain.Controls.Add(this.tabGear);
            this.tabControlMain.Controls.Add(this.tabPlayers);
            this.tabControlMain.Controls.Add(this.tabBookings);
            this.tabControlMain.Controls.Add(this.tabIssueReturn);
            this.tabControlMain.Controls.Add(this.tabPayment);
            this.tabControlMain.Controls.Add(this.tabArrivals);
            this.tabControlMain.Controls.Add(this.tabReports);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(150, 60);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 1;
            this.tabControlMain.Size = new System.Drawing.Size(850, 576);
            this.tabControlMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlMain.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;

            // ------------------------------------------
            // TAB 1: Login
            // ------------------------------------------
            this.tabLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.tabLogin.Controls.Add(this.pnlLoginCenter);
            this.tabLogin.Location = new System.Drawing.Point(4, 5);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Size = new System.Drawing.Size(842, 567);
            this.tabLogin.Text = "Login";

            this.pnlLoginCenter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLoginCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.pnlLoginCenter.Controls.Add(this.lblLoginHint);
            this.pnlLoginCenter.Controls.Add(this.lblLoginError);
            this.pnlLoginCenter.Controls.Add(this.btnClearLogin);
            this.pnlLoginCenter.Controls.Add(this.btnLoginAction);
            this.pnlLoginCenter.Controls.Add(this.txtPassword);
            this.pnlLoginCenter.Controls.Add(this.lblPassword);
            this.pnlLoginCenter.Controls.Add(this.txtUsername);
            this.pnlLoginCenter.Controls.Add(this.lblUsername);
            this.pnlLoginCenter.Controls.Add(this.lblLoginTitle);
            this.pnlLoginCenter.Location = new System.Drawing.Point(251, 110);
            this.pnlLoginCenter.Name = "pnlLoginCenter";
            this.pnlLoginCenter.Size = new System.Drawing.Size(340, 310);

            this.lblLoginTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLoginTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.lblLoginTitle.Location = new System.Drawing.Point(0, 0);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(340, 35);
            this.lblLoginTitle.Text = "Log in";
            this.lblLoginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblUsername.Location = new System.Drawing.Point(0, 45);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(340, 20);
            this.lblUsername.Text = "Username";

            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.txtUsername.Location = new System.Drawing.Point(0, 68);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "e.g. j.marshal";
            this.txtUsername.Size = new System.Drawing.Size(340, 23);
            this.txtUsername.Text = "j.marshal";

            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblPassword.Location = new System.Drawing.Point(0, 105);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(340, 20);
            this.lblPassword.Text = "Password";

            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.txtPassword.Location = new System.Drawing.Point(0, 128);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(340, 23);
            this.txtPassword.Text = "marshal123";
            this.txtPassword.UseSystemPasswordChar = true;

            this.lblLoginError.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblLoginError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblLoginError.Location = new System.Drawing.Point(0, 155);
            this.lblLoginError.Name = "lblLoginError";
            this.lblLoginError.Size = new System.Drawing.Size(340, 25);
            this.lblLoginError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnLoginAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnLoginAction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.btnLoginAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginAction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoginAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.btnLoginAction.Location = new System.Drawing.Point(0, 185);
            this.btnLoginAction.Name = "btnLoginAction";
            this.btnLoginAction.Size = new System.Drawing.Size(165, 34);
            this.btnLoginAction.Text = "Log in";
            this.btnLoginAction.UseVisualStyleBackColor = false;
            this.btnLoginAction.Click += new System.EventHandler(this.btnLoginAction_Click);

            this.btnClearLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnClearLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.btnClearLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.btnClearLogin.Location = new System.Drawing.Point(175, 185);
            this.btnClearLogin.Name = "btnClearLogin";
            this.btnClearLogin.Size = new System.Drawing.Size(165, 34);
            this.btnClearLogin.Text = "Cancel";
            this.btnClearLogin.UseVisualStyleBackColor = false;
            this.btnClearLogin.Click += new System.EventHandler(this.btnClearLogin_Click);

            this.lblLoginHint.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblLoginHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(135)))), ((int)(((byte)(128)))));
            this.lblLoginHint.Location = new System.Drawing.Point(0, 235);
            this.lblLoginHint.Name = "lblLoginHint";
            this.lblLoginHint.Size = new System.Drawing.Size(340, 40);
            this.lblLoginHint.Text = "Default accounts: j.marshal (marshal123) or admin (admin123)";
            this.lblLoginHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ------------------------------------------
            // TAB 2: Dashboard
            // ------------------------------------------
            this.tabDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.tabDashboard.Controls.Add(this.dgvTodaySchedule);
            this.tabDashboard.Controls.Add(this.lblTodaySchedule);
            this.tabDashboard.Controls.Add(this.pnlCardInUse);
            this.tabDashboard.Controls.Add(this.pnlCardGear);
            this.tabDashboard.Controls.Add(this.pnlCardBookings);
            this.tabDashboard.Controls.Add(this.lblDashTitle);
            this.tabDashboard.Location = new System.Drawing.Point(4, 5);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(16);
            this.tabDashboard.Size = new System.Drawing.Size(842, 567);
            this.tabDashboard.Text = "Dashboard";

            this.lblDashTitle.AutoSize = true;
            this.lblDashTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDashTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.lblDashTitle.Location = new System.Drawing.Point(16, 14);
            this.lblDashTitle.Name = "lblDashTitle";
            this.lblDashTitle.Text = "Today";

            // Card 1: Bookings today
            this.pnlCardBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.pnlCardBookings.Controls.Add(this.lblCardBookingsText);
            this.pnlCardBookings.Controls.Add(this.lblCardBookingsCount);
            this.pnlCardBookings.Controls.Add(this.lblCardBookingsIcon);
            this.pnlCardBookings.Location = new System.Drawing.Point(16, 42);
            this.pnlCardBookings.Name = "pnlCardBookings";
            this.pnlCardBookings.Size = new System.Drawing.Size(255, 90);

            this.lblCardBookingsIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCardBookingsIcon.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblCardBookingsIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(138)))), ((int)(((byte)(221)))));
            this.lblCardBookingsIcon.Location = new System.Drawing.Point(0, 0);
            this.lblCardBookingsIcon.Name = "lblCardBookingsIcon";
            this.lblCardBookingsIcon.Size = new System.Drawing.Size(255, 30);
            this.lblCardBookingsIcon.Text = "📅";
            this.lblCardBookingsIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblCardBookingsCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCardBookingsCount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCardBookingsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.lblCardBookingsCount.Location = new System.Drawing.Point(0, 30);
            this.lblCardBookingsCount.Name = "lblCardBookingsCount";
            this.lblCardBookingsCount.Size = new System.Drawing.Size(255, 30);
            this.lblCardBookingsCount.Text = "0";
            this.lblCardBookingsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblCardBookingsText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCardBookingsText.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblCardBookingsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblCardBookingsText.Location = new System.Drawing.Point(0, 65);
            this.lblCardBookingsText.Name = "lblCardBookingsText";
            this.lblCardBookingsText.Size = new System.Drawing.Size(255, 25);
            this.lblCardBookingsText.Text = "Bookings today";
            this.lblCardBookingsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Card 2: Gear ready
            this.pnlCardGear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.pnlCardGear.Controls.Add(this.lblCardGearText);
            this.pnlCardGear.Controls.Add(this.lblCardGearCount);
            this.pnlCardGear.Controls.Add(this.lblCardGearIcon);
            this.pnlCardGear.Location = new System.Drawing.Point(286, 42);
            this.pnlCardGear.Name = "pnlCardGear";
            this.pnlCardGear.Size = new System.Drawing.Size(255, 90);

            this.lblCardGearIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCardGearIcon.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblCardGearIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(138)))), ((int)(((byte)(221)))));
            this.lblCardGearIcon.Location = new System.Drawing.Point(0, 0);
            this.lblCardGearIcon.Name = "lblCardGearIcon";
            this.lblCardGearIcon.Size = new System.Drawing.Size(255, 30);
            this.lblCardGearIcon.Text = "📦";
            this.lblCardGearIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblCardGearCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCardGearCount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCardGearCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.lblCardGearCount.Location = new System.Drawing.Point(0, 30);
            this.lblCardGearCount.Name = "lblCardGearCount";
            this.lblCardGearCount.Size = new System.Drawing.Size(255, 30);
            this.lblCardGearCount.Text = "0";
            this.lblCardGearCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblCardGearText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCardGearText.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblCardGearText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblCardGearText.Location = new System.Drawing.Point(0, 65);
            this.lblCardGearText.Name = "lblCardGearText";
            this.lblCardGearText.Size = new System.Drawing.Size(255, 25);
            this.lblCardGearText.Text = "Gear ready";
            this.lblCardGearText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Card 3: Gear in use
            this.pnlCardInUse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.pnlCardInUse.Controls.Add(this.lblCardInUseText);
            this.pnlCardInUse.Controls.Add(this.lblCardInUseCount);
            this.pnlCardInUse.Controls.Add(this.lblCardInUseIcon);
            this.pnlCardInUse.Location = new System.Drawing.Point(556, 42);
            this.pnlCardInUse.Name = "pnlCardInUse";
            this.pnlCardInUse.Size = new System.Drawing.Size(255, 90);

            this.lblCardInUseIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCardInUseIcon.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblCardInUseIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(138)))), ((int)(((byte)(221)))));
            this.lblCardInUseIcon.Location = new System.Drawing.Point(0, 0);
            this.lblCardInUseIcon.Name = "lblCardInUseIcon";
            this.lblCardInUseIcon.Size = new System.Drawing.Size(255, 30);
            this.lblCardInUseIcon.Text = "🎯";
            this.lblCardInUseIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblCardInUseCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCardInUseCount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCardInUseCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.lblCardInUseCount.Location = new System.Drawing.Point(0, 30);
            this.lblCardInUseCount.Name = "lblCardInUseCount";
            this.lblCardInUseCount.Size = new System.Drawing.Size(255, 30);
            this.lblCardInUseCount.Text = "0";
            this.lblCardInUseCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblCardInUseText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCardInUseText.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblCardInUseText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblCardInUseText.Location = new System.Drawing.Point(0, 65);
            this.lblCardInUseText.Name = "lblCardInUseText";
            this.lblCardInUseText.Size = new System.Drawing.Size(255, 25);
            this.lblCardInUseText.Text = "Gear in use";
            this.lblCardInUseText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Schedule Table
            this.lblTodaySchedule.AutoSize = true;
            this.lblTodaySchedule.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTodaySchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.lblTodaySchedule.Location = new System.Drawing.Point(16, 150);
            this.lblTodaySchedule.Name = "lblTodaySchedule";
            this.lblTodaySchedule.Text = "Today's Field Schedule";

            this.dgvTodaySchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTodaySchedule.Location = new System.Drawing.Point(16, 180);
            this.dgvTodaySchedule.Name = "dgvTodaySchedule";
            this.dgvTodaySchedule.Size = new System.Drawing.Size(810, 370);

            // ------------------------------------------
            // TAB 3: Gear
            // ------------------------------------------
            this.tabGear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.tabGear.Controls.Add(this.lblGearCostNote);
            this.tabGear.Controls.Add(this.dgvGear);
            this.tabGear.Controls.Add(this.btnGearClear);
            this.tabGear.Controls.Add(this.btnGearRemove);
            this.tabGear.Controls.Add(this.btnGearSave);
            this.tabGear.Controls.Add(this.btnGearAdd);
            this.tabGear.Controls.Add(this.cmbGearCondition);
            this.tabGear.Controls.Add(this.lblGearCondition);
            this.tabGear.Controls.Add(this.cmbGearSize);
            this.tabGear.Controls.Add(this.lblGearSize);
            this.tabGear.Controls.Add(this.cmbGearType);
            this.tabGear.Controls.Add(this.lblGearType);
            this.tabGear.Controls.Add(this.txtGearSerial);
            this.tabGear.Controls.Add(this.lblGearSerial);
            this.tabGear.Controls.Add(this.btnGearFind);
            this.tabGear.Controls.Add(this.txtGearSearch);
            this.tabGear.Controls.Add(this.lblGearTitle);
            this.tabGear.Location = new System.Drawing.Point(4, 5);
            this.tabGear.Name = "tabGear";
            this.tabGear.Padding = new System.Windows.Forms.Padding(16);
            this.tabGear.Size = new System.Drawing.Size(842, 567);
            this.tabGear.Text = "Gear";

            this.lblGearTitle.AutoSize = true;
            this.lblGearTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGearTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.lblGearTitle.Location = new System.Drawing.Point(16, 14);
            this.lblGearTitle.Name = "lblGearTitle";
            this.lblGearTitle.Text = "Gear";

            this.txtGearSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            this.txtGearSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGearSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGearSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.txtGearSearch.Location = new System.Drawing.Point(16, 42);
            this.txtGearSearch.Name = "txtGearSearch";
            this.txtGearSearch.PlaceholderText = "Scan or type serial number";
            this.txtGearSearch.Size = new System.Drawing.Size(350, 23);

            this.btnGearFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnGearFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.btnGearFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGearFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGearFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.btnGearFind.Location = new System.Drawing.Point(374, 40);
            this.btnGearFind.Name = "btnGearFind";
            this.btnGearFind.Size = new System.Drawing.Size(80, 26);
            this.btnGearFind.Text = "🔍 Find";
            this.btnGearFind.UseVisualStyleBackColor = false;
            this.btnGearFind.Click += new System.EventHandler(this.btnGearFind_Click);

            this.lblGearSerial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGearSerial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblGearSerial.Location = new System.Drawing.Point(16, 83);
            this.lblGearSerial.Name = "lblGearSerial";
            this.lblGearSerial.Size = new System.Drawing.Size(100, 20);
            this.lblGearSerial.Text = "Serial number";

            this.txtGearSerial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            this.txtGearSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGearSerial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGearSerial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.txtGearSerial.Location = new System.Drawing.Point(120, 80);
            this.txtGearSerial.Name = "txtGearSerial";
            this.txtGearSerial.PlaceholderText = "e.g. MK-0231";
            this.txtGearSerial.Size = new System.Drawing.Size(160, 23);

            this.lblGearType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGearType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblGearType.Location = new System.Drawing.Point(310, 83);
            this.lblGearType.Name = "lblGearType";
            this.lblGearType.Size = new System.Drawing.Size(70, 20);
            this.lblGearType.Text = "Type";

            this.cmbGearType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            this.cmbGearType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGearType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGearType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbGearType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.cmbGearType.Items.AddRange(new object[] { "Marker", "Mask", "Overall", "Gas cylinder" });
            this.cmbGearType.Location = new System.Drawing.Point(385, 80);
            this.cmbGearType.Name = "cmbGearType";
            this.cmbGearType.Size = new System.Drawing.Size(160, 23);

            this.lblGearSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGearSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblGearSize.Location = new System.Drawing.Point(16, 118);
            this.lblGearSize.Name = "lblGearSize";
            this.lblGearSize.Size = new System.Drawing.Size(100, 20);
            this.lblGearSize.Text = "Size";

            this.cmbGearSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            this.cmbGearSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGearSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGearSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbGearSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.cmbGearSize.Items.AddRange(new object[] { "-", "S", "M", "L", "XL" });
            this.cmbGearSize.Location = new System.Drawing.Point(120, 115);
            this.cmbGearSize.Name = "cmbGearSize";
            this.cmbGearSize.Size = new System.Drawing.Size(160, 23);

            this.lblGearCondition.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGearCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblGearCondition.Location = new System.Drawing.Point(310, 118);
            this.lblGearCondition.Name = "lblGearCondition";
            this.lblGearCondition.Size = new System.Drawing.Size(70, 20);
            this.lblGearCondition.Text = "Condition";

            this.cmbGearCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            this.cmbGearCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGearCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGearCondition.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbGearCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.cmbGearCondition.Items.AddRange(new object[] { "Ready", "In use", "Needs cleaning", "Under repair", "Retired" });
            this.cmbGearCondition.Location = new System.Drawing.Point(385, 115);
            this.cmbGearCondition.Name = "cmbGearCondition";
            this.cmbGearCondition.Size = new System.Drawing.Size(160, 23);

            this.btnGearAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnGearAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.btnGearAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGearAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGearAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.btnGearAdd.Location = new System.Drawing.Point(16, 155);
            this.btnGearAdd.Name = "btnGearAdd";
            this.btnGearAdd.Size = new System.Drawing.Size(90, 28);
            this.btnGearAdd.Text = "➕ Add";
            this.btnGearAdd.UseVisualStyleBackColor = false;
            this.btnGearAdd.Click += new System.EventHandler(this.btnGearAdd_Click);

            this.btnGearSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnGearSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.btnGearSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGearSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGearSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.btnGearSave.Location = new System.Drawing.Point(114, 155);
            this.btnGearSave.Name = "btnGearSave";
            this.btnGearSave.Size = new System.Drawing.Size(115, 28);
            this.btnGearSave.Text = "💾 Save changes";
            this.btnGearSave.UseVisualStyleBackColor = false;
            this.btnGearSave.Click += new System.EventHandler(this.btnGearSave_Click);

            this.btnGearRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnGearRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.btnGearRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGearRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGearRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.btnGearRemove.Location = new System.Drawing.Point(237, 155);
            this.btnGearRemove.Name = "btnGearRemove";
            this.btnGearRemove.Size = new System.Drawing.Size(95, 28);
            this.btnGearRemove.Text = "🗑️ Remove";
            this.btnGearRemove.UseVisualStyleBackColor = false;
            this.btnGearRemove.Click += new System.EventHandler(this.btnGearRemove_Click);

            this.btnGearClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnGearClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.btnGearClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGearClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGearClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.btnGearClear.Location = new System.Drawing.Point(340, 155);
            this.btnGearClear.Name = "btnGearClear";
            this.btnGearClear.Size = new System.Drawing.Size(85, 28);
            this.btnGearClear.Text = "🔄 Clear";
            this.btnGearClear.UseVisualStyleBackColor = false;
            this.btnGearClear.Click += new System.EventHandler(this.btnGearClear_Click);

            this.dgvGear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGear.Location = new System.Drawing.Point(16, 195);
            this.dgvGear.Name = "dgvGear";
            this.dgvGear.Size = new System.Drawing.Size(810, 340);
            this.dgvGear.SelectionChanged += new System.EventHandler(this.dgvGear_SelectionChanged);

            this.lblGearCostNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGearCostNote.AutoSize = true;
            this.lblGearCostNote.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblGearCostNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(135)))), ((int)(((byte)(128)))));
            this.lblGearCostNote.Location = new System.Drawing.Point(16, 542);
            this.lblGearCostNote.Name = "lblGearCostNote";
            this.lblGearCostNote.Text = "ℹ️ Cost isn't shown here - that's an office record, not something you need on the floor.";

            // ------------------------------------------
            // TAB 4: Players
            // ------------------------------------------
            this.tabPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.tabPlayers.Controls.Add(this.dgvPlayers);
            this.tabPlayers.Controls.Add(this.btnPlayerClear);
            this.tabPlayers.Controls.Add(this.btnPlayerFind);
            this.tabPlayers.Controls.Add(this.btnPlayerSave);
            this.tabPlayers.Controls.Add(this.btnPlayerAdd);
            this.tabPlayers.Controls.Add(this.chkPlayerWaiver);
            this.tabPlayers.Controls.Add(this.txtPlayerSurname);
            this.tabPlayers.Controls.Add(this.lblPlayerSurname);
            this.tabPlayers.Controls.Add(this.txtPlayerFirst);
            this.tabPlayers.Controls.Add(this.lblPlayerFirst);
            this.tabPlayers.Controls.Add(this.lblPlayersTitle);
            this.tabPlayers.Location = new System.Drawing.Point(4, 5);
            this.tabPlayers.Name = "tabPlayers";
            this.tabPlayers.Padding = new System.Windows.Forms.Padding(16);
            this.tabPlayers.Size = new System.Drawing.Size(842, 567);
            this.tabPlayers.Text = "Players";

            this.lblPlayersTitle.AutoSize = true;
            this.lblPlayersTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPlayersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.lblPlayersTitle.Location = new System.Drawing.Point(16, 14);
            this.lblPlayersTitle.Name = "lblPlayersTitle";
            this.lblPlayersTitle.Text = "Players";

            this.lblPlayerFirst.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPlayerFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblPlayerFirst.Location = new System.Drawing.Point(16, 48);
            this.lblPlayerFirst.Name = "lblPlayerFirst";
            this.lblPlayerFirst.Size = new System.Drawing.Size(90, 20);
            this.lblPlayerFirst.Text = "First name";

            this.txtPlayerFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            this.txtPlayerFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlayerFirst.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPlayerFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.txtPlayerFirst.Location = new System.Drawing.Point(110, 45);
            this.txtPlayerFirst.Name = "txtPlayerFirst";
            this.txtPlayerFirst.Size = new System.Drawing.Size(180, 23);

            this.lblPlayerSurname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPlayerSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblPlayerSurname.Location = new System.Drawing.Point(310, 48);
            this.lblPlayerSurname.Name = "lblPlayerSurname";
            this.lblPlayerSurname.Size = new System.Drawing.Size(80, 20);
            this.lblPlayerSurname.Text = "Surname";

            this.txtPlayerSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            this.txtPlayerSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlayerSurname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPlayerSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.txtPlayerSurname.Location = new System.Drawing.Point(395, 45);
            this.txtPlayerSurname.Name = "txtPlayerSurname";
            this.txtPlayerSurname.Size = new System.Drawing.Size(180, 23);

            this.chkPlayerWaiver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkPlayerWaiver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.chkPlayerWaiver.Location = new System.Drawing.Point(110, 78);
            this.chkPlayerWaiver.Name = "chkPlayerWaiver";
            this.chkPlayerWaiver.Size = new System.Drawing.Size(180, 24);
            this.chkPlayerWaiver.Text = "Waiver signed";

            this.btnPlayerAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnPlayerAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.btnPlayerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPlayerAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.btnPlayerAdd.Location = new System.Drawing.Point(16, 115);
            this.btnPlayerAdd.Name = "btnPlayerAdd";
            this.btnPlayerAdd.Size = new System.Drawing.Size(90, 28);
            this.btnPlayerAdd.Text = "➕ Add";
            this.btnPlayerAdd.UseVisualStyleBackColor = false;
            this.btnPlayerAdd.Click += new System.EventHandler(this.btnPlayerAdd_Click);

            this.btnPlayerSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnPlayerSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.btnPlayerSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPlayerSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.btnPlayerSave.Location = new System.Drawing.Point(114, 115);
            this.btnPlayerSave.Name = "btnPlayerSave";
            this.btnPlayerSave.Size = new System.Drawing.Size(115, 28);
            this.btnPlayerSave.Text = "💾 Save changes";
            this.btnPlayerSave.UseVisualStyleBackColor = false;
            this.btnPlayerSave.Click += new System.EventHandler(this.btnPlayerSave_Click);

            this.btnPlayerFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnPlayerFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.btnPlayerFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPlayerFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.btnPlayerFind.Location = new System.Drawing.Point(237, 115);
            this.btnPlayerFind.Name = "btnPlayerFind";
            this.btnPlayerFind.Size = new System.Drawing.Size(85, 28);
            this.btnPlayerFind.Text = "🔍 Find";
            this.btnPlayerFind.UseVisualStyleBackColor = false;
            this.btnPlayerFind.Click += new System.EventHandler(this.btnPlayerFind_Click);

            this.btnPlayerClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnPlayerClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.btnPlayerClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPlayerClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.btnPlayerClear.Location = new System.Drawing.Point(330, 115);
            this.btnPlayerClear.Name = "btnPlayerClear";
            this.btnPlayerClear.Size = new System.Drawing.Size(85, 28);
            this.btnPlayerClear.Text = "🔄 Clear";
            this.btnPlayerClear.UseVisualStyleBackColor = false;
            this.btnPlayerClear.Click += new System.EventHandler(this.btnPlayerClear_Click);

            this.dgvPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlayers.Location = new System.Drawing.Point(16, 155);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.Size = new System.Drawing.Size(810, 395);
            this.dgvPlayers.SelectionChanged += new System.EventHandler(this.dgvPlayers_SelectionChanged);

            // ------------------------------------------
            // TAB 5: Bookings
            // ------------------------------------------
            this.tabBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.tabBookings.Controls.Add(this.dgvBookings);
            this.tabBookings.Controls.Add(this.btnBookingClear);
            this.tabBookings.Controls.Add(this.btnBookingSave);
            this.tabBookings.Controls.Add(this.btnBookingAdd);
            this.tabBookings.Controls.Add(this.numBookingPlayers);
            this.tabBookings.Controls.Add(this.lblBookingNumPlayers);
            this.tabBookings.Controls.Add(this.txtBookingField);
            this.tabBookings.Controls.Add(this.lblBookingField);
            this.tabBookings.Controls.Add(this.cmbBookingOccasion);
            this.tabBookings.Controls.Add(this.lblBookingOccasion);
            this.tabBookings.Controls.Add(this.dtpBookingDate);
            this.tabBookings.Controls.Add(this.lblBookingDate);
            this.tabBookings.Controls.Add(this.cmbBookingCustomer);
            this.tabBookings.Controls.Add(this.lblBookedBy);
            this.tabBookings.Controls.Add(this.lblBookingsTitle);
            this.tabBookings.Location = new System.Drawing.Point(4, 5);
            this.tabBookings.Name = "tabBookings";
            this.tabBookings.Padding = new System.Windows.Forms.Padding(16);
            this.tabBookings.Size = new System.Drawing.Size(842, 567);
            this.tabBookings.Text = "Bookings";

            this.lblBookingsTitle.AutoSize = true;
            this.lblBookingsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBookingsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.lblBookingsTitle.Location = new System.Drawing.Point(16, 12);
            this.lblBookingsTitle.Name = "lblBookingsTitle";
            this.lblBookingsTitle.Text = "Bookings";

            this.lblBookedBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBookedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblBookedBy.Location = new System.Drawing.Point(16, 45);
            this.lblBookedBy.Name = "lblBookedBy";
            this.lblBookedBy.Size = new System.Drawing.Size(120, 20);
            this.lblBookedBy.Text = "Booked by";

            this.cmbBookingCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            this.cmbBookingCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookingCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBookingCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbBookingCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.cmbBookingCustomer.Location = new System.Drawing.Point(145, 42);
            this.cmbBookingCustomer.Name = "cmbBookingCustomer";
            this.cmbBookingCustomer.Size = new System.Drawing.Size(200, 23);

            this.lblBookingDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBookingDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblBookingDate.Location = new System.Drawing.Point(365, 45);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(70, 20);
            this.lblBookingDate.Text = "Date";

            this.dtpBookingDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.dtpBookingDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            this.dtpBookingDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(138)))), ((int)(((byte)(221)))));
            this.dtpBookingDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBookingDate.Location = new System.Drawing.Point(440, 42);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(160, 23);

            this.lblBookingOccasion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBookingOccasion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblBookingOccasion.Location = new System.Drawing.Point(16, 78);
            this.lblBookingOccasion.Name = "lblBookingOccasion";
            this.lblBookingOccasion.Size = new System.Drawing.Size(120, 20);
            this.lblBookingOccasion.Text = "Occasion";

            this.cmbBookingOccasion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            this.cmbBookingOccasion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookingOccasion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBookingOccasion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbBookingOccasion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.cmbBookingOccasion.Items.AddRange(new object[] { "Birthday", "Bachelor", "Tour group", "Corporate" });
            this.cmbBookingOccasion.Location = new System.Drawing.Point(145, 75);
            this.cmbBookingOccasion.Name = "cmbBookingOccasion";
            this.cmbBookingOccasion.Size = new System.Drawing.Size(200, 23);

            this.lblBookingField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBookingField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblBookingField.Location = new System.Drawing.Point(365, 78);
            this.lblBookingField.Name = "lblBookingField";
            this.lblBookingField.Size = new System.Drawing.Size(70, 20);
            this.lblBookingField.Text = "Field";

            this.txtBookingField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            this.txtBookingField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookingField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBookingField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.txtBookingField.Location = new System.Drawing.Point(440, 75);
            this.txtBookingField.Name = "txtBookingField";
            this.txtBookingField.Size = new System.Drawing.Size(160, 23);
            this.txtBookingField.Text = "Field 1";

            this.lblBookingNumPlayers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBookingNumPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblBookingNumPlayers.Location = new System.Drawing.Point(16, 112);
            this.lblBookingNumPlayers.Name = "lblBookingNumPlayers";
            this.lblBookingNumPlayers.Size = new System.Drawing.Size(120, 20);
            this.lblBookingNumPlayers.Text = "Number of players";

            this.numBookingPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            this.numBookingPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numBookingPlayers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numBookingPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.numBookingPlayers.Location = new System.Drawing.Point(145, 110);
            this.numBookingPlayers.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            this.numBookingPlayers.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numBookingPlayers.Name = "numBookingPlayers";
            this.numBookingPlayers.Size = new System.Drawing.Size(90, 23);
            this.numBookingPlayers.Value = new decimal(new int[] { 4, 0, 0, 0 });

            this.btnBookingAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnBookingAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.btnBookingAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBookingAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.btnBookingAdd.Location = new System.Drawing.Point(16, 150);
            this.btnBookingAdd.Name = "btnBookingAdd";
            this.btnBookingAdd.Size = new System.Drawing.Size(120, 28);
            this.btnBookingAdd.Text = "➕ Add booking";
            this.btnBookingAdd.UseVisualStyleBackColor = false;
            this.btnBookingAdd.Click += new System.EventHandler(this.btnBookingAdd_Click);

            this.btnBookingSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnBookingSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.btnBookingSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBookingSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.btnBookingSave.Location = new System.Drawing.Point(145, 150);
            this.btnBookingSave.Name = "btnBookingSave";
            this.btnBookingSave.Size = new System.Drawing.Size(120, 28);
            this.btnBookingSave.Text = "💾 Save changes";
            this.btnBookingSave.UseVisualStyleBackColor = false;
            this.btnBookingSave.Click += new System.EventHandler(this.btnBookingSave_Click);

            this.btnBookingClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnBookingClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.btnBookingClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBookingClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.btnBookingClear.Location = new System.Drawing.Point(275, 150);
            this.btnBookingClear.Name = "btnBookingClear";
            this.btnBookingClear.Size = new System.Drawing.Size(85, 28);
            this.btnBookingClear.Text = "🔄 Clear";
            this.btnBookingClear.UseVisualStyleBackColor = false;
            this.btnBookingClear.Click += new System.EventHandler(this.btnBookingClear_Click);

            this.dgvBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBookings.Location = new System.Drawing.Point(16, 190);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.Size = new System.Drawing.Size(810, 360);
            this.dgvBookings.SelectionChanged += new System.EventHandler(this.dgvBookings_SelectionChanged);

            // ------------------------------------------
            // TAB 6: Issue / Return
            // ------------------------------------------
            this.tabIssueReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.tabIssueReturn.Controls.Add(this.btnIssueTakeBack);
            this.tabIssueReturn.Controls.Add(this.cmbReturnCondition);
            this.tabIssueReturn.Controls.Add(this.lblReturnCondition);
            this.tabIssueReturn.Controls.Add(this.dgvIssueActive);
            this.tabIssueReturn.Controls.Add(this.lblIssueActive);
            this.tabIssueReturn.Controls.Add(this.btnIssueHandOut);
            this.tabIssueReturn.Controls.Add(this.chkListIssueReady);
            this.tabIssueReturn.Controls.Add(this.lblIssueReady);
            this.tabIssueReturn.Controls.Add(this.cmbIssuePlayer);
            this.tabIssueReturn.Controls.Add(this.lblIssuePlayer);
            this.tabIssueReturn.Controls.Add(this.cmbIssueBooking);
            this.tabIssueReturn.Controls.Add(this.lblIssueBooking);
            this.tabIssueReturn.Controls.Add(this.lblIssueTitle);
            this.tabIssueReturn.Location = new System.Drawing.Point(4, 5);
            this.tabIssueReturn.Name = "tabIssueReturn";
            this.tabIssueReturn.Padding = new System.Windows.Forms.Padding(16);
            this.tabIssueReturn.Size = new System.Drawing.Size(842, 567);
            this.tabIssueReturn.Text = "Issue / return";

            this.lblIssueTitle.AutoSize = true;
            this.lblIssueTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblIssueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.lblIssueTitle.Location = new System.Drawing.Point(16, 12);
            this.lblIssueTitle.Name = "lblIssueTitle";
            this.lblIssueTitle.Text = "Issue / return gear";

            this.lblIssueBooking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIssueBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblIssueBooking.Location = new System.Drawing.Point(16, 42);
            this.lblIssueBooking.Name = "lblIssueBooking";
            this.lblIssueBooking.Size = new System.Drawing.Size(90, 20);
            this.lblIssueBooking.Text = "Booking";

            this.cmbIssueBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            this.cmbIssueBooking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIssueBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbIssueBooking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbIssueBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.cmbIssueBooking.Location = new System.Drawing.Point(110, 39);
            this.cmbIssueBooking.Name = "cmbIssueBooking";
            this.cmbIssueBooking.Size = new System.Drawing.Size(300, 23);
            this.cmbIssueBooking.SelectedIndexChanged += new System.EventHandler(this.cmbIssueBooking_SelectedIndexChanged);

            this.lblIssuePlayer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIssuePlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblIssuePlayer.Location = new System.Drawing.Point(430, 42);
            this.lblIssuePlayer.Name = "lblIssuePlayer";
            this.lblIssuePlayer.Size = new System.Drawing.Size(60, 20);
            this.lblIssuePlayer.Text = "Player";

            this.cmbIssuePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            this.cmbIssuePlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIssuePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbIssuePlayer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbIssuePlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.cmbIssuePlayer.Location = new System.Drawing.Point(495, 39);
            this.cmbIssuePlayer.Name = "cmbIssuePlayer";
            this.cmbIssuePlayer.Size = new System.Drawing.Size(220, 23);

            this.lblIssueReady.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIssueReady.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblIssueReady.Location = new System.Drawing.Point(16, 75);
            this.lblIssueReady.Name = "lblIssueReady";
            this.lblIssueReady.Size = new System.Drawing.Size(320, 20);
            this.lblIssueReady.Text = "Ready to hand out";

            this.chkListIssueReady.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            this.chkListIssueReady.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chkListIssueReady.CheckOnClick = true;
            this.chkListIssueReady.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkListIssueReady.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.chkListIssueReady.Location = new System.Drawing.Point(16, 100);
            this.chkListIssueReady.Name = "chkListIssueReady";
            this.chkListIssueReady.Size = new System.Drawing.Size(340, 180);

            this.btnIssueHandOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnIssueHandOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.btnIssueHandOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueHandOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIssueHandOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.btnIssueHandOut.Location = new System.Drawing.Point(16, 290);
            this.btnIssueHandOut.Name = "btnIssueHandOut";
            this.btnIssueHandOut.Size = new System.Drawing.Size(130, 30);
            this.btnIssueHandOut.Text = "➡️ Hand out";
            this.btnIssueHandOut.UseVisualStyleBackColor = false;
            this.btnIssueHandOut.Click += new System.EventHandler(this.btnIssueHandOut_Click);

            this.lblIssueActive.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIssueActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblIssueActive.Location = new System.Drawing.Point(375, 75);
            this.lblIssueActive.Name = "lblIssueActive";
            this.lblIssueActive.Size = new System.Drawing.Size(340, 20);
            this.lblIssueActive.Text = "Currently Issued Gear";

            this.dgvIssueActive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIssueActive.Location = new System.Drawing.Point(375, 100);
            this.dgvIssueActive.Name = "dgvIssueActive";
            this.dgvIssueActive.Size = new System.Drawing.Size(450, 180);

            this.lblReturnCondition.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblReturnCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblReturnCondition.Location = new System.Drawing.Point(375, 294);
            this.lblReturnCondition.Name = "lblReturnCondition";
            this.lblReturnCondition.Size = new System.Drawing.Size(110, 20);
            this.lblReturnCondition.Text = "Return Condition";

            this.cmbReturnCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            this.cmbReturnCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReturnCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbReturnCondition.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbReturnCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.cmbReturnCondition.Items.AddRange(new object[] { "Ready", "Needs cleaning", "Under repair" });
            this.cmbReturnCondition.Location = new System.Drawing.Point(490, 291);
            this.cmbReturnCondition.Name = "cmbReturnCondition";
            this.cmbReturnCondition.Size = new System.Drawing.Size(140, 23);

            this.btnIssueTakeBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnIssueTakeBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.btnIssueTakeBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueTakeBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIssueTakeBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.btnIssueTakeBack.Location = new System.Drawing.Point(640, 288);
            this.btnIssueTakeBack.Name = "btnIssueTakeBack";
            this.btnIssueTakeBack.Size = new System.Drawing.Size(130, 30);
            this.btnIssueTakeBack.Text = "⬅️ Take back";
            this.btnIssueTakeBack.UseVisualStyleBackColor = false;
            this.btnIssueTakeBack.Click += new System.EventHandler(this.btnIssueTakeBack_Click);

            // ------------------------------------------
            // TAB 7: Payment
            // ------------------------------------------
            this.tabPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.tabPayment.Controls.Add(this.dgvPayments);
            this.tabPayment.Controls.Add(this.lblPayHistory);
            this.tabPayment.Controls.Add(this.btnPayPrint);
            this.tabPayment.Controls.Add(this.btnPayTake);
            this.tabPayment.Controls.Add(this.numPayAmount);
            this.tabPayment.Controls.Add(this.lblPayAmount);
            this.tabPayment.Controls.Add(this.lblPaySummary);
            this.tabPayment.Controls.Add(this.cmbPayBooking);
            this.tabPayment.Controls.Add(this.lblPayBooking);
            this.tabPayment.Controls.Add(this.lblPaymentTitle);
            this.tabPayment.Location = new System.Drawing.Point(4, 5);
            this.tabPayment.Name = "tabPayment";
            this.tabPayment.Padding = new System.Windows.Forms.Padding(16);
            this.tabPayment.Size = new System.Drawing.Size(842, 567);
            this.tabPayment.Text = "Payment";

            this.lblPaymentTitle.AutoSize = true;
            this.lblPaymentTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPaymentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.lblPaymentTitle.Location = new System.Drawing.Point(16, 12);
            this.lblPaymentTitle.Name = "lblPaymentTitle";
            this.lblPaymentTitle.Text = "Payment";

            this.lblPayBooking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPayBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblPayBooking.Location = new System.Drawing.Point(16, 42);
            this.lblPayBooking.Name = "lblPayBooking";
            this.lblPayBooking.Size = new System.Drawing.Size(100, 20);
            this.lblPayBooking.Text = "Booking";

            this.cmbPayBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            this.cmbPayBooking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPayBooking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbPayBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.cmbPayBooking.Location = new System.Drawing.Point(120, 39);
            this.cmbPayBooking.Name = "cmbPayBooking";
            this.cmbPayBooking.Size = new System.Drawing.Size(320, 23);
            this.cmbPayBooking.SelectedIndexChanged += new System.EventHandler(this.cmbPayBooking_SelectedIndexChanged);

            this.lblPaySummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.lblPaySummary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPaySummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.lblPaySummary.Location = new System.Drawing.Point(16, 75);
            this.lblPaySummary.Name = "lblPaySummary";
            this.lblPaySummary.Padding = new System.Windows.Forms.Padding(8);
            this.lblPaySummary.Size = new System.Drawing.Size(424, 60);
            this.lblPaySummary.Text = "Select a booking to view balance details...";

            this.lblPayAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPayAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblPayAmount.Location = new System.Drawing.Point(16, 150);
            this.lblPayAmount.Name = "lblPayAmount";
            this.lblPayAmount.Size = new System.Drawing.Size(100, 20);
            this.lblPayAmount.Text = "Amount (R)";

            this.numPayAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            this.numPayAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numPayAmount.DecimalPlaces = 2;
            this.numPayAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numPayAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.numPayAmount.Location = new System.Drawing.Point(120, 148);
            this.numPayAmount.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            this.numPayAmount.Name = "numPayAmount";
            this.numPayAmount.Size = new System.Drawing.Size(160, 23);

            this.btnPayTake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnPayTake.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.btnPayTake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayTake.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPayTake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.btnPayTake.Location = new System.Drawing.Point(16, 185);
            this.btnPayTake.Name = "btnPayTake";
            this.btnPayTake.Size = new System.Drawing.Size(140, 30);
            this.btnPayTake.Text = "💵 Record payment";
            this.btnPayTake.UseVisualStyleBackColor = false;
            this.btnPayTake.Click += new System.EventHandler(this.btnPayTake_Click);

            this.btnPayPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnPayPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.btnPayPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPayPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.btnPayPrint.Location = new System.Drawing.Point(165, 185);
            this.btnPayPrint.Name = "btnPayPrint";
            this.btnPayPrint.Size = new System.Drawing.Size(130, 30);
            this.btnPayPrint.Text = "🖨️ Print receipt";
            this.btnPayPrint.UseVisualStyleBackColor = false;
            this.btnPayPrint.Click += new System.EventHandler(this.btnPayPrint_Click);

            this.lblPayHistory.AutoSize = true;
            this.lblPayHistory.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPayHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.lblPayHistory.Location = new System.Drawing.Point(16, 225);
            this.lblPayHistory.Name = "lblPayHistory";
            this.lblPayHistory.Text = "Transaction Log for Selected Booking";

            this.dgvPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayments.Location = new System.Drawing.Point(16, 250);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.Size = new System.Drawing.Size(810, 300);

            // ------------------------------------------
            // TAB 8: Arrivals
            // ------------------------------------------
            this.tabArrivals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.tabArrivals.Controls.Add(this.btnArrConfirm);
            this.tabArrivals.Controls.Add(this.btnArrCheckAll);
            this.tabArrivals.Controls.Add(this.dgvArrList);
            this.tabArrivals.Controls.Add(this.lblArrStatus);
            this.tabArrivals.Controls.Add(this.cmbArrBooking);
            this.tabArrivals.Controls.Add(this.lblArrBooking);
            this.tabArrivals.Controls.Add(this.lblArrTitle);
            this.tabArrivals.Location = new System.Drawing.Point(4, 5);
            this.tabArrivals.Name = "tabArrivals";
            this.tabArrivals.Padding = new System.Windows.Forms.Padding(16);
            this.tabArrivals.Size = new System.Drawing.Size(842, 567);
            this.tabArrivals.Text = "Arrivals";

            this.lblArrTitle.AutoSize = true;
            this.lblArrTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblArrTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.lblArrTitle.Location = new System.Drawing.Point(16, 12);
            this.lblArrTitle.Name = "lblArrTitle";
            this.lblArrTitle.Text = "Arrivals";

            this.lblArrBooking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblArrBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblArrBooking.Location = new System.Drawing.Point(16, 42);
            this.lblArrBooking.Name = "lblArrBooking";
            this.lblArrBooking.Size = new System.Drawing.Size(90, 20);
            this.lblArrBooking.Text = "Booking";

            this.cmbArrBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            this.cmbArrBooking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArrBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbArrBooking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbArrBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.cmbArrBooking.Location = new System.Drawing.Point(110, 39);
            this.cmbArrBooking.Name = "cmbArrBooking";
            this.cmbArrBooking.Size = new System.Drawing.Size(320, 23);
            this.cmbArrBooking.SelectedIndexChanged += new System.EventHandler(this.cmbArrBooking_SelectedIndexChanged);

            this.lblArrStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblArrStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblArrStatus.Location = new System.Drawing.Point(16, 75);
            this.lblArrStatus.Name = "lblArrStatus";
            this.lblArrStatus.Size = new System.Drawing.Size(600, 20);
            this.lblArrStatus.Text = "Check in participants as they arrive at the safety briefing area.";

            this.dgvArrList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArrList.Location = new System.Drawing.Point(16, 105);
            this.dgvArrList.Name = "dgvArrList";
            this.dgvArrList.Size = new System.Drawing.Size(810, 400);

            this.btnArrCheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnArrCheckAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnArrCheckAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.btnArrCheckAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrCheckAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnArrCheckAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.btnArrCheckAll.Location = new System.Drawing.Point(16, 520);
            this.btnArrCheckAll.Name = "btnArrCheckAll";
            this.btnArrCheckAll.Size = new System.Drawing.Size(160, 30);
            this.btnArrCheckAll.Text = "✔️ Check All Present";
            this.btnArrCheckAll.UseVisualStyleBackColor = false;
            this.btnArrCheckAll.Click += new System.EventHandler(this.btnArrCheckAll_Click);

            this.btnArrConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnArrConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnArrConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.btnArrConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnArrConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.btnArrConfirm.Location = new System.Drawing.Point(186, 520);
            this.btnArrConfirm.Name = "btnArrConfirm";
            this.btnArrConfirm.Size = new System.Drawing.Size(160, 30);
            this.btnArrConfirm.Text = "💾 Confirm Attendance";
            this.btnArrConfirm.UseVisualStyleBackColor = false;
            this.btnArrConfirm.Click += new System.EventHandler(this.btnArrConfirm_Click);

            // ------------------------------------------
            // TAB 9: Reports
            // ------------------------------------------
            this.tabReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.tabReports.Controls.Add(this.dgvRepTransactions);
            this.tabReports.Controls.Add(this.lblRepTotal);
            this.tabReports.Controls.Add(this.btnRepPrint);
            this.tabReports.Controls.Add(this.btnRepShowIncome);
            this.tabReports.Controls.Add(this.dtpRepTo);
            this.tabReports.Controls.Add(this.lblRepTo);
            this.tabReports.Controls.Add(this.dtpRepFrom);
            this.tabReports.Controls.Add(this.lblRepFrom);
            this.tabReports.Controls.Add(this.lblRepTitle);
            this.tabReports.Location = new System.Drawing.Point(4, 5);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(16);
            this.tabReports.Size = new System.Drawing.Size(842, 567);
            this.tabReports.Text = "Reports";

            this.lblRepTitle.AutoSize = true;
            this.lblRepTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRepTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.lblRepTitle.Location = new System.Drawing.Point(16, 12);
            this.lblRepTitle.Name = "lblRepTitle";
            this.lblRepTitle.Text = "Reports";

            this.lblRepFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRepFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblRepFrom.Location = new System.Drawing.Point(16, 42);
            this.lblRepFrom.Name = "lblRepFrom";
            this.lblRepFrom.Size = new System.Drawing.Size(50, 20);
            this.lblRepFrom.Text = "From";

            this.dtpRepFrom.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.dtpRepFrom.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            this.dtpRepFrom.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(138)))), ((int)(((byte)(221)))));
            this.dtpRepFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpRepFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRepFrom.Location = new System.Drawing.Point(70, 39);
            this.dtpRepFrom.Name = "dtpRepFrom";
            this.dtpRepFrom.Size = new System.Drawing.Size(140, 23);

            this.lblRepTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRepTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(178)))), ((int)(((byte)(169)))));
            this.lblRepTo.Location = new System.Drawing.Point(230, 42);
            this.lblRepTo.Name = "lblRepTo";
            this.lblRepTo.Size = new System.Drawing.Size(30, 20);
            this.lblRepTo.Text = "To";

            this.dtpRepTo.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.dtpRepTo.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            this.dtpRepTo.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(138)))), ((int)(((byte)(221)))));
            this.dtpRepTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpRepTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRepTo.Location = new System.Drawing.Point(270, 39);
            this.dtpRepTo.Name = "dtpRepTo";
            this.dtpRepTo.Size = new System.Drawing.Size(140, 23);

            this.btnRepShowIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnRepShowIncome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.btnRepShowIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepShowIncome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRepShowIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.btnRepShowIncome.Location = new System.Drawing.Point(16, 75);
            this.btnRepShowIncome.Name = "btnRepShowIncome";
            this.btnRepShowIncome.Size = new System.Drawing.Size(130, 28);
            this.btnRepShowIncome.Text = "📊 Show income";
            this.btnRepShowIncome.UseVisualStyleBackColor = false;
            this.btnRepShowIncome.Click += new System.EventHandler(this.btnRepShowIncome_Click);

            this.btnRepPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnRepPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.btnRepPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRepPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.btnRepPrint.Location = new System.Drawing.Point(155, 75);
            this.btnRepPrint.Name = "btnRepPrint";
            this.btnRepPrint.Size = new System.Drawing.Size(90, 28);
            this.btnRepPrint.Text = "🖨️ Print";
            this.btnRepPrint.UseVisualStyleBackColor = false;
            this.btnRepPrint.Click += new System.EventHandler(this.btnRepPrint_Click);

            this.lblRepTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRepTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRepTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            this.lblRepTotal.Location = new System.Drawing.Point(580, 78);
            this.lblRepTotal.Name = "lblRepTotal";
            this.lblRepTotal.Size = new System.Drawing.Size(246, 25);
            this.lblRepTotal.Text = "Total: R 0.00";
            this.lblRepTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.dgvRepTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRepTransactions.Location = new System.Drawing.Point(16, 115);
            this.dgvRepTransactions.Name = "dgvRepTransactions";
            this.dgvRepTransactions.Size = new System.Drawing.Size(810, 435);

            // ==========================================
            // Main Form Definition
            // ==========================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1000, 658);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pnlTitleBar);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(920, 620);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Close Contact Paintball Management System";

            this.tabControlMain.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.pnlLoginCenter.ResumeLayout(false);
            this.pnlLoginCenter.PerformLayout();
            this.tabDashboard.ResumeLayout(false);
            this.tabDashboard.PerformLayout();
            this.pnlCardBookings.ResumeLayout(false);
            this.pnlCardGear.ResumeLayout(false);
            this.pnlCardInUse.ResumeLayout(false);
            this.tabGear.ResumeLayout(false);
            this.tabGear.PerformLayout();
            this.tabPlayers.ResumeLayout(false);
            this.tabPlayers.PerformLayout();
            this.tabBookings.ResumeLayout(false);
            this.tabBookings.PerformLayout();
            this.tabIssueReturn.ResumeLayout(false);
            this.tabIssueReturn.PerformLayout();
            this.tabPayment.ResumeLayout(false);
            this.tabPayment.PerformLayout();
            this.tabArrivals.ResumeLayout(false);
            this.tabArrivals.PerformLayout();
            this.tabReports.ResumeLayout(false);
            this.tabReports.PerformLayout();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ConfigureNavButton(System.Windows.Forms.Button btn, string text, int tabIndex, System.Windows.Forms.TabPage targetTab)
        {
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            btn.Dock = System.Windows.Forms.DockStyle.Top;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            btn.Height = 36;
            btn.Name = "btnNav_" + targetTab.Name;
            btn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            btn.TabIndex = tabIndex;
            btn.Text = text;
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.UseVisualStyleBackColor = false;
            btn.Click += (s, e) => NavigateToTab(targetTab);
        }

        private void ConfigureAllDataGrids()
        {
            // 1. Today Schedule Columns
            this.dgvTodaySchedule.Columns.Add("CustomerName", "Customer");
            this.dgvTodaySchedule.Columns.Add("EventType", "Occasion");
            this.dgvTodaySchedule.Columns.Add("FieldAssignment", "Field");
            this.dgvTodaySchedule.Columns.Add("NumberOfPlayers", "Players");
            ApplyGridDesignStyle(this.dgvTodaySchedule);

            // 2. Gear Columns
            this.dgvGear.Columns.Add("ItemID", "ID");
            this.dgvGear.Columns["ItemID"]!.Visible = false;
            this.dgvGear.Columns.Add("SerialNumber", "Serial no.");
            this.dgvGear.Columns.Add("ItemType", "Type");
            this.dgvGear.Columns.Add("Size", "Size");
            this.dgvGear.Columns.Add("Status", "Condition");
            ApplyGridDesignStyle(this.dgvGear);

            // 3. Players Columns
            this.dgvPlayers.Columns.Add("TouristID", "ID");
            this.dgvPlayers.Columns["TouristID"]!.Visible = false;
            this.dgvPlayers.Columns.Add("FirstName", "First name");
            this.dgvPlayers.Columns.Add("Surname", "Surname");
            this.dgvPlayers.Columns.Add("Waiver", "Waiver");
            ApplyGridDesignStyle(this.dgvPlayers);

            // 4. Bookings Columns
            this.dgvBookings.Columns.Add("EventID", "ID");
            this.dgvBookings.Columns["EventID"]!.Visible = false;
            this.dgvBookings.Columns.Add("CustomerName", "Booked by");
            this.dgvBookings.Columns.Add("EventDate", "Date");
            this.dgvBookings.Columns.Add("EventType", "Occasion");
            this.dgvBookings.Columns.Add("FieldAssignment", "Field");
            this.dgvBookings.Columns.Add("NumberOfPlayers", "Number of players");
            ApplyGridDesignStyle(this.dgvBookings);

            // 5. Issue Active Columns
            this.dgvIssueActive.Columns.Add("IssuanceID", "ID");
            this.dgvIssueActive.Columns["IssuanceID"]!.Visible = false;
            this.dgvIssueActive.Columns.Add("CustomerName", "Player");
            this.dgvIssueActive.Columns.Add("GearDescription", "Gear Item");
            this.dgvIssueActive.Columns.Add("IssueDateTime", "Checked Out At");
            ApplyGridDesignStyle(this.dgvIssueActive);

            // 6. Payments Columns
            this.dgvPayments.Columns.Add("PaymentID", "Receipt #");
            this.dgvPayments.Columns.Add("PaymentDate", "Date");
            this.dgvPayments.Columns.Add("Amount", "Amount (R)");
            ApplyGridDesignStyle(this.dgvPayments);

            // 7. Arrivals Columns
            var colName = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "PlayerName", HeaderText = "Name", ReadOnly = true };
            var colWaiver = new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Waiver", HeaderText = "Waiver", ReadOnly = true };
            var colHere = new System.Windows.Forms.DataGridViewCheckBoxColumn { Name = "Here", HeaderText = "Here", ReadOnly = false };
            this.dgvArrList.Columns.AddRange(colName, colWaiver, colHere);
            this.dgvArrList.ReadOnly = false;
            ApplyGridDesignStyle(this.dgvArrList);

            // 8. Reports Columns
            this.dgvRepTransactions.Columns.Add("PaymentDate", "Date");
            this.dgvRepTransactions.Columns.Add("ReceiptNo", "Receipt #");
            this.dgvRepTransactions.Columns.Add("BookedBy", "Customer");
            this.dgvRepTransactions.Columns.Add("EventType", "Occasion");
            this.dgvRepTransactions.Columns.Add("Amount", "Amount (R)");
            ApplyGridDesignStyle(this.dgvRepTransactions);
        }

        private void ApplyGridDesignStyle(System.Windows.Forms.DataGridView dgv)
        {
            dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgv.ColumnHeadersHeight = 28;

            dgv.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(56)))));
            dgv.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(232)))));
            dgv.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(68)))), ((int)(((byte)(124)))));
            dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(212)))), ((int)(((byte)(244)))));
            dgv.RowTemplate.Height = 26;
        }
    }
}
