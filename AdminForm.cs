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
            DataRowView currentRow = (DataRowView)tblUsersBindingSource.Current;
            cmbUser.Text = currentRow["UserType"].ToString();
            cmbBlood.Text = currentRow["BloodType"].ToString();

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
         
            }
            else
            {
                MessageBox.Show("Deletion cancelled");
            }


            
        }

        private void btnBloodFilter_Click(object sender, EventArgs e)
        {
            tblUsersBindingSource.Filter = "BloodType = '" + cmbBloodFilter.Text + "'";
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            tblUsersBindingSource.EndEdit();
        }

        private void btnFilterActive_Click(object sender, EventArgs e)
        {

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
    }
}
