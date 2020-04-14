using System;
using System.Data.SqlClient;
namespace ADOR1evisted
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().CreateTable();
            new Program().insertValues();
            new Program().delete();
            //new Program().updateTable();
            Console.ReadKey();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database= assignment; integrated security=SSPI");
                SqlCommand cm = new SqlCommand("create table Orderss123(Orderid int not null primary key,Customerid int not null,Emoloyeeid int not null, Order_date date,Shipperid int not null)", con);
                SqlCommand cm1 = new SqlCommand("create table Employeess123(Employeeid int not null primary key,lastname varchar(30),firstname varchar(30), Birth_date date,photo varchar(20),notes varchar(200))", con);
                con.Open();
                cm.ExecuteNonQuery();
                cm1.ExecuteNonQuery();

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
        public void insertValues()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database= assignment; integrated security=SSPI");

                SqlCommand cm2 = new SqlCommand("insert into Orderss123 values('102422', '4', '9','04/27/1996','54')", con);
                SqlCommand cm3 = new SqlCommand("insert into Orderss123 values('102423', '5', '6','07/20/1996','56')", con);
                SqlCommand cm4 = new SqlCommand("insert into Orderss123 values('102424', '6', '87','07/17/1997','55')", con);
                SqlCommand cm5 = new SqlCommand("insert into Orderss123 values('102425', '7', '4','07/07/1998','53')", con);
                SqlCommand cm6 = new SqlCommand("insert into Orderss123 values('102426', '8', '23','05/27/1999','57')", con);

                SqlCommand cm7 = new SqlCommand("insert into Employeess123 values('1','Simon', 'philip','12/19/1970','emplld4.pic','philp has good communication skill')", con);
                SqlCommand cm8 = new SqlCommand("insert into Employeess123 values('2','maik', 'callahan','12/12/1971','emplld5.pic','callahan has good skill')", con);
                SqlCommand cm9 = new SqlCommand("insert into Employeess123 values('3','haybe', 'Davolio','02/13/1972','emplld6.pic','davolio has good thinking skill')", con);
                SqlCommand cm10 = new SqlCommand("insert into Employeess123 values('4','cury', 'Fuller','01/03/1973','emplld7.pic','cury is smart ')", con);
                SqlCommand cm11 = new SqlCommand("insert into Employeess123 values('5','massy', 'king','03/05/1974','emplld8.pic','massy has good dancing skill')", con);
                SqlCommand cm12= new SqlCommand("insert into Employeess123 values('6','varun', 'leverling','04/16/1975','emplld14.pic','varun has pure communication skill')", con);
                SqlCommand cm13 = new SqlCommand("insert into Employeess123 values('7','david', 'peacock','05/18/1976','emplld11.pic','david is a good player')", con);
                SqlCommand cm14 = new SqlCommand("insert into Employeess123 values('8','vilson', 'suyama','06/18/19707','emplld12.pic','suyama talks too much ')", con);

                con.Open();

                cm2.ExecuteNonQuery();
                cm3.ExecuteNonQuery();
                cm4.ExecuteNonQuery();
                cm5.ExecuteNonQuery();
                cm6.ExecuteNonQuery();
                cm7.ExecuteNonQuery();
                cm8.ExecuteNonQuery();
                cm9.ExecuteNonQuery();
                cm10.ExecuteNonQuery();
                cm11.ExecuteNonQuery();
                cm12.ExecuteNonQuery();
                cm13.ExecuteNonQuery();
                cm14.ExecuteNonQuery();
                Console.WriteLine("values inserted Successfully");
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
        /*
        public void displayTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database= assignment; integrated security=SSPI");
                SqlCommand cm15 = new SqlCommand("update employees123 set photo=empid_new.pic where lastname ='Fuller' ", con);
                con.Open();
                cm15.ExecuteReader();


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


        */

        
        public void delete()
        {
            SqlConnection con = null;
            try
            {

                con = new SqlConnection("data source=.; database= assignment; integrated security=SSPI");
                
                SqlCommand cm = new SqlCommand("delete from Orderss123 where Shipperid = '2'", con);
              
                con.Open();
               
                cm.ExecuteNonQuery();

                Console.WriteLine("Record Deleted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }

    }
}



