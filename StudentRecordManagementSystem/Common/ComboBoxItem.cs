using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecordManagementSystem
{
    class ComboBoxItem
    {
        protected String _msg;
        protected Object _tag;
        
        public ComboBoxItem(string msg, Object tag)
        {
            this._msg = msg;
            this._tag = tag;
        }
        public override string ToString()
        {
            return this._msg;
        }
        public string Message
        {
            get {
                return _msg;
            }
        } 
        public Object Tag
        {
            get
            {
                return _tag;
            }
        }
    }
}
