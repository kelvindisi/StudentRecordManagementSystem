using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Exceptions
{
    [Serializable]
    class CourseAlreadyExistsException: Exception
    {
        public CourseAlreadyExistsException() { }
        public CourseAlreadyExistsException(string courseCourseCode)
            :base(string.Format("Course with course code {0} already exists.", courseCourseCode)){}
    }
}
