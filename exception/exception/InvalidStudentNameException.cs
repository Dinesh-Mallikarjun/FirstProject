using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception
{ 
    [Serializable]
private class InvalidStudentNameException : Exception
{
    public InvalidStudentNameException()
    {
    }

    public InvalidStudentNameException(string message) : base(message)
    {
    }

    public InvalidStudentNameException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected InvalidStudentNameException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
}