using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhileMenuDriven
{
    class Pyramid
    {
        static void Main(string[] args)
        {
            bool flag = true;
            Start:
            do
            {
                Console.WriteLine("Enter your choice :  \n 1.Factorial \n 2. print pyramid \n3. prime number\n 4. exit");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Enter number");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Factorial of a number is : " + factorial(x));
                        break;
                    case 2:
                        pyramid();
                        break;
                    case 3:
                        primeNumber();
                        break;
                    case 4:
                        flag = false;
                        Console.WriteLine("Thank you");
                        break;
                    default:
                        Console.WriteLine("you have entered invalid choice please enter valid choice : ");
                        goto Start;
                }
            } while (flag);
        }
        static int factorial(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        static void pyramid()
        {
            Console.WriteLine("Enter number of rows : ");
            int row = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < row; i++)
            {
                for (int j = 1; j <= row - i; j++)

                    Console.Write(" ");

                for (int k = 1; k <= 2 * i - 1; k++)

                    Console.Write("*");
                Console.Write("\n");
            }                  
            Console.ReadKey();

        }
        static bool primeNumber()
        {
            bool isPrime = true;
            Console.WriteLine("Enter a number ");
            int high = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= high; i++)
            {
                for (int j = 2; j <= high; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    Console.WriteLine(i + " ");
                isPrime = true;
            }
            Console.ReadKey();
            return false;
        }
    }
}