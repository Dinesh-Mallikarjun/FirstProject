using MVCEmployee.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVCEmployee.Repository
{
    public class EmpRepository
    {

        private SqlConnection con;
       
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["myConnection"].ToString();
            con = new SqlConnection(constr);
        }
        public bool AddEmployee(Employee obj)
        {

            connection();
            SqlCommand com = new SqlCommand("AddNewEmpDetails", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Name", obj.Name);
            com.Parameters.AddWithValue("@City", obj.City);
            com.Parameters.AddWithValue("@Address", obj.Address);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            { 
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Employee> GetAllEmployees()
        {
            connection();
            List<Employee> EmpList = new List<Employee>();
            SqlCommand com = new SqlCommand("GetEmployees", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {

                EmpList.Add(
                    new Employee
                    {
                        Empid = Convert.ToInt32(dr["Id"]),
                        Name = Convert.ToString(dr["Name"]),
                        City = Convert.ToString(dr["City"]),
                        Address = Convert.ToString(dr["Address"])
                    }
                    );
            }
            return EmpList;
        }
    }
}