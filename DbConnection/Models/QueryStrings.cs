using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class QueryStrings
    {
        public static string studentRecordCard = "SELECT enrollment.regNo, first_name, surname, email,"
                    + "unit_code, unit_name, CEIL(semester/2) as year, semester, "
                    + "COALESCE(score,0) AS score, COALESCE(outof,1) AS outof "
                    + "FROM registered_units JOIN session_units ON "
                    + "registered_units.session_unit_id = session_units.id "
                    + "JOIN enrollment ON enrollment.id = "
                    + "registered_units.student_id JOIN student_bio ON "
                    + "student_bio.id = enrollment.student_id JOIN units ON "
                    + "units.id = session_units.unit_id LEFT JOIN assessment "
                    + "ON assessment.registered_id = registered_units.id "
                    + "WHERE registered_units.id = @regId";

        public static string SessionCounter = "SELECT COUNT(class_session.id) "
            + "AS count FROM class_session WHERE class_session.session_unit_id "
            +  "IN(SELECT registered_units.session_unit_id "
            + "FROM registered_units WHERE id = @regId)";
        public static string AttendedCounter = "SELECT COUNT(id) AS count "
            + "FROM attendance WHERE registration_id=@regId";
        public static string saveScore = "INSERT INTO `assessment`"
            + "(`registered_id`, `score`, `outof`) "
            + "VALUES (@regId, @score, @outof)";
        public static string deleteScore = "DELETE FROM `assessment` WHERE registered_id=@regId";
    }
}
