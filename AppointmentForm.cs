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
            var dataTable = adapter.GetData("Par02");
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
            DateTime date = calDate.SelectionStart;
            string time = cmbTime.Text;
            DataTable scheduleTb = new ist2jwDataSet.ScheduleDataTable();
            DataTable appointmentTb = new ist2jwDataSet.AppointmentDataTable();
        
            /**AppointmentValidation check = new AppointmentValidation(date , time , scheduleTb , appointmentTb , userID);
            
            if (check.DateValidation() == true) {
                // insert into appointment table
            }
            else  {
            MessageBox.Show("Date is not available");
            }
            */

            
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
            var dataTable = adapter.GetData();
            dataGridView1.DataSource = dataTable;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}