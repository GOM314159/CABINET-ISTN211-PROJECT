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
            String firstName = fNameTextBox.Text;
            String lastName = lastNameTextBox.Text;
            String iDNumber = mIDTextBox.Text;
            String phoneNumber = mCellphoneTextBox.Text;

            Boolean firstNameCheck = false;
            Boolean surNameCheck = false;
            Boolean IDNumberCheck = false;
            Boolean phoneNumberCheck = false;


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


            // if all fields are filled in correctly, the following code will execute
            if (firstNameCheck && surNameCheck && IDNumberCheck && phoneNumberCheck)
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
            MessageBox.Show("B= " + numBString);

            for (int i = 0; i < numBString.Length; i++)
            {
                NumC += Convert.ToInt32(Char.GetNumericValue(numBString[i]));
            }
            MessageBox.Show("C = " + NumC.ToString());
            total = NumA + NumC;

            MessageBox.Show("D = " + total.ToString());

            if (total < 10)
            {
                totalStringtrim = total.ToString();
            }
            else
            {

                totalStringtrim = (total.ToString()).Substring(1, 1);
            }

            int checkDigit = 10 - Convert.ToInt32(totalStringtrim);
            MessageBox.Show(checkDigit.ToString());

            if (checkDigit == Convert.ToInt32(idNumber.Substring(12, 1)))
            {
                validID = true;
            }

            return validID;
        }

    }
}
