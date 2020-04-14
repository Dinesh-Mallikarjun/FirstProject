using System;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adorevisit
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            Create();
            obj.InsertTable2();
            obj.InsertTable1();
        }

        public void InsertTable2()
        {
            string cs1 = "Data Source=.;DataBase=Business2;integrated security=SSPI";
            using (SqlConnection con = new SqlConnection(cs1))
            {
                bool flag = true;
                do
                {
                    Console.WriteLine("Enter Employee id:");
                    int Eid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Last name:");
                    string lname = Console.ReadLine();
                    Console.WriteLine("Enter First name:");
                    string fname = Console.ReadLine();
                    Console.WriteLine("enter birth date(yyyy-mm-dd)");
                    string date = Console.ReadLine();
                    Console.WriteLine("enter photo:");
                    string photo = Console.ReadLine();
                    Console.WriteLine("enter notes:");
                    string notes = Console.ReadLine();

                    string data = "insert into Employees1 values(" + Eid + ",'" + lname + "','" + fname + "','" + date + "','" + photo + "','" + notes + "')";
                    SqlCommand cmd = new SqlCommand(data, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Console.WriteLine("do you want to add more details(y/n):");
                    char ch = Console.ReadLine()[0];
                    if (ch == 'y' || ch == 'Y')
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }

                } while (flag);
            }
        }
        private void InsertTable1()
        {
            string cs1 = "Data Source=.;DataBase=Business2;integrated security=SSPI";
            using (SqlConnection con = new SqlConnection(cs1))
            {
                bool flag = true;
                do
                {
                    Console.WriteLine("Enter Order id:");
                    int Oid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter customer id:");
                    int Cid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter employee id:");
                    int Eid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter order date(yyyy-mm-dd)");
                    string date = Console.ReadLine();
                    Console.WriteLine("enter Shipper id:");
                    int Sid = Convert.ToInt32(Console.ReadLine());

                    string data = "insert into Orders values(" + Oid + "," + Cid + "," + Eid + ",'" + date + "'," + Sid + ")";
                    SqlCommand cmd = new SqlCommand(data, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Console.WriteLine("do you want to add more details(y/n):");
                    char ch = Console.ReadLine()[0];
                    if (ch == 'y' || ch == 'Y')
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }

                } while (flag);
            }
        }
        public static void Create()
        {
            string cs = "Data Source=.;DataBase=Business2;integrated security=SSPI";
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("Create Table Orders(OrderId int not null PRIMARY KEY,CustomerId int,EmployeeId int FOREIGN KEY references Employees(EmployeeId),OrderDate date,ShipperId int)", con);
                SqlCommand cmd1 = new SqlCommand("Create Table Employees1(EmployeeId int not null PRIMARY KEY,LastName varchar(50),FirstName varchar(50),BirthDate date,Photo varchar(50),Notes varchar(100))", con);
                con.Open();
               
                cmd1.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                Console.ReadKey();

            }

        }
    }
}

