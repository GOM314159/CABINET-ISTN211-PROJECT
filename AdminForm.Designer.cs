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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ist2jwDataSet = new BloodBankSystem.ist2jwDataSet();
            this.tblBloodInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsersTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.tblUsersTableAdapter();
            this.tblBloodInventoryTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.TblBloodInventoryTableAdapter();
            this.appointmentTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.AppointmentTableAdapter();
            this.scheduleTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.ScheduleTableAdapter();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button19 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnAppLast = new System.Windows.Forms.Button();
            this.btnAppFirst = new System.Windows.Forms.Button();
            this.btnAppPrev = new System.Windows.Forms.Button();
            this.btnAppNext = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button20 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.appIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnBloodLast = new System.Windows.Forms.Button();
            this.btnBloodFirst = new System.Windows.Forms.Button();
            this.btnBloodPrev = new System.Windows.Forms.Button();
            this.btnBllodNext = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlRemoveFilters = new System.Windows.Forms.Panel();
            this.btnRemoveFilter = new System.Windows.Forms.Button();
            this.pnlUserNav = new System.Windows.Forms.Panel();
            this.btnUserLast = new System.Windows.Forms.Button();
            this.btnUserFirst = new System.Windows.Forms.Button();
            this.btnUserPrev = new System.Windows.Forms.Button();
            this.btnUserNext = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmdUserFilter = new System.Windows.Forms.ComboBox();
            this.btnUserFilter = new System.Windows.Forms.Button();
            this.cmbBloodFilter = new System.Windows.Forms.ComboBox();
            this.btnBloodFilter = new System.Windows.Forms.Button();
            this.btnSurnameAlphabetical = new System.Windows.Forms.Button();
            this.btnNameAlphabetical = new System.Windows.Forms.Button();
            this.btnFilterInactive = new System.Windows.Forms.Button();
            this.btnFilterActive = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveAccountDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlUserEdit = new System.Windows.Forms.Panel();
            this.btnInsertUser = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2jwDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBloodInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.pnlRemoveFilters.SuspendLayout();
            this.pnlUserNav.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlUserEdit.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrator Dashboard";
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
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "Appointment";
            this.appointmentBindingSource.DataSource = this.ist2jwDataSet;
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel7);
            this.tabPage3.Controls.Add(this.panel13);
            this.tabPage3.Controls.Add(this.panel10);
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(793, 387);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Appointments";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel7.Controls.Add(this.button19);
            this.panel7.Controls.Add(this.button17);
            this.panel7.Controls.Add(this.button8);
            this.panel7.Controls.Add(this.button15);
            this.panel7.Controls.Add(this.dateTimePicker5);
            this.panel7.Controls.Add(this.label21);
            this.panel7.Location = new System.Drawing.Point(542, 9);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(242, 149);
            this.panel7.TabIndex = 9;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(6, 147);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(171, 27);
            this.button19.TabIndex = 5;
            this.button19.Text = "Sort by capacity(desc)";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(6, 121);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(171, 23);
            this.button17.TabIndex = 4;
            this.button17.Text = "Sort by capacity(asc)";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(6, 83);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(171, 32);
            this.button8.TabIndex = 3;
            this.button8.Text = "Filter by time(Later than)";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(6, 54);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(171, 32);
            this.button15.TabIndex = 2;
            this.button15.Text = "Filter by time(Later than)";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker5.Location = new System.Drawing.Point(6, 35);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(99, 23);
            this.dateTimePicker5.TabIndex = 1;
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
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel13.Controls.Add(this.button16);
            this.panel13.Location = new System.Drawing.Point(542, 157);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(242, 33);
            this.panel13.TabIndex = 8;
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
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.SteelBlue;
            this.panel10.Controls.Add(this.btnAppLast);
            this.panel10.Controls.Add(this.btnAppFirst);
            this.panel10.Controls.Add(this.btnAppPrev);
            this.panel10.Controls.Add(this.btnAppNext);
            this.panel10.Location = new System.Drawing.Point(15, 157);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(499, 36);
            this.panel10.TabIndex = 7;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.button20);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Controls.Add(this.dateTimePicker3);
            this.panel4.Controls.Add(this.dateTimePicker2);
            this.panel4.Controls.Add(this.textBox10);
            this.panel4.Location = new System.Drawing.Point(3, 199);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(784, 192);
            this.panel4.TabIndex = 1;
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.button20.Location = new System.Drawing.Point(358, 29);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(134, 38);
            this.button20.TabIndex = 10;
            this.button20.Text = "Insert appointment";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(59, 152);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 16);
            this.label18.TabIndex = 9;
            this.label18.Text = "Capacity:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(9, 118);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 16);
            this.label17.TabIndex = 8;
            this.label17.Text = "Appointment time:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(5, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 16);
            this.label16.TabIndex = 7;
            this.label16.Text = "Appointment Date:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 16);
            this.label15.TabIndex = 6;
            this.label15.Text = "Appointment ID:";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(358, 86);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 36);
            this.button6.TabIndex = 5;
            this.button6.Text = "Delete record";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(358, 140);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 32);
            this.button5.TabIndex = 4;
            this.button5.Text = "Apply changes";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentBindingSource, "Capacity", true));
            this.numericUpDown1.Location = new System.Drawing.Point(132, 152);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "hh:mm";
            this.dateTimePicker3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "Time", true));
            this.dateTimePicker3.Location = new System.Drawing.Point(132, 118);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "AppDate", true));
            this.dateTimePicker2.Location = new System.Drawing.Point(132, 72);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "AppID", true));
            this.textBox10.Location = new System.Drawing.Point(132, 35);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appIDDataGridViewTextBoxColumn1,
            this.appDateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.appointmentBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(3, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(533, 151);
            this.dataGridView3.TabIndex = 0;
            // 
            // appIDDataGridViewTextBoxColumn1
            // 
            this.appIDDataGridViewTextBoxColumn1.DataPropertyName = "AppID";
            this.appIDDataGridViewTextBoxColumn1.HeaderText = "AppID";
            this.appIDDataGridViewTextBoxColumn1.Name = "appIDDataGridViewTextBoxColumn1";
            // 
            // appDateDataGridViewTextBoxColumn
            // 
            this.appDateDataGridViewTextBoxColumn.DataPropertyName = "AppDate";
            this.appDateDataGridViewTextBoxColumn.HeaderText = "AppDate";
            this.appDateDataGridViewTextBoxColumn.Name = "appDateDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Capacity";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel12);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.panel9);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Blood Inventory";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel12.Controls.Add(this.button14);
            this.panel12.Location = new System.Drawing.Point(513, 155);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(268, 33);
            this.panel12.TabIndex = 8;
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(6, 6);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(122, 23);
            this.button14.TabIndex = 1;
            this.button14.Text = "Remove";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Controls.Add(this.button7);
            this.panel6.Controls.Add(this.button4);
            this.panel6.Controls.Add(this.dateTimePicker4);
            this.panel6.Controls.Add(this.label20);
            this.panel6.Location = new System.Drawing.Point(513, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(268, 149);
            this.panel6.TabIndex = 7;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(6, 83);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(171, 32);
            this.button7.TabIndex = 3;
            this.button7.Text = "Filter by expiry date(Later than)";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(6, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 32);
            this.button4.TabIndex = 2;
            this.button4.Text = "Filter by expiry date(Later than)";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(6, 35);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(99, 23);
            this.dateTimePicker4.TabIndex = 1;
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
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.SteelBlue;
            this.panel9.Controls.Add(this.btnBloodLast);
            this.panel9.Controls.Add(this.btnBloodFirst);
            this.panel9.Controls.Add(this.btnBloodPrev);
            this.panel9.Controls.Add(this.btnBllodNext);
            this.panel9.Location = new System.Drawing.Point(8, 152);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(499, 36);
            this.panel9.TabIndex = 6;
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
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.textBox9);
            this.panel3.Controls.Add(this.textBox8);
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(8, 189);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 195);
            this.panel3.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(21, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "Expiry date:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(46, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "UserID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(3, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "AppointmentID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(26, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Blood type:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(52, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "UnitID:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(263, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete record";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(263, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Apply changes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBloodInventoryBindingSource, "ExpiryDate", true));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBloodInventoryBindingSource, "BloodType", true));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(104, 134);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 3;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBloodInventoryBindingSource, "AppID", true));
            this.textBox9.Location = new System.Drawing.Point(104, 101);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(121, 20);
            this.textBox9.TabIndex = 2;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBloodInventoryBindingSource, "UserID", true));
            this.textBox8.Location = new System.Drawing.Point(104, 65);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(121, 20);
            this.textBox8.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblBloodInventoryBindingSource, "UnitID", true));
            this.textBox7.Location = new System.Drawing.Point(104, 31);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(121, 20);
            this.textBox7.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unitIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn1,
            this.appIDDataGridViewTextBoxColumn,
            this.bloodTypeDataGridViewTextBoxColumn1,
            this.expiryDateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblBloodInventoryBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(507, 155);
            this.dataGridView2.TabIndex = 0;
            // 
            // unitIDDataGridViewTextBoxColumn
            // 
            this.unitIDDataGridViewTextBoxColumn.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn.HeaderText = "UnitID";
            this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn1
            // 
            this.userIDDataGridViewTextBoxColumn1.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn1.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn1.Name = "userIDDataGridViewTextBoxColumn1";
            // 
            // appIDDataGridViewTextBoxColumn
            // 
            this.appIDDataGridViewTextBoxColumn.DataPropertyName = "AppID";
            this.appIDDataGridViewTextBoxColumn.HeaderText = "AppID";
            this.appIDDataGridViewTextBoxColumn.Name = "appIDDataGridViewTextBoxColumn";
            // 
            // bloodTypeDataGridViewTextBoxColumn1
            // 
            this.bloodTypeDataGridViewTextBoxColumn1.DataPropertyName = "BloodType";
            this.bloodTypeDataGridViewTextBoxColumn1.HeaderText = "BloodType";
            this.bloodTypeDataGridViewTextBoxColumn1.Name = "bloodTypeDataGridViewTextBoxColumn1";
            // 
            // expiryDateDataGridViewTextBoxColumn
            // 
            this.expiryDateDataGridViewTextBoxColumn.DataPropertyName = "ExpiryDate";
            this.expiryDateDataGridViewTextBoxColumn.HeaderText = "ExpiryDate";
            this.expiryDateDataGridViewTextBoxColumn.Name = "expiryDateDataGridViewTextBoxColumn";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlRemoveFilters);
            this.tabPage1.Controls.Add(this.pnlUserNav);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.pnlUserEdit);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "    Users    ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlRemoveFilters
            // 
            this.pnlRemoveFilters.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlRemoveFilters.Controls.Add(this.btnRemoveFilter);
            this.pnlRemoveFilters.Location = new System.Drawing.Point(536, 179);
            this.pnlRemoveFilters.Name = "pnlRemoveFilters";
            this.pnlRemoveFilters.Size = new System.Drawing.Size(251, 33);
            this.pnlRemoveFilters.TabIndex = 6;
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
            this.panel5.Controls.Add(this.cmdUserFilter);
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
            // 
            // cmdUserFilter
            // 
            this.cmdUserFilter.FormattingEnabled = true;
            this.cmdUserFilter.Items.AddRange(new object[] {
            "Admin",
            "Nurse",
            "Donor"});
            this.cmdUserFilter.Location = new System.Drawing.Point(126, 168);
            this.cmdUserFilter.Name = "cmdUserFilter";
            this.cmdUserFilter.Size = new System.Drawing.Size(73, 21);
            this.cmdUserFilter.TabIndex = 8;
            this.cmdUserFilter.Text = "Admin";
            // 
            // btnUserFilter
            // 
            this.btnUserFilter.Location = new System.Drawing.Point(6, 165);
            this.btnUserFilter.Name = "btnUserFilter";
            this.btnUserFilter.Size = new System.Drawing.Size(138, 25);
            this.btnUserFilter.TabIndex = 7;
            this.btnUserFilter.Text = "Fliter by user type";
            this.btnUserFilter.UseVisualStyleBackColor = true;
            // 
            // cmbBloodFilter
            // 
            this.cmbBloodFilter.FormattingEnabled = true;
            this.cmbBloodFilter.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.cmbBloodFilter.Location = new System.Drawing.Point(126, 137);
            this.cmbBloodFilter.Name = "cmbBloodFilter";
            this.cmbBloodFilter.Size = new System.Drawing.Size(73, 21);
            this.cmbBloodFilter.TabIndex = 6;
            this.cmbBloodFilter.Text = "O";
            // 
            // btnBloodFilter
            // 
            this.btnBloodFilter.Location = new System.Drawing.Point(6, 133);
            this.btnBloodFilter.Name = "btnBloodFilter";
            this.btnBloodFilter.Size = new System.Drawing.Size(138, 26);
            this.btnBloodFilter.TabIndex = 5;
            this.btnBloodFilter.Text = "Filter by blood type";
            this.btnBloodFilter.UseVisualStyleBackColor = true;
            this.btnBloodFilter.Click += new System.EventHandler(this.btnBloodFilter_Click);
            // 
            // btnSurnameAlphabetical
            // 
            this.btnSurnameAlphabetical.Location = new System.Drawing.Point(6, 101);
            this.btnSurnameAlphabetical.Name = "btnSurnameAlphabetical";
            this.btnSurnameAlphabetical.Size = new System.Drawing.Size(193, 26);
            this.btnSurnameAlphabetical.TabIndex = 4;
            this.btnSurnameAlphabetical.Text = "Sort alphabetically(Surname)";
            this.btnSurnameAlphabetical.UseVisualStyleBackColor = true;
            // 
            // btnNameAlphabetical
            // 
            this.btnNameAlphabetical.Location = new System.Drawing.Point(6, 69);
            this.btnNameAlphabetical.Name = "btnNameAlphabetical";
            this.btnNameAlphabetical.Size = new System.Drawing.Size(193, 26);
            this.btnNameAlphabetical.TabIndex = 3;
            this.btnNameAlphabetical.Text = "Sort alphabetically(Name)";
            this.btnNameAlphabetical.UseVisualStyleBackColor = true;
            this.btnNameAlphabetical.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnFilterInactive
            // 
            this.btnFilterInactive.Location = new System.Drawing.Point(126, 35);
            this.btnFilterInactive.Name = "btnFilterInactive";
            this.btnFilterInactive.Size = new System.Drawing.Size(120, 28);
            this.btnFilterInactive.TabIndex = 2;
            this.btnFilterInactive.Text = "Filter by inactive";
            this.btnFilterInactive.UseVisualStyleBackColor = true;
            // 
            // btnFilterActive
            // 
            this.btnFilterActive.Location = new System.Drawing.Point(6, 35);
            this.btnFilterActive.Name = "btnFilterActive";
            this.btnFilterActive.Size = new System.Drawing.Size(120, 28);
            this.btnFilterActive.TabIndex = 1;
            this.btnFilterActive.Text = "Filter by active";
            this.btnFilterActive.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Filters/sorting:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.iDNumberDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn,
            this.bloodTypeDataGridViewTextBoxColumn,
            this.isActiveAccountDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblUsersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 170);
            this.dataGridView1.TabIndex = 3;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // iDNumberDataGridViewTextBoxColumn
            // 
            this.iDNumberDataGridViewTextBoxColumn.DataPropertyName = "IDNumber";
            this.iDNumberDataGridViewTextBoxColumn.HeaderText = "IDNumber";
            this.iDNumberDataGridViewTextBoxColumn.Name = "iDNumberDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "UserType";
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            // 
            // bloodTypeDataGridViewTextBoxColumn
            // 
            this.bloodTypeDataGridViewTextBoxColumn.DataPropertyName = "BloodType";
            this.bloodTypeDataGridViewTextBoxColumn.HeaderText = "BloodType";
            this.bloodTypeDataGridViewTextBoxColumn.Name = "bloodTypeDataGridViewTextBoxColumn";
            // 
            // isActiveAccountDataGridViewCheckBoxColumn
            // 
            this.isActiveAccountDataGridViewCheckBoxColumn.DataPropertyName = "isActiveAccount";
            this.isActiveAccountDataGridViewCheckBoxColumn.HeaderText = "isActiveAccount";
            this.isActiveAccountDataGridViewCheckBoxColumn.Name = "isActiveAccountDataGridViewCheckBoxColumn";
            // 
            // pnlUserEdit
            // 
            this.pnlUserEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlUserEdit.Controls.Add(this.btnInsertUser);
            this.pnlUserEdit.Controls.Add(this.label9);
            this.pnlUserEdit.Controls.Add(this.label8);
            this.pnlUserEdit.Controls.Add(this.label7);
            this.pnlUserEdit.Controls.Add(this.label6);
            this.pnlUserEdit.Controls.Add(this.label5);
            this.pnlUserEdit.Controls.Add(this.label4);
            this.pnlUserEdit.Controls.Add(this.label3);
            this.pnlUserEdit.Controls.Add(this.label2);
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
            this.pnlUserEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlUserEdit.Location = new System.Drawing.Point(6, 218);
            this.pnlUserEdit.Name = "pnlUserEdit";
            this.pnlUserEdit.Size = new System.Drawing.Size(778, 163);
            this.pnlUserEdit.TabIndex = 2;
            // 
            // btnInsertUser
            // 
            this.btnInsertUser.Location = new System.Drawing.Point(469, 25);
            this.btnInsertUser.Name = "btnInsertUser";
            this.btnInsertUser.Size = new System.Drawing.Size(121, 31);
            this.btnInsertUser.TabIndex = 20;
            this.btnInsertUser.Text = "Insert record";
            this.btnInsertUser.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(240, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "User Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(233, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Blood Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Surname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(217, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Phone number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "UserID:";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(469, 74);
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
            this.cmbUser.Location = new System.Drawing.Point(320, 61);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(121, 24);
            this.cmbUser.TabIndex = 8;
            // 
            // cmbBlood
            // 
            this.cmbBlood.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblUsersBindingSource, "UserType", true));
            this.cmbBlood.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "BloodType", true));
            this.cmbBlood.FormattingEnabled = true;
            this.cmbBlood.Location = new System.Drawing.Point(320, 86);
            this.cmbBlood.Name = "cmbBlood";
            this.cmbBlood.Size = new System.Drawing.Size(121, 24);
            this.cmbBlood.TabIndex = 7;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 413);
            this.tabControl1.TabIndex = 1;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2jwDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBloodInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.pnlRemoveFilters.ResumeLayout(false);
            this.pnlUserNav.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlUserEdit.ResumeLayout(false);
            this.pnlUserEdit.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private ist2jwDataSet ist2jwDataSet;
        private ist2jwDataSetTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private System.Windows.Forms.BindingSource tblBloodInventoryBindingSource;
        private ist2jwDataSetTableAdapters.TblBloodInventoryTableAdapter tblBloodInventoryTableAdapter;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private ist2jwDataSetTableAdapters.AppointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private ist2jwDataSetTableAdapters.ScheduleTableAdapter scheduleTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnAppLast;
        private System.Windows.Forms.Button btnAppFirst;
        private System.Windows.Forms.Button btnAppPrev;
        private System.Windows.Forms.Button btnAppNext;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn appIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn appDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnBloodLast;
        private System.Windows.Forms.Button btnBloodFirst;
        private System.Windows.Forms.Button btnBloodPrev;
        private System.Windows.Forms.Button btnBllodNext;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn appIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlRemoveFilters;
        private System.Windows.Forms.Button btnRemoveFilter;
        private System.Windows.Forms.Panel pnlUserNav;
        private System.Windows.Forms.Button btnUserLast;
        private System.Windows.Forms.Button btnUserFirst;
        private System.Windows.Forms.Button btnUserPrev;
        private System.Windows.Forms.Button btnUserNext;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmdUserFilter;
        private System.Windows.Forms.Button btnUserFilter;
        private System.Windows.Forms.ComboBox cmbBloodFilter;
        private System.Windows.Forms.Button btnBloodFilter;
        private System.Windows.Forms.Button btnSurnameAlphabetical;
        private System.Windows.Forms.Button btnNameAlphabetical;
        private System.Windows.Forms.Button btnFilterInactive;
        private System.Windows.Forms.Button btnFilterActive;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button20;
    }
}