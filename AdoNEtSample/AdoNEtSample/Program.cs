using System;
using System.Data.SqlClient;
namespace AdoNetConsoleApplication
{
    class Program
    {
        private static void Main(string[] args)
        { 
       
     
            SqlConnection con = null;
            try
            {
              
                con = new SqlConnection("data source=.; database=SAMPLE; integrated security=SSPI");
                
                SqlCommand cm = new SqlCommand("Select * from Country", con);
               
                con.Open();
                
                SqlDataReader sdr = cm.ExecuteReader();
                
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["CountryId"] + " " + sdr["CountryName"] ); // Displaying Record  
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
                Console.ReadKey();
            }
            
            finally
            {
                con.Close();
            }
        }
    }
}