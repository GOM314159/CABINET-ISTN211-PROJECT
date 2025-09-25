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
        private DataTable userAppointmentTb;
        private DataTable appointmentTb;
        private bool validDate = false;
        public bool isNewDate = false;
        private string venue;

        public AppointmentValidation(DateTime date, string time, DataTable userAppointmentTb, DataTable appointmentTb, string userId , string venue)
        {
            this.date = date;
            this.time = time;
            this.userAppointmentTb = userAppointmentTb;
            this.appointmentTb = appointmentTb;
            this.userId = userId;
            this.venue = venue;
        }

        public bool IsDateAvailable()
        {
            DataTable sortedAppointmentTb = SortedTableDateDesc(appointmentTb);
     
            bool isAvailable = false;
            int count = 0;

            //checks if date is in the past
            if ((date < DateTime.Now) )
            {
                return false;
            }

            //checks if date exits in the database and if the same venue was chosen
            //if capacity == 2 then date is not available 
            foreach (DataRow record in sortedAppointmentTb.Rows)
            {
                if ((DateTime)record["Date"] == this.date)
                {
                    if ( ((string)record["Venue"]).Equals(venue) ) {
                        if ((int)record["Capacity"] == 1)
                        {
                            isAvailable = true;
                            break;
                        }
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

        public bool DateValidationCheck()
        {
            bool isValid = false;

            DataTable sortedAppointmentTb = SortedTableDateDesc(appointmentTb);
            DataTable sortedUserAppointmentTb = SortedTableDateDesc(userAppointmentTb);
            DateTime lastDate = date;

            // check if date is available 
            if (IsDateAvailable())
            {
                // we have to check whether the last attended appointment was 2 months before the one they're booking currently 

                bool hasAttended = false;
                foreach (DataRow row in sortedUserAppointmentTb.Rows)
                {
                    // checks if this user has attended any of their previous appointments
                    if ((bool)row["Attended"] == true)
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
