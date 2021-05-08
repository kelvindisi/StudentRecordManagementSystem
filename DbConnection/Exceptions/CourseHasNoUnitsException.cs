using System;

namespace DataAccess.Exceptions
{
    [Serializable]
    class CourseHasNoUnitsException : Exception
    {
        public CourseHasNoUnitsException() { }
        public CourseHasNoUnitsException(string courseName)
            : base(String.Format("{0} has no units registered", courseName)) { }
    }
}
