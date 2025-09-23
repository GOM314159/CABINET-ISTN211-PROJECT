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

            Random rnd = new Random();
            String userID = rnd.Next(0, 1000000).ToString(); // Generates a 6-digit userID as a string
            String userType = "User";
            String firstName = fNameTextBox.Text;
            String lastName = lastNameTextBox.Text;
            String iDNumber = mIDTextBox.Text;
            String phoneNumber = mCellphoneTextBox.Text;
            String password = passwordTextBox.Text;
            String bloodType = bloodtypeCmbox.Text;
            Boolean isActiveAcc = true;

            Boolean userIDCheck = false;
            Boolean firstNameCheck = false;
            Boolean surNameCheck = false;
            Boolean IDNumberCheck = false;
            Boolean phoneNumberCheck = false;
            Boolean passwordCheck = false;

            //userID check  
            if (validUserID(userID))
            {
                MessageBox.Show("Your User ID is: " + userID);
                userIDCheck = true;
            }
           
            // First Name check
            if (!string.IsNullOrWhiteSpace(firstName))
            {
                firstNameCheck = true;
                fNameTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                fNameTextBox.BackColor = Color.IndianRed;
                firstNameCheck = false;
            }

            // Last name check
            if (!string.IsNullOrWhiteSpace(lastName))
            {
                surNameCheck = true;
                lastNameTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                lastNameTextBox.BackColor = Color.IndianRed;
                surNameCheck = false;
            }

            // ID Number check
            if (!string.IsNullOrWhiteSpace(iDNumber) && iDNumber.Length == 13)
            {
                if (validIDCheck(iDNumber))
                {
                    IDNumberCheck = true;
                    mIDTextBox.BackColor = Color.LightGreen;
                }
            }
            else
            {
                mIDTextBox.BackColor = Color.IndianRed;
                IDNumberCheck = false;
            }

            // Phone Number check
            if (!string.IsNullOrWhiteSpace(mCellphoneTextBox.Text) && phoneNumber.Length == 10)
            {
                phoneNumberCheck = true;
                mCellphoneTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                mCellphoneTextBox.BackColor = Color.IndianRed;
                phoneNumberCheck = false;
            }

            //Blood Type check
            if (!string.IsNullOrWhiteSpace(bloodType))
            {
                bloodtypeCmbox.BackColor = Color.LightGreen;
            }
            else
            {
                bloodtypeCmbox.BackColor = Color.IndianRed;
            }

            // password check
            if (!string.IsNullOrWhiteSpace(password) && validPasswordCheck(password))
            {
                passwordCheck = true;
                passwordTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                passwordTextBox.BackColor = Color.IndianRed;
                passwordCheck = false;
            }

            // if all fields are filled in correctly, the following code will execute
            if (userIDCheck && firstNameCheck && surNameCheck && IDNumberCheck && phoneNumberCheck && passwordCheck)
            {
                try {  var adapter = new ist2jwDataSetTableAdapters.tblUsersTableAdapter();
                var dataTable = adapter.UserRegistration(userID,firstName, lastName, iDNumber, phoneNumber, password,userType,bloodType,isActiveAcc);
                MessageBox.Show("Registration Successful Welcome to 'Blood Bank System' ");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while creating account " + ex.Message);
                }
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

        private Boolean validIDCheck(String idNumber)
        {
            Boolean validID = false;
            int NumA = 0;
            String idTrimmed = null;
            int NumB = 0;
            int NumC = 0;
            int total = 0;
            String totalStringtrim;

            for (int i = 0; i < idNumber.Length - 1; i += 2)
            {
                NumA += Convert.ToInt32(Char.GetNumericValue(idNumber[i]));
            }

            for (int i = 1; i < idNumber.Length; i += 2)
            {
                idTrimmed += Char.GetNumericValue(idNumber[i]).ToString();

            }
            NumB = Convert.ToInt32(idTrimmed) * 2;

            String numBString = NumB.ToString();


            for (int i = 0; i < numBString.Length; i++)
            {
                NumC += Convert.ToInt32(Char.GetNumericValue(numBString[i]));
            }

            total = NumA + NumC;

 

            if (total < 10)
            {
                totalStringtrim = total.ToString();
            }
            else
            {

                totalStringtrim = (total.ToString()).Substring(1, 1);
            }

            int checkDigit = 10 - Convert.ToInt32(totalStringtrim);


            if (checkDigit == Convert.ToInt32(idNumber.Substring(12, 1)))
            {
                validID = true;
            }

            return validID;
        }

        private Boolean validPasswordCheck(String password)
        {
            Boolean hasUpper = false;
            Boolean hasDigit = false;
            Boolean hasSpecial = false;
            Boolean validPassword = false;

            if (password.Length >= 8)
            {
               foreach (char c in password)
                {
                    if (Char.IsUpper(c))
                    {
                      hasUpper = true;
                    }   
                    
                    if (Char.IsDigit(c))
                    {
                      hasDigit = true;
                    }
                    if (!Char.IsLetterOrDigit(c) && !Char.IsWhiteSpace(c))
                    {
                      hasSpecial = true;
                    }

                }
               if (hasUpper && hasDigit && hasSpecial)
                {
                    validPassword = true;
                }

            }
            return validPassword;
        }

        private Boolean validUserID(String userID)
        {
            Boolean userIDCheck = false;

            var adapter1 = new ist2jwDataSetTableAdapters.tblUsersTableAdapter();
            var dataTable1 = adapter1.FindUserID(userID);

            if (dataTable1.Count() == 0)
            {
                userIDCheck = true;
            }
            else
            {
                Random rnd = new Random();
                userID = rnd.Next(0, 1000000).ToString();
                validUserID(userID);
            }


            return userIDCheck;
        }

    }
}
