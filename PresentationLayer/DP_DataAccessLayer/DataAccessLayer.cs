using Doctor_Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_DataAccessLayer
{
    public class DataAccessLayer
    {

        public void AddDoctor(Doctor doctor)
        {

            SqlConnection con = new SqlConnection("data source=.; database=DoctorPatient; integrated security=true");

            SqlCommand cmd = new SqlCommand("insertDoctor", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            cmd.Parameters.AddWithValue("@Doctor_Name", doctor._DoctorName);
            cmd.Parameters.AddWithValue("@Salary", doctor._Salary);
            cmd.ExecuteNonQuery();
            con.Close();       
        }
        
    }
}
