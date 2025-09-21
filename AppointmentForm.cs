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
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            DateTime date = calDate.SelectionStart;
            string time = cmbTime.Text;

            // get schedule and appointment table from database

            /**AppointmentValidation check = new AppointmentValidation(date , time , scheduleTb , appointmentTb , userID);
            
            if (check.DateValidation == true) {
                add appointment to database
            } else  {
            MessageBox.Show("Date is not available");
            }

            */
        }
    }
}