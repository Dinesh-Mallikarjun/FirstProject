using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter value");
            string str = Console.ReadLine();
            if(checkName(str))
            {

            AddValue(ref str);
            Console.WriteLine("combined value  "+str);
            Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Enter values which accepts only alphabets");
                Console.ReadKey();
            }
        }
        public static void AddValue(ref string str)
        {
            Console.WriteLine("enter another value ");
            string str2 = Console.ReadLine();

            str = str + str2;
            Console.WriteLine("The value is added  " + str);
            Console.ReadKey();
        }
        public static bool checkName(string value)
        {
            bool result = false;
            Regex regex = new Regex(@"^[A-Za-z]");
            Match match = regex.Match(value);
            if(match.Success)
            {
                result = true;
            }
            return result;
        }
        //string str3 = null;     
        //int x = null;//error     
        //int? y = null;
        
    }
}
