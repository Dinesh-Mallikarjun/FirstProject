using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2
{
    public abstract class Demo
    {             
        public abstract int add(int x, int y);
    }
    public  class Demo1:Demo
    {   
        public   override int add(int a , int b)
        {
            int result = a + b;
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            Console.WriteLine("Enter value of a ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of  b ");
            int y = Convert.ToInt32(Console.ReadLine());
            Demo1 d1 = new Demo1();
            result = d1.add(x,y);
            Console.WriteLine("Addition of two numbers is : "+result);
            

            Console.ReadKey();

        }
    }
}
