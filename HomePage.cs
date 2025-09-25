using System;
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
        public HomePage(String dbuserID,String name)
        {
            InitializeComponent();
            userID = dbuserID;
            userName = name;
            prfNameLbl.Text = userID + "'s Profile"; 
            welcomelbl.Text = "Welcome "+ userName;
            prfPnl.Visible = false;
        }
        public HomePage()
        {
            InitializeComponent();
            prfNameLbl.Text = userName + "'s Profile";
            welcomelbl.Text = "Welcome " + userName;
            prfPnl.Visible = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

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
        {
            Form appointment = new AppointmentForm();
            appointment.Show();
            this.Hide();
        }
    }
}
