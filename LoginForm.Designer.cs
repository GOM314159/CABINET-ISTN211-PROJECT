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
            this.logTitleLbl = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.mIDTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // logTitleLbl
            // 
            this.logTitleLbl.BackColor = System.Drawing.Color.Red;
            this.logTitleLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logTitleLbl.Font = new System.Drawing.Font("Modern No. 20", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTitleLbl.ForeColor = System.Drawing.Color.Transparent;
            this.logTitleLbl.Location = new System.Drawing.Point(0, 0);
            this.logTitleLbl.Name = "logTitleLbl";
            this.logTitleLbl.Size = new System.Drawing.Size(534, 50);
            this.logTitleLbl.TabIndex = 2;
            this.logTitleLbl.Text = "Login Page";
            this.logTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDLabel
            // 
            this.IDLabel.BackColor = System.Drawing.Color.White;
            this.IDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.IDLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.IDLabel.Location = new System.Drawing.Point(186, 123);
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
            this.PasswordTextBox.Location = new System.Drawing.Point(109, 308);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(301, 38);
            this.PasswordTextBox.TabIndex = 13;
            this.PasswordTextBox.Tag = "";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.BackColor = System.Drawing.Color.White;
            this.PasswordLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.PasswordLbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.PasswordLbl.Location = new System.Drawing.Point(186, 258);
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
            this.loginBtn.Location = new System.Drawing.Point(152, 365);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(219, 72);
            this.loginBtn.TabIndex = 17;
            this.loginBtn.Text = "Log in";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
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
            // 
            // mIDTextBox
            // 
            this.mIDTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mIDTextBox.Font = new System.Drawing.Font("Arial", 20.25F);
            this.mIDTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mIDTextBox.Location = new System.Drawing.Point(109, 169);
            this.mIDTextBox.Mask = "0 0 0 0 0 0 0 0 0 0 0 0 0";
            this.mIDTextBox.Name = "mIDTextBox";
            this.mIDTextBox.Size = new System.Drawing.Size(301, 39);
            this.mIDTextBox.TabIndex = 19;
            this.mIDTextBox.ValidatingType = typeof(int);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BloodBankSystem.Properties.Resources.RegBack;
            this.ClientSize = new System.Drawing.Size(534, 496);
            this.Controls.Add(this.mIDTextBox);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.logTitleLbl);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label logTitleLbl;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.MaskedTextBox mIDTextBox;
    }
}