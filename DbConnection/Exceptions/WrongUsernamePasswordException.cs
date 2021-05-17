using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Exceptions
{
    [Serializable]
    class WrongUsernamePasswordException: Exception
    {
        public WrongUsernamePasswordException()
            :base("Wrong username or password") { }
    }
}
