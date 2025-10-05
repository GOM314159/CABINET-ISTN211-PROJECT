using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankSystem
{
    public partial class HomePage : Form
    {
        private static String userName;
        public static String userID;
        public HomePage(String dbuserID, String name)
        {
            InitializeComponent();
            userID = dbuserID;
            userName = name;
            prfNameLbl.Text = userName + "'s\nProfile";
            welcomelbl.Text = "Welcome " + userName;
            prfPnl.Visible = false;
            bloodSymbolTimer.Start();
        }
        public HomePage()
        {
            InitializeComponent();
            prfNameLbl.Text = userName + "'s Profile";
            welcomelbl.Text = "Welcome " + userName;
            prfPnl.Visible = false;
            bloodSymbolTimer.Start();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist2jwDataSet.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.ist2jwDataSet.tblUsers);
            // TODO: This line of code loads data into the 'ist2jwDataSet.TblBloodInventory' table. You can move, or remove it, as needed.
            this.tblBloodInventoryTableAdapter.Fill(this.ist2jwDataSet.TblBloodInventory);
      
        }

        private void ProfileImg_Click(object sender, EventArgs e)
        {   // Toggle profile panel visibility
            if (prfPnl.Visible)
            {
                prfPnl.Visible = false;
                badgeGroup.Visible = false;
                ProfileImg.Location = new Point(683, 0);
                this.Size = new Size(800, 619);
                donateBtn.Location = new Point(254, 250);
                PhoneNumGrp.Visible = false;
                LoadUserPhoneNumber();
            }
            else
            {
                prfPnl.Visible = true;
                badgeGroup.Visible = true;
                ProfileImg.Location = new Point(997, 0);
                this.Size = new Size(1114, 619);
                donateBtn.Location = new Point(407, 257);
            }
        }

        private void donateBtn_Click(object sender, EventArgs e)
        {   // Navigate to Donation Form
            Form appointment = new AppointmentForm();
            appointment.Show();
            this.Hide();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {   // Confirm log out action
            DialogResult logAns = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.OKCancel);
            if (logAns == DialogResult.OK)
            {
                this.Hide();
                prfPnl.Visible = false;
                Form welcomeForm = new WelcomeForm();
                welcomeForm.Show();

            }
        }

        // Method to get the minimum blood units across all blood types (Github co-pilot)
        private String GetMinimumBloodSymbol()
        {
            // Dictionary to hold counts for each blood type
            Dictionary<string, int> bloodTypeCounts = new Dictionary<string, int>();

            foreach (DataRow row in ist2jwDataSet.TblBloodInventory.Rows)
            {
                string bloodType = row["BloodType"].ToString();

                if (bloodTypeCounts.ContainsKey(bloodType))
                {
                    bloodTypeCounts[bloodType]++;
                }
                else
                {
                    bloodTypeCounts[bloodType] = 1;
                }
            }

            // If there are no blood types, return 0
            if (bloodTypeCounts.Count == 0)
                return "";

            // Find the minimum count among all blood types
            int minCount = int.MaxValue;
            string minBloodType = "";

            foreach (var kvp in bloodTypeCounts)
            {   
                // kvp.Key is blood type, kvp.Value is count
                if (kvp.Value < minCount)
                {
                    minCount = kvp.Value;
                    minBloodType = kvp.Key;
                }
            }
            return minBloodType;
        }

        private int GetMinimumBloodCount()
        {
            // Dictionary to hold counts for each blood type
            Dictionary<string, int> bloodTypeCounts = new Dictionary<string, int>();

            foreach (DataRow row in ist2jwDataSet.TblBloodInventory.Rows)
            {
                string bloodType = row["BloodType"].ToString();
                if (bloodTypeCounts.ContainsKey(bloodType))
                {
                    bloodTypeCounts[bloodType]++;
                }
                else
                {
                    bloodTypeCounts[bloodType] = 1;
                }
            }

            // If there are no blood types, return 0
            if (bloodTypeCounts.Count == 0)
                return 0;

            // Find the minimum count among all blood types
            int minCount = int.MaxValue;
            foreach (var count in bloodTypeCounts.Values)
            {
                if (count < minCount)
                    minCount = count;
            }

            return minCount;
        }

        private void bloodSymbolTimer_Tick(object sender, EventArgs e)
        {
            bloodSymbolLbl.Text = GetMinimumBloodSymbol();
            ttlDonLbl.Text = getTotalBloodDonatedforUser().ToString() + " Units";

            updLbls();

            bloodSymbolTimer.Enabled = false;
        }

        private int getTotalBloodDonatedforUser()
        {
            int totalDonated = 0;

            // Filter the binding source to include only records for the current user
           try
            {  
                tblBloodInventoryBindingSource.Filter = "UserID = '" + userID + "'";

                if (tblBloodInventoryBindingSource.Count == 0)
                {
                    return 0; // No records found for the user
                }
                else
                {
                    foreach (DataRow row in tblBloodInventoryBindingSource)
                    {   // Sum up the UnitsDonated for the filtered user records
                        totalDonated += Convert.ToInt32(row["UnitsDonated"]);
                    }
                }
            }
            catch (Exception)
            {
                return 0;
            }
           
            return totalDonated;
        }

        private void updLbls()
        {
            switch (getTotalBloodDonatedforUser())
            {
                case 1:
                    donorStatusLbl.Text = "New Donor";
                    numLiveSavedLbl.Text = (1 * 3).ToString() + " Lives Saved"; ;
                    badge1Img.Visible = true;
                    badge2Img.Visible = false;
                    badge3Img.Visible = false;
                    badge4Img.Visible = false;
                    break;

                case int c when (c > 1 && c <= 5):
                    donorStatusLbl.Text = "Regular Donor";
                    numLiveSavedLbl.Text = (c * 3).ToString() + " Lives Saved";
                    badge1Img.Visible = true;
                    badge2Img.Visible = true;
                    badge3Img.Visible = false;
                    badge4Img.Visible = false;
                    break;

                case int c when (c > 10):
                    donorStatusLbl.Text = "Super Donor";
                    numLiveSavedLbl.Text = (c * 3).ToString() + " Lives Saved";
                    badge1Img.Visible = true;
                    badge2Img.Visible = true;
                    badge3Img.Visible = true;
                    badge4Img.Visible = false;

                    break;
                case int c when (c > 20):
                    donorStatusLbl.Text = "Legendary Donor";
                    numLiveSavedLbl.Text = (c * 3).ToString() + " Lives Saved";
                    badge1Img.Visible = true;
                    badge2Img.Visible = true;
                    badge3Img.Visible = true;
                    badge4Img.Visible = true;
                    break;

                default:
                    donorStatusLbl.Text = "New Donor";
                    numLiveSavedLbl.Text = "0 Lives Saved";
                    badge1Img.Visible = false;
                    badge2Img.Visible = false;
                    badge3Img.Visible = false;
                    badge4Img.Visible = false;
                    break;
            }

            switch (GetMinimumBloodCount())
            {
                case 0: // No stock
                    urgentNeedsPnl.Visible = true;
                    BloodLvlLbl.Text = "Out of Stock";
                    BloodLvlLbl.ForeColor = Color.Red;
                    break;
                case int c when (c > 0 && c <= 10): // Critical level
                    BloodLvlLbl.Text = "Critical";
                    BloodLvlLbl.ForeColor = Color.DarkOrange;
                    break;
                case int c when (c > 10 && c <= 25): // Low level
                    BloodLvlLbl.Text = "Low";
                    BloodLvlLbl.ForeColor = Color.Orange;
                    break;
                case int c when (c > 25): // Sufficient level
                    urgentNeedsPnl.Visible = false;
                    break;

            }
        }

        private void pLivesSavedLbl_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void updPhoneNumBtn_Click(object sender, EventArgs e)
        {
            
           if (!PhoneNumGrp.Visible)
            {
                PhoneNumGrp.Visible = true;
                updPhoneNumBtn.Text = "Save";

            }
            else
            {
                // Validate phone number format (basic validation)
                string newPhoneNumber = phoneNumTextBox.Text.Trim();
                if (IsValidPhoneNumber(newPhoneNumber))
                {
                    // Update the phone number in the dataset
                    var userRow = ist2jwDataSet.tblUsers
                        .AsEnumerable()
                        .FirstOrDefault(row => row.Field<string>("UserID") == userID);

                    if (userRow != null)
                    {
                        userRow.SetField("PhoneNumber", newPhoneNumber);
                        // Save changes to the database
                        tblUsersTableAdapter.Update(ist2jwDataSet.tblUsers);
                        MessageBox.Show("Phone number updated successfully.");

                        PhoneNumGrp.Visible = false;
                        updPhoneNumBtn.Text = "Update Phone Number";
                        LoadUserPhoneNumber();
                    }

                }
                else
                {
                    MessageBox.Show("Please enter a valid phone number.");
                }

            }

        }

        private bool IsValidPhoneNumber(string newPhoneNumber)
        {
            Boolean phoneNumberCheck = false;

            if (!string.IsNullOrWhiteSpace(newPhoneNumber) && newPhoneNumber.Length == 10)
            {
                if (newPhoneNumber[0].Equals('0'))
                {
                    phoneNumberCheck = true;
                }
                else
                {
                    MessageBox.Show("Phone number should start with a '0'", "Registration Helper", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    phoneNumberCheck = false;
                }
            }
            else
            {
                phoneNumberCheck = false;
            }
            return phoneNumberCheck;
        }

        private void LoadUserPhoneNumber()
        {
            // Find the user row by userID
            var userRow = ist2jwDataSet.tblUsers
                .AsEnumerable()
                .FirstOrDefault(row => row.Field<string>("UserID") == userID);

            if (userRow != null)
            {
                phoneNumTextBox.Text = userRow.Field<string>("PhoneNumber");
            }
        }

      
    }

}
