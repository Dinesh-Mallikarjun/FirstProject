using EntityLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Reaserch_DataAccess_Layer
{
    public class DataAccess
    {
        private SqlConnection connection;

        private void sqlconnection()
        {
            string constr = ConfigurationManager.ConnectionStrings["connection"].ToString();
            connection = new SqlConnection(constr);
        }
        public void AddDisease(Disease disease)
        {
            sqlconnection();
            SqlCommand cmd = new SqlCommand("AddDisease", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();
            cmd.Parameters.AddWithValue("@Disease_name", disease.Disease_name);
            cmd.Parameters.AddWithValue("@severity", disease.severity);
            cmd.Parameters.AddWithValue("@cause", disease.cause);
            cmd.Parameters.AddWithValue("@Disease_description", disease.Disease_description);
            cmd.ExecuteNonQuery();
            connection.Close();          
        }
    }
}
