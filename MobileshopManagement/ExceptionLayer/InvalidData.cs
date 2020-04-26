using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionLayer
{
    public class InvalidData :Exception
    {
        public InvalidData(string message) : base(message)
        {

        }
            
    }
    public class RatingOverLoadedException : Exception
    {
        public RatingOverLoadedException(string message) : base(message)
        {

        }
    }
    public class NoParametersException : Exception
    {
        public NoParametersException(string message) : base(message)
        {

        }
    }
    public class InValidOperatorIdException : Exception
    {
        public InValidOperatorIdException(string message) : base(message)
        {

        }
    }
}





