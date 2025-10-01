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
            prfNameLbl.Text = userName + "'s Profile";
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
            // TODO: This line of code loads data into the 'ist2jwDataSet.TblBloodInventory' table. You can move, or remove it, as needed.
            this.tblBloodInventoryTableAdapter.Fill(this.ist2jwDataSet.TblBloodInventory);

        }

        private void ProfileImg_Click(object sender, EventArgs e)
        {   // Toggle profile panel visibility
            if (prfPnl.Visible)
            {
                prfPnl.Visible = false;
            }
            else
            {
                prfPnl.Visible = true;
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
            tblBloodInventoryBindingSource.Filter = "UserID = '" + userID + "'";

            foreach (DataRow row in tblBloodInventoryBindingSource)
            {   // Sum up the UnitsDonated for the filtered user records
                totalDonated += Convert.ToInt32(row["UnitsDonated"]);
            }

            return totalDonated;
        }

        private void updLbls()
        {
            switch (getTotalBloodDonatedforUser())
            {
                case 0:
                    donorStatusLbl.Text = "New Donor";
                    numLiveSavedLbl.Text = "0 Lives Saved";
                    break;

                case int c when (c > 0 && c <= 10):
                    donorStatusLbl.Text = "Regular Donor";
                    numLiveSavedLbl.Text = (c * 3).ToString() + " Lives Saved";
                    break;

                case int c when (c > 10):
                    donorStatusLbl.Text = "Super Donor";
                    numLiveSavedLbl.Text = (c * 3).ToString() + " Lives Saved";
                    break;
                case int c when (c > 20):
                    donorStatusLbl.Text = "Legendary Donor";
                    numLiveSavedLbl.Text = (c * 3).ToString() + " Lives Saved";
                    break;

                default:
                    donorStatusLbl.Text = "New Donor";
                    numLiveSavedLbl.Text = "0 Lives Saved";
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
    }

}
