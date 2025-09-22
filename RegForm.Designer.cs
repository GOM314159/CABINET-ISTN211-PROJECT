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
            this.regTitleLbl = new System.Windows.Forms.Label();
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
            this.ist2jwDataSet = new BloodBankSystem.ist2jwDataSet();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsersTableAdapter = new BloodBankSystem.ist2jwDataSetTableAdapters.tblUsersTableAdapter();
            this.tableAdapterManager = new BloodBankSystem.ist2jwDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.ist2jwDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // regTitleLbl
            // 
            this.regTitleLbl.BackColor = System.Drawing.Color.MistyRose;
            this.regTitleLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.regTitleLbl.Font = new System.Drawing.Font("Modern No. 20", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regTitleLbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.regTitleLbl.Location = new System.Drawing.Point(0, -1);
            this.regTitleLbl.Name = "regTitleLbl";
            this.regTitleLbl.Size = new System.Drawing.Size(707, 50);
            this.regTitleLbl.TabIndex = 3;
            this.regTitleLbl.Text = "Registration Page";
            this.regTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.CellLbl.Location = new System.Drawing.Point(46, 339);
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
            this.regBtn.Location = new System.Drawing.Point(220, 422);
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
            this.BackBtn.BackgroundImage = global::BloodBankSystem.Properties.Resources.buttonbackGreen;
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BackBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Arial", 18.25F);
            this.BackBtn.Location = new System.Drawing.Point(12, 508);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(104, 39);
            this.BackBtn.TabIndex = 17;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
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
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.SurnameTextBox_TextChanged);
            // 
            // mCellphoneTextBox
            // 
            this.mCellphoneTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mCellphoneTextBox.Font = new System.Drawing.Font("Arial", 16.25F);
            this.mCellphoneTextBox.Location = new System.Drawing.Point(349, 339);
            this.mCellphoneTextBox.Mask = "0000000000";
            this.mCellphoneTextBox.Name = "mCellphoneTextBox";
            this.mCellphoneTextBox.Size = new System.Drawing.Size(292, 32);
            this.mCellphoneTextBox.TabIndex = 19;
            this.mCellphoneTextBox.ValidatingType = typeof(int);
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
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BloodBankSystem.Properties.Resources.RegBack;
            this.ClientSize = new System.Drawing.Size(707, 571);
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
            this.Controls.Add(this.regTitleLbl);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.RegForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ist2jwDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label regTitleLbl;
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
    }
}