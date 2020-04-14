using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodvenkat_from_part_15
{/*
    class Program
    {
        
        public   static void Main()
        {
            Program.evenNumber(30);
            Program p = new Program();
            int sum = p.add(10,20);
            Console.WriteLine(sum);
       
            Console.ReadLine();
        }

        public int add (int fn,int sn)
        {
            return fn + sn;
        }
        public static void evenNumber(int target)
        {
            int start = 0;
            while(start<=target)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }
    
    *//*
    public static void Main()
        { int total = 0;
            int product = 0;
            simpleMethod(10, 20, out total, out product);

            Console.WriteLine("sum ={0} && product={1}", total, product);
            Console.ReadKey();
        }
        public static void  simpleMethod(int n ,int m ,out int sum,out int product)
        {
            sum = n + m;
            product = n * m;
        }
        *//*
        public static void Main()
        {
            int[] numbers = new int[2];
            numbers[0] = 82;
            numbers[1] = 873;
           // paramsMethod();
            paramsMethod(numbers);
        }
            public static void paramsMethod(params int[] numbers)
        {
            Console.WriteLine("There are {0} elements",numbers.Length);
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        /*
         * 
         */
    class Customer
    {
        string _fname;
        string _lname;

        public Customer(string firstname, string secondname)
        {
            this._fname = firstname;
            this._lname = secondname;
        }
        public void fullName()
        {
            Console.WriteLine("full name={0}" ,this._fname," " + this._lname);
            
        }
        ~Customer()
        {

        }


    }

    class Program
    {
        public static void Main()
        {
            Customer c1 = new Customer("dinesh", "mashetty");
            c1.fullName();
            Console.ReadKey();
        }
    }
}