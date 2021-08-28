using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Serializable]
    public class AttendanceSummary
    {
        public int sessions { get; set; }
        public string regNo { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public int attended { get; set; }

        public float percentage()
        {
            float _percentage = 0;
            if (sessions > 0)
                _percentage = attended / (float)sessions * 100;
            return _percentage;
        }

        public AttendanceSummary(int sessions)
        {
            this.sessions = sessions;
        }
    }
}
