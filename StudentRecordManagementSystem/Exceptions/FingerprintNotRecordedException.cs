using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecordManagementSystem.Exceptions
{
    [Serializable]
    public class FingerprintNotRecordedException: Exception
    {
        public FingerprintNotRecordedException()
            : base("Fingerprint not recorded") { }

        public FingerprintNotRecordedException(string email)
            : base(string.Format("Fingerprint for {0} not recorded", email)) { }
    }
}
