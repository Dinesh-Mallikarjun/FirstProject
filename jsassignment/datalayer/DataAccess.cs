using entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalayer
{
    public class DataAccess
    {
        static SqlConnection con = new SqlConnection("data source=.; database=addDetails; integrated security=true");
        public void AddDemo(demoentity d)
        {
            SqlCommand cmd = new SqlCommand("insertdemo1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@firstname", d.firstname);
            cmd.Parameters.AddWithValue("@lastname", d.lastname);
            cmd.Parameters.AddWithValue("@email", d.email);
            cmd.Parameters.AddWithValue("@phone", d.phone);
            cmd.Parameters.AddWithValue("@password", d.password);
            cmd.Parameters.AddWithValue("@confirmpassword", d.confirmpassword);
            cmd.Parameters.AddWithValue("@description", d.description);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
