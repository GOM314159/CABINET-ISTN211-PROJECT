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
            this.components = new System.ComponentModel.Container();
            this.welcomelbl = new System.Windows.Forms.Label();
            this.bbNameLbl = new System.Windows.Forms.Label();
            this.ProfileImg = new System.Windows.Forms.PictureBox();
            this.prfPnl = new System.Windows.Forms.Panel();
            this.numLiveSavedLbl = new System.Windows.Forms.Label();
            this.pLivesSavedLbl = new System.Windows.Forms.Label();
            this.donorStatusLbl = new System.Windows.Forms.Label();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.ttlDonLbl = new System.Windows.Forms.Label();
            this.prfnextDateLbl = new System.Windows.Forms.Label();
            this.prfLastDonLbl = new System.Windows.Forms.Label();
            this.prfDonLbl = new System.Windows.Forms.Label();
            this.prfNameLbl = new System.Windows.Forms.Label();
            this.donateBtn = new System.Windows.Forms.Button();
            this.urgentNeedsPnl = new System.Windows.Forms.Panel();
            this.BloodLvlLbl = new System.Windows.Forms.Label();
            this.bloodSymbolLbl = new System.Windows.Forms.Label();
            this.BloodtypeLbl = new System.Windows.Forms.Label();
            this.UrgentNeedsLbl = new System.Windows.Forms.Label();
            this.ist2jwDataSet = new BloodBankSystem.ist2jwDataSet();
            this.tblBloodInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblBloodInventoryTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.TblBloodInventoryTableAdapter();
            this.tableAdapterManager = new BloodBankSystem.ist2jwDataSetTableAdapters.TableAdapterManager();
            this.bloodSymbolTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProfileImg)).BeginInit();
            this.prfPnl.SuspendLayout();
            this.urgentNeedsPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ist2jwDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBloodInventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomelbl
            // 
            this.welcomelbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomelbl.BackColor = System.Drawing.Color.White;
            this.welcomelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.25F, System.Drawing.FontStyle.Bold);
            this.welcomelbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.welcomelbl.Location = new System.Drawing.Point(197, 0);
            this.welcomelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomelbl.Name = "welcomelbl";
            this.welcomelbl.Size = new System.Drawing.Size(856, 58);
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
            this.bbNameLbl.Size = new System.Drawing.Size(857, 63);
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
            this.ProfileImg.Location = new System.Drawing.Point(1169, 0);
            this.ProfileImg.Margin = new System.Windows.Forms.Padding(4);
            this.ProfileImg.Name = "ProfileImg";
            this.ProfileImg.Size = new System.Drawing.Size(86, 76);
            this.ProfileImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfileImg.TabIndex = 4;
            this.ProfileImg.TabStop = false;
            this.ProfileImg.Click += new System.EventHandler(this.ProfileImg_Click);
            // 
            // prfPnl
            // 
            this.prfPnl.BackColor = System.Drawing.Color.MistyRose;
            this.prfPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prfPnl.Controls.Add(this.numLiveSavedLbl);
            this.prfPnl.Controls.Add(this.pLivesSavedLbl);
            this.prfPnl.Controls.Add(this.donorStatusLbl);
            this.prfPnl.Controls.Add(this.logOutBtn);
            this.prfPnl.Controls.Add(this.monthCalendar1);
            this.prfPnl.Controls.Add(this.ttlDonLbl);
            this.prfPnl.Controls.Add(this.prfnextDateLbl);
            this.prfPnl.Controls.Add(this.prfLastDonLbl);
            this.prfPnl.Controls.Add(this.prfDonLbl);
            this.prfPnl.Controls.Add(this.prfNameLbl);
            this.prfPnl.Location = new System.Drawing.Point(905, 74);
            this.prfPnl.Name = "prfPnl";
            this.prfPnl.Size = new System.Drawing.Size(350, 654);
            this.prfPnl.TabIndex = 5;
            this.prfPnl.Visible = false;
            // 
            // numLiveSavedLbl
            // 
            this.numLiveSavedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.numLiveSavedLbl.ForeColor = System.Drawing.Color.Maroon;
            this.numLiveSavedLbl.Location = new System.Drawing.Point(-1, 246);
            this.numLiveSavedLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numLiveSavedLbl.Name = "numLiveSavedLbl";
            this.numLiveSavedLbl.Size = new System.Drawing.Size(349, 26);
            this.numLiveSavedLbl.TabIndex = 22;
            this.numLiveSavedLbl.Text = "0";
            this.numLiveSavedLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pLivesSavedLbl
            // 
            this.pLivesSavedLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLivesSavedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.pLivesSavedLbl.ForeColor = System.Drawing.Color.Maroon;
            this.pLivesSavedLbl.Location = new System.Drawing.Point(0, 201);
            this.pLivesSavedLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pLivesSavedLbl.Name = "pLivesSavedLbl";
            this.pLivesSavedLbl.Size = new System.Drawing.Size(348, 32);
            this.pLivesSavedLbl.TabIndex = 21;
            this.pLivesSavedLbl.Text = "Potential lives saved";
            this.pLivesSavedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // donorStatusLbl
            // 
            this.donorStatusLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.donorStatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.donorStatusLbl.ForeColor = System.Drawing.Color.Green;
            this.donorStatusLbl.Location = new System.Drawing.Point(0, 46);
            this.donorStatusLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.donorStatusLbl.Name = "donorStatusLbl";
            this.donorStatusLbl.Size = new System.Drawing.Size(348, 32);
            this.donorStatusLbl.TabIndex = 20;
            this.donorStatusLbl.Text = "Donor Level";
            this.donorStatusLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logOutBtn.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackOrange;
            this.logOutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logOutBtn.FlatAppearance.BorderSize = 0;
            this.logOutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.logOutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Arial", 18.25F);
            this.logOutBtn.Location = new System.Drawing.Point(113, 602);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(137, 39);
            this.logOutBtn.TabIndex = 19;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(58, 412);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 6;
            // 
            // ttlDonLbl
            // 
            this.ttlDonLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.ttlDonLbl.ForeColor = System.Drawing.Color.Maroon;
            this.ttlDonLbl.Location = new System.Drawing.Point(-1, 152);
            this.ttlDonLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ttlDonLbl.Name = "ttlDonLbl";
            this.ttlDonLbl.Size = new System.Drawing.Size(347, 26);
            this.ttlDonLbl.TabIndex = 4;
            this.ttlDonLbl.Text = "0";
            this.ttlDonLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // prfnextDateLbl
            // 
            this.prfnextDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.prfnextDateLbl.ForeColor = System.Drawing.Color.Maroon;
            this.prfnextDateLbl.Location = new System.Drawing.Point(-1, 348);
            this.prfnextDateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prfnextDateLbl.Name = "prfnextDateLbl";
            this.prfnextDateLbl.Size = new System.Drawing.Size(351, 26);
            this.prfnextDateLbl.TabIndex = 3;
            this.prfnextDateLbl.Text = "Date TBD";
            this.prfnextDateLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // prfLastDonLbl
            // 
            this.prfLastDonLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prfLastDonLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.prfLastDonLbl.ForeColor = System.Drawing.Color.Maroon;
            this.prfLastDonLbl.Location = new System.Drawing.Point(0, 304);
            this.prfLastDonLbl.Name = "prfLastDonLbl";
            this.prfLastDonLbl.Size = new System.Drawing.Size(348, 32);
            this.prfLastDonLbl.TabIndex = 2;
            this.prfLastDonLbl.Text = "Last Donation";
            this.prfLastDonLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // prfDonLbl
            // 
            this.prfDonLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prfDonLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.prfDonLbl.ForeColor = System.Drawing.Color.Maroon;
            this.prfDonLbl.Location = new System.Drawing.Point(0, 107);
            this.prfDonLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prfDonLbl.Name = "prfDonLbl";
            this.prfDonLbl.Size = new System.Drawing.Size(348, 32);
            this.prfDonLbl.TabIndex = 1;
            this.prfDonLbl.Text = "Total Donations";
            this.prfDonLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prfNameLbl
            // 
            this.prfNameLbl.BackColor = System.Drawing.Color.MistyRose;
            this.prfNameLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prfNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prfNameLbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.prfNameLbl.Location = new System.Drawing.Point(0, 0);
            this.prfNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prfNameLbl.Name = "prfNameLbl";
            this.prfNameLbl.Size = new System.Drawing.Size(349, 33);
            this.prfNameLbl.TabIndex = 0;
            this.prfNameLbl.Text = "Name";
            this.prfNameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // donateBtn
            // 
            this.donateBtn.BackColor = System.Drawing.Color.Transparent;
            this.donateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.donateBtn.FlatAppearance.BorderSize = 0;
            this.donateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.donateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.donateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.donateBtn.Location = new System.Drawing.Point(479, 311);
            this.donateBtn.Name = "donateBtn";
            this.donateBtn.Size = new System.Drawing.Size(277, 174);
            this.donateBtn.TabIndex = 6;
            this.donateBtn.Text = "DONATE";
            this.donateBtn.UseVisualStyleBackColor = false;
            this.donateBtn.Click += new System.EventHandler(this.donateBtn_Click);
            // 
            // urgentNeedsPnl
            // 
            this.urgentNeedsPnl.BackColor = System.Drawing.Color.LightGray;
            this.urgentNeedsPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urgentNeedsPnl.Controls.Add(this.BloodLvlLbl);
            this.urgentNeedsPnl.Controls.Add(this.bloodSymbolLbl);
            this.urgentNeedsPnl.Controls.Add(this.BloodtypeLbl);
            this.urgentNeedsPnl.Controls.Add(this.UrgentNeedsLbl);
            this.urgentNeedsPnl.Location = new System.Drawing.Point(0, 581);
            this.urgentNeedsPnl.Name = "urgentNeedsPnl";
            this.urgentNeedsPnl.Size = new System.Drawing.Size(287, 147);
            this.urgentNeedsPnl.TabIndex = 7;
            // 
            // BloodLvlLbl
            // 
            this.BloodLvlLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.BloodLvlLbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.BloodLvlLbl.Location = new System.Drawing.Point(0, 96);
            this.BloodLvlLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BloodLvlLbl.Name = "BloodLvlLbl";
            this.BloodLvlLbl.Size = new System.Drawing.Size(284, 43);
            this.BloodLvlLbl.TabIndex = 6;
            this.BloodLvlLbl.Text = "Level";
            this.BloodLvlLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bloodSymbolLbl
            // 
            this.bloodSymbolLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.bloodSymbolLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bloodSymbolLbl.Location = new System.Drawing.Point(170, 56);
            this.bloodSymbolLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bloodSymbolLbl.Name = "bloodSymbolLbl";
            this.bloodSymbolLbl.Size = new System.Drawing.Size(60, 40);
            this.bloodSymbolLbl.TabIndex = 5;
            // 
            // BloodtypeLbl
            // 
            this.BloodtypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.BloodtypeLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.BloodtypeLbl.Location = new System.Drawing.Point(0, 56);
            this.BloodtypeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BloodtypeLbl.Name = "BloodtypeLbl";
            this.BloodtypeLbl.Size = new System.Drawing.Size(194, 40);
            this.BloodtypeLbl.TabIndex = 2;
            this.BloodtypeLbl.Text = "Blood Type : ";
            this.BloodtypeLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UrgentNeedsLbl
            // 
            this.UrgentNeedsLbl.BackColor = System.Drawing.Color.LightGray;
            this.UrgentNeedsLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UrgentNeedsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.UrgentNeedsLbl.ForeColor = System.Drawing.Color.Red;
            this.UrgentNeedsLbl.Location = new System.Drawing.Point(0, 0);
            this.UrgentNeedsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UrgentNeedsLbl.Name = "UrgentNeedsLbl";
            this.UrgentNeedsLbl.Size = new System.Drawing.Size(285, 40);
            this.UrgentNeedsLbl.TabIndex = 1;
            this.UrgentNeedsLbl.Text = "URGENT NEED!!!";
            this.UrgentNeedsLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // tblBloodInventoryTableAdapter
            // 
            this.tblBloodInventoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ScheduleTableAdapter = null;
            this.tableAdapterManager.TblBloodInventoryTableAdapter = this.tblBloodInventoryTableAdapter;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BloodBankSystem.ist2jwDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bloodSymbolTimer
            // 
            this.bloodSymbolTimer.Enabled = true;
            this.bloodSymbolTimer.Interval = 500;
            this.bloodSymbolTimer.Tick += new System.EventHandler(this.bloodSymbolTimer_Tick);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BloodBankSystem.Properties.Resources.HomeBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1254, 728);
            this.Controls.Add(this.urgentNeedsPnl);
            this.Controls.Add(this.donateBtn);
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
            this.urgentNeedsPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ist2jwDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBloodInventoryBindingSource)).EndInit();
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
        private System.Windows.Forms.Label prfLastDonLbl;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label ttlDonLbl;
        private System.Windows.Forms.Button donateBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Panel urgentNeedsPnl;
        private System.Windows.Forms.Label BloodtypeLbl;
        private System.Windows.Forms.Label UrgentNeedsLbl;
        private System.Windows.Forms.Label BloodLvlLbl;
        private System.Windows.Forms.Label bloodSymbolLbl;
        private ist2jwDataSet ist2jwDataSet;
        private System.Windows.Forms.BindingSource tblBloodInventoryBindingSource;
        private ist2jwDataSetTableAdapters.TblBloodInventoryTableAdapter tblBloodInventoryTableAdapter;
        private ist2jwDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label donorStatusLbl;
        private System.Windows.Forms.Timer bloodSymbolTimer;
        private System.Windows.Forms.Label numLiveSavedLbl;
        private System.Windows.Forms.Label pLivesSavedLbl;
    }
}