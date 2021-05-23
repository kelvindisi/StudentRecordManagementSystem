namespace DataAccess.Models
{
    public class EnrollmentModel
    {
        private int id;
        private BioDataModel student;
        private CourseModel course;
        private string regNo;
        private int enrollmentYear;

        
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public BioDataModel Student
        {
            get { return student; }
            set { student = value; }
        }
        public CourseModel Course
        {
            get { return course; }
            set { course = value; }
        }
        public string RegistrationNo
        {
            get { return regNo; }
            set { regNo = value; }
        }
        public int EnrollmentYear
        {
            get { return enrollmentYear; }
            set { enrollmentYear = value; }
        }

    }
}
