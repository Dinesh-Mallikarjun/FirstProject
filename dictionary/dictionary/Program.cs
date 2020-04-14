using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class Program
    {
        public static void PrintDict<K, V>(Dictionary<K, V> dict)
        {
            foreach (K key in dict.Keys)
            {
                Console.WriteLine(key + " : " + dict[key]);
            }
        }

        public static void Main()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>
        {
            { "1", "mindtree" },
            { "2", "kalinga" }
        };

            PrintDict(dict);
            Console.ReadKey();
        }
    }
}
