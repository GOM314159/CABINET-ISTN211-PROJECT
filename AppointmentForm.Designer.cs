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
            System.Windows.Forms.Label appIDLabel1;
            System.Windows.Forms.Label appDateLabel1;
            System.Windows.Forms.Label timeLabel1;
            System.Windows.Forms.Label capacityLabel;
            System.Windows.Forms.Label venueLabel1;
            System.Windows.Forms.Label scheduleIDLabel1;
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label appIDLabel2;
            System.Windows.Forms.Label attendedLabel1;
            this.btnBookAppointment = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timeTextBox1 = new System.Windows.Forms.TextBox();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ist2jwDataSet = new BloodBankSystem.ist2jwDataSet();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.appDateDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.venueTextBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.appointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appIDTextBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.tblUserScheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblUserScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.sortVenueBtn = new System.Windows.Forms.Button();
            this.sortAttendedBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.sortDateBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.venueFilterCmbx = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.attendedFilterRdBtn = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.monthFilterCmbx = new System.Windows.Forms.ComboBox();
            this.yearFilterCmbx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.filterAppointmentsBtn = new System.Windows.Forms.Button();
            this.scheduleIDTextBox = new System.Windows.Forms.TextBox();
            this.userIDScheduleTextBox = new System.Windows.Forms.TextBox();
            this.appIDScheduleTextBox = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.attendedScheduleCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableAdapterManager = new BloodBankSystem.ist2jwDataSetTableAdapters.TableAdapterManager();
            this.appointmentTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.AppointmentTableAdapter();
            this.tblUserScheduleTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.tblUserScheduleTableAdapter();
            this.scheduleTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.ScheduleTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.searchDateTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.filterAppCapacityCmbx = new System.Windows.Forms.ComboBox();
            this.filterAppVenueCmbx = new System.Windows.Forms.ComboBox();
            this.filterAppMonthCmbx = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.sortAppointmentDateBtn = new System.Windows.Forms.Button();
            this.sortAppointmentsVenueBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filterAppYearCmbx = new System.Windows.Forms.ComboBox();
            appIDLabel1 = new System.Windows.Forms.Label();
            appDateLabel1 = new System.Windows.Forms.Label();
            timeLabel1 = new System.Windows.Forms.Label();
            capacityLabel = new System.Windows.Forms.Label();
            venueLabel1 = new System.Windows.Forms.Label();
            scheduleIDLabel1 = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            appIDLabel2 = new System.Windows.Forms.Label();
            attendedLabel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2jwDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserScheduleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserScheduleBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // appIDLabel1
            // 
            appIDLabel1.AutoSize = true;
            appIDLabel1.Location = new System.Drawing.Point(57, 543);
            appIDLabel1.Name = "appIDLabel1";
            appIDLabel1.Size = new System.Drawing.Size(51, 16);
            appIDLabel1.TabIndex = 14;
            appIDLabel1.Text = "App ID:";
            appIDLabel1.Visible = false;
            // 
            // appDateLabel1
            // 
            appDateLabel1.AutoSize = true;
            appDateLabel1.Location = new System.Drawing.Point(14, 28);
            appDateLabel1.Name = "appDateLabel1";
            appDateLabel1.Size = new System.Drawing.Size(36, 16);
            appDateLabel1.TabIndex = 16;
            appDateLabel1.Text = "Date";
            // 
            // timeLabel1
            // 
            timeLabel1.AutoSize = true;
            timeLabel1.Location = new System.Drawing.Point(14, 65);
            timeLabel1.Name = "timeLabel1";
            timeLabel1.Size = new System.Drawing.Size(41, 16);
            timeLabel1.TabIndex = 18;
            timeLabel1.Text = "Time:";
            // 
            // capacityLabel
            // 
            capacityLabel.AutoSize = true;
            capacityLabel.Location = new System.Drawing.Point(462, 34);
            capacityLabel.Name = "capacityLabel";
            capacityLabel.Size = new System.Drawing.Size(63, 16);
            capacityLabel.TabIndex = 20;
            capacityLabel.Text = "Capacity:";
            // 
            // venueLabel1
            // 
            venueLabel1.AutoSize = true;
            venueLabel1.Location = new System.Drawing.Point(462, 62);
            venueLabel1.Name = "venueLabel1";
            venueLabel1.Size = new System.Drawing.Size(49, 16);
            venueLabel1.TabIndex = 22;
            venueLabel1.Text = "Venue:";
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
            userIDLabel.Location = new System.Drawing.Point(57, 445);
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
            appIDLabel2.Location = new System.Drawing.Point(57, 473);
            appIDLabel2.Name = "appIDLabel2";
            appIDLabel2.Size = new System.Drawing.Size(51, 16);
            appIDLabel2.TabIndex = 36;
            appIDLabel2.Text = "App ID:";
            appIDLabel2.Visible = false;
            // 
            // attendedLabel1
            // 
            attendedLabel1.AutoSize = true;
            attendedLabel1.Enabled = false;
            attendedLabel1.Location = new System.Drawing.Point(57, 503);
            attendedLabel1.Name = "attendedLabel1";
            attendedLabel1.Size = new System.Drawing.Size(64, 16);
            attendedLabel1.TabIndex = 38;
            attendedLabel1.Text = "Attended:";
            attendedLabel1.Visible = false;
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.BackColor = System.Drawing.Color.White;
            this.btnBookAppointment.Location = new System.Drawing.Point(12, 18);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(200, 94);
            this.btnBookAppointment.TabIndex = 3;
            this.btnBookAppointment.Text = "Book My Appointment";
            this.btnBookAppointment.UseVisualStyleBackColor = false;
            this.btnBookAppointment.Click += new System.EventHandler(this.btnBookAppointment_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(16, 21);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(91, 36);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(6, 21);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(140, 23);
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
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 376);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.searchDateTime);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Location = new System.Drawing.Point(519, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(408, 50);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.timeTextBox1);
            this.groupBox3.Controls.Add(timeLabel1);
            this.groupBox3.Controls.Add(capacityLabel);
            this.groupBox3.Controls.Add(appDateLabel1);
            this.groupBox3.Controls.Add(this.capacityTextBox);
            this.groupBox3.Controls.Add(this.appDateDateTimePicker1);
            this.groupBox3.Controls.Add(venueLabel1);
            this.groupBox3.Controls.Add(this.venueTextBox1);
            this.groupBox3.Location = new System.Drawing.Point(19, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(908, 100);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment Details";
            // 
            // timeTextBox1
            // 
            this.timeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "Time", true));
            this.timeTextBox1.Location = new System.Drawing.Point(89, 59);
            this.timeTextBox1.Name = "timeTextBox1";
            this.timeTextBox1.ReadOnly = true;
            this.timeTextBox1.Size = new System.Drawing.Size(268, 22);
            this.timeTextBox1.TabIndex = 19;
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
            // capacityTextBox
            // 
            this.capacityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "Capacity", true));
            this.capacityTextBox.Location = new System.Drawing.Point(535, 31);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.ReadOnly = true;
            this.capacityTextBox.Size = new System.Drawing.Size(200, 22);
            this.capacityTextBox.TabIndex = 21;
            // 
            // appDateDateTimePicker1
            // 
            this.appDateDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentBindingSource, "AppDate", true));
            this.appDateDateTimePicker1.Enabled = false;
            this.appDateDateTimePicker1.Location = new System.Drawing.Point(89, 28);
            this.appDateDateTimePicker1.Name = "appDateDateTimePicker1";
            this.appDateDateTimePicker1.Size = new System.Drawing.Size(268, 22);
            this.appDateDateTimePicker1.TabIndex = 17;
            // 
            // venueTextBox1
            // 
            this.venueTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "Venue", true));
            this.venueTextBox1.Location = new System.Drawing.Point(535, 59);
            this.venueTextBox1.Name = "venueTextBox1";
            this.venueTextBox1.ReadOnly = true;
            this.venueTextBox1.Size = new System.Drawing.Size(200, 22);
            this.venueTextBox1.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(19, 184);
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
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 26);
            this.button1.TabIndex = 27;
            this.button1.Text = "Last";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(128, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 26);
            this.button3.TabIndex = 26;
            this.button3.Text = "Prev";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(17, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 26);
            this.button4.TabIndex = 25;
            this.button4.Text = "First";
            this.button4.UseVisualStyleBackColor = true;
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
            this.appointmentDataGridView.Location = new System.Drawing.Point(19, 14);
            this.appointmentDataGridView.Name = "appointmentDataGridView";
            this.appointmentDataGridView.RowHeadersWidth = 51;
            this.appointmentDataGridView.RowTemplate.Height = 24;
            this.appointmentDataGridView.Size = new System.Drawing.Size(920, 164);
            this.appointmentDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AppID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Appointment ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AppDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "Appointment Date";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn3.HeaderText = "Time";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Capacity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Capacity";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Venue";
            this.dataGridViewTextBoxColumn5.HeaderText = "Venue";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataMember = "Schedule";
            this.scheduleBindingSource.DataSource = this.ist2jwDataSet;
            // 
            // appIDTextBox1
            // 
            this.appIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "AppID", true));
            this.appIDTextBox1.Location = new System.Drawing.Point(40, 543);
            this.appIDTextBox1.Name = "appIDTextBox1";
            this.appIDTextBox1.ReadOnly = true;
            this.appIDTextBox1.Size = new System.Drawing.Size(122, 22);
            this.appIDTextBox1.TabIndex = 15;
            this.appIDTextBox1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.tblUserScheduleDataGridView);
            this.panel2.Location = new System.Drawing.Point(6, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 392);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFirst);
            this.groupBox1.Controls.Add(this.btnPrev);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnLast);
            this.groupBox1.Location = new System.Drawing.Point(188, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 60);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nvaigation";
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(150, 21);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(134, 23);
            this.btnPrev.TabIndex = 8;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(290, 21);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(141, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(437, 21);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(130, 23);
            this.btnLast.TabIndex = 10;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.button4_Click);
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
            this.tblUserScheduleDataGridView.Location = new System.Drawing.Point(3, 3);
            this.tblUserScheduleDataGridView.Name = "tblUserScheduleDataGridView";
            this.tblUserScheduleDataGridView.ReadOnly = true;
            this.tblUserScheduleDataGridView.RowHeadersWidth = 51;
            this.tblUserScheduleDataGridView.RowTemplate.Height = 24;
            this.tblUserScheduleDataGridView.Size = new System.Drawing.Size(908, 231);
            this.tblUserScheduleDataGridView.TabIndex = 10;
            this.tblUserScheduleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblUserScheduleDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ScheduleID";
            this.dataGridViewTextBoxColumn6.HeaderText = "ScheduleID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "AppID";
            this.dataGridViewTextBoxColumn7.HeaderText = "Appointment ID";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "AppDate";
            this.dataGridViewTextBoxColumn8.HeaderText = "Appointment Date";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn9.HeaderText = "Time";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Venue";
            this.dataGridViewTextBoxColumn10.HeaderText = "Venue";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Attended";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Attended";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // tblUserScheduleBindingSource
            // 
            this.tblUserScheduleBindingSource.DataMember = "tblUserSchedule";
            this.tblUserScheduleBindingSource.DataSource = this.ist2jwDataSet;
            this.tblUserScheduleBindingSource.CurrentChanged += new System.EventHandler(this.tblUserScheduleBindingSource_CurrentChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.Controls.Add(this.sortVenueBtn);
            this.panel3.Controls.Add(this.sortAttendedBtn);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.sortDateBtn);
            this.panel3.Location = new System.Drawing.Point(9, 408);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 173);
            this.panel3.TabIndex = 10;
            this.panel3.Tag = "";
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // sortVenueBtn
            // 
            this.sortVenueBtn.Location = new System.Drawing.Point(189, 79);
            this.sortVenueBtn.Name = "sortVenueBtn";
            this.sortVenueBtn.Size = new System.Drawing.Size(112, 32);
            this.sortVenueBtn.TabIndex = 3;
            this.sortVenueBtn.Text = "Venue";
            this.sortVenueBtn.UseVisualStyleBackColor = true;
            this.sortVenueBtn.Click += new System.EventHandler(this.sortVenueBtn_Click);
            // 
            // sortAttendedBtn
            // 
            this.sortAttendedBtn.Location = new System.Drawing.Point(269, 24);
            this.sortAttendedBtn.Name = "sortAttendedBtn";
            this.sortAttendedBtn.Size = new System.Drawing.Size(112, 32);
            this.sortAttendedBtn.TabIndex = 2;
            this.sortAttendedBtn.Text = "Last Attended";
            this.sortAttendedBtn.UseVisualStyleBackColor = true;
            this.sortAttendedBtn.Click += new System.EventHandler(this.sortAttendedBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sort By :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // sortDateBtn
            // 
            this.sortDateBtn.Location = new System.Drawing.Point(132, 25);
            this.sortDateBtn.Name = "sortDateBtn";
            this.sortDateBtn.Size = new System.Drawing.Size(112, 32);
            this.sortDateBtn.TabIndex = 0;
            this.sortDateBtn.Text = "Latest Date";
            this.sortDateBtn.UseVisualStyleBackColor = true;
            this.sortDateBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(249, 116);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(122, 47);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(342, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 36);
            this.label3.TabIndex = 11;
            this.label3.Text = "MY APPOINTMENTS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.IndianRed;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.venueFilterCmbx);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.resetBtn);
            this.panel4.Controls.Add(this.attendedFilterRdBtn);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.monthFilterCmbx);
            this.panel4.Controls.Add(this.yearFilterCmbx);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(496, 408);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(430, 173);
            this.panel4.TabIndex = 13;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(231, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Venue";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Month";
            // 
            // venueFilterCmbx
            // 
            this.venueFilterCmbx.FormattingEnabled = true;
            this.venueFilterCmbx.Items.AddRange(new object[] {
            "All",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.venueFilterCmbx.Location = new System.Drawing.Point(303, 38);
            this.venueFilterCmbx.Name = "venueFilterCmbx";
            this.venueFilterCmbx.Size = new System.Drawing.Size(121, 24);
            this.venueFilterCmbx.TabIndex = 15;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(104, 116);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(139, 47);
            this.button7.TabIndex = 14;
            this.button7.Text = "Apply";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // attendedFilterRdBtn
            // 
            this.attendedFilterRdBtn.AutoSize = true;
            this.attendedFilterRdBtn.Location = new System.Drawing.Point(303, 79);
            this.attendedFilterRdBtn.Name = "attendedFilterRdBtn";
            this.attendedFilterRdBtn.Size = new System.Drawing.Size(82, 20);
            this.attendedFilterRdBtn.TabIndex = 5;
            this.attendedFilterRdBtn.TabStop = true;
            this.attendedFilterRdBtn.Text = "Attended";
            this.attendedFilterRdBtn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Year";
            // 
            // monthFilterCmbx
            // 
            this.monthFilterCmbx.FormattingEnabled = true;
            this.monthFilterCmbx.Items.AddRange(new object[] {
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
            this.monthFilterCmbx.Location = new System.Drawing.Point(90, 84);
            this.monthFilterCmbx.Name = "monthFilterCmbx";
            this.monthFilterCmbx.Size = new System.Drawing.Size(121, 24);
            this.monthFilterCmbx.TabIndex = 2;
            // 
            // yearFilterCmbx
            // 
            this.yearFilterCmbx.FormattingEnabled = true;
            this.yearFilterCmbx.Items.AddRange(new object[] {
            "2025",
            "2026"});
            this.yearFilterCmbx.Location = new System.Drawing.Point(90, 38);
            this.yearFilterCmbx.Name = "yearFilterCmbx";
            this.yearFilterCmbx.Size = new System.Drawing.Size(121, 24);
            this.yearFilterCmbx.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Filter By:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(962, 650);
            this.tabControl1.TabIndex = 15;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.Firebrick;
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Controls.Add(this.panel8);
            this.tabPage1.Controls.Add(appIDLabel1);
            this.tabPage1.Controls.Add(scheduleIDLabel1);
            this.tabPage1.Controls.Add(this.scheduleIDTextBox);
            this.tabPage1.Controls.Add(userIDLabel);
            this.tabPage1.Controls.Add(this.userIDScheduleTextBox);
            this.tabPage1.Controls.Add(appIDLabel2);
            this.tabPage1.Controls.Add(this.appIDScheduleTextBox);
            this.tabPage1.Controls.Add(attendedLabel1);
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Controls.Add(this.attendedScheduleCheckBox);
            this.tabPage1.Controls.Add(this.appIDTextBox1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(954, 621);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Schedule an Appointment";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.IndianRed;
            this.panel7.Controls.Add(this.groupBox6);
            this.panel7.Location = new System.Drawing.Point(6, 388);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(338, 227);
            this.panel7.TabIndex = 10;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.IndianRed;
            this.panel8.Controls.Add(this.groupBox5);
            this.panel8.Location = new System.Drawing.Point(350, 388);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(365, 227);
            this.panel8.TabIndex = 11;
            // 
            // filterAppointmentsBtn
            // 
            this.filterAppointmentsBtn.Location = new System.Drawing.Point(146, 165);
            this.filterAppointmentsBtn.Name = "filterAppointmentsBtn";
            this.filterAppointmentsBtn.Size = new System.Drawing.Size(91, 31);
            this.filterAppointmentsBtn.TabIndex = 1;
            this.filterAppointmentsBtn.Text = "Apply ";
            this.filterAppointmentsBtn.UseVisualStyleBackColor = true;
            this.filterAppointmentsBtn.Click += new System.EventHandler(this.filterAppointmentsBtn_Click);
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
            // userIDScheduleTextBox
            // 
            this.userIDScheduleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "UserID", true));
            this.userIDScheduleTextBox.Enabled = false;
            this.userIDScheduleTextBox.Location = new System.Drawing.Point(146, 442);
            this.userIDScheduleTextBox.Name = "userIDScheduleTextBox";
            this.userIDScheduleTextBox.Size = new System.Drawing.Size(104, 22);
            this.userIDScheduleTextBox.TabIndex = 35;
            this.userIDScheduleTextBox.Visible = false;
            // 
            // appIDScheduleTextBox
            // 
            this.appIDScheduleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.scheduleBindingSource, "AppID", true));
            this.appIDScheduleTextBox.Enabled = false;
            this.appIDScheduleTextBox.Location = new System.Drawing.Point(146, 470);
            this.appIDScheduleTextBox.Name = "appIDScheduleTextBox";
            this.appIDScheduleTextBox.Size = new System.Drawing.Size(104, 22);
            this.appIDScheduleTextBox.TabIndex = 37;
            this.appIDScheduleTextBox.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.IndianRed;
            this.panel6.Controls.Add(this.btnBookAppointment);
            this.panel6.Location = new System.Drawing.Point(721, 388);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(224, 227);
            this.panel6.TabIndex = 9;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // attendedScheduleCheckBox
            // 
            this.attendedScheduleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.scheduleBindingSource, "Attended", true));
            this.attendedScheduleCheckBox.Enabled = false;
            this.attendedScheduleCheckBox.Location = new System.Drawing.Point(146, 498);
            this.attendedScheduleCheckBox.Name = "attendedScheduleCheckBox";
            this.attendedScheduleCheckBox.Size = new System.Drawing.Size(104, 24);
            this.attendedScheduleCheckBox.TabIndex = 39;
            this.attendedScheduleCheckBox.Text = "checkBox1";
            this.attendedScheduleCheckBox.UseVisualStyleBackColor = true;
            this.attendedScheduleCheckBox.Visible = false;
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
            this.tabPage2.Size = new System.Drawing.Size(954, 575);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Appointment History";
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
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(728, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(221, 46);
            this.button5.TabIndex = 16;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date";
            // 
            // searchDateTime
            // 
            this.searchDateTime.Location = new System.Drawing.Point(77, 17);
            this.searchDateTime.Name = "searchDateTime";
            this.searchDateTime.Size = new System.Drawing.Size(239, 22);
            this.searchDateTime.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.filterAppYearCmbx);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.filterAppCapacityCmbx);
            this.groupBox5.Controls.Add(this.filterAppVenueCmbx);
            this.groupBox5.Controls.Add(this.filterAppMonthCmbx);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.filterAppointmentsBtn);
            this.groupBox5.Location = new System.Drawing.Point(25, 9);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(305, 215);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filter";
            // 
            // filterAppCapacityCmbx
            // 
            this.filterAppCapacityCmbx.FormattingEnabled = true;
            this.filterAppCapacityCmbx.Items.AddRange(new object[] {
            "1",
            "2"});
            this.filterAppCapacityCmbx.Location = new System.Drawing.Point(146, 124);
            this.filterAppCapacityCmbx.Name = "filterAppCapacityCmbx";
            this.filterAppCapacityCmbx.Size = new System.Drawing.Size(121, 24);
            this.filterAppCapacityCmbx.TabIndex = 16;
            // 
            // filterAppVenueCmbx
            // 
            this.filterAppVenueCmbx.FormattingEnabled = true;
            this.filterAppVenueCmbx.Items.AddRange(new object[] {
            "Westville",
            "Springfield",
            "Durban Noth",
            "Phoenix"});
            this.filterAppVenueCmbx.Location = new System.Drawing.Point(146, 93);
            this.filterAppVenueCmbx.Name = "filterAppVenueCmbx";
            this.filterAppVenueCmbx.Size = new System.Drawing.Size(121, 24);
            this.filterAppVenueCmbx.TabIndex = 15;
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
            "12 December "});
            this.filterAppMonthCmbx.Location = new System.Drawing.Point(146, 58);
            this.filterAppMonthCmbx.Name = "filterAppMonthCmbx";
            this.filterAppMonthCmbx.Size = new System.Drawing.Size(121, 24);
            this.filterAppMonthCmbx.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(48, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Capacity";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(48, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Venue";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(48, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Month";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button8);
            this.groupBox6.Controls.Add(this.sortAppointmentDateBtn);
            this.groupBox6.Controls.Add(this.sortAppointmentsVenueBtn);
            this.groupBox6.Location = new System.Drawing.Point(19, 18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(291, 200);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sort";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(53, 86);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(160, 34);
            this.button8.TabIndex = 7;
            this.button8.Text = "Venue (Ascending)";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // sortAppointmentDateBtn
            // 
            this.sortAppointmentDateBtn.Location = new System.Drawing.Point(53, 39);
            this.sortAppointmentDateBtn.Name = "sortAppointmentDateBtn";
            this.sortAppointmentDateBtn.Size = new System.Drawing.Size(160, 34);
            this.sortAppointmentDateBtn.TabIndex = 5;
            this.sortAppointmentDateBtn.Text = "Date (Descending)";
            this.sortAppointmentDateBtn.UseVisualStyleBackColor = true;
            this.sortAppointmentDateBtn.Click += new System.EventHandler(this.sortAppointmentDateBtn_Click_1);
            // 
            // sortAppointmentsVenueBtn
            // 
            this.sortAppointmentsVenueBtn.Location = new System.Drawing.Point(53, 137);
            this.sortAppointmentsVenueBtn.Name = "sortAppointmentsVenueBtn";
            this.sortAppointmentsVenueBtn.Size = new System.Drawing.Size(160, 34);
            this.sortAppointmentsVenueBtn.TabIndex = 6;
            this.sortAppointmentsVenueBtn.Text = "Venue (Descending)";
            this.sortAppointmentsVenueBtn.UseVisualStyleBackColor = true;
            this.sortAppointmentsVenueBtn.Click += new System.EventHandler(this.sortAppointmentsVenueBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Year";
            // 
            // filterAppYearCmbx
            // 
            this.filterAppYearCmbx.FormattingEnabled = true;
            this.filterAppYearCmbx.Items.AddRange(new object[] {
            "2025",
            "2026",
            "2027"});
            this.filterAppYearCmbx.Location = new System.Drawing.Point(146, 28);
            this.filterAppYearCmbx.Name = "filterAppYearCmbx";
            this.filterAppYearCmbx.Size = new System.Drawing.Size(121, 24);
            this.filterAppYearCmbx.TabIndex = 18;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(986, 735);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnHome);
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
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblUserScheduleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserScheduleBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ist2jwDataSet ist2jwDataSet;
        private System.Windows.Forms.Button btnBookAppointment;
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
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox monthFilterCmbx;
        private System.Windows.Forms.ComboBox yearFilterCmbx;
        private System.Windows.Forms.RadioButton attendedFilterRdBtn;
        private System.Windows.Forms.Button sortAttendedBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button sortVenueBtn;
        private System.Windows.Forms.ComboBox venueFilterCmbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button filterAppointmentsBtn;
        private ist2jwDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private ist2jwDataSetTableAdapters.AppointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.DataGridView appointmentDataGridView;
        private System.Windows.Forms.BindingSource tblUserScheduleBindingSource;
        private ist2jwDataSetTableAdapters.tblUserScheduleTableAdapter tblUserScheduleTableAdapter;
        private System.Windows.Forms.DataGridView tblUserScheduleDataGridView;
        private System.Windows.Forms.TextBox appIDTextBox1;
        private System.Windows.Forms.DateTimePicker appDateDateTimePicker1;
        private System.Windows.Forms.TextBox timeTextBox1;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.TextBox venueTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
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
    }
}