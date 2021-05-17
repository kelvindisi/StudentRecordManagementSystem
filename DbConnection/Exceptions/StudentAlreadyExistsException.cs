using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Exceptions
{
    [Serializable]
    class StudentAlreadyExistsException : Exception
    {
        public StudentAlreadyExistsException()
            :base("Student bio-data already exists") { }
        public StudentAlreadyExistsException(string email)
            : base(string.Format("Student Bio-Data with email {0} exists", email)) { }
    }
}
