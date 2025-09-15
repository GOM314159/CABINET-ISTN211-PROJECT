namespace BloodBank_Test_1
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
            this.regTitleLbl = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.CellLbl = new System.Windows.Forms.Label();
            this.CellTextBox = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.regBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // regTitleLbl
            // 
            this.regTitleLbl.BackColor = System.Drawing.Color.Red;
            this.regTitleLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regTitleLbl.Font = new System.Drawing.Font("Arial", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regTitleLbl.ForeColor = System.Drawing.Color.Transparent;
            this.regTitleLbl.Location = new System.Drawing.Point(0, 0);
            this.regTitleLbl.Name = "regTitleLbl";
            this.regTitleLbl.Size = new System.Drawing.Size(684, 50);
            this.regTitleLbl.TabIndex = 3;
            this.regTitleLbl.Text = "Registration Page";
            this.regTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.FirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.FirstNameTextBox.Location = new System.Drawing.Point(342, 111);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(302, 32);
            this.FirstNameTextBox.TabIndex = 4;
            this.FirstNameTextBox.Tag = "";
            // 
            // NameLbl
            // 
            this.NameLbl.BackColor = System.Drawing.Color.White;
            this.NameLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.NameLbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.NameLbl.Location = new System.Drawing.Point(48, 112);
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
            this.SurnameLbl.Location = new System.Drawing.Point(48, 169);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(229, 33);
            this.SurnameLbl.TabIndex = 7;
            this.SurnameLbl.Text = "Surname";
            this.SurnameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.SurnameTextBox.Location = new System.Drawing.Point(342, 169);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(302, 32);
            this.SurnameTextBox.TabIndex = 6;
            this.SurnameTextBox.Tag = "";
            this.SurnameTextBox.TextChanged += new System.EventHandler(this.SurnameTextBox_TextChanged);
            // 
            // IDLabel
            // 
            this.IDLabel.BackColor = System.Drawing.Color.White;
            this.IDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.IDLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.IDLabel.Location = new System.Drawing.Point(48, 227);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(229, 33);
            this.IDLabel.TabIndex = 8;
            this.IDLabel.Text = "ID Number";
            this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDTextBox
            // 
            this.IDTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.IDTextBox.Location = new System.Drawing.Point(342, 226);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(302, 32);
            this.IDTextBox.TabIndex = 9;
            this.IDTextBox.Tag = "";
            // 
            // CellLbl
            // 
            this.CellLbl.BackColor = System.Drawing.Color.White;
            this.CellLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CellLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.CellLbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.CellLbl.Location = new System.Drawing.Point(48, 288);
            this.CellLbl.Name = "CellLbl";
            this.CellLbl.Size = new System.Drawing.Size(229, 33);
            this.CellLbl.TabIndex = 10;
            this.CellLbl.Text = "Cellphone Number";
            this.CellLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CellTextBox
            // 
            this.CellTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CellTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.CellTextBox.Location = new System.Drawing.Point(342, 286);
            this.CellTextBox.Name = "CellTextBox";
            this.CellTextBox.Size = new System.Drawing.Size(302, 32);
            this.CellTextBox.TabIndex = 11;
            this.CellTextBox.Tag = "";
            // 
            // EmailLbl
            // 
            this.EmailLbl.BackColor = System.Drawing.Color.White;
            this.EmailLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.EmailLbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.EmailLbl.Location = new System.Drawing.Point(48, 351);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(229, 33);
            this.EmailLbl.TabIndex = 12;
            this.EmailLbl.Text = "Email";
            this.EmailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.EmailTextBox.Location = new System.Drawing.Point(342, 351);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(302, 32);
            this.EmailTextBox.TabIndex = 13;
            this.EmailTextBox.Tag = "";
            // 
            // AddressLbl
            // 
            this.AddressLbl.BackColor = System.Drawing.Color.White;
            this.AddressLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.AddressLbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AddressLbl.Location = new System.Drawing.Point(48, 411);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(229, 33);
            this.AddressLbl.TabIndex = 14;
            this.AddressLbl.Text = "Address";
            this.AddressLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.AddressTextBox.Location = new System.Drawing.Point(342, 410);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(302, 32);
            this.AddressTextBox.TabIndex = 15;
            this.AddressTextBox.Tag = "";
            // 
            // regBtn
            // 
            this.regBtn.BackColor = System.Drawing.Color.Transparent;
            this.regBtn.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackRed;
            this.regBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regBtn.FlatAppearance.BorderSize = 0;
            this.regBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regBtn.Font = new System.Drawing.Font("Arial", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBtn.ForeColor = System.Drawing.Color.Red;
            this.regBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.regBtn.Location = new System.Drawing.Point(228, 470);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(219, 61);
            this.regBtn.TabIndex = 16;
            this.regBtn.Text = "Register";
            this.regBtn.UseVisualStyleBackColor = false;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackBlue;
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Arial", 18.25F);
            this.BackBtn.Location = new System.Drawing.Point(12, 550);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(104, 39);
            this.BackBtn.TabIndex = 17;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BloodBankSystem.Properties.Resources.RegBack;
            this.ClientSize = new System.Drawing.Size(684, 601);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.AddressLbl);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.CellTextBox);
            this.Controls.Add(this.CellLbl);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.SurnameLbl);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.regTitleLbl);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label regTitleLbl;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label CellLbl;
        private System.Windows.Forms.TextBox CellTextBox;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}