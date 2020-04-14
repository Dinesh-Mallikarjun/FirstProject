using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    interface demo
    {
        void print();
    }
    class Demo1 : demo
    {
        public virtual void print()
        {
            Console.WriteLine("Hello");
        }

    }
    class Demo2 : Demo1
    {
        public  override void print()
        {
            Console.WriteLine("World");
        }
        public  void print1()
        {
            Console.WriteLine("good night");
        }

        class Program
        {
            static void Main(string[] args)
            {
                Demo2 d2 = new Demo2();
                d2.print();
                d2.print1();
                Console.ReadKey();
            }
        }
    }
}
