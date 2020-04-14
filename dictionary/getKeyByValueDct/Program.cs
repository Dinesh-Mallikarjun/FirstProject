using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getKeyByValueDct
{
    class Program
    {
        public static T KeyByValue<T, W>(this Dictionary<T, W> dict, W val)
        {
            T key = ;
            foreach (KeyValuePair<T, W> pair in dict)
            {
                if (EqualityComparer<W>.Default.Equals(pair.Value, val))
                {
                    key = pair.Key;
                    break;
                }
            }
            return key;
        }
        public static void Main()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>()
                                                                                {
                                                                                    {"1", "one"},
                                                                                    {"2", "two"},
                                                                                    {"3", "three"}
                                                                                };

            string key = KeyByValue(dict, "two");
            Console.WriteLine("Key: " + key);
        }
    }
}
