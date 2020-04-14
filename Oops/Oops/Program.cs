using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class Customer
    {
       
        public  void PrimeMember() { }
        public  void NonprimeMember() {  }
    }
    class Amazon : Customer
    {
        new  public void PrimeMember()
        {
            Console.WriteLine("prime members will get 5 % of discount ");
        }
        new  public  void  NonprimeMember()
        {
            Console.WriteLine("Non prime members will get 3% of discount");
        }
        static void Main(string[] args)
        {
            Amazon am = new Amazon();
            
            am.PrimeMember();
            am.NonprimeMember();

            Console.ReadKey();
        }
    }
}
