using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BioDataModel
    {
        private string surName;
        private string firstName;
        private string gender;
        private DateTime dob;
        private string passport;
        private string box;
        private string town;
        private string email;
        private string religion;
        private string village;
        private string location;
        private string county;
        private string phone;
                
        public string PPhone
        {
            get { return phone; }
            set { phone = value; }
        }


        public BioDataModel(
            string surName, string firstName, string gender, string phone, DateTime birth_date, string passport,
            string box, string town, string email, string religion, string village, string location, string county
            )
        {
            PSurname = surName;
            PFirstName = firstName;
            PGender = gender;
            PPhone = phone;
            PDOB = birth_date;
            PPassport = passport;
            PBox = box;
            PTown = town;
            PEmail = email;
            PReligion = religion;
            Pvillage = village;
            PLocation = location;
            PCounty = county;
        }
        public string PCounty
        {
            get { return county; }
            set { county = value; }
        }

        public string PLocation
        {
            get { return location; }
            set { location = value; }
        }


        public string Pvillage
        {
            get { return village; }
            set { village = value; }
        }


        public string PReligion
        {
            get { return religion; }
            set { religion = value; }
        }


        public string PEmail
        {
            get { return email; }
            set { email = value; }
        }


        public string PTown
        {
            get { return town; }
            set { town = value; }
        }


        public string PBox
        {
            get { return box; }
            set { box = value; }
        }

        public string PPassport
        {
            get { return passport; }
            set { passport = value; }
        }

        public DateTime PDOB
        {
            get { return dob; }
            set {
                if (value > DateTime.Now)
                    dob = DateTime.Now.AddYears(-10);
                else
                    dob = value;
            }
        }


        public string PGender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string PFirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string PSurname
        {
            get { return surName; }
            set { surName = value; }
        }

    }
}
