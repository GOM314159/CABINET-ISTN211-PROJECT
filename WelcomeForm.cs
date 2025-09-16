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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void LogLbl_Click(object sender, EventArgs e)
        {
           
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            Form regform = new RegForm();
            regform.Show();
            this.Hide();
            this.Hide();
        }

        private void Logbtn_Click(object sender, EventArgs e)
        {
            Form logform = new LoginForm();
            logform.Show();
            this.Hide();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}