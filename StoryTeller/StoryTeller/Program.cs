using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
        Start:
            do {
                Console.WriteLine("Enter your choice :\n 1.pyramid \n2.exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter a character:");
                        char ch = Convert.ToChar(Console.ReadLine());
                        int n= typeCast(ch);                       
                        pyramid(n);
                        break;
                    case 2:
                        flag = false;
                        Console.WriteLine("Thank you....");
                        break;
                    default:
                        Console.WriteLine("You have entered invalid choice please enter valid choice");
                        goto Start;
                }

            } while (flag);
        }
        public static int typeCast(char ch1)
        {
            int a = 0;
            if (ch1 >= 'a' && ch1 <= 'z')
            {
                 a = ch1 - 32;
            }
            else
            {
                 a = ch1;
            }
            return a;
        }
        public static void pyramid(int n)
        {
           
            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)

                    Console.Write(" ");

                for (int k = 1; k <= 2 * i - 1; k++)

                    Console.Write(n);
                Console.Write("\n");
            }
            Console.ReadKey();

  
        }
    }
    
}
