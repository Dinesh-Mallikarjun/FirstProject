using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation

{

    public class demo1
    {
        private string str1;
        private string str2;

        public string SetName()
        {
            string str1 = Console.ReadLine();
            return str1;
        }
        public string GetName()
        {
            return str1;
        }
        
        public string SetSurName()
        {
            string str2 = Console.ReadLine();
            return str2;
        }
        public string GetSurName()
        {
            return str2;
        }
      

        public void display()
        {
            Console.WriteLine(SetName()+"  "+SetSurName());
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                demo1 d1 = new demo1();


                Console.WriteLine("Enter name");
                string str1 = d1.SetName();

                Console.WriteLine("Enter Second name ");
                string str2 = d1.SetName();
                

    
                //d1.Surname = "Mashetty";
                //Console.WriteLine("name="+d1.Name);
                //Console.WriteLine("surname=" + d1.Surname);

                d1.display();
                Console.ReadKey();
            }
        }
    
}