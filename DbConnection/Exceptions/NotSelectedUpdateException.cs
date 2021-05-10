using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Exceptions
{
    [Serializable]
    public class NotSelectedUpdateException : Exception
    {
        public NotSelectedUpdateException()
            :base("Select item first before you update"){ }

        public NotSelectedUpdateException(string item)
            : base(String.Format("Please select {0} to update", item)) { }
    }
}
