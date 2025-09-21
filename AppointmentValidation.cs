using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BloodBankSystem
{
    internal class AppointmentValidation
    {
        private DateTime date;
        private string time;
        private string userId;
        private DataTable scheduleTb;
        private DataTable appointmentTb;
        private bool validDate = false;
        public bool isNewDate = false;

        public AppointmentValidation(DateTime date, string time, DataTable scheduleTb, DataTable appointmentTb, string userId)
        {
            this.date = date;
            this.time = time;
            this.scheduleTb = scheduleTb;
            this.appointmentTb = appointmentTb;
            this.userId = userId;
        }

        public bool IsDateAvailable()
        {
            DataTable sortedAppointmentTb = SortedTableDateDesc(appointmentTb);
            bool isAvailable = false;
            int count = 0;

            //checks if date is in the past or falls on a Sunday
            if ((date < DateTime.Now) || (date.DayOfWeek == DayOfWeek.Sunday))
            {
                return false;
            }

            //checks if date exits in the database and if the capacity is == 1,
            //if capacity == 2 then date is not available 
            foreach (DataRow row in sortedAppointmentTb.Rows)
            {
                if ((DateTime)row["Date"] == this.date)
                {
                    if ((int)row["Capacity"] == 1)
                    {
                        isAvailable = true;
                        break;
                    }
                }
                count++;

            }
            // if date is not in the database 
            if ((count == sortedAppointmentTb.Rows.Count) && (isAvailable == false))
            {
                isNewDate = true;
                isAvailable = true;
            }

            return isAvailable;

        }

        public bool DateValidation()
        {
            bool isValid = false;

            DataTable sortedAppointmentTb = SortedTableDateDesc(appointmentTb);
            DateTime lastDate = date;

            // check if date is available 
            if (IsDateAvailable())
            {
                // we have to check whether the last attended appointment was 2 months before
                // the one they're booking currently 

                bool hasAttended = false;
                foreach (DataRow row in scheduleTb.Rows)
                {
                    // checks if this user has attended any of their previous appointments
                    if (((bool)row["Attend"] == true) && ((string)row["UserID"] == userId))
                    {
                        hasAttended = true;
                        lastDate = (DateTime)row["Date"];
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
                }
                else
                {
                    // special case : what if they never go for all of their appointments ? 
                    // they should be able to book an appointment on any day they choose 
                    isValid = true;
                }
            }
            else
            {
                return false;
            }
            return isValid;
        }


        //this method sorts tables in descending order according to date
        public DataTable SortedTableDateDesc(DataTable dt)
        {
            DataView dataView = new DataView(dt);
            dataView.Sort = "Date DESC";

            DataTable sortedTb = dataView.ToTable();
            return sortedTb;
        }
    }
}
