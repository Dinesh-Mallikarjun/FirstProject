using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSBuildDemo
{
    public class BClass
    {
        public virtual void GetInfo()
        {
            Console.WriteLine("Welcome to kalinga");
        }
    }
    public class DClass : BClass
    {
        public override void GetInfo()
        {
            Console.WriteLine("Welcome to Orchard");
        }
    }
    class Program
    {   
        static void Main(string[] args)
        {
            DClass d = new DClass();
            d.GetInfo();
            BClass b = new BClass();
            b.GetInfo();
            Console.ReadKey();
        }
    }
}
