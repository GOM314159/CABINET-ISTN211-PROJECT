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
using static BloodBankSystem.ist2jwDataSet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            var dt =  adapter.GetUserAppointments( HomePage.userID);
            userAppointmentsDataGrid.DataSource = dt;

            var adapter2 = new ist2jwDataSetTableAdapters.AppointmentTableAdapter();
            var dataTable2 = adapter2.GetData();
            appointmentsDataGrid.DataSource = dataTable2;
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

            string appID = userAppointmentsDataGrid.SelectedCells[0].Value.ToString();
            DateTime date = (DateTime)userAppointmentsDataGrid.SelectedCells[1].Value;
            int capacity = Int32.Parse(userAppointmentsDataGrid.SelectedCells[3].Value.ToString());
            

            Random rnd = new Random();
            string schID = "S" + rnd.Next(0, 1000000).ToString();
            string dateString = date.ToString("d");
            

            DataTable userAppointmentTb = new ist2jwDataSet.UserAppointmentsDataTable();

            string currentUserID = HomePage.userID;

            AppointmentValidation check = new AppointmentValidation(date  , userAppointmentTb , capacity);
            
            if (check.DateValidationCheck() == true) {
                try
                {
                    var adapter = new ist2jwDataSetTableAdapters.ScheduleTableAdapter();
                    var dataTable1 = adapter.InsertSchedule(schID, currentUserID, dateString, true);
                    MessageBox.Show("Appointment booked successfully!");

                    var adapter2 = new ist2jwDataSetTableAdapters.AppointmentTableAdapter();
                    var dataTable2 = adapter2.UpdateCapacity(2 , appID);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error booking appointment: " + ex.Message);
                }
                
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

        private void resetBtn_Click(object sender, EventArgs e)
        {
            
            var adapter = new ist2jwDataSetTableAdapters.UserAppointmentsTableAdapter();
            var dataTable = adapter.GetUserAppointments(HomePage.userID);
            userAppointmentsDataGrid.DataSource = dataTable;
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataView dataView = new DataView(ist2jwDataSet.UserAppointments);
            dataView.Sort = "Appointment Date DESC";

            userAppointmentsDataGrid.DataSource = dataView;
        }

        private void sortAttendedBtn_Click(object sender, EventArgs e)
        {
            DataView dataView = new DataView(ist2jwDataSet.UserAppointments);
            dataView.Sort = "Appointment Date DESC , Attended DESC";

            userAppointmentsDataGrid.DataSource = dataView;
        }

        private void sortVenueBtn_Click(object sender, EventArgs e)
        {
            DataView dataView = new DataView(ist2jwDataSet.UserAppointments);
            dataView.Sort = "Venue ASC";

            userAppointmentsDataGrid.DataSource = dataView;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int year = Int32.Parse(yearFilterCmbx.Text);
            int month = Int32.Parse(monthFilterCmbx.Text.Substring(0,2));
            string venue = venueFilterCmbx.Text;

            if (string.IsNullOrEmpty(yearFilterCmbx.Text) && string.IsNullOrEmpty(monthFilterCmbx.Text) && string.IsNullOrEmpty(venue))
            {
                MessageBox.Show("Please select at least one field to be filtered");
          
            } else
            {
                var adapter = new ist2jwDataSetTableAdapters.UserAppointmentsTableAdapter();
                var dataTable = adapter.FilterDataBy(year, month, venue , attendedFilterRdBtn.Checked);
                userAppointmentsDataGrid.DataSource = dataTable; 
            }

        }

        private void btnConfirmAppointment_Click(object sender, EventArgs e)
        {

            

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sortAppointmentDateBtn_Click(object sender, EventArgs e)
        {
            DataView dataView = new DataView(ist2jwDataSet.Appointment);
            dataView.Sort = "AppDate DESC";

            appointmentsDataGrid.DataSource = dataView;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void filterResetAppointments_Click(object sender, EventArgs e)
        {
            var adapter = new ist2jwDataSetTableAdapters.AppointmentTableAdapter();
            var dataTable = adapter.GetData();
            userAppointmentsDataGrid.DataSource = dataTable;
        }

        private void filterAppointmentsBtn_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(filterAppointmentsMonthCmbx.Text) && string.IsNullOrEmpty(filterAppointmentsVenueCmbx.Text))
            {
                MessageBox.Show("Please select at least one field to be filtered");

            }
            else
            {
                
                int month = Int32.Parse(filterAppointmentsMonthCmbx.Text.Substring(0, 2));
                string venue = filterAppointmentsVenueCmbx.Text;
                int capacity = Int32.Parse(filterAppointmentsCapacityCmbx.Text);

                var adapter = new ist2jwDataSetTableAdapters.AppointmentTableAdapter();
                var dataTable = adapter.FilterDataBy(year, month, capacity,venue);
                userAppointmentsDataGrid.DataSource = dataTable;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
                
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void sortAppointmentsVenueBtn_Click(object sender, EventArgs e)
        {
            DataView dataView = new DataView(ist2jwDataSet.Appointment);
            dataView.Sort = "Venue DESC";

            appointmentsDataGrid.DataSource = dataView;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataView dataView = new DataView(ist2jwDataSet.Appointment);
            dataView.Sort = "AppDate ASC";

            appointmentsDataGrid.DataSource = dataView;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataView dataView = new DataView(ist2jwDataSet.Appointment);
            dataView.Sort = "Venue ASC";

            appointmentsDataGrid.DataSource = dataView;
        }
    }
}