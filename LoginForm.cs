using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankSystem
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
            Form welcomeform = new WelcomeForm();
            welcomeform.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            String password = PasswordTextBox.Text;
            String IDnumber = mIDTextBox.Text.ToString();
          
              try
              {
                var adapter = new ist2jwDataSetTableAdapters.tblUsersTableAdapter();
                var dataTable = adapter.GetUserInfo(IDnumber); //error here

                if (dataTable.Rows.Count > 0)
                {
                    string dbPassword = dataTable.Rows[0]["Password"].ToString();
                  

                    if (password.Equals(dbPassword))
                    {  
                        String isAdmin = dataTable.Rows[0]["UserType"].ToString();
                        this.Hide();

                        if (isAdmin.Equals("A"))
                        {
                            MessageBox.Show("Admin Login Successful! \nWelcome " + dataTable.Rows[0]["Name"]); 
                            Form adminForm = new AdminForm();
                            adminForm.Show();
                        }
                        else
                        {   // regular user login
                            MessageBox.Show("Login Successful! \nWelcome " + dataTable.Rows[0]["Name"], "Successful Login", MessageBoxButtons.OK);
                            Form homeForm = new HomePage(dataTable.Rows[0]["UserID"].ToString(),dataTable.Rows[0]["Name"].ToString());
                            homeForm.Show();
                        }

                    }
                    else
                    {   //password field is empty
                        if (String.IsNullOrEmpty(password))
                        {
                            MessageBox.Show("Please Enter your password.");
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password entered. Please try again.");
                            PasswordTextBox.Clear();
                        }
                           
                    }

                }
                else
                {
                    MessageBox.Show("Donor not found. Please check your ID Number.");
                }

              }
              catch (SqlException ex)
              {
                MessageBox.Show(ex.Message);
              }

          ;

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist2jwDataSet.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.ist2jwDataSet.tblUsers);

        }

        private void tblUsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblUsersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ist2jwDataSet);

        }

        private void passShowImg_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.PasswordChar == '*')
            {
                PasswordTextBox.PasswordChar = '\0';
                passShowImg.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
                passShowImg.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void loginBtn_MouseDown(object sender, MouseEventArgs   e)
        {
            loginBtn.FlatStyle = FlatStyle.Popup;
        }

        private void loginBtn_MouseUp(object sender, MouseEventArgs e)
        {
            loginBtn.FlatStyle = FlatStyle.Flat;
        }

        private void BackBtn_MouseDown(object sender, MouseEventArgs e)
        {
            BackBtn.FlatStyle = FlatStyle.Popup;    
        }

        private void BackBtn_MouseUp(object sender, MouseEventArgs e)
        {
            BackBtn.FlatStyle = FlatStyle.Flat; 
        }
    }
}
