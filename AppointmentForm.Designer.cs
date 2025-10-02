namespace BloodBankSystem
{
    partial class AppointmentForm
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
            System.Windows.Forms.Label timeLabel1;
            System.Windows.Forms.Label scheduleIDLabel1;
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label appIDLabel2;
            System.Windows.Forms.Label attendedLabel1;
            System.Windows.Forms.Label scheduleIDLabel;
            System.Windows.Forms.Label timeLabel;
            System.Windows.Forms.Label appIDLabel1;
            System.Windows.Forms.Label capacityLabel;
            System.Windows.Forms.Label venueLabel1;
            System.Windows.Forms.Label venueLabel;
            System.Windows.Forms.Label attendedLabel;
            System.Windows.Forms.Label appDateLabel;
            this.btnHome = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.searchDateTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timeTextBox1 = new System.Windows.Forms.TextBox();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ist2jwDataSet = new BloodBankSystem.ist2jwDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.appointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.appIDTextBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.searchScheduleDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tblUserScheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.tblUserScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.scheduleIDTextBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.sortAttendedBtn = new System.Windows.Forms.Button();
            this.sortVenueBtn = new System.Windows.Forms.Button();
            this.sortDateBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.scheduleFilterCmbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.filterScheduleVenueCmbx = new System.Windows.Forms.ComboBox();
            this.filterScheduleAttendedCheckBox = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.filterScheduleMonthCmbx = new System.Windows.Forms.ComboBox();
            this.filterScheduleYearCmbx = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.sortAppointmentDateBtn = new System.Windows.Forms.Button();
            this.sortAppointmentsVenueBtn = new System.Windows.Forms.Button();
            this.scheduleIDTextBox = new System.Windows.Forms.TextBox();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userIDScheduleTextBox = new System.Windows.Forms.TextBox();
            this.appIDScheduleTextBox = new System.Windows.Forms.TextBox();
            this.attendedScheduleCheckBox = new System.Windows.Forms.CheckBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.filterSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filterAppYearCmbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filterAppCapacityCmbx = new System.Windows.Forms.ComboBox();
            this.filterAppVenueCmbx = new System.Windows.Forms.ComboBox();
            this.filterAppMonthCmbx = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.filterAppointmentsBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.appointmentTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.AppointmentTableAdapter();
            this.tblUserScheduleTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.tblUserScheduleTableAdapter();
            this.scheduleTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.ScheduleTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.venueTextBox1 = new System.Windows.Forms.TextBox();
            this.btnBookAppointment = new System.Windows.Forms.Button();
            this.attendedCheckBox = new System.Windows.Forms.CheckBox();
            this.venueTextBox = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.tableAdapterManager = new BloodBankSystem.ist2jwDataSetTableAdapters.TableAdapterManager();
            this.appDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            timeLabel1 = new System.Windows.Forms.Label();
            scheduleIDLabel1 = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            appIDLabel2 = new System.Windows.Forms.Label();
            attendedLabel1 = new System.Windows.Forms.Label();
            scheduleIDLabel = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            appIDLabel1 = new System.Windows.Forms.Label();
            capacityLabel = new System.Windows.Forms.Label();
            venueLabel1 = new System.Windows.Forms.Label();
            venueLabel = new System.Windows.Forms.Label();
            attendedLabel = new System.Windows.Forms.Label();
            appDateLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2jwDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserScheduleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserScheduleBindingSource)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            this.panel8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeLabel1
            // 
            timeLabel1.AutoSize = true;
            timeLabel1.Location = new System.Drawing.Point(111, 24);
            timeLabel1.Name = "timeLabel1";
            timeLabel1.Size = new System.Drawing.Size(41, 16);
            timeLabel1.TabIndex = 18;
            timeLabel1.Text = "Time:";
            // 
            // scheduleIDLabel1
            // 
            scheduleIDLabel1.AutoSize = true;
            scheduleIDLabel1.Enabled = false;
            scheduleIDLabel1.Location = new System.Drawing.Point(57, 417);
            scheduleIDLabel1.Name = "scheduleIDLabel1";
            scheduleIDLabel1.Size = new System.Drawing.Size(83, 16);
            scheduleIDLabel1.TabIndex = 32;
            scheduleIDLabel1.Text = "Schedule ID:";
            scheduleIDLabel1.Visible = false;
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Enabled = false;
            userIDLabel.Location = new System.Drawing.Point(57, 300);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(55, 16);
            userIDLabel.TabIndex = 34;
            userIDLabel.Text = "User ID:";
            userIDLabel.Visible = false;
            // 
            // appIDLabel2
            // 
            appIDLabel2.AutoSize = true;
            appIDLabel2.Enabled = false;
            appIDLabel2.Location = new System.Drawing.Point(57, 401);
            appIDLabel2.Name = "appIDLabel2";
            appIDLabel2.Size = new System.Drawing.Size(81, 16);
            appIDLabel2.TabIndex = 36;
            appIDLabel2.Text = "App_Sch ID:";
            appIDLabel2.Visible = false;
            // 
            // attendedLabel1
            // 
            attendedLabel1.AutoSize = true;
            attendedLabel1.Enabled = false;
            attendedLabel1.Location = new System.Drawing.Point(57, 431);
            attendedLabel1.Name = "attendedLabel1";
            attendedLabel1.Size = new System.Drawing.Size(64, 16);
            attendedLabel1.TabIndex = 38;
            attendedLabel1.Text = "Attended:";
            attendedLabel1.Visible = false;
            // 
            // scheduleIDLabel
            // 
            scheduleIDLabel.AutoSize = true;
            scheduleIDLabel.Location = new System.Drawing.Point(622, 33);
            scheduleIDLabel.Name = "scheduleIDLabel";
            scheduleIDLabel.Size = new System.Drawing.Size(83, 16);
            scheduleIDLabel.TabIndex = 22;
            scheduleIDLabel.Text = "Schedule ID:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(103, 35);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(41, 16);
            timeLabel.TabIndex = 28;
            timeLabel.Text = "Time:";
            // 
            // appIDLabel1
            // 
            appIDLabel1.AutoSize = true;
            appIDLabel1.Location = new System.Drawing.Point(61, 334);
            appIDLabel1.Name = "appIDLabel1";
            appIDLabel1.Size = new System.Drawing.Size(51, 16);
            appIDLabel1.TabIndex = 14;
            appIDLabel1.Text = "App ID:";
            appIDLabel1.Visible = false;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 17);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(68, 29);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(6, 21);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(98, 23);
            this.btnFirst.TabIndex = 7;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.appointmentDataGridView);
            this.panel1.Location = new System.Drawing.Point(9, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 465);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.searchDateTime);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Location = new System.Drawing.Point(519, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(408, 50);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // searchDateTime
            // 
            this.searchDateTime.Location = new System.Drawing.Point(77, 17);
            this.searchDateTime.Name = "searchDateTime";
            this.searchDateTime.Size = new System.Drawing.Size(239, 22);
            this.searchDateTime.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(324, 17);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.monthCalendar2);
            this.groupBox3.Controls.Add(this.btnBookAppointment);
            this.groupBox3.Controls.Add(capacityLabel);
            this.groupBox3.Controls.Add(this.capacityTextBox);
            this.groupBox3.Controls.Add(venueLabel1);
            this.groupBox3.Controls.Add(this.venueTextBox1);
            this.groupBox3.Controls.Add(this.timeTextBox1);
            this.groupBox3.Controls.Add(timeLabel1);
            this.groupBox3.Location = new System.Drawing.Point(519, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 382);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment Details";
            // 
            // timeTextBox1
            // 
            this.timeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "Time", true));
            this.timeTextBox1.Location = new System.Drawing.Point(166, 21);
            this.timeTextBox1.Name = "timeTextBox1";
            this.timeTextBox1.ReadOnly = true;
            this.timeTextBox1.Size = new System.Drawing.Size(133, 22);
            this.timeTextBox1.TabIndex = 19;
            this.timeTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(19, 400);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 51);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Navigation";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(253, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 26);
            this.button2.TabIndex = 28;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_3);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 26);
            this.button1.TabIndex = 27;
            this.button1.Text = "Last";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(128, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 26);
            this.button3.TabIndex = 26;
            this.button3.Text = "Prev";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(17, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 26);
            this.button4.TabIndex = 25;
            this.button4.Text = "First";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_2);
            // 
            // appointmentDataGridView
            // 
            this.appointmentDataGridView.AutoGenerateColumns = false;
            this.appointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.appointmentDataGridView.DataSource = this.appointmentBindingSource;
            this.appointmentDataGridView.Location = new System.Drawing.Point(17, 13);
            this.appointmentDataGridView.Name = "appointmentDataGridView";
            this.appointmentDataGridView.RowHeadersWidth = 51;
            this.appointmentDataGridView.RowTemplate.Height = 24;
            this.appointmentDataGridView.Size = new System.Drawing.Size(495, 389);
            this.appointmentDataGridView.TabIndex = 14;
            // 
            // appIDTextBox1
            // 
            this.appIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "AppID", true));
            this.appIDTextBox1.Location = new System.Drawing.Point(132, 328);
            this.appIDTextBox1.Name = "appIDTextBox1";
            this.appIDTextBox1.ReadOnly = true;
            this.appIDTextBox1.Size = new System.Drawing.Size(104, 22);
            this.appIDTextBox1.TabIndex = 15;
            this.appIDTextBox1.Visible = false;
            this.appIDTextBox1.TextChanged += new System.EventHandler(this.appIDTextBox1_TextChanged);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Venue";
            this.dataGridViewTextBoxColumn5.HeaderText = "Venue";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // appIDTextBox1
            // 
            this.appIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "AppID", true));
            this.appIDTextBox1.Location = new System.Drawing.Point(99, 443);
            this.appIDTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.appIDTextBox1.Name = "appIDTextBox1";
            this.appIDTextBox1.ReadOnly = true;
            this.appIDTextBox1.Size = new System.Drawing.Size(79, 20);
            this.appIDTextBox1.TabIndex = 15;
            this.appIDTextBox1.TextChanged += new System.EventHandler(this.appIDTextBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.groupBox10);
            this.panel2.Controls.Add(this.tblUserScheduleDataGridView);
            this.panel2.Controls.Add(this.groupBox7);
            this.panel2.Controls.Add(scheduleIDLabel);
            this.panel2.Controls.Add(this.scheduleIDTextBox1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(6, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 450);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.button10);
            this.groupBox10.Controls.Add(this.searchScheduleDate);
            this.groupBox10.Controls.Add(this.label7);
            this.groupBox10.Location = new System.Drawing.Point(499, 18);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(412, 60);
            this.groupBox10.TabIndex = 35;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Search";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(316, 21);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 2;
            this.button10.Text = "Search";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // searchScheduleDate
            // 
            this.searchScheduleDate.Location = new System.Drawing.Point(62, 21);
            this.searchScheduleDate.Name = "searchScheduleDate";
            this.searchScheduleDate.Size = new System.Drawing.Size(248, 22);
            this.searchScheduleDate.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Date";
            // 
            // tblUserScheduleDataGridView
            // 
            this.tblUserScheduleDataGridView.AutoGenerateColumns = false;
            this.tblUserScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblUserScheduleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewCheckBoxColumn1});
            this.tblUserScheduleDataGridView.DataSource = this.tblUserScheduleBindingSource;
            this.tblUserScheduleDataGridView.Location = new System.Drawing.Point(16, 18);
            this.tblUserScheduleDataGridView.Name = "tblUserScheduleDataGridView";
            this.tblUserScheduleDataGridView.ReadOnly = true;
            this.tblUserScheduleDataGridView.RowHeadersWidth = 51;
            this.tblUserScheduleDataGridView.RowTemplate.Height = 24;
            this.tblUserScheduleDataGridView.Size = new System.Drawing.Size(463, 346);
            this.tblUserScheduleDataGridView.TabIndex = 10;
            this.tblUserScheduleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblUserScheduleDataGridView_CellContentClick);
            // 
            // tblUserScheduleBindingSource
            // 
            this.tblUserScheduleBindingSource.DataMember = "tblUserSchedule";
            this.tblUserScheduleBindingSource.DataSource = this.ist2jwDataSet;
            this.tblUserScheduleBindingSource.CurrentChanged += new System.EventHandler(this.tblUserScheduleBindingSource_CurrentChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.monthCalendar1);
            this.groupBox7.Controls.Add(venueLabel);
            this.groupBox7.Controls.Add(this.attendedCheckBox);
            this.groupBox7.Controls.Add(attendedLabel);
            this.groupBox7.Controls.Add(this.venueTextBox);
            this.groupBox7.Controls.Add(this.timeTextBox);
            this.groupBox7.Controls.Add(timeLabel);
            this.groupBox7.Location = new System.Drawing.Point(499, 84);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(412, 346);
            this.groupBox7.TabIndex = 34;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Schedule Details";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // timeTextBox
            // 
            this.timeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUserScheduleBindingSource, "Time", true));
            this.timeTextBox.Enabled = false;
            this.timeTextBox.Location = new System.Drawing.Point(167, 29);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.ReadOnly = true;
            this.timeTextBox.Size = new System.Drawing.Size(155, 22);
            this.timeTextBox.TabIndex = 29;
            this.timeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // scheduleIDTextBox1
            // 
            this.scheduleIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUserScheduleBindingSource, "ScheduleID", true));
            this.scheduleIDTextBox1.Enabled = false;
            this.scheduleIDTextBox1.Location = new System.Drawing.Point(711, 30);
            this.scheduleIDTextBox1.Name = "scheduleIDTextBox1";
            this.scheduleIDTextBox1.Size = new System.Drawing.Size(200, 22);
            this.scheduleIDTextBox1.TabIndex = 23;
            this.scheduleIDTextBox1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFirst);
            this.groupBox1.Controls.Add(this.btnPrev);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnLast);
            this.groupBox1.Location = new System.Drawing.Point(16, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 60);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigation";
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(110, 21);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(103, 23);
            this.btnPrev.TabIndex = 8;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(219, 21);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(107, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(332, 21);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(99, 23);
            this.btnLast.TabIndex = 10;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.Controls.Add(this.groupBox8);
            this.panel3.Location = new System.Drawing.Point(947, 299);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 161);
            this.panel3.TabIndex = 10;
            this.panel3.Tag = "";
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button7);
            this.groupBox8.Controls.Add(this.sortAttendedBtn);
            this.groupBox8.Controls.Add(this.sortVenueBtn);
            this.groupBox8.Controls.Add(this.sortDateBtn);
            this.groupBox8.Location = new System.Drawing.Point(18, 8);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(280, 133);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Sort";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(154, 57);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(111, 33);
            this.button7.TabIndex = 4;
            this.button7.Text = "Venue DESC";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // sortAttendedBtn
            // 
            this.sortAttendedBtn.Location = new System.Drawing.Point(34, 22);
            this.sortAttendedBtn.Name = "sortAttendedBtn";
            this.sortAttendedBtn.Size = new System.Drawing.Size(84, 26);
            this.sortAttendedBtn.TabIndex = 2;
            this.sortAttendedBtn.Text = "Last Attended";
            this.sortAttendedBtn.UseVisualStyleBackColor = true;
            this.sortAttendedBtn.Click += new System.EventHandler(this.sortAttendedBtn_Click);
            // 
            // sortVenueBtn
            // 
            this.sortVenueBtn.Location = new System.Drawing.Point(34, 60);
            this.sortVenueBtn.Name = "sortVenueBtn";
            this.sortVenueBtn.Size = new System.Drawing.Size(112, 32);
            this.sortVenueBtn.TabIndex = 3;
            this.sortVenueBtn.Text = "Venue ASC";
            this.sortVenueBtn.UseVisualStyleBackColor = true;
            this.sortVenueBtn.Click += new System.EventHandler(this.sortVenueBtn_Click);
            // 
            // sortDateBtn
            // 
            this.sortDateBtn.Location = new System.Drawing.Point(153, 22);
            this.sortDateBtn.Name = "sortDateBtn";
            this.sortDateBtn.Size = new System.Drawing.Size(84, 26);
            this.sortDateBtn.TabIndex = 0;
            this.sortDateBtn.Text = "Latest Date";
            this.sortDateBtn.UseVisualStyleBackColor = true;
            this.sortDateBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(524, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "MY APPOINTMENTS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.IndianRed;
            this.panel4.Controls.Add(this.groupBox9);
            this.panel4.Location = new System.Drawing.Point(947, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(320, 283);
            this.panel4.TabIndex = 13;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button9);
            this.groupBox9.Controls.Add(this.label6);
            this.groupBox9.Controls.Add(this.scheduleFilterCmbx);
            this.groupBox9.Controls.Add(this.label5);
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Controls.Add(this.filterScheduleVenueCmbx);
            this.groupBox9.Controls.Add(this.filterScheduleAttendedCheckBox);
            this.groupBox9.Controls.Add(this.label8);
            this.groupBox9.Controls.Add(this.filterScheduleMonthCmbx);
            this.groupBox9.Controls.Add(this.filterScheduleYearCmbx);
            this.groupBox9.Location = new System.Drawing.Point(18, 8);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(280, 257);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Filter";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(82, 207);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(121, 37);
            this.button9.TabIndex = 27;
            this.button9.Text = "Apply Filter";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Filter By";
            // 
            // scheduleFilterCmbx
            // 
            this.scheduleFilterCmbx.FormattingEnabled = true;
            this.scheduleFilterCmbx.Items.AddRange(new object[] {
            "Year",
            "Month",
            "Venue",
            "Attended"});
            this.scheduleFilterCmbx.Location = new System.Drawing.Point(138, 27);
            this.scheduleFilterCmbx.Name = "scheduleFilterCmbx";
            this.scheduleFilterCmbx.Size = new System.Drawing.Size(121, 24);
            this.scheduleFilterCmbx.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Venue";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Month";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // filterScheduleVenueCmbx
            // 
            this.filterScheduleVenueCmbx.DataSource = this.ist2jwDataSet;
            this.filterScheduleVenueCmbx.DisplayMember = "Appointment.Venue";
            this.filterScheduleVenueCmbx.FormattingEnabled = true;
            this.filterScheduleVenueCmbx.Location = new System.Drawing.Point(138, 132);
            this.filterScheduleVenueCmbx.Name = "filterScheduleVenueCmbx";
            this.filterScheduleVenueCmbx.Size = new System.Drawing.Size(121, 24);
            this.filterScheduleVenueCmbx.TabIndex = 22;
            this.filterScheduleVenueCmbx.ValueMember = "Appointment.Venue";
            // 
            // filterScheduleAttendedCheckBox
            // 
            this.filterScheduleAttendedCheckBox.AutoSize = true;
            this.filterScheduleAttendedCheckBox.Location = new System.Drawing.Point(138, 172);
            this.filterScheduleAttendedCheckBox.Name = "filterScheduleAttendedCheckBox";
            this.filterScheduleAttendedCheckBox.Size = new System.Drawing.Size(82, 20);
            this.filterScheduleAttendedCheckBox.TabIndex = 21;
            this.filterScheduleAttendedCheckBox.TabStop = true;
            this.filterScheduleAttendedCheckBox.Text = "Attended";
            this.filterScheduleAttendedCheckBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Year";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // filterScheduleMonthCmbx
            // 
            this.filterScheduleMonthCmbx.FormattingEnabled = true;
            this.filterScheduleMonthCmbx.Items.AddRange(new object[] {
            "01 January",
            "02 Feburary",
            "03 March",
            "04 April",
            "05 May",
            "06 June",
            "07 July",
            "08 August ",
            "09 September",
            "10 October ",
            "11 November",
            "12 December"});
            this.filterScheduleMonthCmbx.Location = new System.Drawing.Point(138, 97);
            this.filterScheduleMonthCmbx.Name = "filterScheduleMonthCmbx";
            this.filterScheduleMonthCmbx.Size = new System.Drawing.Size(121, 24);
            this.filterScheduleMonthCmbx.TabIndex = 19;
            this.filterScheduleMonthCmbx.SelectedIndexChanged += new System.EventHandler(this.monthFilterCmbx_SelectedIndexChanged);
            // 
            // filterScheduleYearCmbx
            // 
            this.filterScheduleYearCmbx.FormattingEnabled = true;
            this.filterScheduleYearCmbx.Items.AddRange(new object[] {
            "2025",
            "2026",
            "2027"});
            this.filterScheduleYearCmbx.Location = new System.Drawing.Point(138, 62);
            this.filterScheduleYearCmbx.Name = "filterScheduleYearCmbx";
            this.filterScheduleYearCmbx.Size = new System.Drawing.Size(121, 24);
            this.filterScheduleYearCmbx.TabIndex = 18;
            this.filterScheduleYearCmbx.SelectedIndexChanged += new System.EventHandler(this.yearFilterCmbx_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1292, 506);
            this.tabControl1.TabIndex = 15;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.Firebrick;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Controls.Add(scheduleIDLabel1);
            this.tabPage1.Controls.Add(this.appIDTextBox1);
            this.tabPage1.Controls.Add(this.scheduleIDTextBox);
            this.tabPage1.Controls.Add(appIDLabel1);
            this.tabPage1.Controls.Add(userIDLabel);
            this.tabPage1.Controls.Add(this.userIDScheduleTextBox);
            this.tabPage1.Controls.Add(appIDLabel2);
            this.tabPage1.Controls.Add(this.appIDScheduleTextBox);
            this.tabPage1.Controls.Add(attendedLabel1);
            this.tabPage1.Controls.Add(this.attendedScheduleCheckBox);
            this.tabPage1.Controls.Add(this.panel8);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1284, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Book Appointment";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.IndianRed;
            this.panel7.Controls.Add(this.groupBox6);
            this.panel7.Location = new System.Drawing.Point(957, 281);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(311, 190);
            this.panel7.TabIndex = 10;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button8);
            this.groupBox6.Controls.Add(this.sortAppointmentDateBtn);
            this.groupBox6.Controls.Add(this.sortAppointmentsVenueBtn);
            this.groupBox6.Location = new System.Drawing.Point(19, 9);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(270, 167);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sort";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(65, 67);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(160, 34);
            this.button8.TabIndex = 7;
            this.button8.Text = "Venue (Ascending)";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // sortAppointmentDateBtn
            // 
            this.sortAppointmentDateBtn.Location = new System.Drawing.Point(65, 23);
            this.sortAppointmentDateBtn.Name = "sortAppointmentDateBtn";
            this.sortAppointmentDateBtn.Size = new System.Drawing.Size(160, 34);
            this.sortAppointmentDateBtn.TabIndex = 5;
            this.sortAppointmentDateBtn.Text = "Date (Descending)";
            this.sortAppointmentDateBtn.UseVisualStyleBackColor = true;
            this.sortAppointmentDateBtn.Click += new System.EventHandler(this.sortAppointmentDateBtn_Click_1);
            // 
            // sortAppointmentsVenueBtn
            // 
            this.sortAppointmentsVenueBtn.Location = new System.Drawing.Point(65, 107);
            this.sortAppointmentsVenueBtn.Name = "sortAppointmentsVenueBtn";
            this.sortAppointmentsVenueBtn.Size = new System.Drawing.Size(160, 34);
            this.sortAppointmentsVenueBtn.TabIndex = 6;
            this.sortAppointmentsVenueBtn.Text = "Venue (Descending)";
            this.sortAppointmentsVenueBtn.UseVisualStyleBackColor = true;
            this.sortAppointmentsVenueBtn.Click += new System.EventHandler(this.sortAppointmentsVenueBtn_Click_1);
            // 
            // scheduleIDTextBox
            // 
            this.scheduleIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "ScheduleID", true));
            this.scheduleIDTextBox.Enabled = false;
            this.scheduleIDTextBox.Location = new System.Drawing.Point(146, 414);
            this.scheduleIDTextBox.Name = "scheduleIDTextBox";
            this.scheduleIDTextBox.Size = new System.Drawing.Size(104, 22);
            this.scheduleIDTextBox.TabIndex = 33;
            this.scheduleIDTextBox.Visible = false;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataMember = "Schedule";
            this.scheduleBindingSource.DataSource = this.ist2jwDataSet;
            // 
            // userIDScheduleTextBox
            // 
            this.userIDScheduleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "UserID", true));
            this.userIDScheduleTextBox.Enabled = false;
            this.userIDScheduleTextBox.Location = new System.Drawing.Point(146, 297);
            this.userIDScheduleTextBox.Name = "userIDScheduleTextBox";
            this.userIDScheduleTextBox.Size = new System.Drawing.Size(104, 22);
            this.userIDScheduleTextBox.TabIndex = 35;
            this.userIDScheduleTextBox.Visible = false;
            // 
            // appIDScheduleTextBox
            // 
            this.appIDScheduleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "AppID", true));
            this.appIDScheduleTextBox.Enabled = false;
            this.appIDScheduleTextBox.Location = new System.Drawing.Point(146, 398);
            this.appIDScheduleTextBox.Name = "appIDScheduleTextBox";
            this.appIDScheduleTextBox.Size = new System.Drawing.Size(104, 22);
            this.appIDScheduleTextBox.TabIndex = 37;
            this.appIDScheduleTextBox.Visible = false;
            // 
            // attendedScheduleCheckBox
            // 
            this.attendedScheduleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.scheduleBindingSource, "Attended", true));
            this.attendedScheduleCheckBox.Enabled = false;
            this.attendedScheduleCheckBox.Location = new System.Drawing.Point(146, 426);
            this.attendedScheduleCheckBox.Name = "attendedScheduleCheckBox";
            this.attendedScheduleCheckBox.Size = new System.Drawing.Size(104, 24);
            this.attendedScheduleCheckBox.TabIndex = 39;
            this.attendedScheduleCheckBox.Text = "checkBox1";
            this.attendedScheduleCheckBox.UseVisualStyleBackColor = true;
            this.attendedScheduleCheckBox.Visible = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.IndianRed;
            this.panel8.Controls.Add(this.groupBox5);
            this.panel8.Location = new System.Drawing.Point(955, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(313, 269);
            this.panel8.TabIndex = 11;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.filterSelect);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.filterAppYearCmbx);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.filterAppCapacityCmbx);
            this.groupBox5.Controls.Add(this.filterAppVenueCmbx);
            this.groupBox5.Controls.Add(this.filterAppMonthCmbx);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.filterAppointmentsBtn);
            this.groupBox5.Location = new System.Drawing.Point(25, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(264, 232);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filter";
            // 
            // filterSelect
            // 
            this.filterSelect.FormattingEnabled = true;
            this.filterSelect.Items.AddRange(new object[] {
            "Year",
            "Month",
            "Venue",
            "Capacity"});
            this.filterSelect.Location = new System.Drawing.Point(88, 149);
            this.filterSelect.Name = "filterSelect";
            this.filterSelect.Size = new System.Drawing.Size(121, 24);
            this.filterSelect.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Filter By: ";
            // 
            // filterAppYearCmbx
            // 
            this.filterAppYearCmbx.FormattingEnabled = true;
            this.filterAppYearCmbx.Items.AddRange(new object[] {
            "2025",
            "2026",
            "2027"});
            this.filterAppYearCmbx.Location = new System.Drawing.Point(88, 18);
            this.filterAppYearCmbx.Name = "filterAppYearCmbx";
            this.filterAppYearCmbx.Size = new System.Drawing.Size(121, 24);
            this.filterAppYearCmbx.TabIndex = 18;
            this.filterAppYearCmbx.SelectedIndexChanged += new System.EventHandler(this.filterAppYearCmbx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Year";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // filterAppCapacityCmbx
            // 
            this.filterAppCapacityCmbx.FormattingEnabled = true;
            this.filterAppCapacityCmbx.Items.AddRange(new object[] {
            "1",
            "2"});
            this.filterAppCapacityCmbx.Location = new System.Drawing.Point(88, 114);
            this.filterAppCapacityCmbx.Name = "filterAppCapacityCmbx";
            this.filterAppCapacityCmbx.Size = new System.Drawing.Size(121, 24);
            this.filterAppCapacityCmbx.TabIndex = 16;
            this.filterAppCapacityCmbx.SelectedIndexChanged += new System.EventHandler(this.filterAppCapacityCmbx_SelectedIndexChanged);
            // 
            // filterAppVenueCmbx
            // 
            this.filterAppVenueCmbx.DataSource = this.ist2jwDataSet;
            this.filterAppVenueCmbx.DisplayMember = "Appointment.Venue";
            this.filterAppVenueCmbx.FormattingEnabled = true;
            this.filterAppVenueCmbx.Location = new System.Drawing.Point(88, 83);
            this.filterAppVenueCmbx.Name = "filterAppVenueCmbx";
            this.filterAppVenueCmbx.Size = new System.Drawing.Size(121, 24);
            this.filterAppVenueCmbx.TabIndex = 15;
            this.filterAppVenueCmbx.ValueMember = "Appointment.Venue";
            this.filterAppVenueCmbx.SelectedIndexChanged += new System.EventHandler(this.filterAppVenueCmbx_SelectedIndexChanged);
            // 
            // filterAppMonthCmbx
            // 
            this.filterAppMonthCmbx.FormattingEnabled = true;
            this.filterAppMonthCmbx.Items.AddRange(new object[] {
            "01 January",
            "02 Feburary",
            "03 March",
            "04 April",
            "05 May",
            "06 June",
            "07 July",
            "08 August ",
            "09 September",
            "10 October ",
            "11 November",
            "12 December"});
            this.filterAppMonthCmbx.Location = new System.Drawing.Point(88, 50);
            this.filterAppMonthCmbx.Name = "filterAppMonthCmbx";
            this.filterAppMonthCmbx.Size = new System.Drawing.Size(121, 24);
            this.filterAppMonthCmbx.TabIndex = 14;
            this.filterAppMonthCmbx.SelectedIndexChanged += new System.EventHandler(this.filterAppMonthCmbx_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Capacity";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Venue";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Month";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // filterAppointmentsBtn
            // 
            this.filterAppointmentsBtn.Location = new System.Drawing.Point(103, 190);
            this.filterAppointmentsBtn.Name = "filterAppointmentsBtn";
            this.filterAppointmentsBtn.Size = new System.Drawing.Size(68, 25);
            this.filterAppointmentsBtn.TabIndex = 1;
            this.filterAppointmentsBtn.Text = "Apply Filter";
            this.filterAppointmentsBtn.UseVisualStyleBackColor = true;
            this.filterAppointmentsBtn.Click += new System.EventHandler(this.filterAppointmentsBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.Firebrick;
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1284, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Appointment History";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1148, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 41);
            this.button5.TabIndex = 16;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // tblUserScheduleTableAdapter
            // 
            this.tblUserScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // scheduleTableAdapter
            // 
            this.scheduleTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AppID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Appointment ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 127;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AppDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "Appointment Date";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 131;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn3.HeaderText = "Time";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 67;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Capacity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Capacity";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 89;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Venue";
            this.dataGridViewTextBoxColumn5.HeaderText = "Venue";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ScheduleID";
            this.dataGridViewTextBoxColumn6.HeaderText = "ScheduleID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "AppID";
            this.dataGridViewTextBoxColumn7.HeaderText = "Appointment ID";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "AppDate";
            this.dataGridViewTextBoxColumn8.HeaderText = "Appointment Date";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 131;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn9.HeaderText = "Time";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 67;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Venue";
            this.dataGridViewTextBoxColumn10.HeaderText = "Venue";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 75;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Attended";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Attended";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 67;
            // 
            // capacityLabel
            // 
            capacityLabel.AutoSize = true;
            capacityLabel.Location = new System.Drawing.Point(89, 60);
            capacityLabel.Name = "capacityLabel";
            capacityLabel.Size = new System.Drawing.Size(63, 16);
            capacityLabel.TabIndex = 24;
            capacityLabel.Text = "Capacity:";
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "Capacity", true));
            this.capacityTextBox.Location = new System.Drawing.Point(166, 57);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.ReadOnly = true;
            this.capacityTextBox.Size = new System.Drawing.Size(133, 22);
            this.capacityTextBox.TabIndex = 25;
            this.capacityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // venueLabel1
            // 
            venueLabel1.AutoSize = true;
            venueLabel1.Location = new System.Drawing.Point(103, 95);
            venueLabel1.Name = "venueLabel1";
            venueLabel1.Size = new System.Drawing.Size(49, 16);
            venueLabel1.TabIndex = 26;
            venueLabel1.Text = "Venue:";
            // 
            // venueTextBox1
            // 
            this.venueTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "Venue", true));
            this.venueTextBox1.Location = new System.Drawing.Point(166, 92);
            this.venueTextBox1.Name = "venueTextBox1";
            this.venueTextBox1.ReadOnly = true;
            this.venueTextBox1.Size = new System.Drawing.Size(133, 22);
            this.venueTextBox1.TabIndex = 27;
            this.venueTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.BackColor = System.Drawing.Color.White;
            this.btnBookAppointment.Location = new System.Drawing.Point(77, 337);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(262, 39);
            this.btnBookAppointment.TabIndex = 3;
            this.btnBookAppointment.Text = "Book My Appointment";
            this.btnBookAppointment.UseVisualStyleBackColor = false;
            this.btnBookAppointment.Click += new System.EventHandler(this.btnBookAppointment_Click);
            // 
            // venueLabel
            // 
            venueLabel.AutoSize = true;
            venueLabel.Location = new System.Drawing.Point(95, 64);
            venueLabel.Name = "venueLabel";
            venueLabel.Size = new System.Drawing.Size(49, 16);
            venueLabel.TabIndex = 34;
            venueLabel.Text = "Venue:";
            // 
            // attendedCheckBox
            // 
            this.attendedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblUserScheduleBindingSource, "Attended", true));
            this.attendedCheckBox.Enabled = false;
            this.attendedCheckBox.Location = new System.Drawing.Point(167, 96);
            this.attendedCheckBox.Name = "attendedCheckBox";
            this.attendedCheckBox.Size = new System.Drawing.Size(26, 24);
            this.attendedCheckBox.TabIndex = 37;
            this.attendedCheckBox.UseVisualStyleBackColor = true;
            // 
            // attendedLabel
            // 
            attendedLabel.AutoSize = true;
            attendedLabel.Location = new System.Drawing.Point(80, 100);
            attendedLabel.Name = "attendedLabel";
            attendedLabel.Size = new System.Drawing.Size(64, 16);
            attendedLabel.TabIndex = 36;
            attendedLabel.Text = "Attended:";
            // 
            // venueTextBox
            // 
            this.venueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUserScheduleBindingSource, "Venue", true));
            this.venueTextBox.Enabled = false;
            this.venueTextBox.Location = new System.Drawing.Point(167, 62);
            this.venueTextBox.Name = "venueTextBox";
            this.venueTextBox.ReadOnly = true;
            this.venueTextBox.Size = new System.Drawing.Size(155, 22);
            this.venueTextBox.TabIndex = 35;
            this.venueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.DataBindings.Add(new System.Windows.Forms.Binding("SelectionRange", this.tblUserScheduleBindingSource, "AppDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.monthCalendar1.Enabled = false;
            this.monthCalendar1.Location = new System.Drawing.Point(83, 128);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 38;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.DataBindings.Add(new System.Windows.Forms.Binding("SelectionRange", this.appointmentBindingSource, "AppDate", true));
            this.monthCalendar2.Enabled = false;
            this.monthCalendar2.Location = new System.Drawing.Point(77, 126);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 28;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ScheduleTableAdapter = null;
            this.tableAdapterManager.TblBloodInventoryTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BloodBankSystem.ist2jwDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // appDateLabel
            // 
            appDateLabel.AutoSize = true;
            appDateLabel.Location = new System.Drawing.Point(198, 30);
            appDateLabel.Name = "appDateLabel";
            appDateLabel.Size = new System.Drawing.Size(67, 16);
            appDateLabel.TabIndex = 16;
            appDateLabel.Text = "App Date:";
            appDateLabel.Visible = false;
            // 
            // appDateTimePicker1
            // 
            this.appDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentBindingSource, "AppDate", true));
            this.appDateTimePicker1.Location = new System.Drawing.Point(271, 26);
            this.appDateTimePicker1.Name = "appDateTimePicker1";
            this.appDateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.appDateTimePicker1.TabIndex = 17;
            this.appDateTimePicker1.Visible = false;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1324, 607);
            this.Controls.Add(appDateLabel);
            this.Controls.Add(this.appDateTimePicker1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AppointmentForm";
            this.Text = "My Appointments";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2jwDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserScheduleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserScheduleBindingSource)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            this.panel8.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ist2jwDataSet ist2jwDataSet;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button sortDateBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button sortAttendedBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button sortVenueBtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button filterAppointmentsBtn;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private ist2jwDataSetTableAdapters.AppointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.DataGridView appointmentDataGridView;
        private System.Windows.Forms.BindingSource tblUserScheduleBindingSource;
        private ist2jwDataSetTableAdapters.tblUserScheduleTableAdapter tblUserScheduleTableAdapter;
        private System.Windows.Forms.DataGridView tblUserScheduleDataGridView;
        private System.Windows.Forms.TextBox timeTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ist2jwDataSetTableAdapters.ScheduleTableAdapter scheduleTableAdapter;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox scheduleIDTextBox;
        private System.Windows.Forms.TextBox userIDScheduleTextBox;
        private System.Windows.Forms.TextBox appIDScheduleTextBox;
        private System.Windows.Forms.CheckBox attendedScheduleCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker searchDateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox filterAppCapacityCmbx;
        private System.Windows.Forms.ComboBox filterAppVenueCmbx;
        private System.Windows.Forms.ComboBox filterAppMonthCmbx;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button sortAppointmentDateBtn;
        private System.Windows.Forms.Button sortAppointmentsVenueBtn;
        private System.Windows.Forms.ComboBox filterAppYearCmbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox scheduleIDTextBox1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox filterSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox filterScheduleVenueCmbx;
        private System.Windows.Forms.RadioButton filterScheduleAttendedCheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox filterScheduleMonthCmbx;
        private System.Windows.Forms.ComboBox filterScheduleYearCmbx;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox scheduleFilterCmbx;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.DateTimePicker searchScheduleDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox appIDTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.TextBox venueTextBox1;
        private System.Windows.Forms.Button btnBookAppointment;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.CheckBox attendedCheckBox;
        private System.Windows.Forms.TextBox venueTextBox;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private ist2jwDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker appDateTimePicker1;
    }
}