using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace employeedata
{
   public  class Employee
    {
     
            private static void Main(string[] args)
            {
                new Employee().Create();
                Console.ReadKey();
            }

            public void Create()
            {
            SqlConnection con = null;
                try
                { con = new SqlConnection("data source=.; database=Example; integrated security=SSPI");                    
                    string query = "Create table EmployeeDetails12(name varchar ,id int primary key,age int,salary int)";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
                catch (InvalidSqlException e)
                {
                    Console.WriteLine("Something went wrong");
                }
                finally
                {
                    con.Close();
                }
                Console.WriteLine("Created table");

            }
            //public void Insert(EmployeeEntity obj)
            //{
            //    sqlconnection();
            //    string query = "insert into EmployeeDetails values('" + obj.Name+"' ,"+obj.Id+","+obj.Age+")";
            //    try
            //    {
            //        connection.Open();
            //        SqlCommand cmd1 = new SqlCommand(query, connection);
            //        cmd1.ExecuteNonQuery();
            //    }
            //    finally
            //    {
            //        connection.Close();
            //    }
            //}
        }
    }