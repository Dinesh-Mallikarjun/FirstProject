using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int m = Convert.ToInt32(Console.ReadLine());
            int y = evenOrodd(m);
            if (y != 1)
                Console.WriteLine("It is odd");
            else
                Console.WriteLine("It is Even");
            Console.WriteLine(ReadTenTimes());
            Console.ReadKey();
        }
        public static int evenOrodd(int a)
        {
            if (a % 2 == 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        static string ReadTenTimes()
        {
            Console.WriteLine("Enter string:");
            String str = Console.ReadLine();
            for(int i=0;i<10;i++)
            {
                Console.WriteLine(str);
            }
            return str;
        }
    }
}
