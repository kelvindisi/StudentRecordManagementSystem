using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Futronic.SDKHelper;
using System.IO;

namespace DataAccess
{
    public class BiometricData
    {
        private static bool detectFakeFinger = true;
        public static bool fastMode = false;
        public static bool MIOT = false;
        public static int max_frame = 5; 

        public static bool DetectFakeFinger()
        {
            return detectFakeFinger;
        }
        public static FarnValues getFARnLevel()
        {
            return FarnValues.farn_normal;
        }
        public static VersionCompatible getCompatibleVersion()
        {
            return VersionCompatible.ftr_version_current;
        }
        public static String GetDatabaseDir(string kCompanyName, string kProductName, string kDbName)
        {
            String szDbDir;
            szDbDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments, Environment.SpecialFolderOption.Create);
            szDbDir = Path.Combine(szDbDir, kCompanyName);
            if (!Directory.Exists(szDbDir))
            {
                Directory.CreateDirectory(szDbDir);
            }
            szDbDir = Path.Combine(szDbDir, kProductName);
            if (!Directory.Exists(szDbDir))
            {
                Directory.CreateDirectory(szDbDir);
            }

            szDbDir = Path.Combine(szDbDir, kDbName);
            if (!Directory.Exists(szDbDir))
            {
                Directory.CreateDirectory(szDbDir);
            }

            return szDbDir;
        }

    }
}
