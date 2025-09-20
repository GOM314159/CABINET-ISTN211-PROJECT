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
            this.prfPnl = new System.Windows.Forms.Panel();
            this.prfNameLbl = new System.Windows.Forms.Label();
            this.prfDonLbl = new System.Windows.Forms.Label();
            this.prfNextDonLbl = new System.Windows.Forms.Label();
            this.prfnextDateLbl = new System.Windows.Forms.Label();
            this.ttlDonLbl = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImg)).BeginInit();
            this.prfPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomelbl
            // 
            this.welcomelbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomelbl.BackColor = System.Drawing.Color.White;
            this.welcomelbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.welcomelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.25F, System.Drawing.FontStyle.Bold);
            this.welcomelbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.welcomelbl.Location = new System.Drawing.Point(197, 0);
            this.welcomelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomelbl.Name = "welcomelbl";
            this.welcomelbl.Size = new System.Drawing.Size(837, 58);
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
            this.bbNameLbl.Location = new System.Drawing.Point(197, 58);
            this.bbNameLbl.Name = "bbNameLbl";
            this.bbNameLbl.Size = new System.Drawing.Size(837, 63);
            this.bbNameLbl.TabIndex = 3;
            this.bbNameLbl.Text = "To Blood    Bankers";
            this.bbNameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProfileImg
            // 
            this.ProfileImg.BackColor = System.Drawing.Color.Transparent;
            this.ProfileImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfileImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfileImg.Image = global::BloodBankSystem.Properties.Resources.ProfileBackImg;
            this.ProfileImg.Location = new System.Drawing.Point(1105, 0);
            this.ProfileImg.Margin = new System.Windows.Forms.Padding(4);
            this.ProfileImg.Name = "ProfileImg";
            this.ProfileImg.Size = new System.Drawing.Size(129, 100);
            this.ProfileImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfileImg.TabIndex = 4;
            this.ProfileImg.TabStop = false;
            this.ProfileImg.Click += new System.EventHandler(this.ProfileImg_Click);
            // 
            // prfPnl
            // 
            this.prfPnl.BackColor = System.Drawing.Color.MistyRose;
            this.prfPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prfPnl.Controls.Add(this.monthCalendar1);
            this.prfPnl.Controls.Add(this.ttlDonLbl);
            this.prfPnl.Controls.Add(this.prfnextDateLbl);
            this.prfPnl.Controls.Add(this.prfNextDonLbl);
            this.prfPnl.Controls.Add(this.prfDonLbl);
            this.prfPnl.Controls.Add(this.prfNameLbl);
            this.prfPnl.Location = new System.Drawing.Point(884, 98);
            this.prfPnl.Name = "prfPnl";
            this.prfPnl.Size = new System.Drawing.Size(350, 550);
            this.prfPnl.TabIndex = 5;
            this.prfPnl.Visible = false;
            // 
            // prfNameLbl
            // 
            this.prfNameLbl.BackColor = System.Drawing.Color.MistyRose;
            this.prfNameLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prfNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prfNameLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.prfNameLbl.Location = new System.Drawing.Point(0, 0);
            this.prfNameLbl.Name = "prfNameLbl";
            this.prfNameLbl.Size = new System.Drawing.Size(347, 41);
            this.prfNameLbl.TabIndex = 0;
            this.prfNameLbl.Text = "Name";
            this.prfNameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // prfDonLbl
            // 
            this.prfDonLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prfDonLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.prfDonLbl.ForeColor = System.Drawing.Color.Maroon;
            this.prfDonLbl.Location = new System.Drawing.Point(-1, 80);
            this.prfDonLbl.Name = "prfDonLbl";
            this.prfDonLbl.Size = new System.Drawing.Size(349, 32);
            this.prfDonLbl.TabIndex = 1;
            this.prfDonLbl.Text = "Total Donations";
            this.prfDonLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // prfNextDonLbl
            // 
            this.prfNextDonLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prfNextDonLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.prfNextDonLbl.ForeColor = System.Drawing.Color.Maroon;
            this.prfNextDonLbl.Location = new System.Drawing.Point(-1, 209);
            this.prfNextDonLbl.Name = "prfNextDonLbl";
            this.prfNextDonLbl.Size = new System.Drawing.Size(348, 32);
            this.prfNextDonLbl.TabIndex = 2;
            this.prfNextDonLbl.Text = "Next Donation";
            this.prfNextDonLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // prfnextDateLbl
            // 
            this.prfnextDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.prfnextDateLbl.ForeColor = System.Drawing.Color.Maroon;
            this.prfnextDateLbl.Location = new System.Drawing.Point(-1, 259);
            this.prfnextDateLbl.Name = "prfnextDateLbl";
            this.prfnextDateLbl.Size = new System.Drawing.Size(348, 32);
            this.prfnextDateLbl.TabIndex = 3;
            this.prfnextDateLbl.Text = "Date";
            this.prfnextDateLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ttlDonLbl
            // 
            this.ttlDonLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.ttlDonLbl.ForeColor = System.Drawing.Color.Maroon;
            this.ttlDonLbl.Location = new System.Drawing.Point(-2, 133);
            this.ttlDonLbl.Name = "ttlDonLbl";
            this.ttlDonLbl.Size = new System.Drawing.Size(348, 32);
            this.ttlDonLbl.TabIndex = 4;
            this.ttlDonLbl.Text = "0";
            this.ttlDonLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(56, 369);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 6;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BloodBankSystem.Properties.Resources.HomeBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1234, 648);
            this.Controls.Add(this.prfPnl);
            this.Controls.Add(this.ProfileImg);
            this.Controls.Add(this.bbNameLbl);
            this.Controls.Add(this.welcomelbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImg)).EndInit();
            this.prfPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcomelbl;
        private System.Windows.Forms.Label bbNameLbl;
        private System.Windows.Forms.PictureBox ProfileImg;
        private System.Windows.Forms.Panel prfPnl;
        private System.Windows.Forms.Label prfDonLbl;
        private System.Windows.Forms.Label prfNameLbl;
        private System.Windows.Forms.Label prfnextDateLbl;
        private System.Windows.Forms.Label prfNextDonLbl;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label ttlDonLbl;
    }
}