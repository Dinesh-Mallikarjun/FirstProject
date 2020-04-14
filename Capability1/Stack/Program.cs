using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push("String1");
            st.Push("string2");
            st.Push("string4");
            st.Push("string5");
            //st.Pop();

            foreach (Object obj in st)
            {
                Console.WriteLine(obj);
            }
            st.Push("string3");
            st.Push("string2");
            st.Push("string4");
            foreach(Object ogj in st)
            {
                Console.WriteLine(st.Peek());
            }
            Console.ReadKey();
        }
    }
}