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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnHomepage = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblAdminDash = new System.Windows.Forms.Label();
            this.tpgAppointments = new System.Windows.Forms.TabPage();
            this.appointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ist2jwDataSet = new BloodBankSystem.ist2jwDataSet();
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
            this.tblBloodInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbBloodInvType = new System.Windows.Forms.ComboBox();
            this.txtBloodAppID = new System.Windows.Forms.TextBox();
            this.txtBloodUserID = new System.Windows.Forms.TextBox();
            this.txtUnitID = new System.Windows.Forms.TextBox();
            this.dgvBlood = new System.Windows.Forms.DataGridView();
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveAccountDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.userIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schedulesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTotalScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvAverage = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAverageScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSearchByUser = new System.Windows.Forms.TextBox();
            this.pnlShortStats = new System.Windows.Forms.Panel();
            this.lblUnattended = new System.Windows.Forms.Label();
            this.lblAttended = new System.Windows.Forms.Label();
            this.lblSchedules = new System.Windows.Forms.Label();
            this.lblShortStats = new System.Windows.Forms.Label();
            this.btnScheduleUserSearch = new System.Windows.Forms.Button();
            this.redDisplay = new System.Windows.Forms.RichTextBox();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tpgStats = new System.Windows.Forms.TabPage();
            this.chtUserSchedule = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtBloodType = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tblUsersTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.tblUsersTableAdapter();
            this.tblBloodInventoryTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.TblBloodInventoryTableAdapter();
            this.appointmentTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.AppointmentTableAdapter();
            this.scheduleTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.ScheduleTableAdapter();
            this.tableAdapterManager = new BloodBankSystem.ist2jwDataSetTableAdapters.TableAdapterManager();
            this.tblTotalScheduleTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.tblTotalScheduleTableAdapter();
            this.tblAverageScheduleTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.tblAverageScheduleTableAdapter();
            this.pnlTopBar.SuspendLayout();
            this.tpgAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2jwDataSet)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.tblBloodInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlood)).BeginInit();
            this.tpgUsers.SuspendLayout();
            this.pnlRemoveUserFilters.SuspendLayout();
            this.pnlUserNav.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            this.pnlUserEdit.SuspendLayout();
            this.tcAdmin.SuspendLayout();
            this.tpgSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTotalScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAverageScheduleBindingSource)).BeginInit();
            this.pnlScheduleNav.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            this.pnlShortStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.tpgStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtUserSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtBloodType)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlTopBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTopBar.Controls.Add(this.btnHomepage);
            this.pnlTopBar.Controls.Add(this.btnLogout);
            this.pnlTopBar.Controls.Add(this.lblAdminDash);
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1052, 40);
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
            this.btnHomepage.Location = new System.Drawing.Point(889, 2);
            this.btnHomepage.Margin = new System.Windows.Forms.Padding(2);
            this.btnHomepage.Name = "btnHomepage";
            this.btnHomepage.Size = new System.Drawing.Size(156, 29);
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
            this.btnLogout.Location = new System.Drawing.Point(3, 4);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(101, 31);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblAdminDash
            // 
            this.lblAdminDash.AutoSize = true;
            this.lblAdminDash.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminDash.Location = new System.Drawing.Point(446, 6);
            this.lblAdminDash.Name = "lblAdminDash";
            this.lblAdminDash.Size = new System.Drawing.Size(249, 24);
            this.lblAdminDash.TabIndex = 0;
            this.lblAdminDash.Text = "Administrator Dashboard";
            // 
            // tpgAppointments
            // 
            this.tpgAppointments.AutoScroll = true;
            this.tpgAppointments.Controls.Add(this.appointmentDataGridView);
            this.tpgAppointments.Controls.Add(this.pnlAppFilters);
            this.tpgAppointments.Controls.Add(this.pnlRemoveAppFilters);
            this.tpgAppointments.Controls.Add(this.pnlAppNav);
            this.tpgAppointments.Controls.Add(this.pnlAppEdit);
            this.tpgAppointments.Location = new System.Drawing.Point(4, 22);
            this.tpgAppointments.Margin = new System.Windows.Forms.Padding(4);
            this.tpgAppointments.Name = "tpgAppointments";
            this.tpgAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tpgAppointments.Size = new System.Drawing.Size(1034, 526);
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
            this.appointmentDataGridView.Location = new System.Drawing.Point(9, 10);
            this.appointmentDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.appointmentDataGridView.Name = "appointmentDataGridView";
            this.appointmentDataGridView.RowHeadersWidth = 51;
            this.appointmentDataGridView.Size = new System.Drawing.Size(745, 272);
            this.appointmentDataGridView.TabIndex = 9;
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
            // ist2jwDataSet
            // 
            this.ist2jwDataSet.DataSetName = "ist2jwDataSet";
            this.ist2jwDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlAppFilters
            // 
            this.pnlAppFilters.AutoScroll = true;
            this.pnlAppFilters.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlAppFilters.Controls.Add(this.btnFilterPassed);
            this.pnlAppFilters.Controls.Add(this.btnFilterUpcoming);
            this.pnlAppFilters.Controls.Add(this.btnCapSortDesc);
            this.pnlAppFilters.Controls.Add(this.btnCapSortAsc);
            this.pnlAppFilters.Controls.Add(this.label21);
            this.pnlAppFilters.Location = new System.Drawing.Point(776, 7);
            this.pnlAppFilters.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAppFilters.Name = "pnlAppFilters";
            this.pnlAppFilters.Size = new System.Drawing.Size(244, 467);
            this.pnlAppFilters.TabIndex = 9;
            // 
            // btnFilterPassed
            // 
            this.btnFilterPassed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFilterPassed.BackgroundImage")));
            this.btnFilterPassed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilterPassed.FlatAppearance.BorderSize = 0;
            this.btnFilterPassed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterPassed.Location = new System.Drawing.Point(8, 166);
            this.btnFilterPassed.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilterPassed.Name = "btnFilterPassed";
            this.btnFilterPassed.Size = new System.Drawing.Size(171, 25);
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
            this.btnFilterUpcoming.Location = new System.Drawing.Point(8, 124);
            this.btnFilterUpcoming.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilterUpcoming.Name = "btnFilterUpcoming";
            this.btnFilterUpcoming.Size = new System.Drawing.Size(171, 28);
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
            this.btnCapSortDesc.Location = new System.Drawing.Point(8, 82);
            this.btnCapSortDesc.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapSortDesc.Name = "btnCapSortDesc";
            this.btnCapSortDesc.Size = new System.Drawing.Size(171, 27);
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
            this.btnCapSortAsc.Location = new System.Drawing.Point(8, 42);
            this.btnCapSortAsc.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapSortAsc.Name = "btnCapSortAsc";
            this.btnCapSortAsc.Size = new System.Drawing.Size(171, 27);
            this.btnCapSortAsc.TabIndex = 4;
            this.btnCapSortAsc.Text = "Sort by capacity(asc)";
            this.btnCapSortAsc.UseVisualStyleBackColor = true;
            this.btnCapSortAsc.Click += new System.EventHandler(this.btnCapSortAsc_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Filters/sorting:";
            // 
            // pnlRemoveAppFilters
            // 
            this.pnlRemoveAppFilters.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlRemoveAppFilters.Controls.Add(this.button16);
            this.pnlRemoveAppFilters.Location = new System.Drawing.Point(776, 484);
            this.pnlRemoveAppFilters.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRemoveAppFilters.Name = "pnlRemoveAppFilters";
            this.pnlRemoveAppFilters.Size = new System.Drawing.Size(250, 33);
            this.pnlRemoveAppFilters.TabIndex = 8;
            // 
            // button16
            // 
            this.button16.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackRed;
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(68, 4);
            this.button16.Margin = new System.Windows.Forms.Padding(4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(112, 23);
            this.button16.TabIndex = 1;
            this.button16.Text = "Remove";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // pnlAppNav
            // 
            this.pnlAppNav.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlAppNav.Controls.Add(this.btnAppLast);
            this.pnlAppNav.Controls.Add(this.btnAppFirst);
            this.pnlAppNav.Controls.Add(this.btnAppPrev);
            this.pnlAppNav.Controls.Add(this.btnAppNext);
            this.pnlAppNav.Location = new System.Drawing.Point(13, 290);
            this.pnlAppNav.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAppNav.Name = "pnlAppNav";
            this.pnlAppNav.Size = new System.Drawing.Size(741, 36);
            this.pnlAppNav.TabIndex = 7;
            // 
            // btnAppLast
            // 
            this.btnAppLast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAppLast.BackgroundImage")));
            this.btnAppLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAppLast.FlatAppearance.BorderSize = 0;
            this.btnAppLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppLast.Location = new System.Drawing.Point(581, 2);
            this.btnAppLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppLast.Name = "btnAppLast";
            this.btnAppLast.Size = new System.Drawing.Size(123, 30);
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
            this.btnAppFirst.Location = new System.Drawing.Point(4, 2);
            this.btnAppFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppFirst.Name = "btnAppFirst";
            this.btnAppFirst.Size = new System.Drawing.Size(120, 30);
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
            this.btnAppPrev.Location = new System.Drawing.Point(186, 2);
            this.btnAppPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppPrev.Name = "btnAppPrev";
            this.btnAppPrev.Size = new System.Drawing.Size(122, 30);
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
            this.btnAppNext.Location = new System.Drawing.Point(452, 2);
            this.btnAppNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppNext.Name = "btnAppNext";
            this.btnAppNext.Size = new System.Drawing.Size(117, 30);
            this.btnAppNext.TabIndex = 0;
            this.btnAppNext.Text = ">";
            this.btnAppNext.UseVisualStyleBackColor = true;
            this.btnAppNext.Click += new System.EventHandler(this.btnAppNext_Click);
            // 
            // pnlAppEdit
            // 
            this.pnlAppEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.pnlAppEdit.Location = new System.Drawing.Point(13, 343);
            this.pnlAppEdit.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAppEdit.Name = "pnlAppEdit";
            this.pnlAppEdit.Size = new System.Drawing.Size(741, 179);
            this.pnlAppEdit.TabIndex = 1;
            // 
            // btnStartAppInsert
            // 
            this.btnStartAppInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStartAppInsert.BackgroundImage")));
            this.btnStartAppInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartAppInsert.FlatAppearance.BorderSize = 0;
            this.btnStartAppInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartAppInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnStartAppInsert.Location = new System.Drawing.Point(411, 25);
            this.btnStartAppInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartAppInsert.Name = "btnStartAppInsert";
            this.btnStartAppInsert.Size = new System.Drawing.Size(134, 44);
            this.btnStartAppInsert.TabIndex = 14;
            this.btnStartAppInsert.Text = "Insert Appointment";
            this.btnStartAppInsert.UseVisualStyleBackColor = true;
            this.btnStartAppInsert.Click += new System.EventHandler(this.btnStartAppInsert_Click);
            // 
            // mtxtTime
            // 
            this.mtxtTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "Time", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "T"));
            this.mtxtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.mtxtTime.Location = new System.Drawing.Point(147, 85);
            this.mtxtTime.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtTime.Mask = "00:00:00";
            this.mtxtTime.Name = "mtxtTime";
            this.mtxtTime.Size = new System.Drawing.Size(200, 21);
            this.mtxtTime.TabIndex = 13;
            this.mtxtTime.ValidatingType = typeof(System.DateTime);
            // 
            // txtVenue
            // 
            this.txtVenue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "Venue", true));
            this.txtVenue.Location = new System.Drawing.Point(147, 148);
            this.txtVenue.Margin = new System.Windows.Forms.Padding(4);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(204, 20);
            this.txtVenue.TabIndex = 12;
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.Location = new System.Drawing.Point(73, 148);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(49, 16);
            this.lblVenue.TabIndex = 11;
            this.lblVenue.Text = "Venue:";
            // 
            // btnAppInsert
            // 
            this.btnAppInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnAppInsert.Location = new System.Drawing.Point(411, 18);
            this.btnAppInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppInsert.Name = "btnAppInsert";
            this.btnAppInsert.Size = new System.Drawing.Size(134, 38);
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
            this.lblCapacity.Location = new System.Drawing.Point(59, 116);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(63, 16);
            this.lblCapacity.TabIndex = 9;
            this.lblCapacity.Text = "Capacity:";
            // 
            // lblAppointmentTime
            // 
            this.lblAppointmentTime.AutoSize = true;
            this.lblAppointmentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentTime.Location = new System.Drawing.Point(9, 88);
            this.lblAppointmentTime.Name = "lblAppointmentTime";
            this.lblAppointmentTime.Size = new System.Drawing.Size(113, 16);
            this.lblAppointmentTime.TabIndex = 8;
            this.lblAppointmentTime.Text = "Appointment time:";
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDate.Location = new System.Drawing.Point(5, 53);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(117, 16);
            this.lblAppointmentDate.TabIndex = 7;
            this.lblAppointmentDate.Text = "Appointment Date:";
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentID.Location = new System.Drawing.Point(21, 17);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(101, 16);
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
            this.btnAppDelete.Location = new System.Drawing.Point(411, 88);
            this.btnAppDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppDelete.Name = "btnAppDelete";
            this.btnAppDelete.Size = new System.Drawing.Size(134, 36);
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
            this.btnUpdateApp.Location = new System.Drawing.Point(411, 141);
            this.btnUpdateApp.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateApp.Name = "btnUpdateApp";
            this.btnUpdateApp.Size = new System.Drawing.Size(134, 32);
            this.btnUpdateApp.TabIndex = 4;
            this.btnUpdateApp.Text = "Apply changes";
            this.btnUpdateApp.UseVisualStyleBackColor = true;
            this.btnUpdateApp.Click += new System.EventHandler(this.btnUpdateApp_Click);
            // 
            // spnCapacity
            // 
            this.spnCapacity.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentBindingSource, "Capacity", true));
            this.spnCapacity.Location = new System.Drawing.Point(147, 114);
            this.spnCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.spnCapacity.Name = "spnCapacity";
            this.spnCapacity.Size = new System.Drawing.Size(120, 20);
            this.spnCapacity.TabIndex = 3;
            // 
            // dtpAppDate
            // 
            this.dtpAppDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "AppDate", true));
            this.dtpAppDate.Location = new System.Drawing.Point(147, 49);
            this.dtpAppDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAppDate.Name = "dtpAppDate";
            this.dtpAppDate.Size = new System.Drawing.Size(200, 20);
            this.dtpAppDate.TabIndex = 1;
            // 
            // txtAppID
            // 
            this.txtAppID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "AppID", true));
            this.txtAppID.Location = new System.Drawing.Point(147, 16);
            this.txtAppID.Margin = new System.Windows.Forms.Padding(4);
            this.txtAppID.Name = "txtAppID";
            this.txtAppID.ReadOnly = true;
            this.txtAppID.Size = new System.Drawing.Size(100, 20);
            this.txtAppID.TabIndex = 0;
            // 
            // btnCancelAppInsert
            // 
            this.btnCancelAppInsert.Location = new System.Drawing.Point(411, 84);
            this.btnCancelAppInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelAppInsert.Name = "btnCancelAppInsert";
            this.btnCancelAppInsert.Size = new System.Drawing.Size(134, 48);
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
            this.tpgBlood.Location = new System.Drawing.Point(4, 22);
            this.tpgBlood.Margin = new System.Windows.Forms.Padding(4);
            this.tpgBlood.Name = "tpgBlood";
            this.tpgBlood.Padding = new System.Windows.Forms.Padding(3);
            this.tpgBlood.Size = new System.Drawing.Size(1034, 526);
            this.tpgBlood.TabIndex = 1;
            this.tpgBlood.Text = "Blood Inventory";
            this.tpgBlood.UseVisualStyleBackColor = true;
            this.tpgBlood.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // pnlRemoveBloodFilters
            // 
            this.pnlRemoveBloodFilters.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlRemoveBloodFilters.Controls.Add(this.btnRemoveBloodFilters);
            this.pnlRemoveBloodFilters.Location = new System.Drawing.Point(760, 280);
            this.pnlRemoveBloodFilters.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRemoveBloodFilters.Name = "pnlRemoveBloodFilters";
            this.pnlRemoveBloodFilters.Size = new System.Drawing.Size(261, 33);
            this.pnlRemoveBloodFilters.TabIndex = 8;
            // 
            // btnRemoveBloodFilters
            // 
            this.btnRemoveBloodFilters.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackRed;
            this.btnRemoveBloodFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveBloodFilters.FlatAppearance.BorderSize = 0;
            this.btnRemoveBloodFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBloodFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveBloodFilters.Location = new System.Drawing.Point(68, 6);
            this.btnRemoveBloodFilters.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveBloodFilters.Name = "btnRemoveBloodFilters";
            this.btnRemoveBloodFilters.Size = new System.Drawing.Size(122, 23);
            this.btnRemoveBloodFilters.TabIndex = 1;
            this.btnRemoveBloodFilters.Text = "Remove";
            this.btnRemoveBloodFilters.UseVisualStyleBackColor = true;
            this.btnRemoveBloodFilters.Click += new System.EventHandler(this.btnRemoveBloodFilters_Click);
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Controls.Add(this.btnEarlyExpiry);
            this.panel6.Controls.Add(this.btnLaterExpiry);
            this.panel6.Controls.Add(this.dtpExpiryFilter);
            this.panel6.Controls.Add(this.label20);
            this.panel6.Location = new System.Drawing.Point(760, 7);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(261, 265);
            this.panel6.TabIndex = 7;
            // 
            // btnEarlyExpiry
            // 
            this.btnEarlyExpiry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEarlyExpiry.BackgroundImage")));
            this.btnEarlyExpiry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEarlyExpiry.FlatAppearance.BorderSize = 0;
            this.btnEarlyExpiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEarlyExpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEarlyExpiry.Location = new System.Drawing.Point(19, 104);
            this.btnEarlyExpiry.Margin = new System.Windows.Forms.Padding(4);
            this.btnEarlyExpiry.Name = "btnEarlyExpiry";
            this.btnEarlyExpiry.Size = new System.Drawing.Size(171, 32);
            this.btnEarlyExpiry.TabIndex = 3;
            this.btnEarlyExpiry.Text = "Filter by expiry date(Earlier than)";
            this.btnEarlyExpiry.UseVisualStyleBackColor = true;
            this.btnEarlyExpiry.Click += new System.EventHandler(this.btnEarlyExpiry_Click);
            // 
            // btnLaterExpiry
            // 
            this.btnLaterExpiry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLaterExpiry.BackgroundImage")));
            this.btnLaterExpiry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLaterExpiry.FlatAppearance.BorderSize = 0;
            this.btnLaterExpiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaterExpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaterExpiry.Location = new System.Drawing.Point(19, 67);
            this.btnLaterExpiry.Margin = new System.Windows.Forms.Padding(4);
            this.btnLaterExpiry.Name = "btnLaterExpiry";
            this.btnLaterExpiry.Size = new System.Drawing.Size(171, 32);
            this.btnLaterExpiry.TabIndex = 2;
            this.btnLaterExpiry.Text = "Filter by expiry date(Later than)";
            this.btnLaterExpiry.UseVisualStyleBackColor = true;
            this.btnLaterExpiry.Click += new System.EventHandler(this.btnLaterExpiry_Click);
            // 
            // dtpExpiryFilter
            // 
            this.dtpExpiryFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dtpExpiryFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiryFilter.Location = new System.Drawing.Point(92, 37);
            this.dtpExpiryFilter.Margin = new System.Windows.Forms.Padding(4);
            this.dtpExpiryFilter.Name = "dtpExpiryFilter";
            this.dtpExpiryFilter.Size = new System.Drawing.Size(99, 23);
            this.dtpExpiryFilter.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 10);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Filters/sorting:";
            // 
            // pnlBloodNav
            // 
            this.pnlBloodNav.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlBloodNav.Controls.Add(this.btnBloodLast);
            this.pnlBloodNav.Controls.Add(this.btnBloodFirst);
            this.pnlBloodNav.Controls.Add(this.btnBloodPrev);
            this.pnlBloodNav.Controls.Add(this.btnBllodNext);
            this.pnlBloodNav.Location = new System.Drawing.Point(8, 280);
            this.pnlBloodNav.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBloodNav.Name = "pnlBloodNav";
            this.pnlBloodNav.Size = new System.Drawing.Size(745, 36);
            this.pnlBloodNav.TabIndex = 6;
            // 
            // btnBloodLast
            // 
            this.btnBloodLast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBloodLast.BackgroundImage")));
            this.btnBloodLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBloodLast.FlatAppearance.BorderSize = 0;
            this.btnBloodLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloodLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloodLast.Location = new System.Drawing.Point(596, 3);
            this.btnBloodLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnBloodLast.Name = "btnBloodLast";
            this.btnBloodLast.Size = new System.Drawing.Size(105, 30);
            this.btnBloodLast.TabIndex = 3;
            this.btnBloodLast.Text = ">>|";
            this.btnBloodLast.UseVisualStyleBackColor = true;
            this.btnBloodLast.Click += new System.EventHandler(this.btnBloodLast_Click);
            // 
            // btnBloodFirst
            // 
            this.btnBloodFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBloodFirst.BackgroundImage")));
            this.btnBloodFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBloodFirst.FlatAppearance.BorderSize = 0;
            this.btnBloodFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloodFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloodFirst.Location = new System.Drawing.Point(12, 4);
            this.btnBloodFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnBloodFirst.Name = "btnBloodFirst";
            this.btnBloodFirst.Size = new System.Drawing.Size(109, 30);
            this.btnBloodFirst.TabIndex = 2;
            this.btnBloodFirst.Text = "|<<";
            this.btnBloodFirst.UseVisualStyleBackColor = true;
            this.btnBloodFirst.Click += new System.EventHandler(this.btnBloodFirst_Click);
            // 
            // btnBloodPrev
            // 
            this.btnBloodPrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBloodPrev.BackgroundImage")));
            this.btnBloodPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBloodPrev.FlatAppearance.BorderSize = 0;
            this.btnBloodPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloodPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloodPrev.Location = new System.Drawing.Point(241, 3);
            this.btnBloodPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnBloodPrev.Name = "btnBloodPrev";
            this.btnBloodPrev.Size = new System.Drawing.Size(101, 30);
            this.btnBloodPrev.TabIndex = 1;
            this.btnBloodPrev.Text = "<";
            this.btnBloodPrev.UseVisualStyleBackColor = true;
            this.btnBloodPrev.Click += new System.EventHandler(this.btnBloodPrev_Click);
            // 
            // btnBllodNext
            // 
            this.btnBllodNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBllodNext.BackgroundImage")));
            this.btnBllodNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBllodNext.FlatAppearance.BorderSize = 0;
            this.btnBllodNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBllodNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBllodNext.Location = new System.Drawing.Point(480, 4);
            this.btnBllodNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnBllodNext.Name = "btnBllodNext";
            this.btnBllodNext.Size = new System.Drawing.Size(101, 29);
            this.btnBllodNext.TabIndex = 0;
            this.btnBllodNext.Text = ">";
            this.btnBllodNext.UseVisualStyleBackColor = true;
            this.btnBllodNext.Click += new System.EventHandler(this.btnBllodNext_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
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
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(7, 324);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1014, 197);
            this.panel3.TabIndex = 1;
            // 
            // lblBloodExpiryDate
            // 
            this.lblBloodExpiryDate.AutoSize = true;
            this.lblBloodExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodExpiryDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBloodExpiryDate.Location = new System.Drawing.Point(20, 158);
            this.lblBloodExpiryDate.Name = "lblBloodExpiryDate";
            this.lblBloodExpiryDate.Size = new System.Drawing.Size(77, 16);
            this.lblBloodExpiryDate.TabIndex = 12;
            this.lblBloodExpiryDate.Text = "Expiry date:";
            // 
            // lblBloodUserID
            // 
            this.lblBloodUserID.AutoSize = true;
            this.lblBloodUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodUserID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBloodUserID.Location = new System.Drawing.Point(45, 51);
            this.lblBloodUserID.Name = "lblBloodUserID";
            this.lblBloodUserID.Size = new System.Drawing.Size(52, 16);
            this.lblBloodUserID.TabIndex = 11;
            this.lblBloodUserID.Text = "UserID:";
            // 
            // lblBloodAppID
            // 
            this.lblBloodAppID.AutoSize = true;
            this.lblBloodAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodAppID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBloodAppID.Location = new System.Drawing.Point(2, 86);
            this.lblBloodAppID.Name = "lblBloodAppID";
            this.lblBloodAppID.Size = new System.Drawing.Size(98, 16);
            this.lblBloodAppID.TabIndex = 10;
            this.lblBloodAppID.Text = "AppointmentID:";
            // 
            // lblTypeBlood
            // 
            this.lblTypeBlood.AutoSize = true;
            this.lblTypeBlood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeBlood.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTypeBlood.Location = new System.Drawing.Point(25, 119);
            this.lblTypeBlood.Name = "lblTypeBlood";
            this.lblTypeBlood.Size = new System.Drawing.Size(75, 16);
            this.lblTypeBlood.TabIndex = 9;
            this.lblTypeBlood.Text = "Blood type:";
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUnitID.Location = new System.Drawing.Point(51, 16);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(46, 16);
            this.lblUnitID.TabIndex = 8;
            this.lblUnitID.Text = "UnitID:";
            // 
            // btnBloodDelete
            // 
            this.btnBloodDelete.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackRed;
            this.btnBloodDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBloodDelete.FlatAppearance.BorderSize = 0;
            this.btnBloodDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloodDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloodDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBloodDelete.Location = new System.Drawing.Point(272, 96);
            this.btnBloodDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnBloodDelete.Name = "btnBloodDelete";
            this.btnBloodDelete.Size = new System.Drawing.Size(125, 39);
            this.btnBloodDelete.TabIndex = 7;
            this.btnBloodDelete.Text = "Delete record";
            this.btnBloodDelete.UseVisualStyleBackColor = true;
            this.btnBloodDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBloodApply
            // 
            this.btnBloodApply.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackBlue;
            this.btnBloodApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBloodApply.FlatAppearance.BorderSize = 0;
            this.btnBloodApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloodApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloodApply.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBloodApply.Location = new System.Drawing.Point(272, 143);
            this.btnBloodApply.Margin = new System.Windows.Forms.Padding(4);
            this.btnBloodApply.Name = "btnBloodApply";
            this.btnBloodApply.Size = new System.Drawing.Size(125, 34);
            this.btnBloodApply.TabIndex = 6;
            this.btnBloodApply.Text = "Apply changes";
            this.btnBloodApply.UseVisualStyleBackColor = true;
            this.btnBloodApply.Click += new System.EventHandler(this.btnBloodApply_Click);
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBloodInventoryBindingSource, "ExpiryDate", true));
            this.dtpExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiry.Location = new System.Drawing.Point(104, 158);
            this.dtpExpiry.Margin = new System.Windows.Forms.Padding(4);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.Size = new System.Drawing.Size(121, 20);
            this.dtpExpiry.TabIndex = 5;
            // 
            // tblBloodInventoryBindingSource
            // 
            this.tblBloodInventoryBindingSource.DataMember = "TblBloodInventory";
            this.tblBloodInventoryBindingSource.DataSource = this.ist2jwDataSet;
            // 
            // cmbBloodInvType
            // 
            this.cmbBloodInvType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBloodInventoryBindingSource, "BloodType", true));
            this.cmbBloodInvType.FormattingEnabled = true;
            this.cmbBloodInvType.Location = new System.Drawing.Point(104, 119);
            this.cmbBloodInvType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBloodInvType.Name = "cmbBloodInvType";
            this.cmbBloodInvType.Size = new System.Drawing.Size(121, 21);
            this.cmbBloodInvType.TabIndex = 3;
            // 
            // txtBloodAppID
            // 
            this.txtBloodAppID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBloodInventoryBindingSource, "AppID", true));
            this.txtBloodAppID.Location = new System.Drawing.Point(104, 85);
            this.txtBloodAppID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBloodAppID.Name = "txtBloodAppID";
            this.txtBloodAppID.ReadOnly = true;
            this.txtBloodAppID.Size = new System.Drawing.Size(121, 20);
            this.txtBloodAppID.TabIndex = 2;
            // 
            // txtBloodUserID
            // 
            this.txtBloodUserID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBloodInventoryBindingSource, "UserID", true));
            this.txtBloodUserID.Location = new System.Drawing.Point(104, 58);
            this.txtBloodUserID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBloodUserID.Name = "txtBloodUserID";
            this.txtBloodUserID.ReadOnly = true;
            this.txtBloodUserID.Size = new System.Drawing.Size(121, 20);
            this.txtBloodUserID.TabIndex = 1;
            // 
            // txtUnitID
            // 
            this.txtUnitID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBloodInventoryBindingSource, "UnitID", true));
            this.txtUnitID.Location = new System.Drawing.Point(104, 16);
            this.txtUnitID.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitID.Name = "txtUnitID";
            this.txtUnitID.ReadOnly = true;
            this.txtUnitID.Size = new System.Drawing.Size(121, 20);
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
            this.dgvBlood.Location = new System.Drawing.Point(7, 7);
            this.dgvBlood.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBlood.Name = "dgvBlood";
            this.dgvBlood.RowHeadersWidth = 51;
            this.dgvBlood.Size = new System.Drawing.Size(746, 272);
            this.dgvBlood.TabIndex = 0;
            this.dgvBlood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBlood_CellContentClick);
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
            // tpgUsers
            // 
            this.tpgUsers.Controls.Add(this.pnlRemoveUserFilters);
            this.tpgUsers.Controls.Add(this.pnlUserNav);
            this.tpgUsers.Controls.Add(this.panel5);
            this.tpgUsers.Controls.Add(this.dgvUsers);
            this.tpgUsers.Controls.Add(this.pnlUserEdit);
            this.tpgUsers.Location = new System.Drawing.Point(4, 22);
            this.tpgUsers.Margin = new System.Windows.Forms.Padding(4);
            this.tpgUsers.Name = "tpgUsers";
            this.tpgUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpgUsers.Size = new System.Drawing.Size(1034, 526);
            this.tpgUsers.TabIndex = 0;
            this.tpgUsers.Text = "    Users    ";
            this.tpgUsers.UseVisualStyleBackColor = true;
            // 
            // pnlRemoveUserFilters
            // 
            this.pnlRemoveUserFilters.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlRemoveUserFilters.Controls.Add(this.btnRemoveFilter);
            this.pnlRemoveUserFilters.Location = new System.Drawing.Point(756, 488);
            this.pnlRemoveUserFilters.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRemoveUserFilters.Name = "pnlRemoveUserFilters";
            this.pnlRemoveUserFilters.Size = new System.Drawing.Size(276, 33);
            this.pnlRemoveUserFilters.TabIndex = 6;
            // 
            // btnRemoveFilter
            // 
            this.btnRemoveFilter.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackRed;
            this.btnRemoveFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveFilter.FlatAppearance.BorderSize = 0;
            this.btnRemoveFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFilter.Location = new System.Drawing.Point(87, 6);
            this.btnRemoveFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveFilter.Name = "btnRemoveFilter";
            this.btnRemoveFilter.Size = new System.Drawing.Size(122, 23);
            this.btnRemoveFilter.TabIndex = 1;
            this.btnRemoveFilter.Text = "Remove";
            this.btnRemoveFilter.UseVisualStyleBackColor = true;
            this.btnRemoveFilter.Click += new System.EventHandler(this.btnRemoveFilter_Click);
            // 
            // pnlUserNav
            // 
            this.pnlUserNav.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlUserNav.Controls.Add(this.btnUserLast);
            this.pnlUserNav.Controls.Add(this.btnUserFirst);
            this.pnlUserNav.Controls.Add(this.btnUserPrev);
            this.pnlUserNav.Controls.Add(this.btnUserNext);
            this.pnlUserNav.Location = new System.Drawing.Point(8, 295);
            this.pnlUserNav.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUserNav.Name = "pnlUserNav";
            this.pnlUserNav.Size = new System.Drawing.Size(737, 36);
            this.pnlUserNav.TabIndex = 5;
            // 
            // btnUserLast
            // 
            this.btnUserLast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUserLast.BackgroundImage")));
            this.btnUserLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserLast.FlatAppearance.BorderSize = 0;
            this.btnUserLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserLast.Location = new System.Drawing.Point(530, 3);
            this.btnUserLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserLast.Name = "btnUserLast";
            this.btnUserLast.Size = new System.Drawing.Size(121, 30);
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
            this.btnUserFirst.Location = new System.Drawing.Point(128, 4);
            this.btnUserFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserFirst.Name = "btnUserFirst";
            this.btnUserFirst.Size = new System.Drawing.Size(121, 30);
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
            this.btnUserPrev.Location = new System.Drawing.Point(257, 4);
            this.btnUserPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserPrev.Name = "btnUserPrev";
            this.btnUserPrev.Size = new System.Drawing.Size(121, 30);
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
            this.btnUserNext.Location = new System.Drawing.Point(402, 3);
            this.btnUserNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserNext.Name = "btnUserNext";
            this.btnUserNext.Size = new System.Drawing.Size(121, 30);
            this.btnUserNext.TabIndex = 0;
            this.btnUserNext.Text = ">";
            this.btnUserNext.UseVisualStyleBackColor = true;
            this.btnUserNext.Click += new System.EventHandler(this.btnUserNext_Click);
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.panel5.Location = new System.Drawing.Point(754, 4);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(276, 474);
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
            this.no1DonorFilterBtn.Location = new System.Drawing.Point(39, 288);
            this.no1DonorFilterBtn.Margin = new System.Windows.Forms.Padding(4);
            this.no1DonorFilterBtn.Name = "no1DonorFilterBtn";
            this.no1DonorFilterBtn.Size = new System.Drawing.Size(194, 36);
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
            this.donorRankingFilterBtn.Location = new System.Drawing.Point(39, 231);
            this.donorRankingFilterBtn.Margin = new System.Windows.Forms.Padding(4);
            this.donorRankingFilterBtn.Name = "donorRankingFilterBtn";
            this.donorRankingFilterBtn.Size = new System.Drawing.Size(194, 36);
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
            this.cmbUserFilter.Location = new System.Drawing.Point(137, 167);
            this.cmbUserFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUserFilter.Name = "cmbUserFilter";
            this.cmbUserFilter.Size = new System.Drawing.Size(73, 21);
            this.cmbUserFilter.TabIndex = 8;
            this.cmbUserFilter.Text = "Admin";
            // 
            // btnUserFilter
            // 
            this.btnUserFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUserFilter.BackgroundImage")));
            this.btnUserFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserFilter.FlatAppearance.BorderSize = 0;
            this.btnUserFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserFilter.Location = new System.Drawing.Point(15, 161);
            this.btnUserFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserFilter.Name = "btnUserFilter";
            this.btnUserFilter.Size = new System.Drawing.Size(104, 25);
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
            this.cmbBloodFilter.Location = new System.Drawing.Point(137, 131);
            this.cmbBloodFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBloodFilter.Name = "cmbBloodFilter";
            this.cmbBloodFilter.Size = new System.Drawing.Size(73, 21);
            this.cmbBloodFilter.TabIndex = 6;
            this.cmbBloodFilter.Text = "O";
            // 
            // btnBloodFilter
            // 
            this.btnBloodFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBloodFilter.BackgroundImage")));
            this.btnBloodFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBloodFilter.FlatAppearance.BorderSize = 0;
            this.btnBloodFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloodFilter.Location = new System.Drawing.Point(15, 127);
            this.btnBloodFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnBloodFilter.Name = "btnBloodFilter";
            this.btnBloodFilter.Size = new System.Drawing.Size(104, 26);
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
            this.btnSurnameAlphabetical.Location = new System.Drawing.Point(15, 97);
            this.btnSurnameAlphabetical.Margin = new System.Windows.Forms.Padding(4);
            this.btnSurnameAlphabetical.Name = "btnSurnameAlphabetical";
            this.btnSurnameAlphabetical.Size = new System.Drawing.Size(194, 26);
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
            this.btnNameAlphabetical.Location = new System.Drawing.Point(15, 63);
            this.btnNameAlphabetical.Margin = new System.Windows.Forms.Padding(4);
            this.btnNameAlphabetical.Name = "btnNameAlphabetical";
            this.btnNameAlphabetical.Size = new System.Drawing.Size(194, 26);
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
            this.btnFilterInactive.Location = new System.Drawing.Point(116, 27);
            this.btnFilterInactive.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilterInactive.Name = "btnFilterInactive";
            this.btnFilterInactive.Size = new System.Drawing.Size(94, 28);
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
            this.btnFilterActive.Location = new System.Drawing.Point(15, 27);
            this.btnFilterActive.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilterActive.Name = "btnFilterActive";
            this.btnFilterActive.Size = new System.Drawing.Size(93, 28);
            this.btnFilterActive.TabIndex = 1;
            this.btnFilterActive.Text = "Filter by active";
            this.btnFilterActive.UseVisualStyleBackColor = true;
            this.btnFilterActive.Click += new System.EventHandler(this.btnFilterActive_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
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
            this.dgvUsers.Location = new System.Drawing.Point(8, 0);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.Size = new System.Drawing.Size(737, 287);
            this.dgvUsers.TabIndex = 3;
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
            this.userTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "User Type";
            this.userTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            // 
            // bloodTypeDataGridViewTextBoxColumn
            // 
            this.bloodTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bloodTypeDataGridViewTextBoxColumn.DataPropertyName = "BloodType";
            this.bloodTypeDataGridViewTextBoxColumn.HeaderText = "Blood Type";
            this.bloodTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bloodTypeDataGridViewTextBoxColumn.Name = "bloodTypeDataGridViewTextBoxColumn";
            // 
            // isActiveAccountDataGridViewCheckBoxColumn
            // 
            this.isActiveAccountDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.isActiveAccountDataGridViewCheckBoxColumn.DataPropertyName = "isActiveAccount";
            this.isActiveAccountDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.isActiveAccountDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isActiveAccountDataGridViewCheckBoxColumn.Name = "isActiveAccountDataGridViewCheckBoxColumn";
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tblUsers";
            this.tblUsersBindingSource.DataSource = this.ist2jwDataSet;
            // 
            // pnlUserEdit
            // 
            this.pnlUserEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.pnlUserEdit.Location = new System.Drawing.Point(8, 336);
            this.pnlUserEdit.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUserEdit.Name = "pnlUserEdit";
            this.pnlUserEdit.Size = new System.Drawing.Size(737, 188);
            this.pnlUserEdit.TabIndex = 2;
            // 
            // btnStartInsert
            // 
            this.btnStartInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStartInsert.BackgroundImage")));
            this.btnStartInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartInsert.FlatAppearance.BorderSize = 0;
            this.btnStartInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartInsert.Location = new System.Drawing.Point(530, 12);
            this.btnStartInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartInsert.Name = "btnStartInsert";
            this.btnStartInsert.Size = new System.Drawing.Size(121, 35);
            this.btnStartInsert.TabIndex = 21;
            this.btnStartInsert.Text = "Insert a User";
            this.btnStartInsert.UseVisualStyleBackColor = true;
            this.btnStartInsert.Click += new System.EventHandler(this.btnStartInsert_Click);
            // 
            // btnInsertUser
            // 
            this.btnInsertUser.Location = new System.Drawing.Point(530, 4);
            this.btnInsertUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertUser.Name = "btnInsertUser";
            this.btnInsertUser.Size = new System.Drawing.Size(121, 31);
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
            this.lblUserType.Location = new System.Drawing.Point(267, 61);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(74, 16);
            this.lblUserType.TabIndex = 19;
            this.lblUserType.Text = "User Type:";
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodType.Location = new System.Drawing.Point(260, 87);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(81, 16);
            this.lblBloodType.TabIndex = 18;
            this.lblBloodType.Text = "Blood Type:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(31, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(25, 117);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(64, 16);
            this.lblSurname.TabIndex = 16;
            this.lblSurname.Text = "Surname:";
            // 
            // lblIDNum
            // 
            this.lblIDNum.AutoSize = true;
            this.lblIDNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNum.Location = new System.Drawing.Point(14, 144);
            this.lblIDNum.Name = "lblIDNum";
            this.lblIDNum.Size = new System.Drawing.Size(74, 16);
            this.lblIDNum.TabIndex = 15;
            this.lblIDNum.Text = "ID Number:";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.Location = new System.Drawing.Point(244, 29);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(97, 16);
            this.lblPhoneNum.TabIndex = 14;
            this.lblPhoneNum.Text = "Phone number:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(14, 49);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 16);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(31, 18);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(52, 16);
            this.lblUserID.TabIndex = 12;
            this.lblUserID.Text = "UserID:";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteUser.BackgroundImage")));
            this.btnDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Location = new System.Drawing.Point(530, 77);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(121, 31);
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
            this.btnUpdateUser.Location = new System.Drawing.Point(530, 130);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(121, 31);
            this.btnUpdateUser.TabIndex = 10;
            this.btnUpdateUser.Text = "Apply changes";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.tblUsersBindingSource, "isActiveAccount", true));
            this.chkActive.Location = new System.Drawing.Point(348, 123);
            this.chkActive.Margin = new System.Windows.Forms.Padding(4);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(125, 20);
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
            this.cmbUser.Location = new System.Drawing.Point(348, 58);
            this.cmbUser.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(121, 24);
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
            this.cmbBlood.Location = new System.Drawing.Point(348, 89);
            this.cmbBlood.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBlood.Name = "cmbBlood";
            this.cmbBlood.Size = new System.Drawing.Size(121, 24);
            this.cmbBlood.TabIndex = 7;
            this.cmbBlood.SelectionChangeCommitted += new System.EventHandler(this.cmbBlood_SelectionChangeCommitted);
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "PhoneNumber", true));
            this.txtPhone.Location = new System.Drawing.Point(348, 27);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "IDNumber", true));
            this.txtID.Location = new System.Drawing.Point(120, 144);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 4;
            // 
            // txtSurname
            // 
            this.txtSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "Surname", true));
            this.txtSurname.Location = new System.Drawing.Point(120, 115);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 22);
            this.txtSurname.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "Name", true));
            this.txtName.Location = new System.Drawing.Point(120, 82);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "Password", true));
            this.txtPassword.Location = new System.Drawing.Point(120, 50);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUserID
            // 
            this.txtUserID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "UserID", true));
            this.txtUserID.Location = new System.Drawing.Point(120, 18);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(100, 22);
            this.txtUserID.TabIndex = 0;
            // 
            // btnCancelInsert
            // 
            this.btnCancelInsert.Location = new System.Drawing.Point(530, 70);
            this.btnCancelInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelInsert.Name = "btnCancelInsert";
            this.btnCancelInsert.Size = new System.Drawing.Size(121, 28);
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
            this.tcAdmin.Location = new System.Drawing.Point(0, 52);
            this.tcAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(1042, 552);
            this.tcAdmin.TabIndex = 2;
            this.tcAdmin.SelectedIndexChanged += new System.EventHandler(this.tcAdmin_SelectedIndexChanged);
            // 
            // tpgSchedule
            // 
            this.tpgSchedule.AutoScroll = true;
            this.tpgSchedule.Controls.Add(this.dgvTotalSchedule);
            this.tpgSchedule.Controls.Add(this.dgvAverage);
            this.tpgSchedule.Controls.Add(this.pnlScheduleNav);
            this.tpgSchedule.Controls.Add(this.panel1);
            this.tpgSchedule.Controls.Add(this.pnlSchedule);
            this.tpgSchedule.Controls.Add(this.dgvSchedule);
            this.tpgSchedule.Location = new System.Drawing.Point(4, 22);
            this.tpgSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.tpgSchedule.Name = "tpgSchedule";
            this.tpgSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tpgSchedule.Size = new System.Drawing.Size(1034, 526);
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
            this.dgvTotalSchedule.Location = new System.Drawing.Point(13, 9);
            this.dgvTotalSchedule.Name = "dgvTotalSchedule";
            this.dgvTotalSchedule.RowHeadersWidth = 51;
            this.dgvTotalSchedule.RowTemplate.Height = 24;
            this.dgvTotalSchedule.Size = new System.Drawing.Size(763, 259);
            this.dgvTotalSchedule.TabIndex = 3;
            this.dgvTotalSchedule.Visible = false;
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
            // dgvAverage
            // 
            this.dgvAverage.AutoGenerateColumns = false;
            this.dgvAverage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAverage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dgvAverage.DataSource = this.tblAverageScheduleBindingSource;
            this.dgvAverage.Location = new System.Drawing.Point(11, 9);
            this.dgvAverage.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAverage.Name = "dgvAverage";
            this.dgvAverage.RowHeadersWidth = 51;
            this.dgvAverage.RowTemplate.Height = 24;
            this.dgvAverage.Size = new System.Drawing.Size(763, 259);
            this.dgvAverage.TabIndex = 4;
            this.dgvAverage.Visible = false;
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
            // pnlScheduleNav
            // 
            this.pnlScheduleNav.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlScheduleNav.Controls.Add(this.btnScheduleFirst);
            this.pnlScheduleNav.Controls.Add(this.btnSchedulePrev);
            this.pnlScheduleNav.Controls.Add(this.btnScheduleNext);
            this.pnlScheduleNav.Controls.Add(this.btnScheduleLast);
            this.pnlScheduleNav.Location = new System.Drawing.Point(11, 276);
            this.pnlScheduleNav.Margin = new System.Windows.Forms.Padding(4);
            this.pnlScheduleNav.Name = "pnlScheduleNav";
            this.pnlScheduleNav.Size = new System.Drawing.Size(764, 42);
            this.pnlScheduleNav.TabIndex = 9;
            // 
            // btnScheduleFirst
            // 
            this.btnScheduleFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScheduleFirst.BackgroundImage")));
            this.btnScheduleFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScheduleFirst.FlatAppearance.BorderSize = 0;
            this.btnScheduleFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleFirst.Location = new System.Drawing.Point(5, 4);
            this.btnScheduleFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnScheduleFirst.Name = "btnScheduleFirst";
            this.btnScheduleFirst.Size = new System.Drawing.Size(129, 36);
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
            this.btnSchedulePrev.Location = new System.Drawing.Point(143, 4);
            this.btnSchedulePrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnSchedulePrev.Name = "btnSchedulePrev";
            this.btnSchedulePrev.Size = new System.Drawing.Size(109, 36);
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
            this.btnScheduleNext.Location = new System.Drawing.Point(290, 4);
            this.btnScheduleNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnScheduleNext.Name = "btnScheduleNext";
            this.btnScheduleNext.Size = new System.Drawing.Size(109, 36);
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
            this.btnScheduleLast.Location = new System.Drawing.Point(407, 4);
            this.btnScheduleLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnScheduleLast.Name = "btnScheduleLast";
            this.btnScheduleLast.Size = new System.Drawing.Size(128, 36);
            this.btnScheduleLast.TabIndex = 0;
            this.btnScheduleLast.Text = ">|";
            this.btnScheduleLast.UseVisualStyleBackColor = true;
            this.btnScheduleLast.Click += new System.EventHandler(this.btnScheduleLast_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAverage);
            this.panel1.Controls.Add(this.btnCountSchedules);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(782, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 307);
            this.panel1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(62, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
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
            this.btnAverage.Location = new System.Drawing.Point(4, 95);
            this.btnAverage.Margin = new System.Windows.Forms.Padding(4);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(184, 52);
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
            this.btnCountSchedules.Location = new System.Drawing.Point(4, 47);
            this.btnCountSchedules.Margin = new System.Windows.Forms.Padding(4);
            this.btnCountSchedules.Name = "btnCountSchedules";
            this.btnCountSchedules.Size = new System.Drawing.Size(186, 40);
            this.btnCountSchedules.TabIndex = 1;
            this.btnCountSchedules.Text = "Count Schedules per Donor";
            this.btnCountSchedules.UseVisualStyleBackColor = true;
            this.btnCountSchedules.Click += new System.EventHandler(this.btnCountSchedules_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filters/sorting:";
            // 
            // pnlSchedule
            // 
            this.pnlSchedule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSchedule.Controls.Add(this.btnDeleteSchedule);
            this.pnlSchedule.Controls.Add(this.btnAppChanges);
            this.pnlSchedule.Controls.Add(this.chkAttended);
            this.pnlSchedule.Controls.Add(this.txtSearchByUser);
            this.pnlSchedule.Controls.Add(this.pnlShortStats);
            this.pnlSchedule.Controls.Add(this.btnScheduleUserSearch);
            this.pnlSchedule.Controls.Add(this.redDisplay);
            this.pnlSchedule.Location = new System.Drawing.Point(11, 327);
            this.pnlSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSchedule.Name = "pnlSchedule";
            this.pnlSchedule.Size = new System.Drawing.Size(1006, 195);
            this.pnlSchedule.TabIndex = 1;
            // 
            // btnDeleteSchedule
            // 
            this.btnDeleteSchedule.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteSchedule.BackgroundImage")));
            this.btnDeleteSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteSchedule.FlatAppearance.BorderSize = 0;
            this.btnDeleteSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnDeleteSchedule.Location = new System.Drawing.Point(350, 7);
            this.btnDeleteSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteSchedule.Name = "btnDeleteSchedule";
            this.btnDeleteSchedule.Size = new System.Drawing.Size(124, 32);
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
            this.btnAppChanges.Location = new System.Drawing.Point(210, 6);
            this.btnAppChanges.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppChanges.Name = "btnAppChanges";
            this.btnAppChanges.Size = new System.Drawing.Size(124, 31);
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
            this.chkAttended.Location = new System.Drawing.Point(62, 14);
            this.chkAttended.Margin = new System.Windows.Forms.Padding(4);
            this.chkAttended.Name = "chkAttended";
            this.chkAttended.Size = new System.Drawing.Size(80, 20);
            this.chkAttended.TabIndex = 7;
            this.chkAttended.Text = "Attended";
            this.chkAttended.UseVisualStyleBackColor = true;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataMember = "Schedule";
            this.scheduleBindingSource.DataSource = this.ist2jwDataSet;
            // 
            // txtSearchByUser
            // 
            this.txtSearchByUser.Location = new System.Drawing.Point(640, 14);
            this.txtSearchByUser.Name = "txtSearchByUser";
            this.txtSearchByUser.Size = new System.Drawing.Size(125, 20);
            this.txtSearchByUser.TabIndex = 5;
            this.txtSearchByUser.Enter += new System.EventHandler(this.txtSearchByUser_Enter);
            this.txtSearchByUser.Leave += new System.EventHandler(this.txtSearchByUser_Leave);
            // 
            // pnlShortStats
            // 
            this.pnlShortStats.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlShortStats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlShortStats.Controls.Add(this.lblUnattended);
            this.pnlShortStats.Controls.Add(this.lblAttended);
            this.pnlShortStats.Controls.Add(this.lblSchedules);
            this.pnlShortStats.Controls.Add(this.lblShortStats);
            this.pnlShortStats.Location = new System.Drawing.Point(6, 46);
            this.pnlShortStats.Margin = new System.Windows.Forms.Padding(4);
            this.pnlShortStats.Name = "pnlShortStats";
            this.pnlShortStats.Size = new System.Drawing.Size(758, 141);
            this.pnlShortStats.TabIndex = 1;
            // 
            // lblUnattended
            // 
            this.lblUnattended.AutoSize = true;
            this.lblUnattended.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblUnattended.Location = new System.Drawing.Point(12, 94);
            this.lblUnattended.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnattended.Name = "lblUnattended";
            this.lblUnattended.Size = new System.Drawing.Size(210, 16);
            this.lblUnattended.TabIndex = 3;
            this.lblUnattended.Text = "Number of schedules unattended: ";
            // 
            // lblAttended
            // 
            this.lblAttended.AutoSize = true;
            this.lblAttended.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblAttended.Location = new System.Drawing.Point(12, 66);
            this.lblAttended.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttended.Name = "lblAttended";
            this.lblAttended.Size = new System.Drawing.Size(193, 16);
            this.lblAttended.TabIndex = 2;
            this.lblAttended.Text = "Number of schedules attended:";
            // 
            // lblSchedules
            // 
            this.lblSchedules.AutoSize = true;
            this.lblSchedules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblSchedules.Location = new System.Drawing.Point(12, 40);
            this.lblSchedules.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSchedules.Name = "lblSchedules";
            this.lblSchedules.Size = new System.Drawing.Size(253, 16);
            this.lblSchedules.TabIndex = 1;
            this.lblSchedules.Text = "Total number of scheduled appointments:";
            // 
            // lblShortStats
            // 
            this.lblShortStats.AutoSize = true;
            this.lblShortStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortStats.Location = new System.Drawing.Point(12, 12);
            this.lblShortStats.Name = "lblShortStats";
            this.lblShortStats.Size = new System.Drawing.Size(114, 16);
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
            this.btnScheduleUserSearch.Location = new System.Drawing.Point(500, 7);
            this.btnScheduleUserSearch.Name = "btnScheduleUserSearch";
            this.btnScheduleUserSearch.Size = new System.Drawing.Size(124, 32);
            this.btnScheduleUserSearch.TabIndex = 3;
            this.btnScheduleUserSearch.Text = "Search by User";
            this.btnScheduleUserSearch.UseVisualStyleBackColor = true;
            this.btnScheduleUserSearch.Click += new System.EventHandler(this.btnScheduleUserSearch_Click);
            // 
            // redDisplay
            // 
            this.redDisplay.Location = new System.Drawing.Point(771, 4);
            this.redDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.redDisplay.Name = "redDisplay";
            this.redDisplay.Size = new System.Drawing.Size(232, 183);
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
            this.dgvSchedule.Location = new System.Drawing.Point(11, 7);
            this.dgvSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowHeadersWidth = 51;
            this.dgvSchedule.Size = new System.Drawing.Size(764, 261);
            this.dgvSchedule.TabIndex = 0;
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
            // tpgStats
            // 
            this.tpgStats.Controls.Add(this.chtUserSchedule);
            this.tpgStats.Controls.Add(this.chtBloodType);
            this.tpgStats.Location = new System.Drawing.Point(4, 22);
            this.tpgStats.Margin = new System.Windows.Forms.Padding(4);
            this.tpgStats.Name = "tpgStats";
            this.tpgStats.Padding = new System.Windows.Forms.Padding(3);
            this.tpgStats.Size = new System.Drawing.Size(1034, 526);
            this.tpgStats.TabIndex = 4;
            this.tpgStats.Text = "     Statistics     ";
            this.tpgStats.UseVisualStyleBackColor = true;
            // 
            // chtUserSchedule
            // 
            chartArea3.Name = "ChartArea1";
            this.chtUserSchedule.ChartAreas.Add(chartArea3);
            legend3.Name = "No. of schedules";
            this.chtUserSchedule.Legends.Add(legend3);
            this.chtUserSchedule.Location = new System.Drawing.Point(536, 5);
            this.chtUserSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.chtUserSchedule.Name = "chtUserSchedule";
            this.chtUserSchedule.Size = new System.Drawing.Size(495, 519);
            this.chtUserSchedule.TabIndex = 1;
            // 
            // chtBloodType
            // 
            chartArea4.Name = "ChartArea1";
            this.chtBloodType.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chtBloodType.Legends.Add(legend4);
            this.chtBloodType.Location = new System.Drawing.Point(6, 5);
            this.chtBloodType.Margin = new System.Windows.Forms.Padding(2);
            this.chtBloodType.Name = "chtBloodType";
            this.chtBloodType.Size = new System.Drawing.Size(516, 524);
            this.chtBloodType.TabIndex = 0;
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
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 607);
            this.Controls.Add(this.tcAdmin);
            this.Controls.Add(this.pnlTopBar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.tpgAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2jwDataSet)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.tblBloodInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlood)).EndInit();
            this.tpgUsers.ResumeLayout(false);
            this.pnlRemoveUserFilters.ResumeLayout(false);
            this.pnlUserNav.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            this.pnlUserEdit.ResumeLayout(false);
            this.pnlUserEdit.PerformLayout();
            this.tcAdmin.ResumeLayout(false);
            this.tpgSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTotalScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAverageScheduleBindingSource)).EndInit();
            this.pnlScheduleNav.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSchedule.ResumeLayout(false);
            this.pnlSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            this.pnlShortStats.ResumeLayout(false);
            this.pnlShortStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.tpgStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtUserSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtBloodType)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveAccountDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button donorRankingFilterBtn;
        private System.Windows.Forms.Button no1DonorFilterBtn;
    }
}