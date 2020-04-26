using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Enter value a");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value b");
                int b = Convert.ToInt32(Console.ReadLine());
                sum(a, b, out int c);
                Console.WriteLine(c);
                Console.ReadKey();
            }

        public static void sum(int a, int b, out int c)
        {
            c = a + b;
        }
        
    }
}
