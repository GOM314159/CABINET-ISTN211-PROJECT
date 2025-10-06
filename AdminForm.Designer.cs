namespace BloodBankSystem
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnHomepage = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblAdminDash = new System.Windows.Forms.Label();
            this.tpgAppointments = new System.Windows.Forms.TabPage();
            this.appointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.pnlAppFilters = new System.Windows.Forms.Panel();
            this.btnFilterPassed = new System.Windows.Forms.Button();
            this.btnFilterUpcoming = new System.Windows.Forms.Button();
            this.btnCapSortDesc = new System.Windows.Forms.Button();
            this.btnCapSortAsc = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.pnlRemoveAppFilters = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.pnlAppNav = new System.Windows.Forms.Panel();
            this.btnAppLast = new System.Windows.Forms.Button();
            this.btnAppFirst = new System.Windows.Forms.Button();
            this.btnAppPrev = new System.Windows.Forms.Button();
            this.btnAppNext = new System.Windows.Forms.Button();
            this.pnlAppEdit = new System.Windows.Forms.Panel();
            this.btnStartAppInsert = new System.Windows.Forms.Button();
            this.mtxtTime = new System.Windows.Forms.MaskedTextBox();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.lblVenue = new System.Windows.Forms.Label();
            this.btnAppInsert = new System.Windows.Forms.Button();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblAppointmentTime = new System.Windows.Forms.Label();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.btnAppDelete = new System.Windows.Forms.Button();
            this.btnUpdateApp = new System.Windows.Forms.Button();
            this.spnCapacity = new System.Windows.Forms.NumericUpDown();
            this.dtpAppDate = new System.Windows.Forms.DateTimePicker();
            this.txtAppID = new System.Windows.Forms.TextBox();
            this.btnCancelAppInsert = new System.Windows.Forms.Button();
            this.tpgBlood = new System.Windows.Forms.TabPage();
            this.pnlRemoveBloodFilters = new System.Windows.Forms.Panel();
            this.btnRemoveBloodFilters = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnEarlyExpiry = new System.Windows.Forms.Button();
            this.btnLaterExpiry = new System.Windows.Forms.Button();
            this.dtpExpiryFilter = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.pnlBloodNav = new System.Windows.Forms.Panel();
            this.btnBloodLast = new System.Windows.Forms.Button();
            this.btnBloodFirst = new System.Windows.Forms.Button();
            this.btnBloodPrev = new System.Windows.Forms.Button();
            this.btnBllodNext = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBloodExpiryDate = new System.Windows.Forms.Label();
            this.lblBloodUserID = new System.Windows.Forms.Label();
            this.lblBloodAppID = new System.Windows.Forms.Label();
            this.lblTypeBlood = new System.Windows.Forms.Label();
            this.lblUnitID = new System.Windows.Forms.Label();
            this.btnBloodDelete = new System.Windows.Forms.Button();
            this.btnBloodApply = new System.Windows.Forms.Button();
            this.dtpExpiry = new System.Windows.Forms.DateTimePicker();
            this.cmbBloodInvType = new System.Windows.Forms.ComboBox();
            this.txtBloodAppID = new System.Windows.Forms.TextBox();
            this.txtBloodUserID = new System.Windows.Forms.TextBox();
            this.txtUnitID = new System.Windows.Forms.TextBox();
            this.dgvBlood = new System.Windows.Forms.DataGridView();
            this.tpgUsers = new System.Windows.Forms.TabPage();
            this.pnlRemoveUserFilters = new System.Windows.Forms.Panel();
            this.btnRemoveFilter = new System.Windows.Forms.Button();
            this.pnlUserNav = new System.Windows.Forms.Panel();
            this.btnUserLast = new System.Windows.Forms.Button();
            this.btnUserFirst = new System.Windows.Forms.Button();
            this.btnUserPrev = new System.Windows.Forms.Button();
            this.btnUserNext = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.no1DonorFilterBtn = new System.Windows.Forms.Button();
            this.donorRankingFilterBtn = new System.Windows.Forms.Button();
            this.cmbUserFilter = new System.Windows.Forms.ComboBox();
            this.btnUserFilter = new System.Windows.Forms.Button();
            this.cmbBloodFilter = new System.Windows.Forms.ComboBox();
            this.btnBloodFilter = new System.Windows.Forms.Button();
            this.btnSurnameAlphabetical = new System.Windows.Forms.Button();
            this.btnNameAlphabetical = new System.Windows.Forms.Button();
            this.btnFilterInactive = new System.Windows.Forms.Button();
            this.btnFilterActive = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.pnlUserEdit = new System.Windows.Forms.Panel();
            this.btnStartInsert = new System.Windows.Forms.Button();
            this.btnInsertUser = new System.Windows.Forms.Button();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblIDNum = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.cmbBlood = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.btnCancelInsert = new System.Windows.Forms.Button();
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpgSchedule = new System.Windows.Forms.TabPage();
            this.dgvTotalSchedule = new System.Windows.Forms.DataGridView();
            this.dgvAverage = new System.Windows.Forms.DataGridView();
            this.pnlScheduleNav = new System.Windows.Forms.Panel();
            this.btnScheduleFirst = new System.Windows.Forms.Button();
            this.btnSchedulePrev = new System.Windows.Forms.Button();
            this.btnScheduleNext = new System.Windows.Forms.Button();
            this.btnScheduleLast = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnCountSchedules = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSchedule = new System.Windows.Forms.Panel();
            this.btnDeleteSchedule = new System.Windows.Forms.Button();
            this.btnAppChanges = new System.Windows.Forms.Button();
            this.chkAttended = new System.Windows.Forms.CheckBox();
            this.txtSearchByUser = new System.Windows.Forms.TextBox();
            this.pnlShortStats = new System.Windows.Forms.Panel();
            this.lblUnattended = new System.Windows.Forms.Label();
            this.lblAttended = new System.Windows.Forms.Label();
            this.lblSchedules = new System.Windows.Forms.Label();
            this.lblShortStats = new System.Windows.Forms.Label();
            this.btnScheduleUserSearch = new System.Windows.Forms.Button();
            this.redDisplay = new System.Windows.Forms.RichTextBox();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.tpgStats = new System.Windows.Forms.TabPage();
            this.chtUserSchedule = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtBloodType = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.insertBloodBtn = new System.Windows.Forms.Button();
            this.insertBloodGrp = new System.Windows.Forms.GroupBox();
            this.insUnitIDTBox = new System.Windows.Forms.TextBox();
            this.unitIDLbl = new System.Windows.Forms.Label();
            this.userIDLbl = new System.Windows.Forms.Label();
            this.insUserIDTBox = new System.Windows.Forms.TextBox();
            this.AppIDLbl = new System.Windows.Forms.Label();
            this.insAppIDTBox = new System.Windows.Forms.TextBox();
            this.expDateLbl = new System.Windows.Forms.Label();
            this.insDTPicker = new System.Windows.Forms.DateTimePicker();
            this.bldTypLbl = new System.Windows.Forms.Label();
            this.insertBloodTypeTBox = new System.Windows.Forms.TextBox();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ist2jwDataSet = new BloodBankSystem.ist2jwDataSet();
            this.tblBloodInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schedulesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTotalScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAverageScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblUsersTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.tblUsersTableAdapter();
            this.tblBloodInventoryTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.TblBloodInventoryTableAdapter();
            this.appointmentTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.AppointmentTableAdapter();
            this.scheduleTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.ScheduleTableAdapter();
            this.tableAdapterManager = new BloodBankSystem.ist2jwDataSetTableAdapters.TableAdapterManager();
            this.tblTotalScheduleTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.tblTotalScheduleTableAdapter();
            this.tblAverageScheduleTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.tblAverageScheduleTableAdapter();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveAccountDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlTopBar.SuspendLayout();
            this.tpgAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
            this.pnlAppFilters.SuspendLayout();
            this.pnlRemoveAppFilters.SuspendLayout();
            this.pnlAppNav.SuspendLayout();
            this.pnlAppEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnCapacity)).BeginInit();
            this.tpgBlood.SuspendLayout();
            this.pnlRemoveBloodFilters.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnlBloodNav.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlood)).BeginInit();
            this.tpgUsers.SuspendLayout();
            this.pnlRemoveUserFilters.SuspendLayout();
            this.pnlUserNav.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.pnlUserEdit.SuspendLayout();
            this.tcAdmin.SuspendLayout();
            this.tpgSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAverage)).BeginInit();
            this.pnlScheduleNav.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSchedule.SuspendLayout();
            this.pnlShortStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.tpgStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtUserSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtBloodType)).BeginInit();
            this.insertBloodGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2jwDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBloodInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTotalScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAverageScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlTopBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTopBar.Controls.Add(this.btnHomepage);
            this.pnlTopBar.Controls.Add(this.btnLogout);
            this.pnlTopBar.Controls.Add(this.lblAdminDash);
            this.pnlTopBar.ForeColor = System.Drawing.Color.White;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 5);
            this.pnlTopBar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1401, 48);
            this.pnlTopBar.TabIndex = 0;
            this.pnlTopBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTopBar_Paint);
            // 
            // btnHomepage
            // 
            this.btnHomepage.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackGreen;
            this.btnHomepage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHomepage.FlatAppearance.BorderSize = 0;
            this.btnHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnHomepage.ForeColor = System.Drawing.Color.Black;
            this.btnHomepage.Location = new System.Drawing.Point(1185, 2);
            this.btnHomepage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHomepage.Name = "btnHomepage";
            this.btnHomepage.Size = new System.Drawing.Size(208, 36);
            this.btnHomepage.TabIndex = 2;
            this.btnHomepage.Text = "My Homepage";
            this.btnHomepage.UseVisualStyleBackColor = true;
            this.btnHomepage.Click += new System.EventHandler(this.btnHomepage_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackRed;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(4, 5);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(135, 38);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblAdminDash
            // 
            this.lblAdminDash.AutoSize = true;
            this.lblAdminDash.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminDash.Location = new System.Drawing.Point(595, 7);
            this.lblAdminDash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminDash.Name = "lblAdminDash";
            this.lblAdminDash.Size = new System.Drawing.Size(321, 29);
            this.lblAdminDash.TabIndex = 0;
            this.lblAdminDash.Text = "Administrator Dashboard";
            // 
            // tpgAppointments
            // 
            this.tpgAppointments.AutoScroll = true;
            this.tpgAppointments.BackgroundImage = global::BloodBankSystem.Properties.Resources.MainBackground;
            this.tpgAppointments.Controls.Add(this.appointmentDataGridView);
            this.tpgAppointments.Controls.Add(this.pnlAppFilters);
            this.tpgAppointments.Controls.Add(this.pnlRemoveAppFilters);
            this.tpgAppointments.Controls.Add(this.pnlAppNav);
            this.tpgAppointments.Controls.Add(this.pnlAppEdit);
            this.tpgAppointments.Location = new System.Drawing.Point(4, 25);
            this.tpgAppointments.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpgAppointments.Name = "tpgAppointments";
            this.tpgAppointments.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgAppointments.Size = new System.Drawing.Size(1381, 650);
            this.tpgAppointments.TabIndex = 2;
            this.tpgAppointments.Text = "Appointments";
            this.tpgAppointments.UseVisualStyleBackColor = true;
            // 
            // appointmentDataGridView
            // 
            this.appointmentDataGridView.AutoGenerateColumns = false;
            this.appointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.appointmentDataGridView.DataSource = this.appointmentBindingSource;
            this.appointmentDataGridView.Location = new System.Drawing.Point(12, 12);
            this.appointmentDataGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.appointmentDataGridView.Name = "appointmentDataGridView";
            this.appointmentDataGridView.RowHeadersWidth = 51;
            this.appointmentDataGridView.Size = new System.Drawing.Size(993, 335);
            this.appointmentDataGridView.TabIndex = 9;
            // 
            // pnlAppFilters
            // 
            this.pnlAppFilters.AutoScroll = true;
            this.pnlAppFilters.BackColor = System.Drawing.Color.Transparent;
            this.pnlAppFilters.Controls.Add(this.btnFilterPassed);
            this.pnlAppFilters.Controls.Add(this.btnFilterUpcoming);
            this.pnlAppFilters.Controls.Add(this.btnCapSortDesc);
            this.pnlAppFilters.Controls.Add(this.btnCapSortAsc);
            this.pnlAppFilters.Controls.Add(this.label21);
            this.pnlAppFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.pnlAppFilters.ForeColor = System.Drawing.Color.White;
            this.pnlAppFilters.Location = new System.Drawing.Point(1035, 9);
            this.pnlAppFilters.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlAppFilters.Name = "pnlAppFilters";
            this.pnlAppFilters.Size = new System.Drawing.Size(325, 518);
            this.pnlAppFilters.TabIndex = 9;
            // 
            // btnFilterPassed
            // 
            this.btnFilterPassed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFilterPassed.BackgroundImage")));
            this.btnFilterPassed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilterPassed.FlatAppearance.BorderSize = 0;
            this.btnFilterPassed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterPassed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnFilterPassed.ForeColor = System.Drawing.Color.Black;
            this.btnFilterPassed.Location = new System.Drawing.Point(48, 405);
            this.btnFilterPassed.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnFilterPassed.Name = "btnFilterPassed";
            this.btnFilterPassed.Size = new System.Drawing.Size(228, 75);
            this.btnFilterPassed.TabIndex = 7;
            this.btnFilterPassed.Text = "Filter by passed";
            this.btnFilterPassed.UseVisualStyleBackColor = true;
            this.btnFilterPassed.Click += new System.EventHandler(this.btnFilterPassed_Click);
            // 
            // btnFilterUpcoming
            // 
            this.btnFilterUpcoming.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFilterUpcoming.BackgroundImage")));
            this.btnFilterUpcoming.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilterUpcoming.FlatAppearance.BorderSize = 0;
            this.btnFilterUpcoming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterUpcoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnFilterUpcoming.ForeColor = System.Drawing.Color.Black;
            this.btnFilterUpcoming.Location = new System.Drawing.Point(48, 288);
            this.btnFilterUpcoming.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnFilterUpcoming.Name = "btnFilterUpcoming";
            this.btnFilterUpcoming.Size = new System.Drawing.Size(228, 79);
            this.btnFilterUpcoming.TabIndex = 6;
            this.btnFilterUpcoming.Text = "Filter by upcoming";
            this.btnFilterUpcoming.UseVisualStyleBackColor = true;
            this.btnFilterUpcoming.Click += new System.EventHandler(this.btnFilterUpcoming_Click);
            // 
            // btnCapSortDesc
            // 
            this.btnCapSortDesc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCapSortDesc.BackgroundImage")));
            this.btnCapSortDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCapSortDesc.FlatAppearance.BorderSize = 0;
            this.btnCapSortDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapSortDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnCapSortDesc.ForeColor = System.Drawing.Color.Black;
            this.btnCapSortDesc.Location = new System.Drawing.Point(48, 166);
            this.btnCapSortDesc.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCapSortDesc.Name = "btnCapSortDesc";
            this.btnCapSortDesc.Size = new System.Drawing.Size(228, 78);
            this.btnCapSortDesc.TabIndex = 5;
            this.btnCapSortDesc.Text = "Sort by capacity(desc)";
            this.btnCapSortDesc.UseVisualStyleBackColor = true;
            this.btnCapSortDesc.Click += new System.EventHandler(this.btnCapSortDesc_Click);
            // 
            // btnCapSortAsc
            // 
            this.btnCapSortAsc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCapSortAsc.BackgroundImage")));
            this.btnCapSortAsc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCapSortAsc.FlatAppearance.BorderSize = 0;
            this.btnCapSortAsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapSortAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnCapSortAsc.ForeColor = System.Drawing.Color.Black;
            this.btnCapSortAsc.Location = new System.Drawing.Point(48, 52);
            this.btnCapSortAsc.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCapSortAsc.Name = "btnCapSortAsc";
            this.btnCapSortAsc.Size = new System.Drawing.Size(228, 78);
            this.btnCapSortAsc.TabIndex = 4;
            this.btnCapSortAsc.Text = "Sort by capacity(asc)";
            this.btnCapSortAsc.UseVisualStyleBackColor = true;
            this.btnCapSortAsc.Click += new System.EventHandler(this.btnCapSortAsc_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 11);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(148, 25);
            this.label21.TabIndex = 0;
            this.label21.Text = "Filters/sorting:";
            // 
            // pnlRemoveAppFilters
            // 
            this.pnlRemoveAppFilters.BackColor = System.Drawing.Color.Transparent;
            this.pnlRemoveAppFilters.Controls.Add(this.button16);
            this.pnlRemoveAppFilters.Location = new System.Drawing.Point(1035, 571);
            this.pnlRemoveAppFilters.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlRemoveAppFilters.Name = "pnlRemoveAppFilters";
            this.pnlRemoveAppFilters.Size = new System.Drawing.Size(325, 71);
            this.pnlRemoveAppFilters.TabIndex = 8;
            // 
            // button16
            // 
            this.button16.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackRed;
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(60, 5);
            this.button16.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(216, 54);
            this.button16.TabIndex = 1;
            this.button16.Text = "Remove Filters";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // pnlAppNav
            // 
            this.pnlAppNav.BackColor = System.Drawing.Color.Transparent;
            this.pnlAppNav.Controls.Add(this.btnAppLast);
            this.pnlAppNav.Controls.Add(this.btnAppFirst);
            this.pnlAppNav.Controls.Add(this.btnAppPrev);
            this.pnlAppNav.Controls.Add(this.btnAppNext);
            this.pnlAppNav.Location = new System.Drawing.Point(17, 357);
            this.pnlAppNav.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlAppNav.Name = "pnlAppNav";
            this.pnlAppNav.Size = new System.Drawing.Size(988, 44);
            this.pnlAppNav.TabIndex = 7;
            // 
            // btnAppLast
            // 
            this.btnAppLast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAppLast.BackgroundImage")));
            this.btnAppLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAppLast.FlatAppearance.BorderSize = 0;
            this.btnAppLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppLast.Location = new System.Drawing.Point(712, 2);
            this.btnAppLast.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAppLast.Name = "btnAppLast";
            this.btnAppLast.Size = new System.Drawing.Size(164, 37);
            this.btnAppLast.TabIndex = 3;
            this.btnAppLast.Text = ">>|";
            this.btnAppLast.UseVisualStyleBackColor = true;
            this.btnAppLast.Click += new System.EventHandler(this.btnAppLast_Click);
            // 
            // btnAppFirst
            // 
            this.btnAppFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAppFirst.BackgroundImage")));
            this.btnAppFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAppFirst.FlatAppearance.BorderSize = 0;
            this.btnAppFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppFirst.Location = new System.Drawing.Point(123, 2);
            this.btnAppFirst.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAppFirst.Name = "btnAppFirst";
            this.btnAppFirst.Size = new System.Drawing.Size(160, 37);
            this.btnAppFirst.TabIndex = 2;
            this.btnAppFirst.Text = "|<<";
            this.btnAppFirst.UseVisualStyleBackColor = true;
            this.btnAppFirst.Click += new System.EventHandler(this.btnAppFirst_Click);
            // 
            // btnAppPrev
            // 
            this.btnAppPrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAppPrev.BackgroundImage")));
            this.btnAppPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAppPrev.FlatAppearance.BorderSize = 0;
            this.btnAppPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppPrev.Location = new System.Drawing.Point(321, 2);
            this.btnAppPrev.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAppPrev.Name = "btnAppPrev";
            this.btnAppPrev.Size = new System.Drawing.Size(163, 37);
            this.btnAppPrev.TabIndex = 1;
            this.btnAppPrev.Text = "<";
            this.btnAppPrev.UseVisualStyleBackColor = true;
            this.btnAppPrev.Click += new System.EventHandler(this.btnAppPrev_Click);
            // 
            // btnAppNext
            // 
            this.btnAppNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAppNext.BackgroundImage")));
            this.btnAppNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAppNext.FlatAppearance.BorderSize = 0;
            this.btnAppNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppNext.Location = new System.Drawing.Point(525, 2);
            this.btnAppNext.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAppNext.Name = "btnAppNext";
            this.btnAppNext.Size = new System.Drawing.Size(156, 37);
            this.btnAppNext.TabIndex = 0;
            this.btnAppNext.Text = ">";
            this.btnAppNext.UseVisualStyleBackColor = true;
            this.btnAppNext.Click += new System.EventHandler(this.btnAppNext_Click);
            // 
            // pnlAppEdit
            // 
            this.pnlAppEdit.BackColor = System.Drawing.Color.Transparent;
            this.pnlAppEdit.Controls.Add(this.btnStartAppInsert);
            this.pnlAppEdit.Controls.Add(this.mtxtTime);
            this.pnlAppEdit.Controls.Add(this.txtVenue);
            this.pnlAppEdit.Controls.Add(this.lblVenue);
            this.pnlAppEdit.Controls.Add(this.btnAppInsert);
            this.pnlAppEdit.Controls.Add(this.lblCapacity);
            this.pnlAppEdit.Controls.Add(this.lblAppointmentTime);
            this.pnlAppEdit.Controls.Add(this.lblAppointmentDate);
            this.pnlAppEdit.Controls.Add(this.lblAppointmentID);
            this.pnlAppEdit.Controls.Add(this.btnAppDelete);
            this.pnlAppEdit.Controls.Add(this.btnUpdateApp);
            this.pnlAppEdit.Controls.Add(this.spnCapacity);
            this.pnlAppEdit.Controls.Add(this.dtpAppDate);
            this.pnlAppEdit.Controls.Add(this.txtAppID);
            this.pnlAppEdit.Controls.Add(this.btnCancelAppInsert);
            this.pnlAppEdit.Location = new System.Drawing.Point(17, 422);
            this.pnlAppEdit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlAppEdit.Name = "pnlAppEdit";
            this.pnlAppEdit.Size = new System.Drawing.Size(988, 220);
            this.pnlAppEdit.TabIndex = 1;
            // 
            // btnStartAppInsert
            // 
            this.btnStartAppInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStartAppInsert.BackgroundImage")));
            this.btnStartAppInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartAppInsert.FlatAppearance.BorderSize = 0;
            this.btnStartAppInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartAppInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnStartAppInsert.Location = new System.Drawing.Point(548, 20);
            this.btnStartAppInsert.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnStartAppInsert.Name = "btnStartAppInsert";
            this.btnStartAppInsert.Size = new System.Drawing.Size(179, 54);
            this.btnStartAppInsert.TabIndex = 14;
            this.btnStartAppInsert.Text = "Insert Appointment";
            this.btnStartAppInsert.UseVisualStyleBackColor = true;
            this.btnStartAppInsert.Click += new System.EventHandler(this.btnStartAppInsert_Click);
            // 
            // mtxtTime
            // 
            this.mtxtTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "Time", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "T"));
            this.mtxtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.mtxtTime.Location = new System.Drawing.Point(196, 105);
            this.mtxtTime.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.mtxtTime.Mask = "00:00:00";
            this.mtxtTime.Name = "mtxtTime";
            this.mtxtTime.Size = new System.Drawing.Size(265, 25);
            this.mtxtTime.TabIndex = 13;
            this.mtxtTime.ValidatingType = typeof(System.DateTime);
            // 
            // txtVenue
            // 
            this.txtVenue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "Venue", true));
            this.txtVenue.Location = new System.Drawing.Point(196, 182);
            this.txtVenue.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(271, 22);
            this.txtVenue.TabIndex = 12;
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.ForeColor = System.Drawing.Color.White;
            this.lblVenue.Location = new System.Drawing.Point(97, 182);
            this.lblVenue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(61, 20);
            this.lblVenue.TabIndex = 11;
            this.lblVenue.Text = "Venue:";
            // 
            // btnAppInsert
            // 
            this.btnAppInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAppInsert.BackgroundImage")));
            this.btnAppInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAppInsert.FlatAppearance.BorderSize = 0;
            this.btnAppInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnAppInsert.Location = new System.Drawing.Point(548, 22);
            this.btnAppInsert.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAppInsert.Name = "btnAppInsert";
            this.btnAppInsert.Size = new System.Drawing.Size(179, 47);
            this.btnAppInsert.TabIndex = 10;
            this.btnAppInsert.Text = "Insert appointment";
            this.btnAppInsert.UseVisualStyleBackColor = true;
            this.btnAppInsert.Visible = false;
            this.btnAppInsert.Click += new System.EventHandler(this.btnAppInsert_Click);
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.ForeColor = System.Drawing.Color.White;
            this.lblCapacity.Location = new System.Drawing.Point(79, 143);
            this.lblCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(79, 20);
            this.lblCapacity.TabIndex = 9;
            this.lblCapacity.Text = "Capacity:";
            // 
            // lblAppointmentTime
            // 
            this.lblAppointmentTime.AutoSize = true;
            this.lblAppointmentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentTime.ForeColor = System.Drawing.Color.White;
            this.lblAppointmentTime.Location = new System.Drawing.Point(12, 108);
            this.lblAppointmentTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppointmentTime.Name = "lblAppointmentTime";
            this.lblAppointmentTime.Size = new System.Drawing.Size(144, 20);
            this.lblAppointmentTime.TabIndex = 8;
            this.lblAppointmentTime.Text = "Appointment time:";
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDate.ForeColor = System.Drawing.Color.White;
            this.lblAppointmentDate.Location = new System.Drawing.Point(7, 65);
            this.lblAppointmentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(148, 20);
            this.lblAppointmentDate.TabIndex = 7;
            this.lblAppointmentDate.Text = "Appointment Date:";
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentID.ForeColor = System.Drawing.Color.White;
            this.lblAppointmentID.Location = new System.Drawing.Point(28, 21);
            this.lblAppointmentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(129, 20);
            this.lblAppointmentID.TabIndex = 6;
            this.lblAppointmentID.Text = "Appointment ID:";
            // 
            // btnAppDelete
            // 
            this.btnAppDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAppDelete.BackgroundImage")));
            this.btnAppDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAppDelete.FlatAppearance.BorderSize = 0;
            this.btnAppDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppDelete.Location = new System.Drawing.Point(548, 108);
            this.btnAppDelete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAppDelete.Name = "btnAppDelete";
            this.btnAppDelete.Size = new System.Drawing.Size(179, 44);
            this.btnAppDelete.TabIndex = 5;
            this.btnAppDelete.Text = "Delete record";
            this.btnAppDelete.UseVisualStyleBackColor = true;
            this.btnAppDelete.Click += new System.EventHandler(this.btnAppDelete_Click);
            // 
            // btnUpdateApp
            // 
            this.btnUpdateApp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateApp.BackgroundImage")));
            this.btnUpdateApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateApp.FlatAppearance.BorderSize = 0;
            this.btnUpdateApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateApp.Location = new System.Drawing.Point(548, 174);
            this.btnUpdateApp.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnUpdateApp.Name = "btnUpdateApp";
            this.btnUpdateApp.Size = new System.Drawing.Size(179, 39);
            this.btnUpdateApp.TabIndex = 4;
            this.btnUpdateApp.Text = "Apply changes";
            this.btnUpdateApp.UseVisualStyleBackColor = true;
            this.btnUpdateApp.Click += new System.EventHandler(this.btnUpdateApp_Click);
            // 
            // spnCapacity
            // 
            this.spnCapacity.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentBindingSource, "Capacity", true));
            this.spnCapacity.Location = new System.Drawing.Point(196, 140);
            this.spnCapacity.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.spnCapacity.Name = "spnCapacity";
            this.spnCapacity.Size = new System.Drawing.Size(160, 22);
            this.spnCapacity.TabIndex = 3;
            // 
            // dtpAppDate
            // 
            this.dtpAppDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "AppDate", true));
            this.dtpAppDate.Location = new System.Drawing.Point(196, 60);
            this.dtpAppDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpAppDate.Name = "dtpAppDate";
            this.dtpAppDate.Size = new System.Drawing.Size(265, 22);
            this.dtpAppDate.TabIndex = 1;
            // 
            // txtAppID
            // 
            this.txtAppID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "AppID", true));
            this.txtAppID.Location = new System.Drawing.Point(196, 20);
            this.txtAppID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAppID.Name = "txtAppID";
            this.txtAppID.Size = new System.Drawing.Size(132, 22);
            this.txtAppID.TabIndex = 0;
            // 
            // btnCancelAppInsert
            // 
            this.btnCancelAppInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelAppInsert.BackgroundImage")));
            this.btnCancelAppInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelAppInsert.FlatAppearance.BorderSize = 0;
            this.btnCancelAppInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAppInsert.Location = new System.Drawing.Point(548, 103);
            this.btnCancelAppInsert.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCancelAppInsert.Name = "btnCancelAppInsert";
            this.btnCancelAppInsert.Size = new System.Drawing.Size(179, 59);
            this.btnCancelAppInsert.TabIndex = 15;
            this.btnCancelAppInsert.Text = "Cancel Insert";
            this.btnCancelAppInsert.UseVisualStyleBackColor = true;
            this.btnCancelAppInsert.Visible = false;
            this.btnCancelAppInsert.Click += new System.EventHandler(this.btnCancelAppInsert_Click);
            // 
            // tpgBlood
            // 
            this.tpgBlood.Controls.Add(this.pnlRemoveBloodFilters);
            this.tpgBlood.Controls.Add(this.panel6);
            this.tpgBlood.Controls.Add(this.pnlBloodNav);
            this.tpgBlood.Controls.Add(this.panel3);
            this.tpgBlood.Controls.Add(this.dgvBlood);
            this.tpgBlood.Location = new System.Drawing.Point(4, 25);
            this.tpgBlood.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpgBlood.Name = "tpgBlood";
            this.tpgBlood.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgBlood.Size = new System.Drawing.Size(1381, 650);
            this.tpgBlood.TabIndex = 1;
            this.tpgBlood.Text = "Blood Inventory";
            this.tpgBlood.UseVisualStyleBackColor = true;
            this.tpgBlood.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // pnlRemoveBloodFilters
            // 
            this.pnlRemoveBloodFilters.BackColor = System.Drawing.Color.Transparent;
            this.pnlRemoveBloodFilters.Controls.Add(this.btnRemoveBloodFilters);
            this.pnlRemoveBloodFilters.ForeColor = System.Drawing.Color.White;
            this.pnlRemoveBloodFilters.Location = new System.Drawing.Point(1013, 310);
            this.pnlRemoveBloodFilters.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlRemoveBloodFilters.Name = "pnlRemoveBloodFilters";
            this.pnlRemoveBloodFilters.Size = new System.Drawing.Size(348, 75);
            this.pnlRemoveBloodFilters.TabIndex = 8;
            // 
            // btnRemoveBloodFilters
            // 
            this.btnRemoveBloodFilters.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveBloodFilters.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackRed;
            this.btnRemoveBloodFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveBloodFilters.FlatAppearance.BorderSize = 0;
            this.btnRemoveBloodFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBloodFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRemoveBloodFilters.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveBloodFilters.Location = new System.Drawing.Point(65, 12);
            this.btnRemoveBloodFilters.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnRemoveBloodFilters.Name = "btnRemoveBloodFilters";
            this.btnRemoveBloodFilters.Size = new System.Drawing.Size(228, 50);
            this.btnRemoveBloodFilters.TabIndex = 1;
            this.btnRemoveBloodFilters.Text = "Remove Filter";
            this.btnRemoveBloodFilters.UseVisualStyleBackColor = false;
            this.btnRemoveBloodFilters.Click += new System.EventHandler(this.btnRemoveBloodFilters_Click);
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.btnEarlyExpiry);
            this.panel6.Controls.Add(this.btnLaterExpiry);
            this.panel6.Controls.Add(this.dtpExpiryFilter);
            this.panel6.Controls.Add(this.label20);
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(1013, 9);
            this.panel6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(348, 274);
            this.panel6.TabIndex = 7;
            // 
            // btnEarlyExpiry
            // 
            this.btnEarlyExpiry.BackColor = System.Drawing.Color.Transparent;
            this.btnEarlyExpiry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEarlyExpiry.BackgroundImage")));
            this.btnEarlyExpiry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEarlyExpiry.FlatAppearance.BorderSize = 0;
            this.btnEarlyExpiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEarlyExpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEarlyExpiry.ForeColor = System.Drawing.Color.Black;
            this.btnEarlyExpiry.Location = new System.Drawing.Point(65, 192);
            this.btnEarlyExpiry.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEarlyExpiry.Name = "btnEarlyExpiry";
            this.btnEarlyExpiry.Size = new System.Drawing.Size(228, 39);
            this.btnEarlyExpiry.TabIndex = 3;
            this.btnEarlyExpiry.Text = "Filter by expiry date(Earlier than)";
            this.btnEarlyExpiry.UseVisualStyleBackColor = false;
            this.btnEarlyExpiry.Click += new System.EventHandler(this.btnEarlyExpiry_Click);
            // 
            // btnLaterExpiry
            // 
            this.btnLaterExpiry.BackColor = System.Drawing.Color.Transparent;
            this.btnLaterExpiry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLaterExpiry.BackgroundImage")));
            this.btnLaterExpiry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLaterExpiry.FlatAppearance.BorderSize = 0;
            this.btnLaterExpiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaterExpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaterExpiry.ForeColor = System.Drawing.Color.Black;
            this.btnLaterExpiry.Location = new System.Drawing.Point(65, 118);
            this.btnLaterExpiry.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLaterExpiry.Name = "btnLaterExpiry";
            this.btnLaterExpiry.Size = new System.Drawing.Size(228, 39);
            this.btnLaterExpiry.TabIndex = 2;
            this.btnLaterExpiry.Text = "Filter by expiry date(Later than)";
            this.btnLaterExpiry.UseVisualStyleBackColor = false;
            this.btnLaterExpiry.Click += new System.EventHandler(this.btnLaterExpiry_Click);
            // 
            // dtpExpiryFilter
            // 
            this.dtpExpiryFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dtpExpiryFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiryFilter.Location = new System.Drawing.Point(123, 46);
            this.dtpExpiryFilter.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpExpiryFilter.Name = "dtpExpiryFilter";
            this.dtpExpiryFilter.Size = new System.Drawing.Size(131, 27);
            this.dtpExpiryFilter.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(21, 12);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 16);
            this.label20.TabIndex = 0;
            this.label20.Text = "Filters/sorting:";
            // 
            // pnlBloodNav
            // 
            this.pnlBloodNav.BackColor = System.Drawing.Color.Transparent;
            this.pnlBloodNav.Controls.Add(this.btnBloodLast);
            this.pnlBloodNav.Controls.Add(this.btnBloodFirst);
            this.pnlBloodNav.Controls.Add(this.btnBloodPrev);
            this.pnlBloodNav.Controls.Add(this.btnBllodNext);
            this.pnlBloodNav.Location = new System.Drawing.Point(11, 345);
            this.pnlBloodNav.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlBloodNav.Name = "pnlBloodNav";
            this.pnlBloodNav.Size = new System.Drawing.Size(993, 44);
            this.pnlBloodNav.TabIndex = 6;
            // 
            // btnBloodLast
            // 
            this.btnBloodLast.BackColor = System.Drawing.Color.Transparent;
            this.btnBloodLast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBloodLast.BackgroundImage")));
            this.btnBloodLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBloodLast.FlatAppearance.BorderSize = 0;
            this.btnBloodLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloodLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloodLast.Location = new System.Drawing.Point(673, 2);
            this.btnBloodLast.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBloodLast.Name = "btnBloodLast";
            this.btnBloodLast.Size = new System.Drawing.Size(140, 37);
            this.btnBloodLast.TabIndex = 3;
            this.btnBloodLast.Text = ">>|";
            this.btnBloodLast.UseVisualStyleBackColor = false;
            this.btnBloodLast.Click += new System.EventHandler(this.btnBloodLast_Click);
            // 
            // btnBloodFirst
            // 
            this.btnBloodFirst.BackColor = System.Drawing.Color.Transparent;
            this.btnBloodFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBloodFirst.BackgroundImage")));
            this.btnBloodFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBloodFirst.FlatAppearance.BorderSize = 0;
            this.btnBloodFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloodFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloodFirst.Location = new System.Drawing.Point(137, 2);
            this.btnBloodFirst.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBloodFirst.Name = "btnBloodFirst";
            this.btnBloodFirst.Size = new System.Drawing.Size(145, 37);
            this.btnBloodFirst.TabIndex = 2;
            this.btnBloodFirst.Text = "|<<";
            this.btnBloodFirst.UseVisualStyleBackColor = false;
            this.btnBloodFirst.Click += new System.EventHandler(this.btnBloodFirst_Click);
            // 
            // btnBloodPrev
            // 
            this.btnBloodPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnBloodPrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBloodPrev.BackgroundImage")));
            this.btnBloodPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBloodPrev.FlatAppearance.BorderSize = 0;
            this.btnBloodPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloodPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloodPrev.Location = new System.Drawing.Point(321, 4);
            this.btnBloodPrev.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBloodPrev.Name = "btnBloodPrev";
            this.btnBloodPrev.Size = new System.Drawing.Size(135, 37);
            this.btnBloodPrev.TabIndex = 1;
            this.btnBloodPrev.Text = "<";
            this.btnBloodPrev.UseVisualStyleBackColor = false;
            this.btnBloodPrev.Click += new System.EventHandler(this.btnBloodPrev_Click);
            // 
            // btnBllodNext
            // 
            this.btnBllodNext.BackColor = System.Drawing.Color.Transparent;
            this.btnBllodNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBllodNext.BackgroundImage")));
            this.btnBllodNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBllodNext.FlatAppearance.BorderSize = 0;
            this.btnBllodNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBllodNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBllodNext.Location = new System.Drawing.Point(511, 4);
            this.btnBllodNext.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBllodNext.Name = "btnBllodNext";
            this.btnBllodNext.Size = new System.Drawing.Size(135, 36);
            this.btnBllodNext.TabIndex = 0;
            this.btnBllodNext.Text = ">";
            this.btnBllodNext.UseVisualStyleBackColor = false;
            this.btnBllodNext.Click += new System.EventHandler(this.btnBllodNext_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.insertBloodGrp);
            this.panel3.Controls.Add(this.lblBloodExpiryDate);
            this.panel3.Controls.Add(this.lblBloodUserID);
            this.panel3.Controls.Add(this.lblBloodAppID);
            this.panel3.Controls.Add(this.lblTypeBlood);
            this.panel3.Controls.Add(this.lblUnitID);
            this.panel3.Controls.Add(this.btnBloodDelete);
            this.panel3.Controls.Add(this.btnBloodApply);
            this.panel3.Controls.Add(this.dtpExpiry);
            this.panel3.Controls.Add(this.cmbBloodInvType);
            this.panel3.Controls.Add(this.txtBloodAppID);
            this.panel3.Controls.Add(this.txtBloodUserID);
            this.panel3.Controls.Add(this.txtUnitID);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(9, 399);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1352, 242);
            this.panel3.TabIndex = 1;
            // 
            // lblBloodExpiryDate
            // 
            this.lblBloodExpiryDate.AutoSize = true;
            this.lblBloodExpiryDate.BackColor = System.Drawing.Color.Transparent;
            this.lblBloodExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodExpiryDate.ForeColor = System.Drawing.Color.White;
            this.lblBloodExpiryDate.Location = new System.Drawing.Point(96, 194);
            this.lblBloodExpiryDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBloodExpiryDate.Name = "lblBloodExpiryDate";
            this.lblBloodExpiryDate.Size = new System.Drawing.Size(97, 20);
            this.lblBloodExpiryDate.TabIndex = 12;
            this.lblBloodExpiryDate.Text = "Expiry date:";
            // 
            // lblBloodUserID
            // 
            this.lblBloodUserID.AutoSize = true;
            this.lblBloodUserID.BackColor = System.Drawing.Color.Transparent;
            this.lblBloodUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodUserID.ForeColor = System.Drawing.Color.White;
            this.lblBloodUserID.Location = new System.Drawing.Point(127, 63);
            this.lblBloodUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBloodUserID.Name = "lblBloodUserID";
            this.lblBloodUserID.Size = new System.Drawing.Size(67, 20);
            this.lblBloodUserID.TabIndex = 11;
            this.lblBloodUserID.Text = "UserID:";
            // 
            // lblBloodAppID
            // 
            this.lblBloodAppID.AutoSize = true;
            this.lblBloodAppID.BackColor = System.Drawing.Color.Transparent;
            this.lblBloodAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodAppID.ForeColor = System.Drawing.Color.White;
            this.lblBloodAppID.Location = new System.Drawing.Point(65, 110);
            this.lblBloodAppID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBloodAppID.Name = "lblBloodAppID";
            this.lblBloodAppID.Size = new System.Drawing.Size(124, 20);
            this.lblBloodAppID.TabIndex = 10;
            this.lblBloodAppID.Text = "AppointmentID:";
            // 
            // lblTypeBlood
            // 
            this.lblTypeBlood.AutoSize = true;
            this.lblTypeBlood.BackColor = System.Drawing.Color.Transparent;
            this.lblTypeBlood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeBlood.ForeColor = System.Drawing.Color.White;
            this.lblTypeBlood.Location = new System.Drawing.Point(96, 148);
            this.lblTypeBlood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeBlood.Name = "lblTypeBlood";
            this.lblTypeBlood.Size = new System.Drawing.Size(93, 20);
            this.lblTypeBlood.TabIndex = 9;
            this.lblTypeBlood.Text = "Blood type:";
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitID.ForeColor = System.Drawing.Color.White;
            this.lblUnitID.Location = new System.Drawing.Point(135, 21);
            this.lblUnitID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(61, 20);
            this.lblUnitID.TabIndex = 8;
            this.lblUnitID.Text = "UnitID:";
            // 
            // btnBloodDelete
            // 
            this.btnBloodDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnBloodDelete.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackRed;
            this.btnBloodDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBloodDelete.FlatAppearance.BorderSize = 0;
            this.btnBloodDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloodDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloodDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBloodDelete.Location = new System.Drawing.Point(456, 171);
            this.btnBloodDelete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBloodDelete.Name = "btnBloodDelete";
            this.btnBloodDelete.Size = new System.Drawing.Size(167, 48);
            this.btnBloodDelete.TabIndex = 7;
            this.btnBloodDelete.Text = "Delete record";
            this.btnBloodDelete.UseVisualStyleBackColor = false;
            this.btnBloodDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBloodApply
            // 
            this.btnBloodApply.BackColor = System.Drawing.Color.Transparent;
            this.btnBloodApply.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackBlue;
            this.btnBloodApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBloodApply.FlatAppearance.BorderSize = 0;
            this.btnBloodApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloodApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloodApply.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBloodApply.Location = new System.Drawing.Point(456, 98);
            this.btnBloodApply.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBloodApply.Name = "btnBloodApply";
            this.btnBloodApply.Size = new System.Drawing.Size(167, 42);
            this.btnBloodApply.TabIndex = 6;
            this.btnBloodApply.Text = "Apply changes";
            this.btnBloodApply.UseVisualStyleBackColor = false;
            this.btnBloodApply.Click += new System.EventHandler(this.btnBloodApply_Click);
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBloodInventoryBindingSource, "ExpiryDate", true));
            this.dtpExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiry.Location = new System.Drawing.Point(233, 194);
            this.dtpExpiry.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.Size = new System.Drawing.Size(160, 22);
            this.dtpExpiry.TabIndex = 5;
            // 
            // cmbBloodInvType
            // 
            this.cmbBloodInvType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBloodInventoryBindingSource, "BloodType", true));
            this.cmbBloodInvType.FormattingEnabled = true;
            this.cmbBloodInvType.Location = new System.Drawing.Point(233, 146);
            this.cmbBloodInvType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbBloodInvType.Name = "cmbBloodInvType";
            this.cmbBloodInvType.Size = new System.Drawing.Size(160, 24);
            this.cmbBloodInvType.TabIndex = 3;
            // 
            // txtBloodAppID
            // 
            this.txtBloodAppID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBloodInventoryBindingSource, "AppID", true));
            this.txtBloodAppID.Location = new System.Drawing.Point(233, 105);
            this.txtBloodAppID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtBloodAppID.Name = "txtBloodAppID";
            this.txtBloodAppID.ReadOnly = true;
            this.txtBloodAppID.Size = new System.Drawing.Size(160, 22);
            this.txtBloodAppID.TabIndex = 2;
            // 
            // txtBloodUserID
            // 
            this.txtBloodUserID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBloodInventoryBindingSource, "UserID", true));
            this.txtBloodUserID.Location = new System.Drawing.Point(233, 62);
            this.txtBloodUserID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtBloodUserID.Name = "txtBloodUserID";
            this.txtBloodUserID.ReadOnly = true;
            this.txtBloodUserID.Size = new System.Drawing.Size(160, 22);
            this.txtBloodUserID.TabIndex = 1;
            // 
            // txtUnitID
            // 
            this.txtUnitID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBloodInventoryBindingSource, "UnitID", true));
            this.txtUnitID.Location = new System.Drawing.Point(233, 20);
            this.txtUnitID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUnitID.Name = "txtUnitID";
            this.txtUnitID.ReadOnly = true;
            this.txtUnitID.Size = new System.Drawing.Size(160, 22);
            this.txtUnitID.TabIndex = 0;
            // 
            // dgvBlood
            // 
            this.dgvBlood.AutoGenerateColumns = false;
            this.dgvBlood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unitIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn1,
            this.appIDDataGridViewTextBoxColumn,
            this.bloodTypeDataGridViewTextBoxColumn1,
            this.expiryDateDataGridViewTextBoxColumn});
            this.dgvBlood.DataSource = this.tblBloodInventoryBindingSource;
            this.dgvBlood.Location = new System.Drawing.Point(9, 9);
            this.dgvBlood.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvBlood.Name = "dgvBlood";
            this.dgvBlood.RowHeadersWidth = 51;
            this.dgvBlood.Size = new System.Drawing.Size(995, 335);
            this.dgvBlood.TabIndex = 0;
            this.dgvBlood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBlood_CellContentClick);
            // 
            // tpgUsers
            // 
            this.tpgUsers.BackgroundImage = global::BloodBankSystem.Properties.Resources.MainBackground;
            this.tpgUsers.Controls.Add(this.pnlRemoveUserFilters);
            this.tpgUsers.Controls.Add(this.pnlUserNav);
            this.tpgUsers.Controls.Add(this.panel5);
            this.tpgUsers.Controls.Add(this.dgvUsers);
            this.tpgUsers.Controls.Add(this.pnlUserEdit);
            this.tpgUsers.Location = new System.Drawing.Point(4, 25);
            this.tpgUsers.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpgUsers.Name = "tpgUsers";
            this.tpgUsers.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgUsers.Size = new System.Drawing.Size(1381, 650);
            this.tpgUsers.TabIndex = 0;
            this.tpgUsers.Text = "    Users    ";
            this.tpgUsers.UseVisualStyleBackColor = true;
            // 
            // pnlRemoveUserFilters
            // 
            this.pnlRemoveUserFilters.BackColor = System.Drawing.Color.Transparent;
            this.pnlRemoveUserFilters.Controls.Add(this.btnRemoveFilter);
            this.pnlRemoveUserFilters.Location = new System.Drawing.Point(1008, 558);
            this.pnlRemoveUserFilters.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlRemoveUserFilters.Name = "pnlRemoveUserFilters";
            this.pnlRemoveUserFilters.Size = new System.Drawing.Size(368, 84);
            this.pnlRemoveUserFilters.TabIndex = 6;
            // 
            // btnRemoveFilter
            // 
            this.btnRemoveFilter.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackRed;
            this.btnRemoveFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveFilter.FlatAppearance.BorderSize = 0;
            this.btnRemoveFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnRemoveFilter.Location = new System.Drawing.Point(49, 16);
            this.btnRemoveFilter.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnRemoveFilter.Name = "btnRemoveFilter";
            this.btnRemoveFilter.Size = new System.Drawing.Size(259, 46);
            this.btnRemoveFilter.TabIndex = 1;
            this.btnRemoveFilter.Text = "Remove Filters";
            this.btnRemoveFilter.UseVisualStyleBackColor = true;
            this.btnRemoveFilter.Click += new System.EventHandler(this.btnRemoveFilter_Click);
            // 
            // pnlUserNav
            // 
            this.pnlUserNav.BackColor = System.Drawing.Color.Transparent;
            this.pnlUserNav.Controls.Add(this.btnUserLast);
            this.pnlUserNav.Controls.Add(this.btnUserFirst);
            this.pnlUserNav.Controls.Add(this.btnUserPrev);
            this.pnlUserNav.Controls.Add(this.btnUserNext);
            this.pnlUserNav.Location = new System.Drawing.Point(11, 363);
            this.pnlUserNav.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlUserNav.Name = "pnlUserNav";
            this.pnlUserNav.Size = new System.Drawing.Size(983, 44);
            this.pnlUserNav.TabIndex = 5;
            // 
            // btnUserLast
            // 
            this.btnUserLast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUserLast.BackgroundImage")));
            this.btnUserLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserLast.FlatAppearance.BorderSize = 0;
            this.btnUserLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserLast.Location = new System.Drawing.Point(683, 4);
            this.btnUserLast.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnUserLast.Name = "btnUserLast";
            this.btnUserLast.Size = new System.Drawing.Size(161, 37);
            this.btnUserLast.TabIndex = 3;
            this.btnUserLast.Text = ">>|";
            this.btnUserLast.UseVisualStyleBackColor = true;
            this.btnUserLast.Click += new System.EventHandler(this.btnUserLast_Click);
            // 
            // btnUserFirst
            // 
            this.btnUserFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUserFirst.BackgroundImage")));
            this.btnUserFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserFirst.FlatAppearance.BorderSize = 0;
            this.btnUserFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserFirst.Location = new System.Drawing.Point(132, 4);
            this.btnUserFirst.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnUserFirst.Name = "btnUserFirst";
            this.btnUserFirst.Size = new System.Drawing.Size(161, 37);
            this.btnUserFirst.TabIndex = 2;
            this.btnUserFirst.Text = "|<<";
            this.btnUserFirst.UseVisualStyleBackColor = true;
            this.btnUserFirst.Click += new System.EventHandler(this.btnUserFirst_Click);
            // 
            // btnUserPrev
            // 
            this.btnUserPrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUserPrev.BackgroundImage")));
            this.btnUserPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserPrev.FlatAppearance.BorderSize = 0;
            this.btnUserPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserPrev.Location = new System.Drawing.Point(316, 4);
            this.btnUserPrev.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnUserPrev.Name = "btnUserPrev";
            this.btnUserPrev.Size = new System.Drawing.Size(161, 37);
            this.btnUserPrev.TabIndex = 1;
            this.btnUserPrev.Text = "<";
            this.btnUserPrev.UseVisualStyleBackColor = true;
            this.btnUserPrev.Click += new System.EventHandler(this.btnUserPrev_Click);
            // 
            // btnUserNext
            // 
            this.btnUserNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUserNext.BackgroundImage")));
            this.btnUserNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserNext.FlatAppearance.BorderSize = 0;
            this.btnUserNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserNext.Location = new System.Drawing.Point(511, 4);
            this.btnUserNext.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnUserNext.Name = "btnUserNext";
            this.btnUserNext.Size = new System.Drawing.Size(161, 37);
            this.btnUserNext.TabIndex = 0;
            this.btnUserNext.Text = ">";
            this.btnUserNext.UseVisualStyleBackColor = true;
            this.btnUserNext.Click += new System.EventHandler(this.btnUserNext_Click);
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.no1DonorFilterBtn);
            this.panel5.Controls.Add(this.donorRankingFilterBtn);
            this.panel5.Controls.Add(this.cmbUserFilter);
            this.panel5.Controls.Add(this.btnUserFilter);
            this.panel5.Controls.Add(this.cmbBloodFilter);
            this.panel5.Controls.Add(this.btnBloodFilter);
            this.panel5.Controls.Add(this.btnSurnameAlphabetical);
            this.panel5.Controls.Add(this.btnNameAlphabetical);
            this.panel5.Controls.Add(this.btnFilterInactive);
            this.panel5.Controls.Add(this.btnFilterActive);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Location = new System.Drawing.Point(1005, 5);
            this.panel5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(368, 537);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // no1DonorFilterBtn
            // 
            this.no1DonorFilterBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("no1DonorFilterBtn.BackgroundImage")));
            this.no1DonorFilterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.no1DonorFilterBtn.FlatAppearance.BorderSize = 0;
            this.no1DonorFilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.no1DonorFilterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.no1DonorFilterBtn.Location = new System.Drawing.Point(52, 464);
            this.no1DonorFilterBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.no1DonorFilterBtn.Name = "no1DonorFilterBtn";
            this.no1DonorFilterBtn.Size = new System.Drawing.Size(273, 46);
            this.no1DonorFilterBtn.TabIndex = 10;
            this.no1DonorFilterBtn.Text = "No.1 Donor";
            this.no1DonorFilterBtn.UseVisualStyleBackColor = true;
            this.no1DonorFilterBtn.Click += new System.EventHandler(this.no1DonorFilterBtn_Click);
            // 
            // donorRankingFilterBtn
            // 
            this.donorRankingFilterBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("donorRankingFilterBtn.BackgroundImage")));
            this.donorRankingFilterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.donorRankingFilterBtn.FlatAppearance.BorderSize = 0;
            this.donorRankingFilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donorRankingFilterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.donorRankingFilterBtn.Location = new System.Drawing.Point(52, 377);
            this.donorRankingFilterBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.donorRankingFilterBtn.Name = "donorRankingFilterBtn";
            this.donorRankingFilterBtn.Size = new System.Drawing.Size(273, 50);
            this.donorRankingFilterBtn.TabIndex = 9;
            this.donorRankingFilterBtn.Text = "Donor Ranking";
            this.donorRankingFilterBtn.UseVisualStyleBackColor = true;
            this.donorRankingFilterBtn.Click += new System.EventHandler(this.donorRankingFilterBtn_Click);
            // 
            // cmbUserFilter
            // 
            this.cmbUserFilter.FormattingEnabled = true;
            this.cmbUserFilter.Items.AddRange(new object[] {
            "Admin",
            "Donor"});
            this.cmbUserFilter.Location = new System.Drawing.Point(228, 303);
            this.cmbUserFilter.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbUserFilter.Name = "cmbUserFilter";
            this.cmbUserFilter.Size = new System.Drawing.Size(96, 24);
            this.cmbUserFilter.TabIndex = 8;
            this.cmbUserFilter.Text = "Admin";
            // 
            // btnUserFilter
            // 
            this.btnUserFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUserFilter.BackgroundImage")));
            this.btnUserFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserFilter.FlatAppearance.BorderSize = 0;
            this.btnUserFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserFilter.Location = new System.Drawing.Point(52, 295);
            this.btnUserFilter.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnUserFilter.Name = "btnUserFilter";
            this.btnUserFilter.Size = new System.Drawing.Size(139, 37);
            this.btnUserFilter.TabIndex = 7;
            this.btnUserFilter.Text = "Fliter by user type";
            this.btnUserFilter.UseVisualStyleBackColor = true;
            this.btnUserFilter.Click += new System.EventHandler(this.btnUserFilter_Click);
            // 
            // cmbBloodFilter
            // 
            this.cmbBloodFilter.FormattingEnabled = true;
            this.cmbBloodFilter.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.cmbBloodFilter.Location = new System.Drawing.Point(228, 234);
            this.cmbBloodFilter.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbBloodFilter.Name = "cmbBloodFilter";
            this.cmbBloodFilter.Size = new System.Drawing.Size(96, 24);
            this.cmbBloodFilter.TabIndex = 6;
            this.cmbBloodFilter.Text = "O";
            // 
            // btnBloodFilter
            // 
            this.btnBloodFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBloodFilter.BackgroundImage")));
            this.btnBloodFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBloodFilter.FlatAppearance.BorderSize = 0;
            this.btnBloodFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloodFilter.Location = new System.Drawing.Point(52, 226);
            this.btnBloodFilter.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBloodFilter.Name = "btnBloodFilter";
            this.btnBloodFilter.Size = new System.Drawing.Size(139, 38);
            this.btnBloodFilter.TabIndex = 5;
            this.btnBloodFilter.Text = "Filter by blood type";
            this.btnBloodFilter.UseVisualStyleBackColor = true;
            this.btnBloodFilter.Click += new System.EventHandler(this.btnBloodFilter_Click);
            // 
            // btnSurnameAlphabetical
            // 
            this.btnSurnameAlphabetical.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSurnameAlphabetical.BackgroundImage")));
            this.btnSurnameAlphabetical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSurnameAlphabetical.FlatAppearance.BorderSize = 0;
            this.btnSurnameAlphabetical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSurnameAlphabetical.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSurnameAlphabetical.Location = new System.Drawing.Point(52, 166);
            this.btnSurnameAlphabetical.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSurnameAlphabetical.Name = "btnSurnameAlphabetical";
            this.btnSurnameAlphabetical.Size = new System.Drawing.Size(273, 38);
            this.btnSurnameAlphabetical.TabIndex = 4;
            this.btnSurnameAlphabetical.Text = "Sort alphabetically(Surname)";
            this.btnSurnameAlphabetical.UseVisualStyleBackColor = true;
            this.btnSurnameAlphabetical.Click += new System.EventHandler(this.btnSurnameAlphabetical_Click);
            // 
            // btnNameAlphabetical
            // 
            this.btnNameAlphabetical.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNameAlphabetical.BackgroundImage")));
            this.btnNameAlphabetical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNameAlphabetical.FlatAppearance.BorderSize = 0;
            this.btnNameAlphabetical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNameAlphabetical.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNameAlphabetical.Location = new System.Drawing.Point(52, 112);
            this.btnNameAlphabetical.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnNameAlphabetical.Name = "btnNameAlphabetical";
            this.btnNameAlphabetical.Size = new System.Drawing.Size(273, 38);
            this.btnNameAlphabetical.TabIndex = 3;
            this.btnNameAlphabetical.Text = "Sort alphabetically(Name)";
            this.btnNameAlphabetical.UseVisualStyleBackColor = true;
            this.btnNameAlphabetical.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnFilterInactive
            // 
            this.btnFilterInactive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFilterInactive.BackgroundImage")));
            this.btnFilterInactive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilterInactive.FlatAppearance.BorderSize = 0;
            this.btnFilterInactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterInactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnFilterInactive.Location = new System.Drawing.Point(200, 46);
            this.btnFilterInactive.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnFilterInactive.Name = "btnFilterInactive";
            this.btnFilterInactive.Size = new System.Drawing.Size(125, 41);
            this.btnFilterInactive.TabIndex = 2;
            this.btnFilterInactive.Text = "Filter by inactive";
            this.btnFilterInactive.UseVisualStyleBackColor = true;
            this.btnFilterInactive.Click += new System.EventHandler(this.btnFilterInactive_Click);
            // 
            // btnFilterActive
            // 
            this.btnFilterActive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFilterActive.BackgroundImage")));
            this.btnFilterActive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilterActive.FlatAppearance.BorderSize = 0;
            this.btnFilterActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnFilterActive.Location = new System.Drawing.Point(52, 46);
            this.btnFilterActive.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnFilterActive.Name = "btnFilterActive";
            this.btnFilterActive.Size = new System.Drawing.Size(124, 41);
            this.btnFilterActive.TabIndex = 1;
            this.btnFilterActive.Text = "Filter by active";
            this.btnFilterActive.UseVisualStyleBackColor = true;
            this.btnFilterActive.Click += new System.EventHandler(this.btnFilterActive_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(27, 12);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 16);
            this.label19.TabIndex = 0;
            this.label19.Text = "Filters/sorting:";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.iDNumberDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn,
            this.bloodTypeDataGridViewTextBoxColumn,
            this.isActiveAccountDataGridViewCheckBoxColumn});
            this.dgvUsers.DataSource = this.tblUsersBindingSource;
            this.dgvUsers.Location = new System.Drawing.Point(11, 0);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.Size = new System.Drawing.Size(983, 353);
            this.dgvUsers.TabIndex = 3;
            // 
            // pnlUserEdit
            // 
            this.pnlUserEdit.BackColor = System.Drawing.Color.Transparent;
            this.pnlUserEdit.Controls.Add(this.btnStartInsert);
            this.pnlUserEdit.Controls.Add(this.btnInsertUser);
            this.pnlUserEdit.Controls.Add(this.lblUserType);
            this.pnlUserEdit.Controls.Add(this.lblBloodType);
            this.pnlUserEdit.Controls.Add(this.lblName);
            this.pnlUserEdit.Controls.Add(this.lblSurname);
            this.pnlUserEdit.Controls.Add(this.lblIDNum);
            this.pnlUserEdit.Controls.Add(this.lblPhoneNum);
            this.pnlUserEdit.Controls.Add(this.lblPassword);
            this.pnlUserEdit.Controls.Add(this.lblUserID);
            this.pnlUserEdit.Controls.Add(this.btnDeleteUser);
            this.pnlUserEdit.Controls.Add(this.btnUpdateUser);
            this.pnlUserEdit.Controls.Add(this.chkActive);
            this.pnlUserEdit.Controls.Add(this.cmbUser);
            this.pnlUserEdit.Controls.Add(this.cmbBlood);
            this.pnlUserEdit.Controls.Add(this.txtPhone);
            this.pnlUserEdit.Controls.Add(this.txtID);
            this.pnlUserEdit.Controls.Add(this.txtSurname);
            this.pnlUserEdit.Controls.Add(this.txtName);
            this.pnlUserEdit.Controls.Add(this.txtPassword);
            this.pnlUserEdit.Controls.Add(this.txtUserID);
            this.pnlUserEdit.Controls.Add(this.btnCancelInsert);
            this.pnlUserEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlUserEdit.ForeColor = System.Drawing.Color.White;
            this.pnlUserEdit.Location = new System.Drawing.Point(11, 414);
            this.pnlUserEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlUserEdit.Name = "pnlUserEdit";
            this.pnlUserEdit.Size = new System.Drawing.Size(983, 231);
            this.pnlUserEdit.TabIndex = 2;
            // 
            // btnStartInsert
            // 
            this.btnStartInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStartInsert.BackgroundImage")));
            this.btnStartInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartInsert.FlatAppearance.BorderSize = 0;
            this.btnStartInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartInsert.ForeColor = System.Drawing.Color.Black;
            this.btnStartInsert.Location = new System.Drawing.Point(707, 26);
            this.btnStartInsert.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnStartInsert.Name = "btnStartInsert";
            this.btnStartInsert.Size = new System.Drawing.Size(161, 43);
            this.btnStartInsert.TabIndex = 21;
            this.btnStartInsert.Text = "Insert a User";
            this.btnStartInsert.UseVisualStyleBackColor = true;
            this.btnStartInsert.Click += new System.EventHandler(this.btnStartInsert_Click);
            // 
            // btnInsertUser
            // 
            this.btnInsertUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsertUser.BackgroundImage")));
            this.btnInsertUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsertUser.FlatAppearance.BorderSize = 0;
            this.btnInsertUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertUser.ForeColor = System.Drawing.Color.Black;
            this.btnInsertUser.Location = new System.Drawing.Point(707, 28);
            this.btnInsertUser.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnInsertUser.Name = "btnInsertUser";
            this.btnInsertUser.Size = new System.Drawing.Size(161, 38);
            this.btnInsertUser.TabIndex = 20;
            this.btnInsertUser.Text = "Insert record";
            this.btnInsertUser.UseVisualStyleBackColor = true;
            this.btnInsertUser.Visible = false;
            this.btnInsertUser.Click += new System.EventHandler(this.btnInsertUser_Click);
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.ForeColor = System.Drawing.Color.White;
            this.lblUserType.Location = new System.Drawing.Point(356, 75);
            this.lblUserType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(91, 20);
            this.lblUserType.TabIndex = 19;
            this.lblUserType.Text = "User Type:";
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodType.ForeColor = System.Drawing.Color.White;
            this.lblBloodType.Location = new System.Drawing.Point(347, 107);
            this.lblBloodType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(98, 20);
            this.lblBloodType.TabIndex = 18;
            this.lblBloodType.Text = "Blood Type:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(56, 105);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 20);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.White;
            this.lblSurname.Location = new System.Drawing.Point(33, 144);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(81, 20);
            this.lblSurname.TabIndex = 16;
            this.lblSurname.Text = "Surname:";
            // 
            // lblIDNum
            // 
            this.lblIDNum.AutoSize = true;
            this.lblIDNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNum.ForeColor = System.Drawing.Color.White;
            this.lblIDNum.Location = new System.Drawing.Point(20, 182);
            this.lblIDNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDNum.Name = "lblIDNum";
            this.lblIDNum.Size = new System.Drawing.Size(95, 20);
            this.lblIDNum.TabIndex = 15;
            this.lblIDNum.Text = "ID Number:";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNum.Location = new System.Drawing.Point(325, 36);
            this.lblPhoneNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(122, 20);
            this.lblPhoneNum.TabIndex = 14;
            this.lblPhoneNum.Text = "Phone number:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(25, 65);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(88, 20);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.White;
            this.lblUserID.Location = new System.Drawing.Point(49, 28);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(67, 20);
            this.lblUserID.TabIndex = 12;
            this.lblUserID.Text = "UserID:";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteUser.BackgroundImage")));
            this.btnDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteUser.Location = new System.Drawing.Point(707, 100);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(161, 38);
            this.btnDeleteUser.TabIndex = 11;
            this.btnDeleteUser.Text = "Delete record";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateUser.BackgroundImage")));
            this.btnUpdateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateUser.Location = new System.Drawing.Point(707, 160);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(161, 38);
            this.btnUpdateUser.TabIndex = 10;
            this.btnUpdateUser.Text = "Apply changes";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.tblUsersBindingSource, "isActiveAccount", true));
            this.chkActive.Location = new System.Drawing.Point(464, 151);
            this.chkActive.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(157, 24);
            this.chkActive.TabIndex = 9;
            this.chkActive.Text = "Is active account";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // cmbUser
            // 
            this.cmbUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "UserType", true));
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Items.AddRange(new object[] {
            "A",
            "D"});
            this.cmbUser.Location = new System.Drawing.Point(464, 71);
            this.cmbUser.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(160, 28);
            this.cmbUser.TabIndex = 8;
            this.cmbUser.SelectionChangeCommitted += new System.EventHandler(this.cmbUser_SelectionChangeCommitted);
            // 
            // cmbBlood
            // 
            this.cmbBlood.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblUsersBindingSource, "UserType", true));
            this.cmbBlood.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "BloodType", true));
            this.cmbBlood.FormattingEnabled = true;
            this.cmbBlood.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.cmbBlood.Location = new System.Drawing.Point(464, 110);
            this.cmbBlood.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbBlood.Name = "cmbBlood";
            this.cmbBlood.Size = new System.Drawing.Size(160, 28);
            this.cmbBlood.TabIndex = 7;
            this.cmbBlood.SelectionChangeCommitted += new System.EventHandler(this.cmbBlood_SelectionChangeCommitted);
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "PhoneNumber", true));
            this.txtPhone.Location = new System.Drawing.Point(464, 33);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(160, 26);
            this.txtPhone.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "IDNumber", true));
            this.txtID.Location = new System.Drawing.Point(160, 178);
            this.txtID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(132, 26);
            this.txtID.TabIndex = 4;
            // 
            // txtSurname
            // 
            this.txtSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "Surname", true));
            this.txtSurname.Location = new System.Drawing.Point(160, 142);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(132, 26);
            this.txtSurname.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "Name", true));
            this.txtName.Location = new System.Drawing.Point(160, 101);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 26);
            this.txtName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "Password", true));
            this.txtPassword.Location = new System.Drawing.Point(160, 62);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(132, 26);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUserID
            // 
            this.txtUserID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "UserID", true));
            this.txtUserID.Location = new System.Drawing.Point(160, 22);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(132, 26);
            this.txtUserID.TabIndex = 0;
            // 
            // btnCancelInsert
            // 
            this.btnCancelInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelInsert.BackgroundImage")));
            this.btnCancelInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelInsert.FlatAppearance.BorderSize = 0;
            this.btnCancelInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelInsert.ForeColor = System.Drawing.Color.Black;
            this.btnCancelInsert.Location = new System.Drawing.Point(707, 101);
            this.btnCancelInsert.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCancelInsert.Name = "btnCancelInsert";
            this.btnCancelInsert.Size = new System.Drawing.Size(161, 34);
            this.btnCancelInsert.TabIndex = 22;
            this.btnCancelInsert.Text = "Cancel Insert";
            this.btnCancelInsert.UseVisualStyleBackColor = true;
            this.btnCancelInsert.Visible = false;
            this.btnCancelInsert.Click += new System.EventHandler(this.btnCancelInsert_Click);
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpgUsers);
            this.tcAdmin.Controls.Add(this.tpgBlood);
            this.tcAdmin.Controls.Add(this.tpgAppointments);
            this.tcAdmin.Controls.Add(this.tpgSchedule);
            this.tcAdmin.Controls.Add(this.tpgStats);
            this.tcAdmin.Location = new System.Drawing.Point(0, 64);
            this.tcAdmin.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(1389, 679);
            this.tcAdmin.TabIndex = 2;
            this.tcAdmin.SelectedIndexChanged += new System.EventHandler(this.tcAdmin_SelectedIndexChanged);
            // 
            // tpgSchedule
            // 
            this.tpgSchedule.AutoScroll = true;
            this.tpgSchedule.BackgroundImage = global::BloodBankSystem.Properties.Resources.MainBackground;
            this.tpgSchedule.Controls.Add(this.dgvTotalSchedule);
            this.tpgSchedule.Controls.Add(this.dgvAverage);
            this.tpgSchedule.Controls.Add(this.pnlScheduleNav);
            this.tpgSchedule.Controls.Add(this.panel1);
            this.tpgSchedule.Controls.Add(this.pnlSchedule);
            this.tpgSchedule.Controls.Add(this.dgvSchedule);
            this.tpgSchedule.Location = new System.Drawing.Point(4, 25);
            this.tpgSchedule.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpgSchedule.Name = "tpgSchedule";
            this.tpgSchedule.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgSchedule.Size = new System.Drawing.Size(1381, 650);
            this.tpgSchedule.TabIndex = 3;
            this.tpgSchedule.Text = "   Schedule   ";
            this.tpgSchedule.UseVisualStyleBackColor = true;
            // 
            // dgvTotalSchedule
            // 
            this.dgvTotalSchedule.AutoGenerateColumns = false;
            this.dgvTotalSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn2,
            this.schedulesDataGridViewTextBoxColumn});
            this.dgvTotalSchedule.DataSource = this.tblTotalScheduleBindingSource;
            this.dgvTotalSchedule.Location = new System.Drawing.Point(17, 11);
            this.dgvTotalSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTotalSchedule.Name = "dgvTotalSchedule";
            this.dgvTotalSchedule.RowHeadersWidth = 51;
            this.dgvTotalSchedule.RowTemplate.Height = 24;
            this.dgvTotalSchedule.Size = new System.Drawing.Size(1017, 319);
            this.dgvTotalSchedule.TabIndex = 3;
            this.dgvTotalSchedule.Visible = false;
            // 
            // dgvAverage
            // 
            this.dgvAverage.AutoGenerateColumns = false;
            this.dgvAverage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAverage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dgvAverage.DataSource = this.tblAverageScheduleBindingSource;
            this.dgvAverage.Location = new System.Drawing.Point(15, 11);
            this.dgvAverage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAverage.Name = "dgvAverage";
            this.dgvAverage.RowHeadersWidth = 51;
            this.dgvAverage.RowTemplate.Height = 24;
            this.dgvAverage.Size = new System.Drawing.Size(1017, 319);
            this.dgvAverage.TabIndex = 4;
            this.dgvAverage.Visible = false;
            // 
            // pnlScheduleNav
            // 
            this.pnlScheduleNav.BackColor = System.Drawing.Color.Transparent;
            this.pnlScheduleNav.Controls.Add(this.btnScheduleFirst);
            this.pnlScheduleNav.Controls.Add(this.btnSchedulePrev);
            this.pnlScheduleNav.Controls.Add(this.btnScheduleNext);
            this.pnlScheduleNav.Controls.Add(this.btnScheduleLast);
            this.pnlScheduleNav.Location = new System.Drawing.Point(15, 340);
            this.pnlScheduleNav.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlScheduleNav.Name = "pnlScheduleNav";
            this.pnlScheduleNav.Size = new System.Drawing.Size(1019, 52);
            this.pnlScheduleNav.TabIndex = 9;
            // 
            // btnScheduleFirst
            // 
            this.btnScheduleFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScheduleFirst.BackgroundImage")));
            this.btnScheduleFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScheduleFirst.FlatAppearance.BorderSize = 0;
            this.btnScheduleFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleFirst.Location = new System.Drawing.Point(112, 0);
            this.btnScheduleFirst.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnScheduleFirst.Name = "btnScheduleFirst";
            this.btnScheduleFirst.Size = new System.Drawing.Size(172, 44);
            this.btnScheduleFirst.TabIndex = 3;
            this.btnScheduleFirst.Text = "|<";
            this.btnScheduleFirst.UseVisualStyleBackColor = true;
            this.btnScheduleFirst.Click += new System.EventHandler(this.btnScheduleFirst_Click);
            // 
            // btnSchedulePrev
            // 
            this.btnSchedulePrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSchedulePrev.BackgroundImage")));
            this.btnSchedulePrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSchedulePrev.FlatAppearance.BorderSize = 0;
            this.btnSchedulePrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedulePrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedulePrev.Location = new System.Drawing.Point(300, 2);
            this.btnSchedulePrev.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSchedulePrev.Name = "btnSchedulePrev";
            this.btnSchedulePrev.Size = new System.Drawing.Size(145, 44);
            this.btnSchedulePrev.TabIndex = 2;
            this.btnSchedulePrev.Text = "<";
            this.btnSchedulePrev.UseVisualStyleBackColor = true;
            this.btnSchedulePrev.Click += new System.EventHandler(this.btnSchedulePrev_Click);
            // 
            // btnScheduleNext
            // 
            this.btnScheduleNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScheduleNext.BackgroundImage")));
            this.btnScheduleNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScheduleNext.FlatAppearance.BorderSize = 0;
            this.btnScheduleNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleNext.Location = new System.Drawing.Point(505, 2);
            this.btnScheduleNext.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnScheduleNext.Name = "btnScheduleNext";
            this.btnScheduleNext.Size = new System.Drawing.Size(145, 44);
            this.btnScheduleNext.TabIndex = 1;
            this.btnScheduleNext.Text = ">";
            this.btnScheduleNext.UseVisualStyleBackColor = true;
            this.btnScheduleNext.Click += new System.EventHandler(this.btnScheduleNext_Click);
            // 
            // btnScheduleLast
            // 
            this.btnScheduleLast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScheduleLast.BackgroundImage")));
            this.btnScheduleLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScheduleLast.FlatAppearance.BorderSize = 0;
            this.btnScheduleLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleLast.Location = new System.Drawing.Point(687, 2);
            this.btnScheduleLast.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnScheduleLast.Name = "btnScheduleLast";
            this.btnScheduleLast.Size = new System.Drawing.Size(171, 44);
            this.btnScheduleLast.TabIndex = 0;
            this.btnScheduleLast.Text = ">|";
            this.btnScheduleLast.UseVisualStyleBackColor = true;
            this.btnScheduleLast.Click += new System.EventHandler(this.btnScheduleLast_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAverage);
            this.panel1.Controls.Add(this.btnCountSchedules);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1043, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 378);
            this.panel1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(83, 329);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAverage.BackgroundImage")));
            this.btnAverage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAverage.FlatAppearance.BorderSize = 0;
            this.btnAverage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAverage.Location = new System.Drawing.Point(32, 196);
            this.btnAverage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(245, 64);
            this.btnAverage.TabIndex = 2;
            this.btnAverage.Text = "Average Scheduled appointment per Donor";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnCountSchedules
            // 
            this.btnCountSchedules.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCountSchedules.BackgroundImage")));
            this.btnCountSchedules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCountSchedules.FlatAppearance.BorderSize = 0;
            this.btnCountSchedules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCountSchedules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnCountSchedules.Location = new System.Drawing.Point(29, 112);
            this.btnCountSchedules.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCountSchedules.Name = "btnCountSchedules";
            this.btnCountSchedules.Size = new System.Drawing.Size(248, 63);
            this.btnCountSchedules.TabIndex = 1;
            this.btnCountSchedules.Text = "Count Schedules per Donor";
            this.btnCountSchedules.UseVisualStyleBackColor = true;
            this.btnCountSchedules.Click += new System.EventHandler(this.btnCountSchedules_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filters/sorting:";
            // 
            // pnlSchedule
            // 
            this.pnlSchedule.BackColor = System.Drawing.Color.Transparent;
            this.pnlSchedule.Controls.Add(this.btnDeleteSchedule);
            this.pnlSchedule.Controls.Add(this.btnAppChanges);
            this.pnlSchedule.Controls.Add(this.chkAttended);
            this.pnlSchedule.Controls.Add(this.txtSearchByUser);
            this.pnlSchedule.Controls.Add(this.pnlShortStats);
            this.pnlSchedule.Controls.Add(this.btnScheduleUserSearch);
            this.pnlSchedule.Controls.Add(this.redDisplay);
            this.pnlSchedule.Location = new System.Drawing.Point(15, 402);
            this.pnlSchedule.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlSchedule.Name = "pnlSchedule";
            this.pnlSchedule.Size = new System.Drawing.Size(1341, 240);
            this.pnlSchedule.TabIndex = 1;
            // 
            // btnDeleteSchedule
            // 
            this.btnDeleteSchedule.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteSchedule.BackgroundImage")));
            this.btnDeleteSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteSchedule.FlatAppearance.BorderSize = 0;
            this.btnDeleteSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnDeleteSchedule.Location = new System.Drawing.Point(431, 10);
            this.btnDeleteSchedule.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDeleteSchedule.Name = "btnDeleteSchedule";
            this.btnDeleteSchedule.Size = new System.Drawing.Size(165, 39);
            this.btnDeleteSchedule.TabIndex = 9;
            this.btnDeleteSchedule.Text = "Delete record";
            this.btnDeleteSchedule.UseVisualStyleBackColor = true;
            this.btnDeleteSchedule.Click += new System.EventHandler(this.btnDeleteSchedule_Click);
            // 
            // btnAppChanges
            // 
            this.btnAppChanges.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackBlue;
            this.btnAppChanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAppChanges.FlatAppearance.BorderSize = 0;
            this.btnAppChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnAppChanges.Location = new System.Drawing.Point(227, 10);
            this.btnAppChanges.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAppChanges.Name = "btnAppChanges";
            this.btnAppChanges.Size = new System.Drawing.Size(165, 38);
            this.btnAppChanges.TabIndex = 8;
            this.btnAppChanges.Text = "Apply changes";
            this.btnAppChanges.UseVisualStyleBackColor = true;
            this.btnAppChanges.Click += new System.EventHandler(this.btnAppChanges_Click);
            // 
            // chkAttended
            // 
            this.chkAttended.AutoSize = true;
            this.chkAttended.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.scheduleBindingSource, "Attended", true));
            this.chkAttended.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.chkAttended.ForeColor = System.Drawing.Color.White;
            this.chkAttended.Location = new System.Drawing.Point(83, 17);
            this.chkAttended.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.chkAttended.Name = "chkAttended";
            this.chkAttended.Size = new System.Drawing.Size(97, 24);
            this.chkAttended.TabIndex = 7;
            this.chkAttended.Text = "Attended";
            this.chkAttended.UseVisualStyleBackColor = true;
            // 
            // txtSearchByUser
            // 
            this.txtSearchByUser.Location = new System.Drawing.Point(821, 20);
            this.txtSearchByUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchByUser.Name = "txtSearchByUser";
            this.txtSearchByUser.Size = new System.Drawing.Size(165, 22);
            this.txtSearchByUser.TabIndex = 5;
            this.txtSearchByUser.Enter += new System.EventHandler(this.txtSearchByUser_Enter);
            this.txtSearchByUser.Leave += new System.EventHandler(this.txtSearchByUser_Leave);
            // 
            // pnlShortStats
            // 
            this.pnlShortStats.BackColor = System.Drawing.Color.Transparent;
            this.pnlShortStats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlShortStats.Controls.Add(this.lblUnattended);
            this.pnlShortStats.Controls.Add(this.lblAttended);
            this.pnlShortStats.Controls.Add(this.lblSchedules);
            this.pnlShortStats.Controls.Add(this.lblShortStats);
            this.pnlShortStats.Location = new System.Drawing.Point(8, 57);
            this.pnlShortStats.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlShortStats.Name = "pnlShortStats";
            this.pnlShortStats.Size = new System.Drawing.Size(1009, 173);
            this.pnlShortStats.TabIndex = 1;
            // 
            // lblUnattended
            // 
            this.lblUnattended.AutoSize = true;
            this.lblUnattended.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblUnattended.ForeColor = System.Drawing.Color.White;
            this.lblUnattended.Location = new System.Drawing.Point(16, 116);
            this.lblUnattended.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUnattended.Name = "lblUnattended";
            this.lblUnattended.Size = new System.Drawing.Size(253, 20);
            this.lblUnattended.TabIndex = 3;
            this.lblUnattended.Text = "Number of schedules unattended: ";
            // 
            // lblAttended
            // 
            this.lblAttended.AutoSize = true;
            this.lblAttended.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblAttended.ForeColor = System.Drawing.Color.White;
            this.lblAttended.Location = new System.Drawing.Point(16, 81);
            this.lblAttended.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAttended.Name = "lblAttended";
            this.lblAttended.Size = new System.Drawing.Size(231, 20);
            this.lblAttended.TabIndex = 2;
            this.lblAttended.Text = "Number of schedules attended:";
            // 
            // lblSchedules
            // 
            this.lblSchedules.AutoSize = true;
            this.lblSchedules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblSchedules.ForeColor = System.Drawing.Color.White;
            this.lblSchedules.Location = new System.Drawing.Point(16, 48);
            this.lblSchedules.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSchedules.Name = "lblSchedules";
            this.lblSchedules.Size = new System.Drawing.Size(302, 20);
            this.lblSchedules.TabIndex = 1;
            this.lblSchedules.Text = "Total number of scheduled appointments:";
            // 
            // lblShortStats
            // 
            this.lblShortStats.AutoSize = true;
            this.lblShortStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortStats.ForeColor = System.Drawing.Color.White;
            this.lblShortStats.Location = new System.Drawing.Point(16, 15);
            this.lblShortStats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShortStats.Name = "lblShortStats";
            this.lblShortStats.Size = new System.Drawing.Size(146, 20);
            this.lblShortStats.TabIndex = 0;
            this.lblShortStats.Text = "Short Statistics:";
            // 
            // btnScheduleUserSearch
            // 
            this.btnScheduleUserSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScheduleUserSearch.BackgroundImage")));
            this.btnScheduleUserSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScheduleUserSearch.FlatAppearance.BorderSize = 0;
            this.btnScheduleUserSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleUserSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnScheduleUserSearch.Location = new System.Drawing.Point(633, 10);
            this.btnScheduleUserSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnScheduleUserSearch.Name = "btnScheduleUserSearch";
            this.btnScheduleUserSearch.Size = new System.Drawing.Size(165, 39);
            this.btnScheduleUserSearch.TabIndex = 3;
            this.btnScheduleUserSearch.Text = "Search by User";
            this.btnScheduleUserSearch.UseVisualStyleBackColor = true;
            this.btnScheduleUserSearch.Click += new System.EventHandler(this.btnScheduleUserSearch_Click);
            // 
            // redDisplay
            // 
            this.redDisplay.Location = new System.Drawing.Point(1027, 5);
            this.redDisplay.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.redDisplay.Name = "redDisplay";
            this.redDisplay.Size = new System.Drawing.Size(308, 224);
            this.redDisplay.TabIndex = 2;
            this.redDisplay.Text = "";
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AutoGenerateColumns = false;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.dgvSchedule.DataSource = this.scheduleBindingSource;
            this.dgvSchedule.Location = new System.Drawing.Point(15, 9);
            this.dgvSchedule.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowHeadersWidth = 51;
            this.dgvSchedule.Size = new System.Drawing.Size(1019, 321);
            this.dgvSchedule.TabIndex = 0;
            // 
            // tpgStats
            // 
            this.tpgStats.Controls.Add(this.chtUserSchedule);
            this.tpgStats.Controls.Add(this.chtBloodType);
            this.tpgStats.Location = new System.Drawing.Point(4, 25);
            this.tpgStats.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tpgStats.Name = "tpgStats";
            this.tpgStats.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgStats.Size = new System.Drawing.Size(1381, 650);
            this.tpgStats.TabIndex = 4;
            this.tpgStats.Text = "     Statistics     ";
            this.tpgStats.UseVisualStyleBackColor = true;
            // 
            // chtUserSchedule
            // 
            chartArea5.Name = "ChartArea1";
            this.chtUserSchedule.ChartAreas.Add(chartArea5);
            legend5.Name = "No. of schedules";
            this.chtUserSchedule.Legends.Add(legend5);
            this.chtUserSchedule.Location = new System.Drawing.Point(715, 6);
            this.chtUserSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chtUserSchedule.Name = "chtUserSchedule";
            this.chtUserSchedule.Size = new System.Drawing.Size(660, 639);
            this.chtUserSchedule.TabIndex = 1;
            // 
            // chtBloodType
            // 
            chartArea6.Name = "ChartArea1";
            this.chtBloodType.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chtBloodType.Legends.Add(legend6);
            this.chtBloodType.Location = new System.Drawing.Point(8, 6);
            this.chtBloodType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chtBloodType.Name = "chtBloodType";
            this.chtBloodType.Size = new System.Drawing.Size(688, 645);
            this.chtBloodType.TabIndex = 0;
            // 
            // insertBloodBtn
            // 
            this.insertBloodBtn.BackColor = System.Drawing.Color.Transparent;
            this.insertBloodBtn.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackBlue;
            this.insertBloodBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.insertBloodBtn.FlatAppearance.BorderSize = 0;
            this.insertBloodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertBloodBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBloodBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.insertBloodBtn.Location = new System.Drawing.Point(271, 168);
            this.insertBloodBtn.Margin = new System.Windows.Forms.Padding(5);
            this.insertBloodBtn.Name = "insertBloodBtn";
            this.insertBloodBtn.Size = new System.Drawing.Size(167, 42);
            this.insertBloodBtn.TabIndex = 13;
            this.insertBloodBtn.Text = "Insert Blood Unit";
            this.insertBloodBtn.UseVisualStyleBackColor = false;
            this.insertBloodBtn.Click += new System.EventHandler(this.insertBloodBtn_Click);
            // 
            // insertBloodGrp
            // 
            this.insertBloodGrp.Controls.Add(this.insertBloodTypeTBox);
            this.insertBloodGrp.Controls.Add(this.bldTypLbl);
            this.insertBloodGrp.Controls.Add(this.insertBloodBtn);
            this.insertBloodGrp.Controls.Add(this.insDTPicker);
            this.insertBloodGrp.Controls.Add(this.expDateLbl);
            this.insertBloodGrp.Controls.Add(this.AppIDLbl);
            this.insertBloodGrp.Controls.Add(this.insAppIDTBox);
            this.insertBloodGrp.Controls.Add(this.userIDLbl);
            this.insertBloodGrp.Controls.Add(this.insUserIDTBox);
            this.insertBloodGrp.Controls.Add(this.unitIDLbl);
            this.insertBloodGrp.Controls.Add(this.insUnitIDTBox);
            this.insertBloodGrp.Location = new System.Drawing.Point(711, 3);
            this.insertBloodGrp.Name = "insertBloodGrp";
            this.insertBloodGrp.Size = new System.Drawing.Size(508, 236);
            this.insertBloodGrp.TabIndex = 14;
            this.insertBloodGrp.TabStop = false;
            this.insertBloodGrp.Text = "Insert Blood Details";
            // 
            // insUnitIDTBox
            // 
            this.insUnitIDTBox.Location = new System.Drawing.Point(22, 48);
            this.insUnitIDTBox.Name = "insUnitIDTBox";
            this.insUnitIDTBox.Size = new System.Drawing.Size(185, 22);
            this.insUnitIDTBox.TabIndex = 0;
            // 
            // unitIDLbl
            // 
            this.unitIDLbl.AutoSize = true;
            this.unitIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.unitIDLbl.ForeColor = System.Drawing.Color.Black;
            this.unitIDLbl.Location = new System.Drawing.Point(75, 23);
            this.unitIDLbl.Name = "unitIDLbl";
            this.unitIDLbl.Size = new System.Drawing.Size(64, 22);
            this.unitIDLbl.TabIndex = 1;
            this.unitIDLbl.Text = "Unit ID";
            // 
            // userIDLbl
            // 
            this.userIDLbl.AutoSize = true;
            this.userIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.userIDLbl.ForeColor = System.Drawing.Color.Black;
            this.userIDLbl.Location = new System.Drawing.Point(69, 90);
            this.userIDLbl.Name = "userIDLbl";
            this.userIDLbl.Size = new System.Drawing.Size(70, 22);
            this.userIDLbl.TabIndex = 3;
            this.userIDLbl.Text = "User ID";
            // 
            // insUserIDTBox
            // 
            this.insUserIDTBox.Location = new System.Drawing.Point(22, 115);
            this.insUserIDTBox.Name = "insUserIDTBox";
            this.insUserIDTBox.Size = new System.Drawing.Size(185, 22);
            this.insUserIDTBox.TabIndex = 2;
            this.insUserIDTBox.Leave += new System.EventHandler(this.insUserIDTBox_Leave);
            // 
            // AppIDLbl
            // 
            this.AppIDLbl.AutoSize = true;
            this.AppIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.AppIDLbl.ForeColor = System.Drawing.Color.Black;
            this.AppIDLbl.Location = new System.Drawing.Point(75, 157);
            this.AppIDLbl.Name = "AppIDLbl";
            this.AppIDLbl.Size = new System.Drawing.Size(64, 22);
            this.AppIDLbl.TabIndex = 5;
            this.AppIDLbl.Text = "App ID";
            // 
            // insAppIDTBox
            // 
            this.insAppIDTBox.Location = new System.Drawing.Point(21, 182);
            this.insAppIDTBox.Name = "insAppIDTBox";
            this.insAppIDTBox.Size = new System.Drawing.Size(185, 22);
            this.insAppIDTBox.TabIndex = 4;
            this.insAppIDTBox.TextChanged += new System.EventHandler(this.insAppIDTBox_TextChanged);
            // 
            // expDateLbl
            // 
            this.expDateLbl.AutoSize = true;
            this.expDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.expDateLbl.ForeColor = System.Drawing.Color.Black;
            this.expDateLbl.Location = new System.Drawing.Point(301, 95);
            this.expDateLbl.Name = "expDateLbl";
            this.expDateLbl.Size = new System.Drawing.Size(103, 22);
            this.expDateLbl.TabIndex = 7;
            this.expDateLbl.Text = "Expiry Date";
            // 
            // insDTPicker
            // 
            this.insDTPicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBloodInventoryBindingSource, "ExpiryDate", true));
            this.insDTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.insDTPicker.Location = new System.Drawing.Point(271, 122);
            this.insDTPicker.Margin = new System.Windows.Forms.Padding(5);
            this.insDTPicker.Name = "insDTPicker";
            this.insDTPicker.Size = new System.Drawing.Size(173, 22);
            this.insDTPicker.TabIndex = 8;
            // 
            // bldTypLbl
            // 
            this.bldTypLbl.AutoSize = true;
            this.bldTypLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.bldTypLbl.ForeColor = System.Drawing.Color.Black;
            this.bldTypLbl.Location = new System.Drawing.Point(313, 23);
            this.bldTypLbl.Name = "bldTypLbl";
            this.bldTypLbl.Size = new System.Drawing.Size(102, 22);
            this.bldTypLbl.TabIndex = 10;
            this.bldTypLbl.Text = "Blood Type";
            // 
            // insertBloodTypeTBox
            // 
            this.insertBloodTypeTBox.Location = new System.Drawing.Point(271, 48);
            this.insertBloodTypeTBox.Name = "insertBloodTypeTBox";
            this.insertBloodTypeTBox.ReadOnly = true;
            this.insertBloodTypeTBox.Size = new System.Drawing.Size(185, 22);
            this.insertBloodTypeTBox.TabIndex = 14;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tblUsers";
            this.tblUsersBindingSource.DataSource = this.ist2jwDataSet;
            // 
            // ist2jwDataSet
            // 
            this.ist2jwDataSet.DataSetName = "ist2jwDataSet";
            this.ist2jwDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBloodInventoryBindingSource
            // 
            this.tblBloodInventoryBindingSource.DataMember = "TblBloodInventory";
            this.tblBloodInventoryBindingSource.DataSource = this.ist2jwDataSet;
            // 
            // unitIDDataGridViewTextBoxColumn
            // 
            this.unitIDDataGridViewTextBoxColumn.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn.HeaderText = "UnitID";
            this.unitIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
            this.unitIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIDDataGridViewTextBoxColumn1
            // 
            this.userIDDataGridViewTextBoxColumn1.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn1.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn1.Name = "userIDDataGridViewTextBoxColumn1";
            this.userIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // appIDDataGridViewTextBoxColumn
            // 
            this.appIDDataGridViewTextBoxColumn.DataPropertyName = "AppID";
            this.appIDDataGridViewTextBoxColumn.HeaderText = "AppID";
            this.appIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appIDDataGridViewTextBoxColumn.Name = "appIDDataGridViewTextBoxColumn";
            this.appIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bloodTypeDataGridViewTextBoxColumn1
            // 
            this.bloodTypeDataGridViewTextBoxColumn1.DataPropertyName = "BloodType";
            this.bloodTypeDataGridViewTextBoxColumn1.HeaderText = "BloodType";
            this.bloodTypeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.bloodTypeDataGridViewTextBoxColumn1.Name = "bloodTypeDataGridViewTextBoxColumn1";
            this.bloodTypeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // expiryDateDataGridViewTextBoxColumn
            // 
            this.expiryDateDataGridViewTextBoxColumn.DataPropertyName = "ExpiryDate";
            this.expiryDateDataGridViewTextBoxColumn.HeaderText = "ExpiryDate";
            this.expiryDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expiryDateDataGridViewTextBoxColumn.Name = "expiryDateDataGridViewTextBoxColumn";
            this.expiryDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AppID";
            this.dataGridViewTextBoxColumn4.HeaderText = "AppID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AppDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "AppDate";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn6.HeaderText = "Time";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Capacity";
            this.dataGridViewTextBoxColumn7.HeaderText = "Capacity";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Venue";
            this.dataGridViewTextBoxColumn8.HeaderText = "Venue";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "Appointment";
            this.appointmentBindingSource.DataSource = this.ist2jwDataSet;
            // 
            // userIDDataGridViewTextBoxColumn2
            // 
            this.userIDDataGridViewTextBoxColumn2.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn2.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn2.Name = "userIDDataGridViewTextBoxColumn2";
            this.userIDDataGridViewTextBoxColumn2.Width = 125;
            // 
            // schedulesDataGridViewTextBoxColumn
            // 
            this.schedulesDataGridViewTextBoxColumn.DataPropertyName = "Schedules";
            this.schedulesDataGridViewTextBoxColumn.HeaderText = "Schedules";
            this.schedulesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.schedulesDataGridViewTextBoxColumn.Name = "schedulesDataGridViewTextBoxColumn";
            this.schedulesDataGridViewTextBoxColumn.ReadOnly = true;
            this.schedulesDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblTotalScheduleBindingSource
            // 
            this.tblTotalScheduleBindingSource.DataMember = "tblTotalSchedule";
            this.tblTotalScheduleBindingSource.DataSource = this.ist2jwDataSet;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TotalSchedules";
            this.dataGridViewTextBoxColumn9.HeaderText = "TotalSchedules";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "UsersWithSchedules";
            this.dataGridViewTextBoxColumn10.HeaderText = "UsersWithSchedules";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "AverageSchedulesPerUser";
            this.dataGridViewTextBoxColumn11.HeaderText = "AverageSchedulesPerUser";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // tblAverageScheduleBindingSource
            // 
            this.tblAverageScheduleBindingSource.DataMember = "tblAverageSchedule";
            this.tblAverageScheduleBindingSource.DataSource = this.ist2jwDataSet;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataMember = "Schedule";
            this.scheduleBindingSource.DataSource = this.ist2jwDataSet;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ScheduleID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ScheduleID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn2.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AppID";
            this.dataGridViewTextBoxColumn3.HeaderText = "AppID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Attended";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Attended";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // tblBloodInventoryTableAdapter
            // 
            this.tblBloodInventoryTableAdapter.ClearBeforeFill = true;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // scheduleTableAdapter
            // 
            this.scheduleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentTableAdapter = this.appointmentTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ScheduleTableAdapter = this.scheduleTableAdapter;
            this.tableAdapterManager.TblBloodInventoryTableAdapter = this.tblBloodInventoryTableAdapter;
            this.tableAdapterManager.tblUsersTableAdapter = this.tblUsersTableAdapter;
            this.tableAdapterManager.UpdateOrder = BloodBankSystem.ist2jwDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblTotalScheduleTableAdapter
            // 
            this.tblTotalScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // tblAverageScheduleTableAdapter
            // 
            this.tblAverageScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User ID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDNumberDataGridViewTextBoxColumn
            // 
            this.iDNumberDataGridViewTextBoxColumn.DataPropertyName = "IDNumber";
            this.iDNumberDataGridViewTextBoxColumn.HeaderText = "ID Number";
            this.iDNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDNumberDataGridViewTextBoxColumn.Name = "iDNumberDataGridViewTextBoxColumn";
            this.iDNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "User Type";
            this.userTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            // 
            // bloodTypeDataGridViewTextBoxColumn
            // 
            this.bloodTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.bloodTypeDataGridViewTextBoxColumn.DataPropertyName = "BloodType";
            this.bloodTypeDataGridViewTextBoxColumn.HeaderText = "Blood Type";
            this.bloodTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bloodTypeDataGridViewTextBoxColumn.Name = "bloodTypeDataGridViewTextBoxColumn";
            this.bloodTypeDataGridViewTextBoxColumn.Width = 107;
            // 
            // isActiveAccountDataGridViewCheckBoxColumn
            // 
            this.isActiveAccountDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.isActiveAccountDataGridViewCheckBoxColumn.DataPropertyName = "isActiveAccount";
            this.isActiveAccountDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.isActiveAccountDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isActiveAccountDataGridViewCheckBoxColumn.Name = "isActiveAccountDataGridViewCheckBoxColumn";
            this.isActiveAccountDataGridViewCheckBoxColumn.Width = 50;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BloodBankSystem.Properties.Resources.MainBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1403, 747);
            this.Controls.Add(this.tcAdmin);
            this.Controls.Add(this.pnlTopBar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.tpgAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).EndInit();
            this.pnlAppFilters.ResumeLayout(false);
            this.pnlAppFilters.PerformLayout();
            this.pnlRemoveAppFilters.ResumeLayout(false);
            this.pnlAppNav.ResumeLayout(false);
            this.pnlAppEdit.ResumeLayout(false);
            this.pnlAppEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnCapacity)).EndInit();
            this.tpgBlood.ResumeLayout(false);
            this.pnlRemoveBloodFilters.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.pnlBloodNav.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlood)).EndInit();
            this.tpgUsers.ResumeLayout(false);
            this.pnlRemoveUserFilters.ResumeLayout(false);
            this.pnlUserNav.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.pnlUserEdit.ResumeLayout(false);
            this.pnlUserEdit.PerformLayout();
            this.tcAdmin.ResumeLayout(false);
            this.tpgSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAverage)).EndInit();
            this.pnlScheduleNav.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSchedule.ResumeLayout(false);
            this.pnlSchedule.PerformLayout();
            this.pnlShortStats.ResumeLayout(false);
            this.pnlShortStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.tpgStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtUserSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtBloodType)).EndInit();
            this.insertBloodGrp.ResumeLayout(false);
            this.insertBloodGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2jwDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBloodInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTotalScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAverageScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblAdminDash;
        private ist2jwDataSet ist2jwDataSet;
        private ist2jwDataSetTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private System.Windows.Forms.BindingSource tblBloodInventoryBindingSource;
        private ist2jwDataSetTableAdapters.TblBloodInventoryTableAdapter tblBloodInventoryTableAdapter;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private ist2jwDataSetTableAdapters.AppointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.TabPage tpgAppointments;
        private System.Windows.Forms.Panel pnlAppFilters;
        private System.Windows.Forms.Button btnCapSortDesc;
        private System.Windows.Forms.Button btnCapSortAsc;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel pnlRemoveAppFilters;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Panel pnlAppNav;
        private System.Windows.Forms.Button btnAppLast;
        private System.Windows.Forms.Button btnAppFirst;
        private System.Windows.Forms.Button btnAppPrev;
        private System.Windows.Forms.Button btnAppNext;
        private System.Windows.Forms.Panel pnlAppEdit;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblAppointmentTime;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.Button btnAppDelete;
        private System.Windows.Forms.Button btnUpdateApp;
        private System.Windows.Forms.NumericUpDown spnCapacity;
        private System.Windows.Forms.DateTimePicker dtpAppDate;
        private System.Windows.Forms.TextBox txtAppID;
        private System.Windows.Forms.TabPage tpgBlood;
        private System.Windows.Forms.Panel pnlRemoveBloodFilters;
        private System.Windows.Forms.Button btnRemoveBloodFilters;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel pnlBloodNav;
        private System.Windows.Forms.Button btnBloodLast;
        private System.Windows.Forms.Button btnBloodFirst;
        private System.Windows.Forms.Button btnBloodPrev;
        private System.Windows.Forms.Button btnBllodNext;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBloodExpiryDate;
        private System.Windows.Forms.Label lblBloodUserID;
        private System.Windows.Forms.Label lblBloodAppID;
        private System.Windows.Forms.Label lblTypeBlood;
        private System.Windows.Forms.Label lblUnitID;
        private System.Windows.Forms.Button btnBloodDelete;
        private System.Windows.Forms.Button btnBloodApply;
        private System.Windows.Forms.DateTimePicker dtpExpiry;
        private System.Windows.Forms.ComboBox cmbBloodInvType;
        private System.Windows.Forms.TextBox txtBloodAppID;
        private System.Windows.Forms.TextBox txtBloodUserID;
        private System.Windows.Forms.TextBox txtUnitID;
        private System.Windows.Forms.DataGridView dgvBlood;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn appIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tpgUsers;
        private System.Windows.Forms.Panel pnlRemoveUserFilters;
        private System.Windows.Forms.Button btnRemoveFilter;
        private System.Windows.Forms.Panel pnlUserNav;
        private System.Windows.Forms.Button btnUserLast;
        private System.Windows.Forms.Button btnUserFirst;
        private System.Windows.Forms.Button btnUserPrev;
        private System.Windows.Forms.Button btnUserNext;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmbUserFilter;
        private System.Windows.Forms.Button btnUserFilter;
        private System.Windows.Forms.ComboBox cmbBloodFilter;
        private System.Windows.Forms.Button btnBloodFilter;
        private System.Windows.Forms.Button btnSurnameAlphabetical;
        private System.Windows.Forms.Button btnNameAlphabetical;
        private System.Windows.Forms.Button btnFilterInactive;
        private System.Windows.Forms.Button btnFilterActive;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel pnlUserEdit;
        private System.Windows.Forms.Button btnInsertUser;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblIDNum;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.ComboBox cmbBlood;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.Button btnAppInsert;
        private System.Windows.Forms.TabPage tpgSchedule;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private ist2jwDataSetTableAdapters.ScheduleTableAdapter scheduleTableAdapter;
        private ist2jwDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.Panel pnlSchedule;
        private System.Windows.Forms.Panel pnlShortStats;
        private System.Windows.Forms.Label lblUnattended;
        private System.Windows.Forms.Label lblAttended;
        private System.Windows.Forms.Label lblSchedules;
        private System.Windows.Forms.Label lblShortStats;
        private System.Windows.Forms.DataGridView appointmentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnScheduleUserSearch;
        private System.Windows.Forms.RichTextBox redDisplay;
        private System.Windows.Forms.Button btnStartInsert;
        private System.Windows.Forms.Button btnCancelInsert;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.MaskedTextBox mtxtTime;
        private System.Windows.Forms.Button btnFilterPassed;
        private System.Windows.Forms.Button btnFilterUpcoming;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtSearchByUser;
        private System.Windows.Forms.Button btnEarlyExpiry;
        private System.Windows.Forms.Button btnLaterExpiry;
        private System.Windows.Forms.DateTimePicker dtpExpiryFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCountSchedules;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.CheckBox chkAttended;
        private System.Windows.Forms.Button btnAppChanges;
        private System.Windows.Forms.Button btnStartAppInsert;
        private System.Windows.Forms.Panel pnlScheduleNav;
        private System.Windows.Forms.Button btnScheduleFirst;
        private System.Windows.Forms.Button btnSchedulePrev;
        private System.Windows.Forms.Button btnScheduleNext;
        private System.Windows.Forms.Button btnScheduleLast;
        private System.Windows.Forms.Button btnCancelAppInsert;
        private System.Windows.Forms.Button btnDeleteSchedule;
        private System.Windows.Forms.TabPage tpgStats;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtBloodType;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtUserSchedule;
        private System.Windows.Forms.Button btnHomepage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource tblTotalScheduleBindingSource;
        private ist2jwDataSetTableAdapters.tblTotalScheduleTableAdapter tblTotalScheduleTableAdapter;
        private System.Windows.Forms.DataGridView dgvTotalSchedule;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tblAverageScheduleBindingSource;
        private ist2jwDataSetTableAdapters.tblAverageScheduleTableAdapter tblAverageScheduleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn schedulesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button donorRankingFilterBtn;
        private System.Windows.Forms.Button no1DonorFilterBtn;
        private System.Windows.Forms.Button insertBloodBtn;
        private System.Windows.Forms.GroupBox insertBloodGrp;
        private System.Windows.Forms.Label userIDLbl;
        private System.Windows.Forms.TextBox insUserIDTBox;
        private System.Windows.Forms.Label unitIDLbl;
        private System.Windows.Forms.TextBox insUnitIDTBox;
        private System.Windows.Forms.Label AppIDLbl;
        private System.Windows.Forms.TextBox insAppIDTBox;
        private System.Windows.Forms.Label bldTypLbl;
        private System.Windows.Forms.DateTimePicker insDTPicker;
        private System.Windows.Forms.Label expDateLbl;
        private System.Windows.Forms.TextBox insertBloodTypeTBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveAccountDataGridViewCheckBoxColumn;
    }
}