using BusinessLayer;
using EntityLayer;
using ExceptionLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresenationLayer
{
    class Presentation
    {
        public static IBusiness business = new Business();
        static void Main(string[] args)
        {

            bool flag = true;
            try
            {
                do
                {
                    Console.WriteLine("Enter your choice from below");
                    Console.WriteLine("Enter 1 to add Operator");
                    Console.WriteLine("Enter 2 to display operators");
                    Console.WriteLine("Enter 3 to add custome");
                    Console.WriteLine("Enter 4 to display customer");
                    Console.WriteLine("Enter 5 to export data to excel");
                    Console.WriteLine("Enter 6 to exit");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    Customer customer = new Customer();
                    switch (choice)
                    {
                        case 1:
                            AddOperators();
                            break;
                        case 2:
                            displayOperators();
                            break;
                        case 3:
                            AddCustomers();
                            break;
                        case 4:
                            displaymobileoperatorss();
                            break;
                        case 5:
                            exportToExcel();
                            break;
                        case 6:
                            flag = false;
                            Console.WriteLine("Thank you");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("You have entered wrong input");
                            break;
                    }

                } while (flag);
            }
            catch (InvalidData e)
            {
                Console.WriteLine(e.Message);
            }
            catch (RatingOverLoadedException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NoParametersException e)
            {                
                Console.WriteLine(e.Message);                
            }
            catch (InValidOperatorIdException e)
            {
                Console.WriteLine(e.Message);                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void AddOperators()
        {
            
            try
            {
                Console.Write("enter no. of Operators you want to add : ");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    MobileOperator mobileOperator = new MobileOperator();
                    Console.WriteLine("enter operator name ");
                    mobileOperator.OperatorName = Console.ReadLine();
                    Console.WriteLine("enter operator Rating ");
                    mobileOperator.OperatorRating = Convert.ToDecimal(Console.ReadLine());
                    business.AddOperator(mobileOperator);
                }
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("mobile Operator added successfully");
                    Console.WriteLine("--------------------------");
            }
            catch (InvalidData e)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine(e.Message);
                Console.WriteLine("--------------------------");

            }
            catch (RatingOverLoadedException e)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine(e.Message);
                Console.WriteLine("--------------------------");
            }
            catch(Exception e)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine(e.Message);
                Console.WriteLine("--------------------------");
            }
           
        }
        public static void displayOperators()
        {

            Console.WriteLine("operator details");
            try
            {
                Console.WriteLine("--------------------------");
                foreach (MobileOperator mobileOperator in business.mobileOperators())
                {
                    Console.Write(mobileOperator.OperatorId+"\t\t");
                    Console.Write(mobileOperator.OperatorName + "\t\t");
                    Console.Write(mobileOperator.OperatorRating + "\t\t");
                    Console.WriteLine();
                   
                }
                Console.WriteLine("--------------------------");

            }
            catch (NoParametersException e)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine(e.Message);
                Console.WriteLine("--------------------------");
            }
        }
        public static void AddCustomers()
        {
            String path = @"D:\Mobile.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            displayOperators();
            try
            {                
                    Customer customer = new Customer();
                    Console.WriteLine("enter Customer name ");
                    customer.CustomerName = Console.ReadLine();
                    Console.WriteLine("enter operator id ");
                    customer.OperatorId = new MobileOperator();
                    customer.OperatorId.OperatorId = Convert.ToInt32(Console.ReadLine());
                    business.AddCustomer(customer);
                    

            }
            catch (InValidOperatorIdException e)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine(e.Message);
                Console.WriteLine("--------------------------");

            }
        }
        public static void exportToExcel()
        {
            List<Customer> customers = new List<Customer>();
            customers = business.AllInfo();
            business.ExportToExcel(customers);
            Console.WriteLine("data exported to excel file successfully ");
        }           
        public static void displaymobileoperatorss()
        {
            decimal avg = business.displaymobileoperators();        
            List<MobileOperator> mobileOperators = business.mobileOperators();
            List<MobileOperator> mobiles = new List<MobileOperator>();
            foreach(MobileOperator item in mobileOperators)
            {
                if(item.OperatorRating>avg)
                {
                    mobiles.Add(item);
                }
            }
            foreach(MobileOperator item in mobiles)
            {
                Console.WriteLine(item.OperatorId);
                Console.WriteLine(item.OperatorRating);
                Console.WriteLine(item.OperatorName);                
            }
            Console.ReadKey();
        }
    }
}

   