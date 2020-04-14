using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Menudriven
    {
        static void Main(string[] args)
        {
            bool flag = true;
             
           
            do
            {
                Console.WriteLine("Enter your choice :  \n 1. print prime number from 1 to 100\n 2. reverse a digit \n 3. pattern \n 4. exit");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Printing prime numbers from 1 to 100");
                        primeNumber();
                        break;
                    case 2:
                        reverse();
                        break;
                    case 3:
                        pattern();
                        break;
                    case 4:
                        Console.WriteLine("Thank you...");
                        Console.ReadKey();
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("You have entered the invalid choice please enter valid choice");
                        break;
                }
            } while (flag);
        }
        static bool primeNumber()
        {
            bool isPrime = true;
            for(int i=2;i<=100;i++)
            {
                for(int j=2;j<=100;j++)
                {
                    if(i!=j&& i%j==0)
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
        static int reverse()
        {
            Console.WriteLine("Enter a number ");
            int number = Convert.ToInt32(Console.ReadLine());
            int rev = 0,rem;
            while (number != 0)
            {
                rem = number % 10;
                rev = rev * 10 + rem;
                number = number / 10;
            }
            Console.WriteLine("Reverse of number is :"+rev);
            Console.ReadKey();
            return rev;
        }
        static void pattern()
        {
            Console.WriteLine("Enter number of rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=rows;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
