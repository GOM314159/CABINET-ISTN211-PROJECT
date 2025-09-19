namespace BloodBankSystem
{
    partial class HomePage
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
            this.welcomelbl = new System.Windows.Forms.Label();
            this.bbNameLbl = new System.Windows.Forms.Label();
            this.ProfileImg = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.donoLbl = new System.Windows.Forms.Panel();
            this.prfNameLbl = new System.Windows.Forms.Label();
            this.donLbl = new System.Windows.Forms.Label();
            this.nextDonLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImg)).BeginInit();
            this.donoLbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomelbl
            // 
            this.welcomelbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomelbl.BackColor = System.Drawing.Color.White;
            this.welcomelbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.welcomelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.25F, System.Drawing.FontStyle.Bold);
            this.welcomelbl.ForeColor = System.Drawing.Color.Red;
            this.welcomelbl.Location = new System.Drawing.Point(174, 0);
            this.welcomelbl.Name = "welcomelbl";
            this.welcomelbl.Size = new System.Drawing.Size(832, 60);
            this.welcomelbl.TabIndex = 2;
            this.welcomelbl.Text = "Welcome ";
            this.welcomelbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bbNameLbl
            // 
            this.bbNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bbNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.bbNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbNameLbl.ForeColor = System.Drawing.Color.Red;
            this.bbNameLbl.Location = new System.Drawing.Point(268, 60);
            this.bbNameLbl.Name = "bbNameLbl";
            this.bbNameLbl.Size = new System.Drawing.Size(649, 51);
            this.bbNameLbl.TabIndex = 3;
            this.bbNameLbl.Text = "To Blood    Bankers";
            this.bbNameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProfileImg
            // 
            this.ProfileImg.BackColor = System.Drawing.Color.Transparent;
            this.ProfileImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfileImg.Image = global::BloodBankSystem.Properties.Resources.ProfileBackImg;
            this.ProfileImg.Location = new System.Drawing.Point(1094, 0);
            this.ProfileImg.Name = "ProfileImg";
            this.ProfileImg.Size = new System.Drawing.Size(90, 80);
            this.ProfileImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfileImg.TabIndex = 4;
            this.ProfileImg.TabStop = false;
            this.ProfileImg.Click += new System.EventHandler(this.ProfileImg_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(22, 404);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // donoLbl
            // 
            this.donoLbl.BackColor = System.Drawing.Color.MistyRose;
            this.donoLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.donoLbl.Controls.Add(this.nextDonLbl);
            this.donoLbl.Controls.Add(this.monthCalendar1);
            this.donoLbl.Controls.Add(this.donLbl);
            this.donoLbl.Controls.Add(this.prfNameLbl);
            this.donoLbl.Location = new System.Drawing.Point(894, 76);
            this.donoLbl.Name = "donoLbl";
            this.donoLbl.Size = new System.Drawing.Size(290, 585);
            this.donoLbl.TabIndex = 6;
            this.donoLbl.Visible = false;
            // 
            // prfNameLbl
            // 
            this.prfNameLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prfNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.prfNameLbl.Location = new System.Drawing.Point(-1, -1);
            this.prfNameLbl.Name = "prfNameLbl";
            this.prfNameLbl.Size = new System.Drawing.Size(292, 44);
            this.prfNameLbl.TabIndex = 0;
            this.prfNameLbl.Text = "Name";
            this.prfNameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // donLbl
            // 
            this.donLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.donLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.donLbl.Location = new System.Drawing.Point(0, 67);
            this.donLbl.Name = "donLbl";
            this.donLbl.Size = new System.Drawing.Size(292, 32);
            this.donLbl.TabIndex = 1;
            this.donLbl.Text = "Total Donations";
            this.donLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nextDonLbl
            // 
            this.nextDonLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nextDonLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.nextDonLbl.Location = new System.Drawing.Point(0, 187);
            this.nextDonLbl.Name = "nextDonLbl";
            this.nextDonLbl.Size = new System.Drawing.Size(292, 32);
            this.nextDonLbl.TabIndex = 2;
            this.nextDonLbl.Text = "Next Donation Date";
            this.nextDonLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BloodBankSystem.Properties.Resources.HomeBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.donoLbl);
            this.Controls.Add(this.ProfileImg);
            this.Controls.Add(this.bbNameLbl);
            this.Controls.Add(this.welcomelbl);
            this.Name = "HomePage";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImg)).EndInit();
            this.donoLbl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcomelbl;
        private System.Windows.Forms.Label bbNameLbl;
        private System.Windows.Forms.PictureBox ProfileImg;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel donoLbl;
        private System.Windows.Forms.Label prfNameLbl;
        private System.Windows.Forms.Label donLbl;
        private System.Windows.Forms.Label nextDonLbl;
    }
}