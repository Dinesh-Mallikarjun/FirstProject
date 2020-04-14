using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionLayer;
namespace DataAcessLayer
{
    public class DataAcess
    {
        static SqlConnection con = new SqlConnection("data source=.; database=Doctor; integrated security=true");
        public void AddDoctor(Doctor doctor)
        {          
                SqlCommand cmd = new SqlCommand("insertDoctor", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@DoctorName", doctor.DoctorName);
                cmd.Parameters.AddWithValue("@DoctorSalary", doctor.Salary);
                cmd.ExecuteNonQuery();
                con.Close();              
        }
        public void AddPatient(Patient patient)
        {
            try {
                //SqlConnection con = new SqlConnection("data source=.; database=Doctor; integrated security=true");
                SqlCommand cmd = new SqlCommand("insertPatient", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@PatientName", patient.PatientName);
                cmd.Parameters.AddWithValue("@DoctorId", patient.DoctorId);
                cmd.Parameters.AddWithValue("@PatientBill", patient.PatientBill);               
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(SqlException e)
            {
                throw new InvalidData("You have entered invalid data",e); 
            }
        }
        public List<Patient> GetPatientDetials(int id)
        {
            //SqlConnection con = new SqlConnection("data source=.; database=Doctor; integrated security=true");
            SqlCommand cmd = new SqlCommand("Search_Patient", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", id);
            List<Patient> patients = new List<Patient>();
            con.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Patient patient = new Patient();
                patients.Add(patient);
                patient.PatientName = (string)sqlDataReader["PatientName"];                
            }
            return patients;
        }
        public List<Doctor> GetDoctorName(string name)
        {
            SqlConnection con = new SqlConnection("data source=.; database=Doctor; integrated security=true");
            List<Doctor> doctors = new List<Doctor>();
            SqlCommand cmd = new SqlCommand("search_docto", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PatientName", name);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Doctor doctor = new Doctor();
                doctor.DoctorName = (string)rd["DoctorName"];
                doctors.Add(doctor);
            }
            con.Close();
            return doctors;
        }
        public List<Doctor> DisplayDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();
            SqlCommand cmd = new SqlCommand("getdoctors", con);
            cmd.CommandType = CommandType.StoredProcedure;            
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Doctor doctor = new Doctor();
                doctor.DoctoreId = (int)rd["Doctoreid"];
                doctor.DoctorName = (string)rd["DoctorName"];
                doctor.Salary = (int)rd["Salary"];
                doctors.Add(doctor);
            }
            con.Close();
            return doctors;
        }
    }
}
