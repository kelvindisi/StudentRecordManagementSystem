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
        public static BioDataModel getBioByEmail(string email)
        {
            BioDataModel bio = new BioDataModel();
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
                {
                    rd.Read();
                    bio.ID = rd.GetInt32("id");
                    bio.PFirstName = rd.GetString("first_name");
                    bio.PSurname = rd.GetString("surname");
                    bio.PGender = rd.GetString("gender");
                    bio.PDOB = rd.GetDateTime("date_of_birth");
                    bio.PPassport = rd.GetString("passport_no");
                    bio.PBox = rd.GetString("box");
                    bio.PTown = rd.GetString("town");
                    bio.PPhone = rd.GetString("phone");
                    bio.PEmail = rd.GetString("email");
                    bio.PReligion = rd.GetString("religion");
                    bio.Pvillage = rd.GetString("village");
                    bio.PLocation = rd.GetString("location");
                    bio.PCounty = rd.GetString("county");
                }
            }
            return bio;
        }
        public static BioDataModel getBioById(int id)
        {
            BioDataModel bio = new BioDataModel();
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM `student_bio` WHERE `id`=@id";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("id", id);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    bio.ID = rd.GetInt32("id");
                    bio.PFirstName = rd.GetString("first_name");
                    bio.PSurname = rd.GetString("surname");
                    bio.PGender = rd.GetString("gender");
                    bio.PDOB = rd.GetDateTime("date_of_birth");
                    bio.PPassport = rd.GetString("passport_no");
                    bio.PBox = rd.GetString("box");
                    bio.PTown = rd.GetString("town");
                    bio.PPhone = rd.GetString("phone");
                    bio.PEmail = rd.GetString("email");
                    bio.PReligion = rd.GetString("religion");
                    bio.Pvillage = rd.GetString("village");
                    bio.PLocation = rd.GetString("location");
                    bio.PCounty = rd.GetString("county");
                }
            }
            return bio;
        }
        public static List<BioDataModel> getStudentBio()
        {
            List<BioDataModel> students = new List<BioDataModel>();
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "SELECT * FROM `student_bio` WHERE 1 ORDER BY id DESC";
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    BioDataModel bio = new BioDataModel();
                    bio.ID = rd.GetInt32("id");
                    bio.PEmail = rd.GetString("email");
                    bio.PFirstName = rd.GetString("first_name");
                    bio.PSurname = rd.GetString("surname");
                    bio.PGender = rd.GetString("gender");
                    students.Add(bio);
                }

            }
            return students;
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

        public static void updateBioData(BioDataModel bioData)
        {
            BioDataModel oldBio = getBioByEmail(bioData.PEmail);
            if (oldBio.ID != 0 && oldBio.ID != bioData.ID)
                throw new StudentAlreadyExistsException(bioData.PEmail);
            saveUpdateBioData(bioData);
        }

        private static void saveUpdateBioData(BioDataModel bioData)
        {
            using (conn = new MySqlConnection(getConnectionString()))
            {
                conn.Open();
                string query = "UPDATE `student_bio` SET `surname`=@surname,"
                    + "`first_name`=@firstName,`gender`=@gender,`date_of_birth`=@dob,"
                    + "`passport_no`=@passport,`box`=@box,`town`=@town,"
                    + "`phone`=@phone,`email`=@email,`religion`=@religion,"
                    + "`village`=@village,`location`=@location,`county`=@county "
                    + "WHERE `id`=@id";
                cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Prepare();
                cmd.Parameters.AddWithValue("surname", bioData.PSurname);
                cmd.Parameters.AddWithValue("firstName", bioData.PFirstName);
                cmd.Parameters.AddWithValue("gender", bioData.PGender);
                cmd.Parameters.AddWithValue("dob", bioData.PDOB);
                cmd.Parameters.AddWithValue("passport", bioData.PPassport);
                cmd.Parameters.AddWithValue("box", bioData.PBox);
                cmd.Parameters.AddWithValue("town", bioData.PTown);
                cmd.Parameters.AddWithValue("phone", bioData.PPhone);
                cmd.Parameters.AddWithValue("email", bioData.PEmail);
                cmd.Parameters.AddWithValue("religion", bioData.PReligion);
                cmd.Parameters.AddWithValue("village", bioData.Pvillage);
                cmd.Parameters.AddWithValue("location", bioData.PLocation);
                cmd.Parameters.AddWithValue("county", bioData.PCounty);
                cmd.Parameters.AddWithValue("id", bioData.ID);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
