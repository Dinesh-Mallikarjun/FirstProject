using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionLayer;

namespace DataAccessLayer
{
    public class DataAccess : IDataAccess
    {
        public void AddCollege(College college)
        {
            SqlConnection connection = new SqlConnection("data source=.; database=ClgDatabase; integrated security=true");
            SqlCommand sqlCommand = new SqlCommand("AddCollegeDetails", connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            connection.Open();
            sqlCommand.Parameters.AddWithValue("@CollegeName",college.CollegeName);
            sqlCommand.Parameters.AddWithValue("@Location", college.Location);
            sqlCommand.Parameters.AddWithValue("@CutOff", college.CutOff);
            sqlCommand.Parameters.AddWithValue("@NoOfAvailableSeats", college.NoOfAvailableSeats);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }
        //public List<College> colleges(College college)
        //{
        //    SqlConnection connection = new SqlConnection("data source=.; database=ClgDatabase; integrated security=true");
        //    SqlCommand sqlCommand = new SqlCommand("", connection);
        //    sqlCommand.CommandType = CommandType.StoredProcedure;
        //    connection.Open();

        //    connection.Close();
        //    return colleges;
        //}
        public void AddStudent(Student student)
        {
            int i = 0;
            SqlConnection con = new SqlConnection("data source=.; database=ClgDatabase; integrated security=true");
            SqlCommand cmd = new SqlCommand($"select NoOfAvailableSeats from College where CollegeId ='{student.CollegeId}'", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            
            while(sdr.Read())
            {
                i = (int)sdr["NoOfAvailableSeats"];
            }
            con.Close();
            if (i > 0)
            {
                SqlConnection conn = new SqlConnection("data source=.; database=ClgDatabase; integrated security=true");
                SqlCommand cmdd = new SqlCommand($"Update College set NoOfAvailableSeats = NoOfAvailableSeats-1 where CollegeId = {student.CollegeId}", conn);
                conn.Open();
                cmdd.ExecuteNonQuery();
                conn.Close();
                SqlConnection connection = new SqlConnection("data source=.; database=ClgDatabase; integrated security=true");
                SqlCommand sqlCommand = new SqlCommand("AddStudent", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                connection.Open();
                sqlCommand.Parameters.AddWithValue("@StudentName", student.StudentName);
                sqlCommand.Parameters.AddWithValue("@ObtainedPercentage", student.ObtainedPercentage);
                sqlCommand.Parameters.AddWithValue("@CollegeId", student.CollegeId);
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
        }

        public List<Student> displaystudents(int id)
        {
            try
            {
                SqlConnection connection = new SqlConnection("data source=.; database=ClgDatabase; integrated security=true");
                SqlCommand sqlCommand = new SqlCommand("Displaystudentdetailssss", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@ID", id);
                List<Student> students = new List<Student>();
                connection.Open();

                SqlDataReader sdr = sqlCommand.ExecuteReader();
                while (sdr.Read())
                {
                    Student student = new Student();
                    student.Studentid = (int)sdr["StudentId"];
                    student.StudentName = (string)sdr["StudentName"];
                    student.CollegeId = (int)sdr["CollegeId"];
                    student.ObtainedPercentage = (int)sdr["ObtainedPercentage"];
                    students.Add(student);
                }
                return students;
            }
            catch(SqlException e)
            {
                throw new InvalidCollegeId("Invalid college id ",e);
            }
        }

        public List<College> DisplayColleges(College clg)
        {
            SqlConnection connection = new SqlConnection("data source=.; database=ClgDatabase; integrated security=true");
            SqlCommand sqlCommand = new SqlCommand("DisplayCollegess", connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;           
            List<College> colleges= new List<College>();
            connection.Open();

            SqlDataReader sdr = sqlCommand.ExecuteReader();
            while (sdr.Read())
            {
                College college = new College();
                colleges.Add(college);
                college.CollegeName = (string)sdr["CollegeName"];
                college.Location = (string)sdr["Location"];
                college.CutOff = (int)sdr["CutOff"];
                college.NoOfAvailableSeats = (int)sdr["NoOfAvailableSeats"];             

            }
            connection.Close();
            return colleges;
        }

        public List<College> Display()
        {
            SqlConnection connection = new SqlConnection("data source=.; database=ClgDatabase; integrated security=true");
            SqlCommand sqlCommand = new SqlCommand("Display", connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            List<College> colleges = new List<College>();
            connection.Open();

            SqlDataReader sdr = sqlCommand.ExecuteReader();
            while (sdr.Read())
            {
                College college = new College();
                college.CollegeName = (string)sdr["CollegeName"];
                college.Location = (string)sdr["Location"];
                college.CutOff = (int)sdr["CutOff"];
                college.CollegeId = (int)sdr["CollegeId"];
                college.NoOfAvailableSeats = (int)sdr["NoOfAvailableSeats"];
                colleges.Add(college);
            }
            connection.Close();
            return colleges;
        }

         public   List<Student> studentsbelow50()
        {
            SqlConnection connection = new SqlConnection("data source=.; database=ClgDatabase; integrated security=true");
            SqlCommand sqlCommand = new SqlCommand("displaystudentsabove50per", connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            List<Student> students = new List<Student>();
            connection.Open();

            SqlDataReader sdr = sqlCommand.ExecuteReader();
            while (sdr.Read())
            {
                Student student = new Student();
                students.Add(student);
                student.Studentid = (int)sdr["StudentId"];
                student.StudentName = (string)sdr["StudentName"];
                student.ObtainedPercentage = (int)sdr["ObtainedPercentage"];
                student.CollegeId = (int)sdr["CollegeId"];
            }
            return students;     
          }

        public void delete(int id)
        {
            SqlConnection connection = new SqlConnection("data source=.; database=ClgDatabase; integrated security=true");
            SqlCommand sqlCommand = new SqlCommand("deletestudent", connection);
            
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@StudentId", id);
            connection.Open();           
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

    }
}
