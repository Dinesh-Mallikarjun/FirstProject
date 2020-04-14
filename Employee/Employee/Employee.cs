using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Employee
{
    public class Employee
    {
        private SqlConnection connection;

        private void sqlconnection()
        {
            string constr = ConfigurationManager.ConnectionStrings["Connection"].ToString();
            connection = new SqlConnection(constr);
        }

        //private static void Main(string[] args)
        //{
        //    new Employee().Create();
        //    Console.ReadKey();
        //}

        //public void Create()
        //{
        //    sqlconnection();
        //    string query = "Create table EmployeeDetails(name varchar ,id int primary key,age int)";
        //    try
        //    {
        //        connection.Open();
        //        SqlCommand cmd = new SqlCommand(query, connection);
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (InvalidSqlException e)
        //    {
        //        Console.WriteLine("Something went wrong");
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    Console.WriteLine("Created table");
          
        //}
        public void Insert(EmployeeEntity obj)
        {
            sqlconnection();
            string query = "insert into EmployeeDetails values('" + obj.Name + "' ," + obj.Id + "," + obj.Age + ")";
            try
            {
                connection.Open();
                SqlCommand cmd1 = new SqlCommand(query, connection);
                cmd1.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }
    }
}