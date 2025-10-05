namespace BloodBankSystem
{
    partial class LoginForm
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
            this.IDLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.mIDTextBox = new System.Windows.Forms.MaskedTextBox();
            this.passShowImg = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ist2jwDataSet = new BloodBankSystem.ist2jwDataSet();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsersTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.tblUsersTableAdapter();
            this.tableAdapterManager = new BloodBankSystem.ist2jwDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.passShowImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2jwDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.BackColor = System.Drawing.Color.White;
            this.IDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.IDLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.IDLabel.Location = new System.Drawing.Point(204, 129);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(154, 33);
            this.IDLabel.TabIndex = 10;
            this.IDLabel.Text = "ID Number";
            this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.PasswordTextBox.Location = new System.Drawing.Point(103, 320);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(339, 38);
            this.PasswordTextBox.TabIndex = 13;
            this.PasswordTextBox.Tag = "";
            this.PasswordTextBox.Text = "Gom314";
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.BackColor = System.Drawing.Color.White;
            this.PasswordLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.PasswordLbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.PasswordLbl.Location = new System.Drawing.Point(204, 274);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(154, 33);
            this.PasswordLbl.TabIndex = 12;
            this.PasswordLbl.Text = "Password";
            this.PasswordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackBlue;
            this.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Arial", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.Red;
            this.loginBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loginBtn.Location = new System.Drawing.Point(174, 385);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(219, 72);
            this.loginBtn.TabIndex = 17;
            this.loginBtn.Text = "Log in";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            this.loginBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginBtn_MouseDown);
            this.loginBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginBtn_MouseUp);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackGreen;
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BackBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Arial", 18.25F);
            this.BackBtn.Location = new System.Drawing.Point(12, 445);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(104, 39);
            this.BackBtn.TabIndex = 18;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            this.BackBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackBtn_MouseDown);
            this.BackBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BackBtn_MouseUp);
            // 
            // mIDTextBox
            // 
            this.mIDTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mIDTextBox.Font = new System.Drawing.Font("Arial", 20.25F);
            this.mIDTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mIDTextBox.Location = new System.Drawing.Point(103, 193);
            this.mIDTextBox.Mask = "0000000000000";
            this.mIDTextBox.Name = "mIDTextBox";
            this.mIDTextBox.Size = new System.Drawing.Size(339, 39);
            this.mIDTextBox.TabIndex = 19;
            this.mIDTextBox.Text = "0507136031089";
            this.mIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mIDTextBox.ValidatingType = typeof(int);
            // 
            // passShowImg
            // 
            this.passShowImg.BackColor = System.Drawing.Color.Transparent;
            this.passShowImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passShowImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passShowImg.Image = global::BloodBankSystem.Properties.Resources.HomeBack;
            this.passShowImg.Location = new System.Drawing.Point(458, 320);
            this.passShowImg.Name = "passShowImg";
            this.passShowImg.Size = new System.Drawing.Size(37, 33);
            this.passShowImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passShowImg.TabIndex = 25;
            this.passShowImg.TabStop = false;
            this.passShowImg.Click += new System.EventHandler(this.passShowImg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BloodBankSystem.Properties.Resources.Logbackground;
            this.pictureBox1.Image = global::BloodBankSystem.Properties.Resources.Logbackground;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 508);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
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
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BloodBankSystem.Properties.Resources.Logbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(554, 509);
            this.Controls.Add(this.passShowImg);
            this.Controls.Add(this.mIDTextBox);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passShowImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2jwDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.MaskedTextBox mIDTextBox;
        private ist2jwDataSet ist2jwDataSet;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private ist2jwDataSetTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private ist2jwDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox passShowImg;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}