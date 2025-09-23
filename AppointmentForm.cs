using BloodBankSystem.ist2jwDataSetTableAdapters;
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
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            var adapter = new ist2jwDataSetTableAdapters.UserAppointmentsTableAdapter();
            var dataTable = adapter.GetData(UserSession.UserId);
            dataGridView1.DataSource = dataTable;
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
            
            DateTime date = calendarDate.SelectionStart;
            string time = timeCmbx.Text;
            string venue = venueCmbx.Text;
            DataTable userAppointmentTb = new ist2jwDataSet.UserAppointmentsDataTable();
            DataTable appointmentTb = new ist2jwDataSet.AppointmentDataTable();
            string currentUserID = UserSession.UserId;


            // validation 
            if (string.IsNullOrEmpty(timeCmbx.Text))
            {
                MessageBox.Show("Please select a time");
                return;
            }

            if (string.IsNullOrEmpty(venueCmbx.Text))
            {
                MessageBox.Show("Please select a venue");
                return;
            }

            if (date.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Appointments cannot be booked on Sundays. Please select another date.");
                return;
            }

            AppointmentValidation check = new AppointmentValidation(date , time , userAppointmentTb , appointmentTb , currentUserID , venue);
            
            if (check.DateValidationCheck() == true) {
                // insert into appointment table
                /**
                 * try {
                 * var adapter = new ist2jwDataSetTableAdapters.AppointmentTableAdapter();
                 * var dataTable = adapter.InsertAppointment(...);
                 * 
                 * MessageBox.Show("Appointment booked successfully");
                 * 
                 * } catch (SqlException ex) {
                 *  MessageBox.Show("Error booking appointment: " + ex.Message);
                 * }
                 */
            }
            else  {
            MessageBox.Show("Date is not available");
            }
            

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            var adapter = new ist2jwDataSetTableAdapters.UserAppointmentsTableAdapter();
            var dataTable = adapter.GetData(UserSession.UserId);
            dataGridView1.DataSource = dataTable;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataView dataView = new DataView(ist2jwDataSet.UserAppointments);
            dataView.Sort = "Date DESC";

            dataGridView1.DataSource = dataView;
        }

        private void sortAttendedBtn_Click(object sender, EventArgs e)
        {
            DataView dataView = new DataView(ist2jwDataSet.UserAppointments);
            dataView.Sort = "Date DESC , Attended DESC";

            dataGridView1.DataSource = dataView;
        }

        private void sortVenueBtn_Click(object sender, EventArgs e)
        {
            DataView dataView = new DataView(ist2jwDataSet.UserAppointments);
            dataView.Sort = "Venue DESC";

            dataGridView1.DataSource = dataView;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            decimal year = Decimal.Parse(yearFilterCmbx.Text);
            decimal month = Decimal.Parse(monthFilterCmbx.Text);
            string venue = venueFilterCmbx.Text;

            if (string.IsNullOrEmpty(yearFilterCmbx.Text) && string.IsNullOrEmpty(monthFilterCmbx.Text) && string.IsNullOrEmpty(venue))
            {
                MessageBox.Show("Please select at least one field to be filtered");
          
            } else
            {
                var adapter = new ist2jwDataSetTableAdapters.UserAppointmentsTableAdapter();
                var dataTable = adapter.FilterDataBy(year, month, venue , attendedFilterRdBtn.Checked);
                dataGridView1.DataSource = dataTable; 
            }

        }
    }
}