using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codechallengeenggcamp
{
    interface addition
    {
        void add();


    }
    class Demo : addition
    {
        virtual public void add()
        {
            Console.WriteLine("class");
        }
    }
    class DEmo : Demo
    {
        override public void add()
        {
            Console.WriteLine("class1");
        }
        class Program
        {
            static void Main(string[] args)
            {
                Demo d = new Demo();
                d.add();

                Console.ReadKey();
            }
        }
    }
}
