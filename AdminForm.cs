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
            // TODO: This line of code loads data into the 'ist2jwDataSet.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.ist2jwDataSet.Appointment);
            // TODO: This line of code loads data into the 'ist2jwDataSet.TblBloodInventory' table. You can move, or remove it, as needed.
            this.tblBloodInventoryTableAdapter.Fill(this.ist2jwDataSet.TblBloodInventory);
            // TODO: This line of code loads data into the 'ist2jwDataSet.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.ist2jwDataSet.tblUsers);



        }

        private void btnUserNext_Click(object sender, EventArgs e)
        {
            tblUsersBindingSource.MoveNext();
        }

        private void btnUserPrev_Click(object sender, EventArgs e)
        {
            tblUsersBindingSource.MovePrevious();
        }

        private void btnUserFirst_Click(object sender, EventArgs e)
        {
            tblUsersBindingSource.MoveFirst();
        }

        private void btnUserLast_Click(object sender, EventArgs e)
        {
            tblUsersBindingSource.MoveLast();
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

        }

        private void btnBloodFilter_Click(object sender, EventArgs e)
        {
            tblUsersBindingSource.Filter = "BloodType = '" + cmbBloodFilter.Text + "'";
        }
    }
}
