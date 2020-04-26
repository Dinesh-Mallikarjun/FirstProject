using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAlloc
{
    class Program
    {
        public static unsafe void Main(string[] args)
        {
            int a = 15;
            int* pointer = stackalloc int[10];
            for(int i=0;i<4;i++)
            {
                a = a + 5;
                pointer[i] = a;
                Console.WriteLine(a);
                Console.WriteLine(*(pointer + i));
            }
            Console.ReadKey();
        }
              
    }
}
