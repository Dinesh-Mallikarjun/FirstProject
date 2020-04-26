using Mobile_BusinessLayer;
using Mobile_EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_PresentationLayer
{
    public class Presentation
    {
        public static Business business = new Business();
        static void Main(string[] args)
        {
            bool flag = true;
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
                    switch (choice)
                    {
                        case 1:
                            AddOperators();
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
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
        }

        public static void AddOperators()
        {
            Console.Write("enter no. of Operators you want to add : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n; i++)
            {
                MobileOperator mobileOperator = new MobileOperator();
                Console.WriteLine("enter opeartor name ");
                mobileOperator.OperatorName = Console.ReadLine();
                Console.WriteLine("enter opeartor Rating ");
                mobileOperator.OperatorRating = Convert.ToDecimal(Console.ReadLine());
                business.AddOperator(mobileOperator);
            }
        }
    }
}
