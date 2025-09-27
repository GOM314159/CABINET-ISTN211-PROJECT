using BloodBankSystem.ist2jwDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

          
           

            //if capacity == 1 then date is  available 
            if (capacity == 1)
            {
                isAvailable = true;
            }
            else if (capacity == 2)
            {
                isAvailable = false;
            }

            if (isAvailable)
            {
                DateTime lastDate = DateTime.Now;
                if (ist2jwDataSet.tblUserSchedule.Rows.Count > 0)
                {
                    tblUserScheduleBindingSource.Sort = "AppDate DESC";
                    this.tblUserScheduleTableAdapter.FillUserSchedule(this.ist2jwDataSet.tblUserSchedule, HomePage.userID);

                    foreach (DataRow row in tblUserScheduleDataGridView.Rows)
                    {
                        if ((bool)row["Attended"] == true)
                        {
                            hasAttended = true;
                            lastDate = (DateTime)row["AppDate"];
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


            string appID = appIDTextBox1.Text;
            DateTime date = appDateDateTimePicker1.Value;
            string dateString = date.ToString("d");
            int capacity = int.Parse(capacityTextBox.Text);
            string currentUserID = HomePage.userID;

            if ((date < DateTime.Now))
            {
                MessageBox.Show("The date you're trying to book is before the present date. Please try again");
               
            }
            else
            {
                if (DateValidation(date, capacity))
                {
                    try
                    {
                        // insert new appointment into schedule table
                        scheduleBindingSource.MoveLast();
                        Random rnd = new Random();
                        int newSchID = rnd.Next(0, 10000);
                        scheduleBindingSource.AddNew();

                        scheduleIDTextBox.Text = "S" + (newSchID + 1).ToString();
                        userIDScheduleTextBox.Text = currentUserID.ToString();
                        appIDScheduleTextBox.Text = appID;
                        attendedScheduleCheckBox.Checked = true;

                        ((DataRowView)scheduleBindingSource.Current)["Attended"] = true;
                        ((DataRowView)scheduleBindingSource.Current)["ScheduleID"] = scheduleIDTextBox.Text;
                        ((DataRowView)scheduleBindingSource.Current)["UserId"] = userIDScheduleTextBox.Text;
                        ((DataRowView)scheduleBindingSource.Current)["AppID"] = appIDScheduleTextBox.Text;
                        scheduleBindingSource.EndEdit();
                        scheduleTableAdapter.Update(ist2jwDataSet);

                        // update appointment table capacity
                        capacityTextBox.Text = (capacity + 1).ToString();
                        appointmentBindingSource.EndEdit();
                        appointmentTableAdapter.Update(ist2jwDataSet);

                        MessageBox.Show("Congrats. Your new appointment has been scheduled ");
                        // refresh tables 
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



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void sortAttendedBtn_Click(object sender, EventArgs e)
        {

        }

        private void sortVenueBtn_Click(object sender, EventArgs e)
        {

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
            if (filterAppMonthCmbx.Text.Equals("") || filterAppCapacityCmbx.Text.Equals(""))
            {
                MessageBox.Show("Please select a month and capacity");
            }
            else
            {
                int year = int.Parse(filterAppYearCmbx.Text);
                int month = int.Parse(filterAppMonthCmbx.Text.Substring(0, 2));
                string venue = filterAppVenueCmbx.Text;
                int capacity = int.Parse(filterAppCapacityCmbx.Text);

                appointmentBindingSource.Filter = "YEAR(AppDate) = " + year + " OR MONTH(AppDate) = " + month + " OR Venue = " + venue + " OR Capacity = " + capacity;

                appointmentDataGridView.Refresh();
            }
           // this.appointmentTableAdapter.Fill(this.ist2jwDataSet.Appointment);
        
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            appointmentBindingSource.MovePrevious();
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
            this.Validate();
            this.appointmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ist2jwDataSet);

        }

        private void fillUserScheduleToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            appointmentBindingSource.MoveFirst();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            appointmentBindingSource.MoveNext();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            appointmentBindingSource.MoveLast();
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

            // TODO: This line of code loads data into the 'ist2jwDataSet.Appointment' table. You can move, or remove it, as needed.
            appointmentBindingSource.Filter = string.Empty;
            appointmentBindingSource.Sort = string.Empty;
            this.appointmentTableAdapter.Fill(this.ist2jwDataSet.Appointment);
            // TODO: This line of code loads data into the 'ist2jwDataSet.tblUserSchedule' table. You can move, or remove it, as needed.

            tblUserScheduleBindingSource.Sort = string.Empty;
            tblUserScheduleBindingSource.Filter = string.Empty;
            this.tblUserScheduleTableAdapter.FillUserSchedule(this.ist2jwDataSet.tblUserSchedule, HomePage.userID);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            DateTime searchDate = searchDateTime.Value;
            appointmentBindingSource.Filter = "AppDate = '" + searchDate.ToString("yyyy-MM-dd") + "'";
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
    }
}