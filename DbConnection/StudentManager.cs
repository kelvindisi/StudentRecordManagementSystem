using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Collections;
using DataAccess.Models;
using DataAccess.Exceptions;

namespace DataAccess
{
    public class StudentManager : DbConnector
    {
        public static void bioDataExists(string email)
        {
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM `student_bio` WHERE `email`=@email";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("email", email);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                    throw new StudentAlreadyExistsException(email);
            }
        }
        public static bool saveBioData(BioDataModel BioData)
        {
            string query = "INSERT INTO `student_bio`(`surname`, `first_name`, `gender`, `date_of_birth`, `passport_no`, `box`, `town`, `phone`, `email`, `religion`, `village`, `location`, `county`)"
                + "VALUES (@surname,@firstName,@gender,@dob,@passport,@box,@town,@phone,"
                + "@email,@religion,@village,@location,@county)";
            bioDataExists(BioData.PEmail); //check biodata exists
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("surname", BioData.PSurname);
                cmd.Parameters.AddWithValue("firstName", BioData.PFirstName);
                cmd.Parameters.AddWithValue("gender", BioData.PGender);
                cmd.Parameters.AddWithValue("dob", BioData.PDOB);
                cmd.Parameters.AddWithValue("passport", BioData.PPassport);
                cmd.Parameters.AddWithValue("box", BioData.PBox);
                cmd.Parameters.AddWithValue("town", BioData.PTown);
                cmd.Parameters.AddWithValue("phone", BioData.PPhone);
                cmd.Parameters.AddWithValue("email", BioData.PEmail);
                cmd.Parameters.AddWithValue("religion", BioData.PReligion);
                cmd.Parameters.AddWithValue("village", BioData.Pvillage);
                cmd.Parameters.AddWithValue("location", BioData.PLocation);
                cmd.Parameters.AddWithValue("county", BioData.PCounty);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            return false;
        }

        public static void deleteBioData(string email)
        {
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "DELETE FROM student_bio WHERE email=@email";
                cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.Parameters.AddWithValue("email", email);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
