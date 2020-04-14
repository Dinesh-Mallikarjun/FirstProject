using System;
using System.Data.SqlClient;
namespace Ado2createtable
{
    class Program
        {
            static void Main(string[] args)
            {
            new Program().CreateTable();
            Console.ReadKey();
            }



            public void CreateTable()
            {
                SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database=SAMPLE; integrated security=SSPI");

                SqlCommand cm = new SqlCommand("create table student987(id int not null,name varchar(100), email varchar(50), join_date date)", con);
                SqlCommand cm1 = new SqlCommand("insert into student987(id, name, email, join_date)values('101', 'Ronald Trump', 'ronald@example.com', '1/12/2017')", con);
                SqlCommand cm2 = new SqlCommand("select * from student987", con);
                con.Open();
                cm.ExecuteNonQuery();
                cm1.ExecuteNonQuery();
                SqlDataReader sdr = cm2.ExecuteReader();
                while (sdr.Read())
                {
                 Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["email"] + " " + sdr["join_date"]);
                }
                 Console.WriteLine("Table created Successfully");
                 Console.ReadKey();
                }
                catch (Exception e)
                {
                 Console.WriteLine("OOPs, something went wrong." + e);
                }
                finally
                {
                 con.Close();
                }
            }
        }
    
}
