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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.welcomelbl = new System.Windows.Forms.Label();
            this.bbNameLbl = new System.Windows.Forms.Label();
            this.ProfileImg = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImg)).BeginInit();
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
            this.welcomelbl.Location = new System.Drawing.Point(158, 0);
            this.welcomelbl.Name = "welcomelbl";
            this.welcomelbl.Size = new System.Drawing.Size(679, 60);
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
            this.bbNameLbl.Size = new System.Drawing.Size(496, 51);
            this.bbNameLbl.TabIndex = 3;
            this.bbNameLbl.Text = "To Blood    Bankers";
            this.bbNameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProfileImg
            // 
            this.ProfileImg.BackColor = System.Drawing.Color.Transparent;
            this.ProfileImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfileImg.Image = ((System.Drawing.Image)(resources.GetObject("ProfileImg.Image")));
            this.ProfileImg.Location = new System.Drawing.Point(960, 0);
            this.ProfileImg.Name = "ProfileImg";
            this.ProfileImg.Size = new System.Drawing.Size(71, 60);
            this.ProfileImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfileImg.TabIndex = 4;
            this.ProfileImg.TabStop = false;
            this.ProfileImg.Click += new System.EventHandler(this.ProfileImg_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(0, 60);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BloodBankSystem.Properties.Resources.HomeBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1031, 661);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.ProfileImg);
            this.Controls.Add(this.bbNameLbl);
            this.Controls.Add(this.welcomelbl);
            this.Name = "HomePage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcomelbl;
        private System.Windows.Forms.Label bbNameLbl;
        private System.Windows.Forms.PictureBox ProfileImg;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}