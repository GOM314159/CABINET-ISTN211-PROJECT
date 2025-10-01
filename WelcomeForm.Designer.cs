namespace BloodBankSystem
{
    partial class WelcomeForm
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
            this.RegBtn = new System.Windows.Forms.Button();
            this.Logbtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RegBtn
            // 
            this.RegBtn.BackColor = System.Drawing.Color.Transparent;
            this.RegBtn.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackBlue;
            this.RegBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RegBtn.FlatAppearance.BorderSize = 0;
            this.RegBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RegBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegBtn.Font = new System.Drawing.Font("Arial", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegBtn.ForeColor = System.Drawing.Color.Red;
            this.RegBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RegBtn.Location = new System.Drawing.Point(12, 145);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(326, 72);
            this.RegBtn.TabIndex = 17;
            this.RegBtn.Text = "Become a Donor";
            this.RegBtn.UseVisualStyleBackColor = false;
            this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
            this.RegBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegBtn_MouseDown);
            this.RegBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RegBtn_MouseUp);
            // 
            // Logbtn
            // 
            this.Logbtn.BackColor = System.Drawing.Color.Transparent;
            this.Logbtn.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackRed;
            this.Logbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logbtn.FlatAppearance.BorderSize = 0;
            this.Logbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Logbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Logbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logbtn.Font = new System.Drawing.Font("Arial", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logbtn.ForeColor = System.Drawing.Color.Blue;
            this.Logbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Logbtn.Location = new System.Drawing.Point(237, 252);
            this.Logbtn.Name = "Logbtn";
            this.Logbtn.Size = new System.Drawing.Size(326, 75);
            this.Logbtn.TabIndex = 19;
            this.Logbtn.Text = "Already a Donor";
            this.Logbtn.UseVisualStyleBackColor = false;
            this.Logbtn.Click += new System.EventHandler(this.Logbtn_Click);
            this.Logbtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Logbtn_MouseDown);
            this.Logbtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Logbtn_MouseUp);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackOrange;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Arial", 18.25F);
            this.ExitBtn.ForeColor = System.Drawing.Color.Black;
            this.ExitBtn.Location = new System.Drawing.Point(220, 378);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(118, 45);
            this.ExitBtn.TabIndex = 20;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            this.ExitBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitBtn_MouseDown);
            this.ExitBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ExitBtn_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BloodBankSystem.Properties.Resources.WelcomeBackground;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(575, 456);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::BloodBankSystem.Properties.Resources.WelcomeBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(575, 449);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.Logbtn);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Form";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RegBtn;
        private System.Windows.Forms.Button Logbtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

