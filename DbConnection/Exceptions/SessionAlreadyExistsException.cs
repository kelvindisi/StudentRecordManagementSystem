using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Exceptions
{
    [Serializable]
    class SessionAlreadyExistsException: Exception
    {
        public static string message(int month, int year)
        {
            int day = 01;
            DateTime date = new DateTime(year, month, day);
            string monthName = date.ToString("MMM");
            string message = string.Format("Session for year {0} starting on {1} already exists",
                year, monthName);
            return message;
        }
        public SessionAlreadyExistsException()
            :base("Session already exists"){}

        public SessionAlreadyExistsException(int month, int year)
            : base(message(month, year)) { }
    }
}
