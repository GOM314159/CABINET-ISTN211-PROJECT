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
            this.pnlTopBar = new System.Windows.Forms.Panel();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCountSchedules = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSchedule = new System.Windows.Forms.Panel();
            this.txtSearchByApp = new System.Windows.Forms.TextBox();
            this.txtSearchByUser = new System.Windows.Forms.TextBox();
            this.btnScheduleEventSearch = new System.Windows.Forms.Button();
            this.btnScheduleUserSearch = new System.Windows.Forms.Button();
            this.redDisplay = new System.Windows.Forms.RichTextBox();
            this.pnlShortStats = new System.Windows.Forms.Panel();
            this.lblUnattended = new System.Windows.Forms.Label();
            this.lblAttended = new System.Windows.Forms.Label();
            this.lblSchedules = new System.Windows.Forms.Label();
            this.lblShortStats = new System.Windows.Forms.Label();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsersTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.tblUsersTableAdapter();
            this.tblBloodInventoryTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.TblBloodInventoryTableAdapter();
            this.appointmentTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.AppointmentTableAdapter();
            this.scheduleTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.ScheduleTableAdapter();
            this.tableAdapterManager = new BloodBankSystem.ist2jwDataSetTableAdapters.TableAdapterManager();
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
            this.panel1.SuspendLayout();
            this.pnlSchedule.SuspendLayout();
            this.pnlShortStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlTopBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTopBar.Controls.Add(this.btnLogout);
            this.pnlTopBar.Controls.Add(this.lblAdminDash);
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(801, 40);
            this.pnlTopBar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnLogout.Location = new System.Drawing.Point(2, 3);
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
            this.lblAdminDash.Location = new System.Drawing.Point(300, 7);
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
            this.tpgAppointments.Name = "tpgAppointments";
            this.tpgAppointments.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpgAppointments.Size = new System.Drawing.Size(793, 387);
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
            this.appointmentDataGridView.Location = new System.Drawing.Point(7, 8);
            this.appointmentDataGridView.Name = "appointmentDataGridView";
            this.appointmentDataGridView.RowHeadersWidth = 51;
            this.appointmentDataGridView.Size = new System.Drawing.Size(529, 150);
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
            this.pnlAppFilters.Location = new System.Drawing.Point(542, 9);
            this.pnlAppFilters.Name = "pnlAppFilters";
            this.pnlAppFilters.Size = new System.Drawing.Size(242, 149);
            this.pnlAppFilters.TabIndex = 9;
            // 
            // btnFilterPassed
            // 
            this.btnFilterPassed.Location = new System.Drawing.Point(6, 135);
            this.btnFilterPassed.Name = "btnFilterPassed";
            this.btnFilterPassed.Size = new System.Drawing.Size(171, 25);
            this.btnFilterPassed.TabIndex = 7;
            this.btnFilterPassed.Text = "Filter by passed";
            this.btnFilterPassed.UseVisualStyleBackColor = true;
            this.btnFilterPassed.Click += new System.EventHandler(this.btnFilterPassed_Click);
            // 
            // btnFilterUpcoming
            // 
            this.btnFilterUpcoming.Location = new System.Drawing.Point(6, 101);
            this.btnFilterUpcoming.Name = "btnFilterUpcoming";
            this.btnFilterUpcoming.Size = new System.Drawing.Size(171, 28);
            this.btnFilterUpcoming.TabIndex = 6;
            this.btnFilterUpcoming.Text = "Filter by upcoming";
            this.btnFilterUpcoming.UseVisualStyleBackColor = true;
            this.btnFilterUpcoming.Click += new System.EventHandler(this.btnFilterUpcoming_Click);
            // 
            // btnCapSortDesc
            // 
            this.btnCapSortDesc.Location = new System.Drawing.Point(6, 67);
            this.btnCapSortDesc.Name = "btnCapSortDesc";
            this.btnCapSortDesc.Size = new System.Drawing.Size(171, 27);
            this.btnCapSortDesc.TabIndex = 5;
            this.btnCapSortDesc.Text = "Sort by capacity(desc)";
            this.btnCapSortDesc.UseVisualStyleBackColor = true;
            this.btnCapSortDesc.Click += new System.EventHandler(this.btnCapSortDesc_Click);
            // 
            // btnCapSortAsc
            // 
            this.btnCapSortAsc.Location = new System.Drawing.Point(6, 34);
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
            this.pnlRemoveAppFilters.Location = new System.Drawing.Point(542, 157);
            this.pnlRemoveAppFilters.Name = "pnlRemoveAppFilters";
            this.pnlRemoveAppFilters.Size = new System.Drawing.Size(242, 33);
            this.pnlRemoveAppFilters.TabIndex = 8;
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(6, 7);
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
            this.pnlAppNav.Location = new System.Drawing.Point(15, 157);
            this.pnlAppNav.Name = "pnlAppNav";
            this.pnlAppNav.Size = new System.Drawing.Size(499, 36);
            this.pnlAppNav.TabIndex = 7;
            // 
            // btnAppLast
            // 
            this.btnAppLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppLast.Location = new System.Drawing.Point(375, 3);
            this.btnAppLast.Name = "btnAppLast";
            this.btnAppLast.Size = new System.Drawing.Size(105, 30);
            this.btnAppLast.TabIndex = 3;
            this.btnAppLast.Text = ">>|";
            this.btnAppLast.UseVisualStyleBackColor = true;
            this.btnAppLast.Click += new System.EventHandler(this.btnAppLast_Click);
            // 
            // btnAppFirst
            // 
            this.btnAppFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppFirst.Location = new System.Drawing.Point(9, 3);
            this.btnAppFirst.Name = "btnAppFirst";
            this.btnAppFirst.Size = new System.Drawing.Size(109, 30);
            this.btnAppFirst.TabIndex = 2;
            this.btnAppFirst.Text = "|<<";
            this.btnAppFirst.UseVisualStyleBackColor = true;
            this.btnAppFirst.Click += new System.EventHandler(this.btnAppFirst_Click);
            // 
            // btnAppPrev
            // 
            this.btnAppPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppPrev.Location = new System.Drawing.Point(124, 3);
            this.btnAppPrev.Name = "btnAppPrev";
            this.btnAppPrev.Size = new System.Drawing.Size(101, 30);
            this.btnAppPrev.TabIndex = 1;
            this.btnAppPrev.Text = "<";
            this.btnAppPrev.UseVisualStyleBackColor = true;
            this.btnAppPrev.Click += new System.EventHandler(this.btnAppPrev_Click);
            // 
            // btnAppNext
            // 
            this.btnAppNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppNext.Location = new System.Drawing.Point(268, 3);
            this.btnAppNext.Name = "btnAppNext";
            this.btnAppNext.Size = new System.Drawing.Size(101, 30);
            this.btnAppNext.TabIndex = 0;
            this.btnAppNext.Text = ">";
            this.btnAppNext.UseVisualStyleBackColor = true;
            this.btnAppNext.Click += new System.EventHandler(this.btnAppNext_Click);
            // 
            // pnlAppEdit
            // 
            this.pnlAppEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.pnlAppEdit.Location = new System.Drawing.Point(139, 199);
            this.pnlAppEdit.Name = "pnlAppEdit";
            this.pnlAppEdit.Size = new System.Drawing.Size(544, 185);
            this.pnlAppEdit.TabIndex = 1;
            // 
            // mtxtTime
            // 
            this.mtxtTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "Time", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "T"));
            this.mtxtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.mtxtTime.Location = new System.Drawing.Point(132, 81);
            this.mtxtTime.Mask = "00:00:00";
            this.mtxtTime.Name = "mtxtTime";
            this.mtxtTime.Size = new System.Drawing.Size(200, 21);
            this.mtxtTime.TabIndex = 13;
            this.mtxtTime.ValidatingType = typeof(System.DateTime);
            // 
            // txtVenue
            // 
            this.txtVenue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "Venue", true));
            this.txtVenue.Location = new System.Drawing.Point(128, 156);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(204, 20);
            this.txtVenue.TabIndex = 12;
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.Location = new System.Drawing.Point(73, 156);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(49, 16);
            this.lblVenue.TabIndex = 11;
            this.lblVenue.Text = "Venue:";
            // 
            // btnAppInsert
            // 
            this.btnAppInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnAppInsert.Location = new System.Drawing.Point(358, 29);
            this.btnAppInsert.Name = "btnAppInsert";
            this.btnAppInsert.Size = new System.Drawing.Size(134, 38);
            this.btnAppInsert.TabIndex = 10;
            this.btnAppInsert.Text = "Insert appointment";
            this.btnAppInsert.UseVisualStyleBackColor = true;
            this.btnAppInsert.Click += new System.EventHandler(this.btnAppInsert_Click);
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(59, 124);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(63, 16);
            this.lblCapacity.TabIndex = 9;
            this.lblCapacity.Text = "Capacity:";
            // 
            // lblAppointmentTime
            // 
            this.lblAppointmentTime.AutoSize = true;
            this.lblAppointmentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentTime.Location = new System.Drawing.Point(9, 86);
            this.lblAppointmentTime.Name = "lblAppointmentTime";
            this.lblAppointmentTime.Size = new System.Drawing.Size(113, 16);
            this.lblAppointmentTime.TabIndex = 8;
            this.lblAppointmentTime.Text = "Appointment time:";
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDate.Location = new System.Drawing.Point(5, 51);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(117, 16);
            this.lblAppointmentDate.TabIndex = 7;
            this.lblAppointmentDate.Text = "Appointment Date:";
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentID.Location = new System.Drawing.Point(21, 15);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(101, 16);
            this.lblAppointmentID.TabIndex = 6;
            this.lblAppointmentID.Text = "Appointment ID:";
            // 
            // btnAppDelete
            // 
            this.btnAppDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppDelete.Location = new System.Drawing.Point(358, 86);
            this.btnAppDelete.Name = "btnAppDelete";
            this.btnAppDelete.Size = new System.Drawing.Size(134, 36);
            this.btnAppDelete.TabIndex = 5;
            this.btnAppDelete.Text = "Delete record";
            this.btnAppDelete.UseVisualStyleBackColor = true;
            this.btnAppDelete.Click += new System.EventHandler(this.btnAppDelete_Click);
            // 
            // btnUpdateApp
            // 
            this.btnUpdateApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateApp.Location = new System.Drawing.Point(358, 140);
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
            this.spnCapacity.Location = new System.Drawing.Point(128, 124);
            this.spnCapacity.Name = "spnCapacity";
            this.spnCapacity.Size = new System.Drawing.Size(120, 20);
            this.spnCapacity.TabIndex = 3;
            // 
            // dtpAppDate
            // 
            this.dtpAppDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "AppDate", true));
            this.dtpAppDate.Location = new System.Drawing.Point(132, 51);
            this.dtpAppDate.Name = "dtpAppDate";
            this.dtpAppDate.Size = new System.Drawing.Size(200, 20);
            this.dtpAppDate.TabIndex = 1;
            // 
            // txtAppID
            // 
            this.txtAppID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "AppID", true));
            this.txtAppID.Location = new System.Drawing.Point(132, 14);
            this.txtAppID.Name = "txtAppID";
            this.txtAppID.ReadOnly = true;
            this.txtAppID.Size = new System.Drawing.Size(100, 20);
            this.txtAppID.TabIndex = 0;
            // 
            // tpgBlood
            // 
            this.tpgBlood.Controls.Add(this.pnlRemoveBloodFilters);
            this.tpgBlood.Controls.Add(this.panel6);
            this.tpgBlood.Controls.Add(this.pnlBloodNav);
            this.tpgBlood.Controls.Add(this.panel3);
            this.tpgBlood.Controls.Add(this.dgvBlood);
            this.tpgBlood.Location = new System.Drawing.Point(4, 22);
            this.tpgBlood.Name = "tpgBlood";
            this.tpgBlood.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpgBlood.Size = new System.Drawing.Size(793, 387);
            this.tpgBlood.TabIndex = 1;
            this.tpgBlood.Text = "Blood Inventory";
            this.tpgBlood.UseVisualStyleBackColor = true;
            this.tpgBlood.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // pnlRemoveBloodFilters
            // 
            this.pnlRemoveBloodFilters.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlRemoveBloodFilters.Controls.Add(this.btnRemoveBloodFilters);
            this.pnlRemoveBloodFilters.Location = new System.Drawing.Point(513, 155);
            this.pnlRemoveBloodFilters.Name = "pnlRemoveBloodFilters";
            this.pnlRemoveBloodFilters.Size = new System.Drawing.Size(268, 33);
            this.pnlRemoveBloodFilters.TabIndex = 8;
            // 
            // btnRemoveBloodFilters
            // 
            this.btnRemoveBloodFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveBloodFilters.Location = new System.Drawing.Point(6, 6);
            this.btnRemoveBloodFilters.Name = "btnRemoveBloodFilters";
            this.btnRemoveBloodFilters.Size = new System.Drawing.Size(122, 23);
            this.btnRemoveBloodFilters.TabIndex = 1;
            this.btnRemoveBloodFilters.Text = "Remove";
            this.btnRemoveBloodFilters.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Controls.Add(this.btnEarlyExpiry);
            this.panel6.Controls.Add(this.btnLaterExpiry);
            this.panel6.Controls.Add(this.dtpExpiryFilter);
            this.panel6.Controls.Add(this.label20);
            this.panel6.Location = new System.Drawing.Point(513, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(268, 149);
            this.panel6.TabIndex = 7;
            // 
            // btnEarlyExpiry
            // 
            this.btnEarlyExpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEarlyExpiry.Location = new System.Drawing.Point(6, 83);
            this.btnEarlyExpiry.Name = "btnEarlyExpiry";
            this.btnEarlyExpiry.Size = new System.Drawing.Size(171, 32);
            this.btnEarlyExpiry.TabIndex = 3;
            this.btnEarlyExpiry.Text = "Filter by expiry date(Earlier than)";
            this.btnEarlyExpiry.UseVisualStyleBackColor = true;
            this.btnEarlyExpiry.Click += new System.EventHandler(this.btnEarlyExpiry_Click);
            // 
            // btnLaterExpiry
            // 
            this.btnLaterExpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaterExpiry.Location = new System.Drawing.Point(6, 54);
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
            this.dtpExpiryFilter.Location = new System.Drawing.Point(6, 35);
            this.dtpExpiryFilter.Name = "dtpExpiryFilter";
            this.dtpExpiryFilter.Size = new System.Drawing.Size(99, 23);
            this.dtpExpiryFilter.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 9);
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
            this.pnlBloodNav.Location = new System.Drawing.Point(8, 152);
            this.pnlBloodNav.Name = "pnlBloodNav";
            this.pnlBloodNav.Size = new System.Drawing.Size(499, 36);
            this.pnlBloodNav.TabIndex = 6;
            // 
            // btnBloodLast
            // 
            this.btnBloodLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloodLast.Location = new System.Drawing.Point(375, 3);
            this.btnBloodLast.Name = "btnBloodLast";
            this.btnBloodLast.Size = new System.Drawing.Size(105, 30);
            this.btnBloodLast.TabIndex = 3;
            this.btnBloodLast.Text = ">>|";
            this.btnBloodLast.UseVisualStyleBackColor = true;
            this.btnBloodLast.Click += new System.EventHandler(this.btnBloodLast_Click);
            // 
            // btnBloodFirst
            // 
            this.btnBloodFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloodFirst.Location = new System.Drawing.Point(9, 3);
            this.btnBloodFirst.Name = "btnBloodFirst";
            this.btnBloodFirst.Size = new System.Drawing.Size(109, 30);
            this.btnBloodFirst.TabIndex = 2;
            this.btnBloodFirst.Text = "|<<";
            this.btnBloodFirst.UseVisualStyleBackColor = true;
            this.btnBloodFirst.Click += new System.EventHandler(this.btnBloodFirst_Click);
            // 
            // btnBloodPrev
            // 
            this.btnBloodPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloodPrev.Location = new System.Drawing.Point(124, 3);
            this.btnBloodPrev.Name = "btnBloodPrev";
            this.btnBloodPrev.Size = new System.Drawing.Size(101, 30);
            this.btnBloodPrev.TabIndex = 1;
            this.btnBloodPrev.Text = "<";
            this.btnBloodPrev.UseVisualStyleBackColor = true;
            this.btnBloodPrev.Click += new System.EventHandler(this.btnBloodPrev_Click);
            // 
            // btnBllodNext
            // 
            this.btnBllodNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBllodNext.Location = new System.Drawing.Point(268, 3);
            this.btnBllodNext.Name = "btnBllodNext";
            this.btnBllodNext.Size = new System.Drawing.Size(101, 30);
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
            this.panel3.Location = new System.Drawing.Point(132, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 194);
            this.panel3.TabIndex = 1;
            // 
            // lblBloodExpiryDate
            // 
            this.lblBloodExpiryDate.AutoSize = true;
            this.lblBloodExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodExpiryDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBloodExpiryDate.Location = new System.Drawing.Point(21, 173);
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
            this.lblBloodUserID.Location = new System.Drawing.Point(46, 66);
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
            this.lblBloodAppID.Location = new System.Drawing.Point(3, 101);
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
            this.lblTypeBlood.Location = new System.Drawing.Point(26, 134);
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
            this.lblUnitID.Location = new System.Drawing.Point(52, 31);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(46, 16);
            this.lblUnitID.TabIndex = 8;
            this.lblUnitID.Text = "UnitID:";
            // 
            // btnBloodDelete
            // 
            this.btnBloodDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloodDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBloodDelete.Location = new System.Drawing.Point(263, 91);
            this.btnBloodDelete.Name = "btnBloodDelete";
            this.btnBloodDelete.Size = new System.Drawing.Size(125, 39);
            this.btnBloodDelete.TabIndex = 7;
            this.btnBloodDelete.Text = "Delete record";
            this.btnBloodDelete.UseVisualStyleBackColor = true;
            this.btnBloodDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBloodApply
            // 
            this.btnBloodApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloodApply.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBloodApply.Location = new System.Drawing.Point(263, 146);
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
            this.dtpExpiry.Location = new System.Drawing.Point(104, 172);
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
            this.cmbBloodInvType.Location = new System.Drawing.Point(104, 134);
            this.cmbBloodInvType.Name = "cmbBloodInvType";
            this.cmbBloodInvType.Size = new System.Drawing.Size(121, 21);
            this.cmbBloodInvType.TabIndex = 3;
            // 
            // txtBloodAppID
            // 
            this.txtBloodAppID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBloodInventoryBindingSource, "AppID", true));
            this.txtBloodAppID.Location = new System.Drawing.Point(104, 101);
            this.txtBloodAppID.Name = "txtBloodAppID";
            this.txtBloodAppID.ReadOnly = true;
            this.txtBloodAppID.Size = new System.Drawing.Size(121, 20);
            this.txtBloodAppID.TabIndex = 2;
            // 
            // txtBloodUserID
            // 
            this.txtBloodUserID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBloodInventoryBindingSource, "UserID", true));
            this.txtBloodUserID.Location = new System.Drawing.Point(104, 65);
            this.txtBloodUserID.Name = "txtBloodUserID";
            this.txtBloodUserID.ReadOnly = true;
            this.txtBloodUserID.Size = new System.Drawing.Size(121, 20);
            this.txtBloodUserID.TabIndex = 1;
            // 
            // txtUnitID
            // 
            this.txtUnitID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBloodInventoryBindingSource, "UnitID", true));
            this.txtUnitID.Location = new System.Drawing.Point(104, 31);
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
            this.dgvBlood.Location = new System.Drawing.Point(0, 0);
            this.dgvBlood.Name = "dgvBlood";
            this.dgvBlood.RowHeadersWidth = 51;
            this.dgvBlood.Size = new System.Drawing.Size(507, 155);
            this.dgvBlood.TabIndex = 0;
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
            this.tpgUsers.Name = "tpgUsers";
            this.tpgUsers.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpgUsers.Size = new System.Drawing.Size(793, 387);
            this.tpgUsers.TabIndex = 0;
            this.tpgUsers.Text = "    Users    ";
            this.tpgUsers.UseVisualStyleBackColor = true;
            // 
            // pnlRemoveUserFilters
            // 
            this.pnlRemoveUserFilters.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlRemoveUserFilters.Controls.Add(this.btnRemoveFilter);
            this.pnlRemoveUserFilters.Location = new System.Drawing.Point(536, 179);
            this.pnlRemoveUserFilters.Name = "pnlRemoveUserFilters";
            this.pnlRemoveUserFilters.Size = new System.Drawing.Size(251, 33);
            this.pnlRemoveUserFilters.TabIndex = 6;
            // 
            // btnRemoveFilter
            // 
            this.btnRemoveFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFilter.Location = new System.Drawing.Point(6, 7);
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
            this.pnlUserNav.Location = new System.Drawing.Point(8, 176);
            this.pnlUserNav.Name = "pnlUserNav";
            this.pnlUserNav.Size = new System.Drawing.Size(522, 36);
            this.pnlUserNav.TabIndex = 5;
            // 
            // btnUserLast
            // 
            this.btnUserLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserLast.Location = new System.Drawing.Point(390, 3);
            this.btnUserLast.Name = "btnUserLast";
            this.btnUserLast.Size = new System.Drawing.Size(121, 30);
            this.btnUserLast.TabIndex = 3;
            this.btnUserLast.Text = ">>|";
            this.btnUserLast.UseVisualStyleBackColor = true;
            this.btnUserLast.Click += new System.EventHandler(this.btnUserLast_Click);
            // 
            // btnUserFirst
            // 
            this.btnUserFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserFirst.Location = new System.Drawing.Point(9, 3);
            this.btnUserFirst.Name = "btnUserFirst";
            this.btnUserFirst.Size = new System.Drawing.Size(121, 30);
            this.btnUserFirst.TabIndex = 2;
            this.btnUserFirst.Text = "|<<";
            this.btnUserFirst.UseVisualStyleBackColor = true;
            this.btnUserFirst.Click += new System.EventHandler(this.btnUserFirst_Click);
            // 
            // btnUserPrev
            // 
            this.btnUserPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserPrev.Location = new System.Drawing.Point(136, 3);
            this.btnUserPrev.Name = "btnUserPrev";
            this.btnUserPrev.Size = new System.Drawing.Size(121, 30);
            this.btnUserPrev.TabIndex = 1;
            this.btnUserPrev.Text = "<";
            this.btnUserPrev.UseVisualStyleBackColor = true;
            this.btnUserPrev.Click += new System.EventHandler(this.btnUserPrev_Click);
            // 
            // btnUserNext
            // 
            this.btnUserNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserNext.Location = new System.Drawing.Point(263, 3);
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
            this.panel5.Controls.Add(this.cmbUserFilter);
            this.panel5.Controls.Add(this.btnUserFilter);
            this.panel5.Controls.Add(this.cmbBloodFilter);
            this.panel5.Controls.Add(this.btnBloodFilter);
            this.panel5.Controls.Add(this.btnSurnameAlphabetical);
            this.panel5.Controls.Add(this.btnNameAlphabetical);
            this.panel5.Controls.Add(this.btnFilterInactive);
            this.panel5.Controls.Add(this.btnFilterActive);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Location = new System.Drawing.Point(536, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(251, 179);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // cmbUserFilter
            // 
            this.cmbUserFilter.FormattingEnabled = true;
            this.cmbUserFilter.Items.AddRange(new object[] {
            "Admin",
            "Donor"});
            this.cmbUserFilter.Location = new System.Drawing.Point(126, 171);
            this.cmbUserFilter.Name = "cmbUserFilter";
            this.cmbUserFilter.Size = new System.Drawing.Size(73, 21);
            this.cmbUserFilter.TabIndex = 8;
            this.cmbUserFilter.Text = "Admin";
            // 
            // btnUserFilter
            // 
            this.btnUserFilter.Location = new System.Drawing.Point(6, 168);
            this.btnUserFilter.Name = "btnUserFilter";
            this.btnUserFilter.Size = new System.Drawing.Size(138, 25);
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
            this.cmbBloodFilter.Location = new System.Drawing.Point(126, 140);
            this.cmbBloodFilter.Name = "cmbBloodFilter";
            this.cmbBloodFilter.Size = new System.Drawing.Size(73, 21);
            this.cmbBloodFilter.TabIndex = 6;
            this.cmbBloodFilter.Text = "O";
            // 
            // btnBloodFilter
            // 
            this.btnBloodFilter.Location = new System.Drawing.Point(6, 136);
            this.btnBloodFilter.Name = "btnBloodFilter";
            this.btnBloodFilter.Size = new System.Drawing.Size(138, 26);
            this.btnBloodFilter.TabIndex = 5;
            this.btnBloodFilter.Text = "Filter by blood type";
            this.btnBloodFilter.UseVisualStyleBackColor = true;
            this.btnBloodFilter.Click += new System.EventHandler(this.btnBloodFilter_Click);
            // 
            // btnSurnameAlphabetical
            // 
            this.btnSurnameAlphabetical.Location = new System.Drawing.Point(6, 104);
            this.btnSurnameAlphabetical.Name = "btnSurnameAlphabetical";
            this.btnSurnameAlphabetical.Size = new System.Drawing.Size(193, 26);
            this.btnSurnameAlphabetical.TabIndex = 4;
            this.btnSurnameAlphabetical.Text = "Sort alphabetically(Surname)";
            this.btnSurnameAlphabetical.UseVisualStyleBackColor = true;
            this.btnSurnameAlphabetical.Click += new System.EventHandler(this.btnSurnameAlphabetical_Click);
            // 
            // btnNameAlphabetical
            // 
            this.btnNameAlphabetical.Location = new System.Drawing.Point(6, 72);
            this.btnNameAlphabetical.Name = "btnNameAlphabetical";
            this.btnNameAlphabetical.Size = new System.Drawing.Size(193, 26);
            this.btnNameAlphabetical.TabIndex = 3;
            this.btnNameAlphabetical.Text = "Sort alphabetically(Name)";
            this.btnNameAlphabetical.UseVisualStyleBackColor = true;
            this.btnNameAlphabetical.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnFilterInactive
            // 
            this.btnFilterInactive.Location = new System.Drawing.Point(105, 38);
            this.btnFilterInactive.Name = "btnFilterInactive";
            this.btnFilterInactive.Size = new System.Drawing.Size(94, 28);
            this.btnFilterInactive.TabIndex = 2;
            this.btnFilterInactive.Text = "Filter by inactive";
            this.btnFilterInactive.UseVisualStyleBackColor = true;
            this.btnFilterInactive.Click += new System.EventHandler(this.btnFilterInactive_Click);
            // 
            // btnFilterActive
            // 
            this.btnFilterActive.Location = new System.Drawing.Point(6, 38);
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
            this.label19.Location = new System.Drawing.Point(3, 10);
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
            this.dgvUsers.Location = new System.Drawing.Point(6, 0);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.Size = new System.Drawing.Size(524, 170);
            this.dgvUsers.TabIndex = 3;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
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
            this.iDNumberDataGridViewTextBoxColumn.HeaderText = "IDNumber";
            this.iDNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDNumberDataGridViewTextBoxColumn.Name = "iDNumberDataGridViewTextBoxColumn";
            this.iDNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "UserType";
            this.userTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            this.userTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // bloodTypeDataGridViewTextBoxColumn
            // 
            this.bloodTypeDataGridViewTextBoxColumn.DataPropertyName = "BloodType";
            this.bloodTypeDataGridViewTextBoxColumn.HeaderText = "BloodType";
            this.bloodTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bloodTypeDataGridViewTextBoxColumn.Name = "bloodTypeDataGridViewTextBoxColumn";
            this.bloodTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // isActiveAccountDataGridViewCheckBoxColumn
            // 
            this.isActiveAccountDataGridViewCheckBoxColumn.DataPropertyName = "isActiveAccount";
            this.isActiveAccountDataGridViewCheckBoxColumn.HeaderText = "isActiveAccount";
            this.isActiveAccountDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isActiveAccountDataGridViewCheckBoxColumn.Name = "isActiveAccountDataGridViewCheckBoxColumn";
            this.isActiveAccountDataGridViewCheckBoxColumn.Width = 125;
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
            this.pnlUserEdit.Location = new System.Drawing.Point(100, 215);
            this.pnlUserEdit.Name = "pnlUserEdit";
            this.pnlUserEdit.Size = new System.Drawing.Size(635, 163);
            this.pnlUserEdit.TabIndex = 2;
            // 
            // btnStartInsert
            // 
            this.btnStartInsert.Location = new System.Drawing.Point(469, 28);
            this.btnStartInsert.Name = "btnStartInsert";
            this.btnStartInsert.Size = new System.Drawing.Size(121, 35);
            this.btnStartInsert.TabIndex = 21;
            this.btnStartInsert.Text = "Insert a User";
            this.btnStartInsert.UseVisualStyleBackColor = true;
            this.btnStartInsert.Click += new System.EventHandler(this.btnStartInsert_Click);
            // 
            // btnInsertUser
            // 
            this.btnInsertUser.Location = new System.Drawing.Point(469, 20);
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
            this.lblUserType.Location = new System.Drawing.Point(240, 63);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(74, 16);
            this.lblUserType.TabIndex = 19;
            this.lblUserType.Text = "User Type:";
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodType.Location = new System.Drawing.Point(233, 89);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(81, 16);
            this.lblBloodType.TabIndex = 18;
            this.lblBloodType.Text = "Blood Type:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(36, 86);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(19, 112);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(64, 16);
            this.lblSurname.TabIndex = 16;
            this.lblSurname.Text = "Surname:";
            // 
            // lblIDNum
            // 
            this.lblIDNum.AutoSize = true;
            this.lblIDNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNum.Location = new System.Drawing.Point(13, 138);
            this.lblIDNum.Name = "lblIDNum";
            this.lblIDNum.Size = new System.Drawing.Size(74, 16);
            this.lblIDNum.TabIndex = 15;
            this.lblIDNum.Text = "ID Number:";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.Location = new System.Drawing.Point(217, 34);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(97, 16);
            this.lblPhoneNum.TabIndex = 14;
            this.lblPhoneNum.Text = "Phone number:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(13, 59);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 16);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(31, 35);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(52, 16);
            this.lblUserID.TabIndex = 12;
            this.lblUserID.Text = "UserID:";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(469, 79);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(121, 31);
            this.btnDeleteUser.TabIndex = 11;
            this.btnDeleteUser.Text = "Delete record";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(469, 123);
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
            this.chkActive.Location = new System.Drawing.Point(320, 114);
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
            this.cmbUser.Location = new System.Drawing.Point(320, 61);
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
            this.cmbBlood.Location = new System.Drawing.Point(320, 86);
            this.cmbBlood.Name = "cmbBlood";
            this.cmbBlood.Size = new System.Drawing.Size(121, 24);
            this.cmbBlood.TabIndex = 7;
            this.cmbBlood.SelectionChangeCommitted += new System.EventHandler(this.cmbBlood_SelectionChangeCommitted);
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "PhoneNumber", true));
            this.txtPhone.Location = new System.Drawing.Point(320, 34);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "IDNumber", true));
            this.txtID.Location = new System.Drawing.Point(89, 138);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 4;
            // 
            // txtSurname
            // 
            this.txtSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "Surname", true));
            this.txtSurname.Location = new System.Drawing.Point(89, 112);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 22);
            this.txtSurname.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "Name", true));
            this.txtName.Location = new System.Drawing.Point(89, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "Password", true));
            this.txtPassword.Location = new System.Drawing.Point(89, 60);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUserID
            // 
            this.txtUserID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "UserID", true));
            this.txtUserID.Location = new System.Drawing.Point(89, 34);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(100, 22);
            this.txtUserID.TabIndex = 0;
            // 
            // btnCancelInsert
            // 
            this.btnCancelInsert.Location = new System.Drawing.Point(469, 74);
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
            this.tcAdmin.Location = new System.Drawing.Point(0, 41);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(801, 413);
            this.tcAdmin.TabIndex = 2;
            this.tcAdmin.SelectedIndexChanged += new System.EventHandler(this.tcAdmin_SelectedIndexChanged);
            // 
            // tpgSchedule
            // 
            this.tpgSchedule.Controls.Add(this.panel1);
            this.tpgSchedule.Controls.Add(this.pnlSchedule);
            this.tpgSchedule.Controls.Add(this.dgvSchedule);
            this.tpgSchedule.Location = new System.Drawing.Point(4, 22);
            this.tpgSchedule.Name = "tpgSchedule";
            this.tpgSchedule.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpgSchedule.Size = new System.Drawing.Size(793, 387);
            this.tpgSchedule.TabIndex = 3;
            this.tpgSchedule.Text = "   Schedule   ";
            this.tpgSchedule.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnCountSchedules);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(480, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 180);
            this.panel1.TabIndex = 8;
            // 
            // btnCountSchedules
            // 
            this.btnCountSchedules.Location = new System.Drawing.Point(16, 36);
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
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filters/sorting:";
            // 
            // pnlSchedule
            // 
            this.pnlSchedule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSchedule.Controls.Add(this.txtSearchByApp);
            this.pnlSchedule.Controls.Add(this.txtSearchByUser);
            this.pnlSchedule.Controls.Add(this.btnScheduleEventSearch);
            this.pnlSchedule.Controls.Add(this.btnScheduleUserSearch);
            this.pnlSchedule.Controls.Add(this.redDisplay);
            this.pnlSchedule.Controls.Add(this.pnlShortStats);
            this.pnlSchedule.Location = new System.Drawing.Point(8, 192);
            this.pnlSchedule.Name = "pnlSchedule";
            this.pnlSchedule.Size = new System.Drawing.Size(777, 187);
            this.pnlSchedule.TabIndex = 1;
            // 
            // txtSearchByApp
            // 
            this.txtSearchByApp.Location = new System.Drawing.Point(419, 133);
            this.txtSearchByApp.Name = "txtSearchByApp";
            this.txtSearchByApp.Size = new System.Drawing.Size(120, 20);
            this.txtSearchByApp.TabIndex = 6;
            // 
            // txtSearchByUser
            // 
            this.txtSearchByUser.Location = new System.Drawing.Point(419, 68);
            this.txtSearchByUser.Name = "txtSearchByUser";
            this.txtSearchByUser.Size = new System.Drawing.Size(120, 20);
            this.txtSearchByUser.TabIndex = 5;
            this.txtSearchByUser.Enter += new System.EventHandler(this.txtSearchByUser_Enter);
            this.txtSearchByUser.Leave += new System.EventHandler(this.txtSearchByUser_Leave);
            // 
            // btnScheduleEventSearch
            // 
            this.btnScheduleEventSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnScheduleEventSearch.Location = new System.Drawing.Point(419, 105);
            this.btnScheduleEventSearch.Name = "btnScheduleEventSearch";
            this.btnScheduleEventSearch.Size = new System.Drawing.Size(120, 36);
            this.btnScheduleEventSearch.TabIndex = 4;
            this.btnScheduleEventSearch.Text = "Search by Event";
            this.btnScheduleEventSearch.UseVisualStyleBackColor = true;
            this.btnScheduleEventSearch.Click += new System.EventHandler(this.btnScheduleEventSearch_Click);
            // 
            // btnScheduleUserSearch
            // 
            this.btnScheduleUserSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnScheduleUserSearch.Location = new System.Drawing.Point(419, 36);
            this.btnScheduleUserSearch.Name = "btnScheduleUserSearch";
            this.btnScheduleUserSearch.Size = new System.Drawing.Size(120, 36);
            this.btnScheduleUserSearch.TabIndex = 3;
            this.btnScheduleUserSearch.Text = "Search by User";
            this.btnScheduleUserSearch.UseVisualStyleBackColor = true;
            this.btnScheduleUserSearch.Click += new System.EventHandler(this.btnScheduleUserSearch_Click);
            // 
            // redDisplay
            // 
            this.redDisplay.Location = new System.Drawing.Point(557, 17);
            this.redDisplay.Name = "redDisplay";
            this.redDisplay.Size = new System.Drawing.Size(217, 158);
            this.redDisplay.TabIndex = 2;
            this.redDisplay.Text = "";
            // 
            // pnlShortStats
            // 
            this.pnlShortStats.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlShortStats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlShortStats.Controls.Add(this.lblUnattended);
            this.pnlShortStats.Controls.Add(this.lblAttended);
            this.pnlShortStats.Controls.Add(this.lblSchedules);
            this.pnlShortStats.Controls.Add(this.lblShortStats);
            this.pnlShortStats.Location = new System.Drawing.Point(3, 3);
            this.pnlShortStats.Name = "pnlShortStats";
            this.pnlShortStats.Size = new System.Drawing.Size(338, 181);
            this.pnlShortStats.TabIndex = 1;
            // 
            // lblUnattended
            // 
            this.lblUnattended.AutoSize = true;
            this.lblUnattended.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblUnattended.Location = new System.Drawing.Point(12, 111);
            this.lblUnattended.Name = "lblUnattended";
            this.lblUnattended.Size = new System.Drawing.Size(210, 16);
            this.lblUnattended.TabIndex = 3;
            this.lblUnattended.Text = "Number of schedules unattended: ";
            // 
            // lblAttended
            // 
            this.lblAttended.AutoSize = true;
            this.lblAttended.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblAttended.Location = new System.Drawing.Point(12, 77);
            this.lblAttended.Name = "lblAttended";
            this.lblAttended.Size = new System.Drawing.Size(193, 16);
            this.lblAttended.TabIndex = 2;
            this.lblAttended.Text = "Number of schedules attended:";
            // 
            // lblSchedules
            // 
            this.lblSchedules.AutoSize = true;
            this.lblSchedules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblSchedules.Location = new System.Drawing.Point(12, 45);
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
            this.dgvSchedule.Location = new System.Drawing.Point(8, 6);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowHeadersWidth = 51;
            this.dgvSchedule.Size = new System.Drawing.Size(466, 180);
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
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataMember = "Schedule";
            this.scheduleBindingSource.DataSource = this.ist2jwDataSet;
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
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 474);
            this.Controls.Add(this.tcAdmin);
            this.Controls.Add(this.pnlTopBar);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSchedule.ResumeLayout(false);
            this.pnlSchedule.PerformLayout();
            this.pnlShortStats.ResumeLayout(false);
            this.pnlShortStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveAccountDataGridViewCheckBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
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
        private System.Windows.Forms.Button btnScheduleEventSearch;
        private System.Windows.Forms.Button btnStartInsert;
        private System.Windows.Forms.Button btnCancelInsert;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.MaskedTextBox mtxtTime;
        private System.Windows.Forms.Button btnFilterPassed;
        private System.Windows.Forms.Button btnFilterUpcoming;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtSearchByApp;
        private System.Windows.Forms.TextBox txtSearchByUser;
        private System.Windows.Forms.Button btnEarlyExpiry;
        private System.Windows.Forms.Button btnLaterExpiry;
        private System.Windows.Forms.DateTimePicker dtpExpiryFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCountSchedules;
        private System.Windows.Forms.Label label1;
    }
}