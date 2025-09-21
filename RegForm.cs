using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankSystem
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void BackLbl_Click(object sender, EventArgs e)
        {

        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            Form homePage = new HomePage();
            homePage.Show();
            this.Hide();

            String firstName = null;
            String surName = null;
            String iDNumber = null;
            String phoneNumber = null;
            String emailAddress = null;
            String address = null;

            Boolean firstNameCheck = false;
            Boolean surNameCheck = false;
            Boolean IDNumberCheck = false;
            Boolean phoneNumberCheck = false;
            Boolean emailAddressCheck = false;
            Boolean addressCheck = false;

            // Checks if firstname field is not null
            if (fNameTextBox.Text != null)
            {
                firstNameCheck = true;
                firstName = fNameTextBox.Text;
                fNameTextBox.BackColor = Color.LightGreen;
            } 
            else if (fNameTextBox.Text == null) // highlights firstname field red if null
            {
                fNameTextBox.BackColor = Color.IndianRed;
                firstNameCheck = false;
            }

            // checks if surname field is not null
            if (sNameTextBox.Text != null)
            {
                surNameCheck = true;
                surName = sNameTextBox.Text;
                sNameTextBox.BackColor = Color.LightGreen;
            }
            else if (fNameTextBox.Text == null) // highlights surname field red if null
            {
                sNameTextBox.BackColor = Color.IndianRed;
                surNameCheck = false;
            }

            // checks if IDnumber field is not null
            if (mIDTextBox.Text != null)
            {
                IDNumberCheck = true;
                iDNumber = mIDTextBox.Text;
                mIDTextBox.BackColor = Color.LightGreen;
            }
            else if (mIDTextBox.Text == null) // highlights idNumber field red if null
            {
                mIDTextBox.BackColor = Color.IndianRed;
                IDNumberCheck = false;
            }

            // checks if phoneNumber field is not null
            if (mCellphoneTextBox.Text != null)
            {
                phoneNumberCheck = true;
                phoneNumber = mCellphoneTextBox.Text;
                mCellphoneTextBox.BackColor = Color.LightGreen;
            }
            else if (mCellphoneTextBox.Text == null) // highlights phoneNumber field red if null
            {
                mCellphoneTextBox.BackColor = Color.IndianRed;
                phoneNumberCheck = false;
            }

            // checks if email field is not null
            if (emailTextBox.Text != null)
            {
                emailAddressCheck = true;
                emailAddress = emailTextBox.Text;
                emailTextBox.BackColor = Color.LightGreen;
            }
            else if (mCellphoneTextBox.Text == null) // highlights email field red if null
            {
                emailTextBox.BackColor = Color.IndianRed;
                emailAddressCheck = false;
            }

            // checks if address field is not null
            if (addressTextBox.Text != null)
            {
                addressCheck = true;
                address = emailTextBox.Text;
                addressTextBox.BackColor = Color.LightGreen;
            }
            else if (addressTextBox.Text == null) // highlights address field red if null
            {
                emailTextBox.BackColor = Color.IndianRed;
                addressCheck = false;
            }


            // if all fields are filled in correctly, the following code will execute
            if (firstNameCheck && surNameCheck && IDNumberCheck && phoneNumberCheck && emailAddressCheck && addressCheck)
            {
              /*  try
                {

                    SqlCommand cm = new SqlCommand("insert into tblUsers values(" + firstName + ")");

                    cm.Parameters.AddWithValue("@<field_names>", your_data);

                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Order Successfull");

                }
                catch (Exception ex) { }
              */
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form Welcomeform = new WelcomeForm();
            Welcomeform.Show();
            this.Hide();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist2jwDataSet.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.ist2jwDataSet.tblUsers);


        }

        private void appointmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.ist2jwDataSet);

        }

        private void tblUsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblUsersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ist2jwDataSet);

        }
    }
}
