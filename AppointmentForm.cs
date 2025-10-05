using System;
using System.Data.SqlClient;
using System.Drawing;
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
            // TODO: This line of code loads data into the 'ist2jwDataSet.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.ist2jwDataSet.Appointment);
            // TODO: This line of code loads data into the 'ist2jwDataSet.tblUserSchedule' table. You can move, or remove it, as needed.
            this.tblUserScheduleTableAdapter.FillUserSchedule(this.ist2jwDataSet.tblUserSchedule, HomePage.userID);

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

        public bool DateValidation(DateTime date, int capacity)
        {
            bool isAvailable = false;
            bool isValid = false;
            bool hasAttended = false;

            //if capacity < 10 then date is available 
            if (capacity < 10)
            {
                isAvailable = true;
            }

            if (isAvailable)
            {
                DateTime lastDate = DateTime.Now;
                if (ist2jwDataSet.tblUserSchedule.Rows.Count > 0)
                {
                    tblUserScheduleBindingSource.Sort = "AppDate DESC";
                    this.tblUserScheduleTableAdapter.FillUserSchedule(this.ist2jwDataSet.tblUserSchedule, HomePage.userID);

                    foreach (DataGridViewRow row in tblUserScheduleDataGridView.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["dataGridViewCheckBoxColumn1"].Value) == true)
                        {
                            hasAttended = true;
                            lastDate = (DateTime)row.Cells["dataGridViewTextBoxColumn8"].Value;
                            break;
                        }
                    }

                    if (hasAttended)
                    {
                        // if the last attended appointment is 2 months ago , then isValid = true
                        int monthDifference = (date.Year - lastDate.Year) * 12 + (date.Month - lastDate.Month);

                        if (monthDifference == 2)
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                        }
                    }

                }
                else
                {
                    isValid = true;
                }

            }

            return isValid;
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string newSchID = "S" + rnd.Next(0, 99999).ToString();
            Boolean schIDCheck = false;
            if (ValidSchID(newSchID))
            {
                schIDCheck = true;
            }
            string appID = appIDTextBox1.Text;
            DateTime date = appDateTimePicker1.Value;
            int capacity = int.Parse(capacityTextBox.Text);
            string currentUserID = HomePage.userID;

            if ((date < DateTime.Now))
            {
                MessageBox.Show("The date you're trying to book is before the present date. Please try again");
                return;
            }

            if (DateValidation(date, capacity))
            {
                try
                {
                    // insert new appointment into schedule table
                    scheduleBindingSource.MoveLast();

                    scheduleTableAdapter.InsertSchedule(newSchID.ToString(), currentUserID, appID, true);

                    // update appointment table capacity
                    appointmentTableAdapter.UpdateCapacity(capacity + 1, appID);

                    MessageBox.Show("Congrats. Your new appointment has been scheduled ");
                    // refresh tables 
                    this.appointmentTableAdapter.Fill(this.ist2jwDataSet.Appointment);
                    this.tblUserScheduleTableAdapter.FillUserSchedule(this.ist2jwDataSet.tblUserSchedule, HomePage.userID);
                    appointmentDataGridView.Refresh();
                    tblUserScheduleDataGridView.Refresh();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error booking appointment: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please choose another appointment to book. This date is full");
            }
        }

        private bool ValidSchID(string schID)
        {
            Boolean schIDCheck = false;

            var adapter1 = new ist2jwDataSetTableAdapters.ScheduleTableAdapter();
            var dataTable1 = adapter1.FindScheduleID(schID);

            if (dataTable1.Rows.Count == 0)
            {
                schIDCheck = true;
            }
            else
            {
                Random rnd = new Random();
                schID = rnd.Next(0, 1000000).ToString();
                ValidSchID(schID);
            }


            return schIDCheck;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
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



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tblUserScheduleBindingSource.Sort = "AppDate DESC";
            tblUserScheduleDataGridView.Refresh();
        }

        private void sortAttendedBtn_Click(object sender, EventArgs e)
        {
            tblUserScheduleBindingSource.Sort = " Attended DESC, AppDate DESC";
            tblUserScheduleDataGridView.Refresh();
        }

        private void sortVenueBtn_Click(object sender, EventArgs e)
        {
            tblUserScheduleBindingSource.Sort = "Venue ASC";
            tblUserScheduleDataGridView.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {



        }

        private void btnConfirmAppointment_Click(object sender, EventArgs e)
        {



        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sortAppointmentDateBtn_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void filterResetAppointments_Click(object sender, EventArgs e)
        {
            this.appointmentTableAdapter.Fill(this.ist2jwDataSet.Appointment);
        }

        private void filterAppointmentsBtn_Click(object sender, EventArgs e)
        {

            if (filterSelect.SelectedIndex == -1)
            {
                // Change background color to red
                filterSelect.BackColor = Color.LightCoral;

                // Optionally, show a message
                MessageBox.Show("Please select a filter option before applying.", "Filter Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return; // Stop the filtering process
            }


            if (filterSelect.Text.Equals("Year") && filterAppYearCmbx.Text.Equals(""))
            {
                filterAppYearCmbx.BackColor = Color.LightCoral;
                MessageBox.Show("Please select a year to filter");
                return;
            }
            else if (filterSelect.Text.Equals("Year"))
            {
                int year = int.Parse(filterAppYearCmbx.Text);
                this.appointmentTableAdapter.FillDataByYear(ist2jwDataSet.Appointment, year);

            }

            if (filterSelect.Text.Equals("Month") && filterAppMonthCmbx.Text.Equals(""))
            {
                filterAppMonthCmbx.BackColor = Color.LightCoral;
                MessageBox.Show("Please select a month to filter ");
                return;
            }
            else if (filterSelect.Text.Equals("Month"))
            {
                int month = int.Parse(filterAppMonthCmbx.Text.Substring(0, 2));

                appointmentTableAdapter.FillDataByMonth(ist2jwDataSet.Appointment, month);

            }
            if (filterSelect.Text.Equals("Venue") && filterAppVenueCmbx.Text.Equals(""))
            {
                filterAppVenueCmbx.BackColor = Color.LightCoral;
                MessageBox.Show("Please select a venue to filter ");
                return;
            }
            else if ((filterSelect.Text.Equals("Venue")))
            {
                string venue = filterAppVenueCmbx.Text;
                this.appointmentTableAdapter.FillDataByVenue(ist2jwDataSet.Appointment, venue);

            }
            if (filterSelect.Text.Equals("Capacity") && filterAppCapacityCmbx.Text.Equals(""))
            {
                filterAppCapacityCmbx.BackColor = Color.LightCoral;
                MessageBox.Show("Please select a capacity to filter ");
                return;
            }
            else if (filterSelect.Text.Equals("Capacity"))
            {
                int capacity = int.Parse(filterAppCapacityCmbx.Text);
                this.appointmentTableAdapter.FillDataByCapacity(ist2jwDataSet.Appointment, capacity);
            }
            // Refresh the DataGridView
            appointmentDataGridView.Refresh();
            // If valid, reset color and continue
            filterSelect.BackColor = Color.White;
            filterAppCapacityCmbx.BackColor = Color.White;
            filterAppMonthCmbx.BackColor = Color.White;
            filterAppYearCmbx.BackColor = Color.White;
            filterAppVenueCmbx.BackColor = Color.White;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }



        private void sortAppointmentsVenueBtn_Click(object sender, EventArgs e)
        {
            appointmentBindingSource.Sort = "Venue DESC";
            this.appointmentTableAdapter.Fill(this.ist2jwDataSet.Appointment);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            appointmentBindingSource.Sort = "AppDate ASC";
            this.appointmentTableAdapter.Fill(this.ist2jwDataSet.Appointment);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            appointmentBindingSource.Sort = "Venue ASC";
            this.appointmentTableAdapter.Fill(this.ist2jwDataSet.Appointment);

        }

        private void fillUserAppointmentsToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void fillUserAppointmentsToolStripButton_Click_1(object sender, EventArgs e)
        {


        }

        private void appointmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void fillUserScheduleToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void tblUserScheduleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tblUserScheduleBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            appointmentBindingSource.Filter = string.Empty;
            appointmentBindingSource.Sort = string.Empty;

            tblUserScheduleBindingSource.Sort = string.Empty;
            tblUserScheduleBindingSource.Filter = string.Empty;
            panelNoApp.Visible = false;
            searchDateTime.Value = DateTime.Now;

            this.appointmentTableAdapter.Fill(this.ist2jwDataSet.Appointment);
            this.tblUserScheduleTableAdapter.FillUserSchedule(this.ist2jwDataSet.tblUserSchedule, HomePage.userID);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            DateTime searchDate = searchDateTime.Value;
            appointmentBindingSource.Filter = "AppDate = '" + searchDate.ToString("yyyy-MM-dd") + "'";

            if (appointmentDataGridView.Rows.Count == 0)
            {
                panelNoApp.Visible = true;
                label13.Text = "No appointments have been scheduled for: " + searchDate.ToString("yyyy-MM-dd");

            }
            else
            {
                panelNoApp.Visible = false;
            }

        }

        private void sortAppointmentDateBtn_Click_1(object sender, EventArgs e)
        {
            appointmentBindingSource.Sort = "AppDate DESC";
            appointmentDataGridView.Refresh();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            appointmentBindingSource.Sort = "Venue DESC";
            appointmentDataGridView.Refresh();
        }

        private void sortAppointmentsVenueBtn_Click_1(object sender, EventArgs e)
        {
            appointmentBindingSource.Sort = "Venue ASC";
            appointmentDataGridView.Refresh();
        }

        private void filterAppYearCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void filterAppCapacityCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filterAppVenueCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filterAppMonthCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void monthFilterCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void yearFilterCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (scheduleFilterCmbx.SelectedIndex == -1)
            {
                // Change background color to red
                scheduleFilterCmbx.BackColor = Color.LightCoral;

                // Optionally, show a message
                MessageBox.Show("Please select a filter option before applying.", "Filter Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return; // Stop the filtering process
            }

            // If valid, reset color and continue
            scheduleFilterCmbx.BackColor = Color.White;

            if (scheduleFilterCmbx.Text.Equals("Year") && filterScheduleYearCmbx.Text.Equals(""))
            {
                filterScheduleYearCmbx.BackColor = Color.LightCoral;
                MessageBox.Show("Please select a year to filter");
                return;
            }
            else if (scheduleFilterCmbx.Text.Equals("Year"))
            {
                int year = int.Parse(filterScheduleYearCmbx.Text);
                this.tblUserScheduleTableAdapter.FilterDataByYear(ist2jwDataSet.tblUserSchedule, HomePage.userID, year);
            }
            if (scheduleFilterCmbx.Text.Equals("Month") && filterScheduleMonthCmbx.Text.Equals(""))
            {
                filterScheduleMonthCmbx.BackColor = Color.LightCoral;
                MessageBox.Show("Please select a month to filter");
                return;
            }
            else if (scheduleFilterCmbx.Text.Equals("Month"))
            {
                int month = int.Parse(filterScheduleMonthCmbx.Text.Substring(0, 2));
                this.tblUserScheduleTableAdapter.FilterDataByMonth(ist2jwDataSet.tblUserSchedule, HomePage.userID, month);

            }
            if (scheduleFilterCmbx.Text.Equals("Venue") && filterScheduleVenueCmbx.Text.Equals(""))
            {
                filterScheduleVenueCmbx.BackColor = Color.LightCoral;
                MessageBox.Show("Please select a venue to filter");
                return;
            }
            else if (scheduleFilterCmbx.Text.Equals("Venue"))
            {
                string venue = filterScheduleVenueCmbx.Text;
                this.tblUserScheduleTableAdapter.FilterDataByVenue(ist2jwDataSet.tblUserSchedule, HomePage.userID, venue);

            }
            if (scheduleFilterCmbx.Text.Equals("Attended"))
            {
                this.tblUserScheduleTableAdapter.FilterDataByAttended(ist2jwDataSet.tblUserSchedule, HomePage.userID, (bool)filterScheduleAttendedCheckBox.Checked);
            }
            // Refresh the DataGridView
            appointmentDataGridView.Refresh();
            filterScheduleMonthCmbx.BackColor = Color.White;
            filterScheduleYearCmbx.BackColor = Color.White;
            filterScheduleVenueCmbx.BackColor = Color.White;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            DateTime searchDate = searchScheduleDate.Value;
            tblUserScheduleBindingSource.Filter = "AppDate = '" + searchDate.ToString("yyyy-MM-dd") + "'";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            tblUserScheduleBindingSource.Sort = "Venue DESC";
            tblUserScheduleDataGridView.Refresh();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void appIDTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillUserScheduleToolStripButton_Click_1(object sender, EventArgs e)
        {


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            appointmentBindingSource.MoveNext();
        }

        private void btnLast2_Click(object sender, EventArgs e)
        {
            appointmentBindingSource.MoveLast();
        }

        private void btnPrev2_Click(object sender, EventArgs e)
        {
            appointmentBindingSource.MovePrevious();
        }

        private void btnFirst2_Click(object sender, EventArgs e)
        {
            appointmentBindingSource.MoveFirst();
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            appointmentBindingSource.MoveNext();
        }

        private void btnLast1_Click(object sender, EventArgs e)
        {
            appointmentBindingSource.MoveLast();
        }

        private void btnPrev1_Click(object sender, EventArgs e)
        {
            appointmentBindingSource.MovePrevious();
        }

        private void btnFirst1_Click(object sender, EventArgs e)
        {
            appointmentBindingSource.MoveFirst();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Appointment schedules are displayed in the table provided by Pulse Point.\r\nPlease select an appointment from the table to continue.\r\n\r\nNote: Your next booking must be at least 2 months after your most recent attended appointment.", "Appointment Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSearchAvailable_Click(object sender, EventArgs e)
        {
            appointmentBindingSource.Filter = "Capacity < 10";
        }

        private void AppointmentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}