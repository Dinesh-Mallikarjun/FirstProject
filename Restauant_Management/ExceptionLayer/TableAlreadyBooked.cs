using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionLayer
{
    public class TableAlreadyBooked : Exception
    {
     public TableAlreadyBooked(string message):base(message)
      {
      }

    }
    
        public class InvalidDataException : Exception
    {
        public InvalidDataException(string message) : base(message)
        {
        }

    }
}
