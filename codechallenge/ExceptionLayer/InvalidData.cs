using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionLayer
{
    public class InvalidData : Exception
    {
        public InvalidData(string message, Exception e) : base(message)
        {
            Console.WriteLine("you have entered invalid data");
        }
    }
}
