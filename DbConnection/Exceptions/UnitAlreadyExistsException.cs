using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Exceptions
{
    [Serializable]
    class UnitAlreadyExistsException: Exception
    {
        public UnitAlreadyExistsException()
            : base("Unit already exists") { }
        public UnitAlreadyExistsException(string unitCode, string courseName)
            : base(String.Format("{0} has another unit with code {1}", courseName, unitCode)) { }

    }
}
