using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BloodBankSystem
{
    public partial class AdminForm : Form
    {
        
        
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist2jwDataSet.Schedule' table. You can move, or remove it, as needed.
            this.scheduleTableAdapter.Fill(this.ist2jwDataSet.Schedule);
            // TODO: This line of code loads data into the 'ist2jwDataSet.Schedule' table. You can move, or remove it, as needed.
            this.scheduleTableAdapter.Fill(this.ist2jwDataSet.Schedule);
            // TODO: This line of code loads data into the 'ist2jwDataSet.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.ist2jwDataSet.Appointment);
            // TODO: This line of code loads data into the 'ist2jwDataSet.TblBloodInventory' table. You can move, or remove it, as needed.
            this.tblBloodInventoryTableAdapter.Fill(this.ist2jwDataSet.TblBloodInventory);
            // TODO: This line of code loads data into the 'ist2jwDataSet.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.ist2jwDataSet.tblUsers);

            ComboboxRefresh();
            
        }

        public void ComboboxRefresh()
        {
            if (tblUsersBindingSource.Current != null)
            {
                DataRowView currentRow = (DataRowView)tblUsersBindingSource.Current;
                cmbUser.Text = currentRow["UserType"].ToString();
                cmbBlood.Text = currentRow["BloodType"].ToString();
            }


        }


        private void btnUserNext_Click(object sender, EventArgs e)
        {
            tblUsersBindingSource.MoveNext();
            ComboboxRefresh();
        }

        private void btnUserPrev_Click(object sender, EventArgs e)
        {
            tblUsersBindingSource.MovePrevious();
            ComboboxRefresh();
        }

        private void btnUserFirst_Click(object sender, EventArgs e)
        {
            tblUsersBindingSource.MoveFirst();
            ComboboxRefresh();
        }

        private void btnUserLast_Click(object sender, EventArgs e)
        {
            tblUsersBindingSource.MoveLast();
            ComboboxRefresh();
        }

        private void btnBllodNext_Click(object sender, EventArgs e)
        {
            tblBloodInventoryBindingSource.MoveNext();
        }

        private void btnBloodPrev_Click(object sender, EventArgs e)
        {
            tblBloodInventoryBindingSource.MovePrevious();
        }

        private void btnBloodLast_Click(object sender, EventArgs e)
        {
            tblBloodInventoryBindingSource.MoveLast();
        }

        private void btnBloodFirst_Click(object sender, EventArgs e)
        {
            tblBloodInventoryBindingSource.MoveFirst();
        }

        private void btnAppNext_Click(object sender, EventArgs e)
        {
            appointmentBindingSource.MoveNext();
        }

        private void btnAppPrev_Click(object sender, EventArgs e)
        {
            appointmentBindingSource.MovePrevious();
        }

        private void btnAppFirst_Click(object sender, EventArgs e)
        {
            appointmentBindingSource.MoveFirst();
        }

        private void btnAppLast_Click(object sender, EventArgs e)
        {
            appointmentBindingSource.MoveLast();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            tblUsersBindingSource.Sort = "Name ASC";
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult Confirmation;
            Confirmation = MessageBox.Show("Are you sure you want to delete this record and associated schedules?", "Confirm", MessageBoxButtons.YesNo);
            if (Confirmation == DialogResult.Yes)
            {
                DataRowView currentRow = (DataRowView)tblUsersBindingSource.Current;
                String UserID = currentRow["UserID"].ToString();

                foreach (DataRowView rowView in appointmentBindingSource)
                {
                    string ID = rowView["UserID"].ToString();

                    if (UserID == ID)
                    {
                        appointmentBindingSource.RemoveCurrent();

                    }

                }

                foreach (DataRowView rowView in tblBloodInventoryBindingSource)
                {
                    string ID = rowView["UserID"].ToString();

                    if (UserID == ID)
                    {
                        tblBloodInventoryBindingSource.RemoveCurrent();
                    }

                }
                tblUsersBindingSource.RemoveCurrent();
                appointmentTableAdapter.Update(ist2jwDataSet);
                tblUsersTableAdapter.Update(ist2jwDataSet);
            }
            else
            {
                MessageBox.Show("Deletion cancelled");
            }



        }

        private void btnBloodFilter_Click(object sender, EventArgs e)
        {
            
            

            
            

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            Boolean bValid = true;
            String firstName = txtName.Text;
            String lastName = txtSurname.Text;
            String phoneNumber = txtPhone.Text;
            String password = txtPassword.Text;
            String iDNumber = txtID.Text;

            String sOut = "Errors:";
            if (string.IsNullOrWhiteSpace(firstName))
            {
                bValid = false;
                sOut = sOut + " \n First Name must not be empty";
            }
            

            // Last name check
            if (string.IsNullOrWhiteSpace(lastName))
            {
                bValid = false;
                sOut = sOut + " \n Surname must not be empty";
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text) && phoneNumber.Length != 10)
            {
                bValid = false;
                sOut = sOut + "\n Phone number must be valid";
            }

            if (string.IsNullOrWhiteSpace(password) && !validPasswordCheck(password))
            {
                bValid = false;
                sOut = sOut + "\n Password must valid";
            }

            if (string.IsNullOrWhiteSpace(iDNumber) && !(iDNumber.Length == 13))
            {
                if (!validIDCheck(iDNumber))
                {
                    bValid = false;
                    sOut = sOut + "\n ID number must be valid";
                }
            }

            if (bValid == false)
            {

                MessageBox.Show(sOut);

            }
            else
            {
                DataRowView currentRow = (DataRowView)tblUsersBindingSource.Current;
                currentRow["UserType"] = cmbUser.Text;
                currentRow["BloodType"] = cmbBlood.Text;
                tblUsersBindingSource.EndEdit();
                tblUsersTableAdapter.Update(ist2jwDataSet);
                MessageBox.Show("Changes applied successsfully!");
            }

                
        }

        private void btnFilterActive_Click(object sender, EventArgs e)
        {
            tblUsersTableAdapter.Fill(ist2jwDataSet.tblUsers);
            tblUsersBindingSource.Filter = "isActiveAccount = True";
        }

        private void btnSurnameAlphabetical_Click(object sender, EventArgs e)
        {
            tblUsersBindingSource.Sort = "Surname ASC";
        }

        private void btnUserFilter_Click(object sender, EventArgs e)
        {
            String UserType = "";
            if (cmbUserFilter.Text == "Admin")
            {

                UserType = "A";

            }
            else
            {

                UserType = "D";

            }

            tblUsersBindingSource.Filter = "UserType = '" + UserType + "'";

        }

        private void btnRemoveFilter_Click(object sender, EventArgs e)
        {
            tblUsersTableAdapter.Fill(ist2jwDataSet.tblUsers);
            tblUsersBindingSource.RemoveSort();
            tblUsersBindingSource.RemoveFilter();

        }

        private void button5_Click(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult Confirmation;
            Confirmation = MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo);
            if (Confirmation == DialogResult.Yes)
            {
                tblBloodInventoryBindingSource.RemoveCurrent();

            }
            else
            {
                MessageBox.Show("Deletion cancelled");
            }




        }

        private void btnBloodApply_Click(object sender, EventArgs e)
        {
            tblBloodInventoryBindingSource.EndEdit();
            //tblBloodInventoryTableAdapter.Update();
        }

        private void btnFilterInactive_Click(object sender, EventArgs e)
        {
            tblUsersBindingSource.MoveFirst();
            tblUsersTableAdapter.Fill(ist2jwDataSet.tblUsers);
            tblUsersBindingSource.Filter = "isActiveAccount = False";
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbUser_SelectionChangeCommitted(object sender, EventArgs e)
        {

            DataRowView currentRow = (DataRowView)tblUsersBindingSource.Current;
            currentRow["UserType"] = cmbUser.Text;

        }

        private void cmbBlood_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRowView currentRow = (DataRowView)tblUsersBindingSource.Current;
            currentRow["BloodType"] = cmbBlood.Text;
        }


        public void statsFill()
        {

            int iNumSchedules = scheduleBindingSource.Count;
            lblSchedules.Text = "Total number of scehduled appointments: " + iNumSchedules.ToString();

            scheduleBindingSource.RemoveFilter();
            scheduleBindingSource.Filter = "Attended = true";
            lblAttended.Text = "Number of schedules attended: " + scheduleBindingSource.Count;

            scheduleBindingSource.RemoveFilter();
            scheduleBindingSource.Filter = "Attended = false";
            lblUnattended.Text = "Number of schedules unattended: " + scheduleBindingSource.Count;

            scheduleBindingSource.RemoveFilter();


        }

        private void tcAdmin_TabIndexChanged(object sender, EventArgs e)
        {

            statsFill();

        }

        private void chtStats_Click(object sender, EventArgs e)
        {

        }

        private void tpgSchedule_Click(object sender, EventArgs e)
        {
            statsFill();
        }

        private void btnScheduleUserSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchByUser.Text))
            {

                MessageBox.Show("Please enter a UserID in the box below");

            }
            else
            {
                Boolean bFound = false;

                int iCount = 0;
                String name = "";
                String UserID;
                tblUsersBindingSource.MoveFirst();

                foreach (DataRowView rowView in tblUsersBindingSource)
                {
                    UserID = rowView["UserID"].ToString();
                    if (UserID == txtSearchByUser.Text)
                    {

                        bFound = true;
                        name = rowView["Name"].ToString() + " " + rowView["Surname"].ToString();

                    }

                }

                if (bFound = false)
                {

                    MessageBox.Show("UserID is invalid or has not been found");

                }
                else
                {



                    foreach (DataRowView rowView in scheduleBindingSource)
                    {
                        UserID = rowView["UserID"].ToString();
                        if (UserID == txtSearchByUser.Text)
                        {

                            iCount++;

                            redDisplay.AppendText("User schedule details:");
                            redDisplay.AppendText("Name: " + name);



                        }


                    }


                }



            }
        }

        public void fillComponents()
        {

            txtSearchByUser.Text = "UserID";
            txtSearchByUser.ForeColor = SystemColors.GrayText;

        }

        private void tcAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            statsFill();
            
        }

        private void btnLaterExpiry_Click(object sender, EventArgs e)
        {
            tblBloodInventoryBindingSource.RemoveFilter();
            tblBloodInventoryBindingSource.RemoveSort();
            tblBloodInventoryBindingSource.Filter = "ExpiryDate > '" + dtpExpiryFilter.Text + "'";
        }

        private void btnEarlyExpiry_Click(object sender, EventArgs e)
        {
            tblBloodInventoryBindingSource.RemoveFilter();
            tblBloodInventoryBindingSource.RemoveSort();
            tblBloodInventoryBindingSource.Filter = "ExpiryDate > '" + dtpExpiryFilter.Text + "'";
        }

        private void btnCapSortAsc_Click(object sender, EventArgs e)
        {
            appointmentBindingSource.RemoveFilter();
            appointmentBindingSource.RemoveSort();
            appointmentBindingSource.Sort = "Capacity ASC";
        }

        private void btnCapSortDesc_Click(object sender, EventArgs e)
        {
            appointmentBindingSource.RemoveFilter();
            appointmentBindingSource.RemoveSort();
            appointmentBindingSource.Sort = "Capacity DESC";
        }

        



        private void btnVenueFilter_Click(object sender, EventArgs e)
        {
            
        }

        String userID;

        private void btnInsertUser_Click(object sender, EventArgs e)
        {

           

            
            String userType = cmbUser.Text;
            String firstName = txtName.Text;
            String lastName = txtSurname.Text;
            String iDNumber = txtID.Text;
            String phoneNumber = txtPhone.Text;
            String password = txtPassword.Text;
            String bloodType = cmbBlood.Text;
            Boolean isActiveAcc = true;

            Boolean userIDCheck = false;
            Boolean firstNameCheck = false;
            Boolean surNameCheck = false;
            Boolean IDNumberCheck = false;
            Boolean phoneNumberCheck = false;
            Boolean passwordCheck = false;
            

            if (validUserID(userID))
            {
                userIDCheck = true;
            }

            // First Name check
            if (!string.IsNullOrWhiteSpace(firstName))
            {
                firstNameCheck = true;
                txtName.BackColor = Color.LightGreen;
            }
            else
            {
                txtName.BackColor = Color.IndianRed;
                firstNameCheck = false;
            }

            // Last name check
            if (!string.IsNullOrWhiteSpace(lastName))
            {
                surNameCheck = true;
                txtSurname.BackColor = Color.LightGreen;
            }
            else
            {
                txtSurname.BackColor = Color.IndianRed;
                surNameCheck = false;
            }

            // ID Number check
            if (!string.IsNullOrWhiteSpace(iDNumber) && iDNumber.Length == 13)
            {
                if (validIDCheck(iDNumber))
                {
                    IDNumberCheck = true;
                    txtID.BackColor = Color.LightGreen;
                }
            }
            else
            {
                txtID.BackColor = Color.IndianRed;
                IDNumberCheck = false;
            }       

            // Phone Number check
            if (!string.IsNullOrWhiteSpace(txtPhone.Text) && phoneNumber.Length == 10)
            {
                phoneNumberCheck = true;
                txtPhone.BackColor = Color.LightGreen;
            }
            else
            {
                txtPhone.BackColor = Color.IndianRed;
                phoneNumberCheck = false;
            }

            //Blood Type check
            if (!string.IsNullOrWhiteSpace(bloodType))
            {
                cmbBlood.BackColor = Color.LightGreen;
                bloodType = cmbBlood.Text;
            }
            else
            {
                cmbBlood.BackColor = Color.IndianRed;
            }

            if (!string.IsNullOrWhiteSpace(userType))
            {
                cmbUser.BackColor = Color.LightGreen;
                userType = cmbUser.Text;
            }
            else
            {
                cmbUser.BackColor = Color.IndianRed;
            }

            // password check
            if (!string.IsNullOrWhiteSpace(password) && validPasswordCheck(password))
            {
                passwordCheck = true;
                txtPassword.BackColor = Color.LightGreen;
            }
            else
            {
                txtPassword.BackColor = Color.IndianRed;
                passwordCheck = false;
            }

            // if all fields are filled in correctly, the following code will execute
            if (userIDCheck && firstNameCheck && surNameCheck && IDNumberCheck && phoneNumberCheck && passwordCheck)
            {
                txtUserID.Text = userID;
                DataRowView currentRow = (DataRowView)tblUsersBindingSource.Current;
                currentRow["UserType"] = userType;
                currentRow["BloodType"] = bloodType;
                currentRow["isActiveAccount"] = chkActive.Checked;
                tblUsersBindingSource.EndEdit();
                tblUsersTableAdapter.Update(ist2jwDataSet);

                MessageBox.Show("New User successfully added!");

                btnInsertUser.Visible = false;
                btnStartInsert.Visible = true;
                btnUpdateUser.Visible = true;
                btnDeleteUser.Visible = true;
                pnlUserEdit.BackColor = SystemColors.ActiveCaption;
                btnCancelInsert.Visible = false;
                txtPassword.ReadOnly = true;

                txtUserID.BackColor = SystemColors.Control;
                txtPassword.BackColor = SystemColors.Control;
                txtName.BackColor = SystemColors.Control;
                txtSurname.BackColor = SystemColors.Control;
                txtID.BackColor = SystemColors.Control;
                txtPhone.BackColor = SystemColors.Control;
                cmbBlood.BackColor = SystemColors.Control;
                cmbUser.BackColor = SystemColors.Control;


                tblUsersTableAdapter.GetData();
                dgvUsers.Refresh();

            }

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

            if (dataTable1.Rows.Count == 0)
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

        private void btnStartInsert_Click(object sender, EventArgs e)
        {

            btnInsertUser.Visible = true;
            btnStartInsert.Visible = false;
            btnUpdateUser.Visible = false;
            btnDeleteUser.Visible = false;
            pnlUserEdit.BackColor = Color.SkyBlue;
            btnCancelInsert.Visible = true;
            txtPassword.ReadOnly = false;

            tblUsersBindingSource.MoveLast();
            Random rnd = new Random();
            userID = rnd.Next(0, 1000000).ToString();
            tblUsersBindingSource.AddNew();
            txtUserID.Text = userID;



            



            MessageBox.Show("Please enter all information");

        }

        private void btnCancelInsert_Click(object sender, EventArgs e)
        {
            btnInsertUser.Visible = false;
            btnStartInsert.Visible = true;
            btnUpdateUser.Visible = true;
            btnDeleteUser.Visible = true;
            pnlUserEdit.BackColor = SystemColors.ActiveCaption;
            btnCancelInsert.Visible = false;
            txtPassword.ReadOnly = true;

            txtUserID.BackColor = SystemColors.Control;
            txtPassword.BackColor = SystemColors.Control;
            txtName.BackColor = SystemColors.Control;
            txtSurname.BackColor = SystemColors.Control;
            txtID.BackColor = SystemColors.Control;
            txtPhone.BackColor = SystemColors.Control;
            cmbBlood.BackColor = SystemColors.Control;
            cmbUser.BackColor = SystemColors.Control;
            

            tblUsersTableAdapter.GetData();
            dgvUsers.Refresh();

            MessageBox.Show("Insertion cancelled");

            tblUsersBindingSource.RemoveCurrent();
            tblUsersTableAdapter.Update(ist2jwDataSet);


        }

        private void btnAppDelete_Click(object sender, EventArgs e)
        {
            DialogResult Confirmation;
            Confirmation = MessageBox.Show("Are you sure you want to delete this record and associated schedules?", "Confirm", MessageBoxButtons.YesNo);
            if (Confirmation == DialogResult.Yes)
            {
                DataRowView currentRow = (DataRowView)tblUsersBindingSource.Current;
                String UserID = currentRow["UserID"].ToString();

                foreach (DataRowView rowView in scheduleBindingSource)
                {
                    string ID = rowView["UserID"].ToString();

                    if (UserID == ID)
                    {
                        scheduleBindingSource.RemoveCurrent();

                    }

                }

                foreach (DataRowView rowView in tblBloodInventoryBindingSource)
                {
                    string ID = rowView["UserID"].ToString();

                    if (UserID == ID)
                    {
                        tblBloodInventoryBindingSource.RemoveCurrent();
                    }

                }
                tblUsersBindingSource.RemoveCurrent();
                appointmentTableAdapter.Update(ist2jwDataSet);
                tblUsersTableAdapter.Update(ist2jwDataSet);
            }
            else
            {
                MessageBox.Show("Deletion cancelled");
            }




        }

        private void btnUpdateApp_Click(object sender, EventArgs e)
        {
            Boolean bValid = true;

            if (bValid == false)
            {
                MessageBox.Show("InValid");
            }
            else
            {
                DataRowView currentRow = (DataRowView)appointmentBindingSource.Current;
                appointmentBindingSource.EndEdit();
                appointmentTableAdapter.Update(ist2jwDataSet);
                MessageBox.Show("Changes applied successsfully!");
            }
                



        }

        private void btnFilterUpcoming_Click(object sender, EventArgs e)
        {
            string today = DateTime.Today.ToString("yyyy-MM-dd");
            appointmentBindingSource.Filter = "AppDate > #" + today +"#";

        }

        private void btnFilterPassed_Click(object sender, EventArgs e)
        {
            string today = DateTime.Today.ToString("yyyy-MM-dd");
            appointmentBindingSource.Filter = "AppDate < #" + today + "#";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            WelcomeForm welcome = new WelcomeForm();
            welcome.Show();
            this.Hide();

        }

        private void txtSearchByUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchByUser.Text))
            {
                txtSearchByUser.Text = "Enter text here...";
                txtSearchByUser.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtSearchByUser_Enter(object sender, EventArgs e)
        {
            if (txtSearchByUser.Text == "UserID")
            {
                txtSearchByUser.Text = "";
                txtSearchByUser.ForeColor = SystemColors.WindowText;
            }
        }

        private void fillByOToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
        //        this.tblBloodInventoryTableAdapter.FillByO(this.ist2jwDataSet.TblBloodInventory);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByOToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
           //     this.tblBloodInventoryTableAdapter.FillByO(this.ist2jwDataSet.TblBloodInventory);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnScheduleEventSearch_Click(object sender, EventArgs e)
        {
            

           

        }

        private void btnCountSchedules_Click(object sender, EventArgs e)
        {

            scheduleTableAdapter.totalUserSchedules();

        }

        private void btnAppInsert_Click(object sender, EventArgs e)
        {
           
        }
    }
}
