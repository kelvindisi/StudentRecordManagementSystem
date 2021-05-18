using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Futronic.SDKHelper;

namespace StudentRecordManagementSystem
{
    class FingerprintConfig
    {
        public static int FARNLevel { get; set; }
        public static int MaxModels { get; set; }
        public static bool detectFakeFinger { get; set; }
        public static bool MIOT { get; set; }
        public static bool FastMode { get; set; }
        public static int identificationLimit { get; set; }
        public static VersionCompatible version { get; set; }
    }
}
