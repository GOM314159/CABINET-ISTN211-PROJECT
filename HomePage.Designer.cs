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
            this.label1 = new System.Windows.Forms.Label();
            this.ttlNumDonLbl = new System.Windows.Forms.Label();
            this.nextDonLbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.welcomelbl.ForeColor = System.Drawing.Color.Red;
            this.welcomelbl.Location = new System.Drawing.Point(126, 0);
            this.welcomelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomelbl.Name = "welcomelbl";
            this.welcomelbl.Size = new System.Drawing.Size(982, 73);
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
            this.bbNameLbl.Location = new System.Drawing.Point(159, 73);
            this.bbNameLbl.Name = "bbNameLbl";
            this.bbNameLbl.Size = new System.Drawing.Size(920, 63);
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
            this.ProfileImg.Location = new System.Drawing.Point(1137, 0);
            this.ProfileImg.Margin = new System.Windows.Forms.Padding(4);
            this.ProfileImg.Name = "ProfileImg";
            this.ProfileImg.Size = new System.Drawing.Size(101, 73);
            this.ProfileImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfileImg.TabIndex = 4;
            this.ProfileImg.TabStop = false;
            this.ProfileImg.Click += new System.EventHandler(this.ProfileImg_Click);
            // 
            // prfPnl
            // 
            this.prfPnl.BackColor = System.Drawing.Color.MistyRose;
            this.prfPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prfPnl.Controls.Add(this.monthCalendar1);
            this.prfPnl.Controls.Add(this.dateTimePicker1);
            this.prfPnl.Controls.Add(this.nextDonLbl);
            this.prfPnl.Controls.Add(this.ttlNumDonLbl);
            this.prfPnl.Controls.Add(this.label1);
            this.prfPnl.Controls.Add(this.prfNameLbl);
            this.prfPnl.Location = new System.Drawing.Point(899, 73);
            this.prfPnl.Name = "prfPnl";
            this.prfPnl.Size = new System.Drawing.Size(339, 666);
            this.prfPnl.TabIndex = 5;
            // 
            // prfNameLbl
            // 
            this.prfNameLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prfNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.prfNameLbl.ForeColor = System.Drawing.Color.IndianRed;
            this.prfNameLbl.Location = new System.Drawing.Point(-2, 0);
            this.prfNameLbl.Name = "prfNameLbl";
            this.prfNameLbl.Size = new System.Drawing.Size(339, 41);
            this.prfNameLbl.TabIndex = 0;
            this.prfNameLbl.Text = "Name";
            this.prfNameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(-2, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Donations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ttlNumDonLbl
            // 
            this.ttlNumDonLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.ttlNumDonLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.ttlNumDonLbl.Location = new System.Drawing.Point(-2, 146);
            this.ttlNumDonLbl.Name = "ttlNumDonLbl";
            this.ttlNumDonLbl.Size = new System.Drawing.Size(339, 41);
            this.ttlNumDonLbl.TabIndex = 2;
            this.ttlNumDonLbl.Text = "0";
            this.ttlNumDonLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nextDonLbl
            // 
            this.nextDonLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nextDonLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.nextDonLbl.ForeColor = System.Drawing.Color.IndianRed;
            this.nextDonLbl.Location = new System.Drawing.Point(-2, 229);
            this.nextDonLbl.Name = "nextDonLbl";
            this.nextDonLbl.Size = new System.Drawing.Size(339, 41);
            this.nextDonLbl.TabIndex = 3;
            this.nextDonLbl.Text = "Next Donation";
            this.nextDonLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.dateTimePicker1.Location = new System.Drawing.Point(-2, 282);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(339, 32);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(61, 484);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BloodBankSystem.Properties.Resources.HomeBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1239, 739);
            this.Controls.Add(this.ProfileImg);
            this.Controls.Add(this.prfPnl);
            this.Controls.Add(this.bbNameLbl);
            this.Controls.Add(this.welcomelbl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomePage";
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
        private System.Windows.Forms.Label prfNameLbl;
        private System.Windows.Forms.Label ttlNumDonLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label nextDonLbl;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}