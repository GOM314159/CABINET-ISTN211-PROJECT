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
        private DataTable userAppointmentTb;
        private int capacity;

        public AppointmentValidation( DateTime date, DataTable userAppointmentTb, int capacity)
        {
            this.date = date;
            this.userAppointmentTb = userAppointmentTb;
            this.capacity = capacity;
        }

        public bool IsDateAvailable()
        {
            bool isAvailable = false;

            //checks if user selected an appointment date that is in the past
            if ((date < DateTime.Now) )
            {
                return false;
            }
       
            //if capacity == 1 then date is  available 
            if (capacity == 1)
            {
                return true;
            }
            else if (capacity == 2)
            {
                return false;
            }
            return isAvailable;

        }

        public bool DateValidationCheck()
        {
            bool isValid = false;

            DataTable sortedUserAppointmentTb = SortedTableDateDesc(userAppointmentTb);
            DateTime lastDate = DateTime.Now;

            // check if date is available 
            if (IsDateAvailable())
            {
                // check whether the last attended appointment was 2 months before the one they're booking currently 
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
                    int monthDifference = (this.date.Year - lastDate.Year) * 12 + (this.date.Month - lastDate.Month);

                    if (monthDifference == 2)
                    {
                        isValid = true;
                    } else
                    {
                        isValid = false;
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
