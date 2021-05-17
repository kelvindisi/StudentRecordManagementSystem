using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecordManagementSystem.Exceptions
{
    [Serializable]
    class InvalidInputException: Exception
    {
        private int v;

        public InvalidInputException()
            : base("You entered invalid input") { }
        public InvalidInputException(string field)
            : base(string.Format("You entered invalid {0}", field)) { }

        public InvalidInputException(string field, int v)
            : base(string.Format("{0} must have atleast length of {1} characters",
                field, v)){ }
    }
}
