using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Exceptions
{
    [Serializable]
    class CourseDoesNotExistException: Exception
    {
        public CourseDoesNotExistException() { }
        public CourseDoesNotExistException(int id)
            : base(string.Format("Course with identity {0} doesn't exist.", id)) { }
        public CourseDoesNotExistException(string courseCode)
            :base(string.Format("Course with code {0} doesn't exist", courseCode)){ }
    }
}
