using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProgram
{
    class Pattern
    {
        static void Main(string[] args)
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Enter your choice :\n 1. pattern 1 \n 2. pattern 2\n 3. exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        pattern1();
                        break;
                    case 2:
                        pattern2();
                        break;
                    case 3:
                        Console.WriteLine("Thank you");
                        Console.ReadKey();
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (flag);
        }
        static void pattern1()
        {
            Console.WriteLine("Enter number of rows");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of columns");
            int column = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<column;j++)
                {
                    if(j%2==0)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine();
            }
        }
        static void pattern2()
        {
            Console.WriteLine("Enter number");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= x; j++)
                {

                    if (i == 1 && j != x / 2 + 1 || j == x && i != x / 2 + 1 || i == x && j != x / 2 + 1 || j == 1 && i != x / 2 + 1)
                        Console.Write("1");
					else if (j == x / 2 + 1 && i == x / 2 + 1)
                        Console.Write("0");
					else
						Console.Write("0");
                }
                Console.WriteLine();
            }
            
        }
    }
}
