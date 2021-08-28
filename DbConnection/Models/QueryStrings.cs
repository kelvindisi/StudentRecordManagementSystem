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
        public static string attendanceSummary = "SELECT enrollment.regNo, student_bio.first_name, "
            + "student_bio.surname, COUNT(attendance.registration_id) AS 'attendance' "
            + "FROM attendance RIGHT JOIN class_session ON attendance.class_session_id = class_session.id "
            + "RIGHT JOIN session_units ON class_session.session_unit_id = session_units.id "
            + "RIGHT JOIN registered_units ON session_units.id = registered_units.session_unit_id "
            + "RIGHT JOIN enrollment ON registered_units.student_id = enrollment.id RIGHT JOIN student_bio "
            + "ON enrollment.student_id = student_bio.id WHERE session_units.session_id= @sess "
            + "AND session_units.id= @sess_unit GROUP BY attendance.registration_id";
    }
}
