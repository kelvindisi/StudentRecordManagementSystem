using System.IO;
using StudentRecordManagementSystem.Exceptions;

namespace StudentRecordManagementSystem.Futronic
{
    public class FingerprintManager
    {
        public static void renameFingerPrint(DbName db, string old, string latest)
        {
            FingerPrintScanner.kDbName = db.ToString();
            string path = FingerPrintScanner.GetDatabaseDir();
            checkDirectory(path);
            checkFingerprintExists(path, old);
            renameFile(path, old, latest);
        }
        public static string validFileName(string invalidFileName)
        {
            string fileName = invalidFileName.Replace(".", "-");
            return fileName;
        }
        private static void renameFile(string path, string old, string latest)
        {
            string oldPath = Path.Combine(path, validFileName(old));
            string newPath = Path.Combine(path, validFileName(latest));

            File.Move(oldPath, newPath);
        }
        public static void checkFingerprintExists(string email, DbName db)
        {
            FingerPrintScanner.kDbName = db.ToString();
            string path = FingerPrintScanner.GetDatabaseDir();

            checkFingerprintExists(path, email);
        }
        private static void checkFingerprintExists(string path, string email)
        {
            string oldPath = Path.Combine(path, validFileName(email));
            if (!File.Exists(oldPath))
            {
                throw new FingerprintNotRecordedException(email);
            }
        }

        private static void checkDirectory(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }
    }
}
