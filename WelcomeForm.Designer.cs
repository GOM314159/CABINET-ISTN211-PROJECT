namespace BloodBank_Test_1
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.RegBtn = new System.Windows.Forms.Button();
            this.Logbtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLbl.BackColor = System.Drawing.Color.White;
            this.titleLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.Red;
            this.titleLbl.Location = new System.Drawing.Point(71, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(487, 65);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Blood Bank System";
            // 
            // RegBtn
            // 
            this.RegBtn.BackColor = System.Drawing.Color.Transparent;
            this.RegBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RegBtn.FlatAppearance.BorderSize = 0;
            this.RegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegBtn.Font = new System.Drawing.Font("Arial", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegBtn.ForeColor = System.Drawing.Color.Red;
            this.RegBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RegBtn.Location = new System.Drawing.Point(71, 255);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(219, 72);
            this.RegBtn.TabIndex = 17;
            this.RegBtn.Text = "Register";
            this.RegBtn.UseVisualStyleBackColor = false;
            this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // Logbtn
            // 
            this.Logbtn.BackColor = System.Drawing.Color.Transparent;
            this.Logbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logbtn.FlatAppearance.BorderSize = 0;
            this.Logbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logbtn.Font = new System.Drawing.Font("Arial", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logbtn.ForeColor = System.Drawing.Color.Blue;
            this.Logbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Logbtn.Location = new System.Drawing.Point(339, 255);
            this.Logbtn.Name = "Logbtn";
            this.Logbtn.Size = new System.Drawing.Size(219, 72);
            this.Logbtn.TabIndex = 19;
            this.Logbtn.Text = "Log In";
            this.Logbtn.UseVisualStyleBackColor = false;
            this.Logbtn.Click += new System.EventHandler(this.Logbtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Arial", 18.25F);
            this.ExitBtn.Location = new System.Drawing.Point(12, 392);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(108, 37);
            this.ExitBtn.TabIndex = 20;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 441);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.Logbtn);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.titleLbl);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Form";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button RegBtn;
        private System.Windows.Forms.Button Logbtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}

