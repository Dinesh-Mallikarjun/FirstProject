using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number:");
          
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("addition is:"+add(a,b));
            Console.ReadKey();
        }
        static int add(int a,int b)
        {
            int c = a + b;
            return c;
        }

    }
}
