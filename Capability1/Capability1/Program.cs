using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capability1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("str1");
            q.Enqueue("str2");
            q.Enqueue("str4");
            q.Enqueue("str5");
            
            int c1 = q.Count;
            foreach (var i in q.ToArray())
                Console.WriteLine(i);
          //  q.Dequeue();
            q.Dequeue();
            q.Enqueue("str3");
            q.Enqueue("str2");
            q.Enqueue("str1");
            foreach (var i in q.ToArray())
                Console.WriteLine(i);
            Console.ReadKey();



        }
    }
}
