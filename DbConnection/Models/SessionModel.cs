using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class SessionModel
    {
        private int id;
        private int year;
        private int month;

        public int Month
        {
            get { return month; }
            set
            {
                if (value < 1 || value > 12)
                    month = 9;
                else
                    month = value;
            }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }


        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public SessionModel()
        {
            ID = 0;
            Month = 9;
            Year = DateTime.Now.Year;
        }
    }
}
