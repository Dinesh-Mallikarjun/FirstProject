using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, c;
            a = 1;
            b = 2;
            c = 0;
             for (int i = 0; i < 10; i++)
            {
                a++;
                b *= 2;
                c = a + b;
            }         
        }
    }
}
