using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank_Test_1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form Welcomeform = new WelcomeForm();
            Welcomeform.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Form form = new HomePage();
            this.Hide();

        }
    }
}
