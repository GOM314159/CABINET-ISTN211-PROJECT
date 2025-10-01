namespace BloodBankSystem
{
    partial class RegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            this.NameLbl = new System.Windows.Forms.Label();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.CellLbl = new System.Windows.Forms.Label();
            this.regBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.mIDTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.mCellphoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.bloodtypeLbl = new System.Windows.Forms.Label();
            this.bloodtypeCmbox = new System.Windows.Forms.ComboBox();
            this.pswrdLbl = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passShowImg = new System.Windows.Forms.PictureBox();
            this.ist2jwDataSet = new BloodBankSystem.ist2jwDataSet();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsersTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.tblUsersTableAdapter();
            this.tableAdapterManager = new BloodBankSystem.ist2jwDataSetTableAdapters.TableAdapterManager();
            this.helpBtn = new System.Windows.Forms.Button();
            this.userRegTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.passShowImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2jwDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.BackColor = System.Drawing.Color.White;
            this.NameLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.NameLbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.NameLbl.Location = new System.Drawing.Point(46, 93);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(229, 33);
            this.NameLbl.TabIndex = 5;
            this.NameLbl.Text = "First Name";
            this.NameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.BackColor = System.Drawing.Color.White;
            this.SurnameLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SurnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.SurnameLbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.SurnameLbl.Location = new System.Drawing.Point(46, 176);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(229, 33);
            this.SurnameLbl.TabIndex = 7;
            this.SurnameLbl.Text = "Last Name";
            this.SurnameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDLabel
            // 
            this.IDLabel.BackColor = System.Drawing.Color.White;
            this.IDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.IDLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.IDLabel.Location = new System.Drawing.Point(46, 255);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(229, 33);
            this.IDLabel.TabIndex = 8;
            this.IDLabel.Text = "ID Number";
            this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CellLbl
            // 
            this.CellLbl.BackColor = System.Drawing.Color.White;
            this.CellLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CellLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.CellLbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.CellLbl.Location = new System.Drawing.Point(46, 328);
            this.CellLbl.Name = "CellLbl";
            this.CellLbl.Size = new System.Drawing.Size(229, 33);
            this.CellLbl.TabIndex = 10;
            this.CellLbl.Text = "Cellphone Number";
            this.CellLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // regBtn
            // 
            this.regBtn.BackColor = System.Drawing.Color.Transparent;
            this.regBtn.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackBlue;
            this.regBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regBtn.FlatAppearance.BorderSize = 0;
            this.regBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.regBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.regBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regBtn.Font = new System.Drawing.Font("Arial", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.regBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.regBtn.Location = new System.Drawing.Point(250, 557);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(219, 61);
            this.regBtn.TabIndex = 16;
            this.regBtn.Text = "Register";
            this.regBtn.UseVisualStyleBackColor = false;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            this.regBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.regBtn_MouseDown);
            this.regBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.regBtn_MouseUp);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackGreen;
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BackBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Arial", 18.25F);
            this.BackBtn.Location = new System.Drawing.Point(12, 579);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(104, 39);
            this.BackBtn.TabIndex = 17;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            this.BackBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackBtn_MouseDown);
            this.BackBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BackBtn_MouseUp);
            // 
            // mIDTextBox
            // 
            this.mIDTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mIDTextBox.Font = new System.Drawing.Font("Arial", 16.25F);
            this.mIDTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mIDTextBox.Location = new System.Drawing.Point(349, 255);
            this.mIDTextBox.Mask = "0000000000000";
            this.mIDTextBox.Name = "mIDTextBox";
            this.mIDTextBox.Size = new System.Drawing.Size(292, 32);
            this.mIDTextBox.TabIndex = 18;
            this.userRegTip.SetToolTip(this.mIDTextBox, "Enter your ID number (Must be a SA ID)");
            this.mIDTextBox.ValidatingType = typeof(int);
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.fNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.fNameTextBox.Location = new System.Drawing.Point(349, 94);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(292, 32);
            this.fNameTextBox.TabIndex = 4;
            this.fNameTextBox.Tag = "";
            this.userRegTip.SetToolTip(this.fNameTextBox, "Enter your First Name");
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lastNameTextBox.Location = new System.Drawing.Point(349, 176);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(292, 32);
            this.lastNameTextBox.TabIndex = 6;
            this.lastNameTextBox.Tag = "";
            this.userRegTip.SetToolTip(this.lastNameTextBox, "Enter your Last Name / Surname");
            // 
            // mCellphoneTextBox
            // 
            this.mCellphoneTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mCellphoneTextBox.Font = new System.Drawing.Font("Arial", 16.25F);
            this.mCellphoneTextBox.Location = new System.Drawing.Point(349, 328);
            this.mCellphoneTextBox.Mask = "0000000000";
            this.mCellphoneTextBox.Name = "mCellphoneTextBox";
            this.mCellphoneTextBox.Size = new System.Drawing.Size(292, 32);
            this.mCellphoneTextBox.TabIndex = 19;
            this.userRegTip.SetToolTip(this.mCellphoneTextBox, "Enter your cellphone number");
            this.mCellphoneTextBox.ValidatingType = typeof(int);
            // 
            // bloodtypeLbl
            // 
            this.bloodtypeLbl.BackColor = System.Drawing.Color.White;
            this.bloodtypeLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bloodtypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.bloodtypeLbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bloodtypeLbl.Location = new System.Drawing.Point(46, 398);
            this.bloodtypeLbl.Name = "bloodtypeLbl";
            this.bloodtypeLbl.Size = new System.Drawing.Size(229, 33);
            this.bloodtypeLbl.TabIndex = 20;
            this.bloodtypeLbl.Text = "Blood Type";
            this.bloodtypeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bloodtypeCmbox
            // 
            this.bloodtypeCmbox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bloodtypeCmbox.Font = new System.Drawing.Font("Arial", 16.25F);
            this.bloodtypeCmbox.FormattingEnabled = true;
            this.bloodtypeCmbox.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O",
            "Not Sure"});
            this.bloodtypeCmbox.Location = new System.Drawing.Point(349, 398);
            this.bloodtypeCmbox.Name = "bloodtypeCmbox";
            this.bloodtypeCmbox.Size = new System.Drawing.Size(292, 33);
            this.bloodtypeCmbox.TabIndex = 21;
            this.userRegTip.SetToolTip(this.bloodtypeCmbox, "Choose your blood type (if unknown choose not sure option )");
            // 
            // pswrdLbl
            // 
            this.pswrdLbl.BackColor = System.Drawing.Color.White;
            this.pswrdLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pswrdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.pswrdLbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.pswrdLbl.Location = new System.Drawing.Point(46, 476);
            this.pswrdLbl.Name = "pswrdLbl";
            this.pswrdLbl.Size = new System.Drawing.Size(229, 33);
            this.pswrdLbl.TabIndex = 22;
            this.pswrdLbl.Text = "Password";
            this.pswrdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.passwordTextBox.Location = new System.Drawing.Point(349, 476);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(292, 32);
            this.passwordTextBox.TabIndex = 23;
            this.passwordTextBox.Tag = "";
            this.userRegTip.SetToolTip(this.passwordTextBox, "Click Help button for more info on making a password");
            // 
            // passShowImg
            // 
            this.passShowImg.BackColor = System.Drawing.Color.Transparent;
            this.passShowImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passShowImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passShowImg.Image = global::BloodBankSystem.Properties.Resources.HomeBack;
            this.passShowImg.Location = new System.Drawing.Point(658, 476);
            this.passShowImg.Name = "passShowImg";
            this.passShowImg.Size = new System.Drawing.Size(37, 33);
            this.passShowImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passShowImg.TabIndex = 24;
            this.passShowImg.TabStop = false;
            this.passShowImg.Click += new System.EventHandler(this.passShowImg_Click);
            // 
            // ist2jwDataSet
            // 
            this.ist2jwDataSet.DataSetName = "ist2jwDataSet";
            this.ist2jwDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tblUsers";
            this.tblUsersBindingSource.DataSource = this.ist2jwDataSet;
            // 
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ScheduleTableAdapter = null;
            this.tableAdapterManager.TblBloodInventoryTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = this.tblUsersTableAdapter;
            this.tableAdapterManager.UpdateOrder = BloodBankSystem.ist2jwDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // helpBtn
            // 
            this.helpBtn.BackColor = System.Drawing.Color.Transparent;
            this.helpBtn.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackOrange;
            this.helpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpBtn.FlatAppearance.BorderSize = 0;
            this.helpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.helpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Font = new System.Drawing.Font("Arial", 18.25F);
            this.helpBtn.Location = new System.Drawing.Point(591, 579);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(104, 39);
            this.helpBtn.TabIndex = 25;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = false;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            this.helpBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.helpBtn_MouseDown);
            this.helpBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.helpBtn_MouseUp_1);
            // 
            // userRegTip
            // 
            this.userRegTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.userRegTip.ToolTipTitle = "Helpful tip";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BloodBankSystem.Properties.Resources.Regbackground;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(707, 632);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::BloodBankSystem.Properties.Resources.HomeBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(707, 630);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.passShowImg);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.pswrdLbl);
            this.Controls.Add(this.bloodtypeCmbox);
            this.Controls.Add(this.bloodtypeLbl);
            this.Controls.Add(this.mCellphoneTextBox);
            this.Controls.Add(this.mIDTextBox);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.CellLbl);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.SurnameLbl);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.RegForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passShowImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2jwDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label CellLbl;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.MaskedTextBox mIDTextBox;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.MaskedTextBox mCellphoneTextBox;
        private ist2jwDataSet ist2jwDataSet;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private ist2jwDataSetTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private ist2jwDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label bloodtypeLbl;
        private System.Windows.Forms.ComboBox bloodtypeCmbox;
        private System.Windows.Forms.Label pswrdLbl;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.PictureBox passShowImg;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.ToolTip userRegTip;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}