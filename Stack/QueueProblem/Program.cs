using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("Two");
            q.Enqueue("One");

            // remove elements
            while (q.Count > 0)
                Console.WriteLine(q.Dequeue());
            Console.ReadKey();
        }
    }
}
