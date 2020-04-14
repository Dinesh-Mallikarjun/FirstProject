using System;
using System.Runtime.Serialization;

namespace Employee
{
    [Serializable]
    internal class InvalidSqlException : Exception
    {
        public InvalidSqlException()
        {
        }

        public InvalidSqlException(string message) : base(message)
        {
        }

        public InvalidSqlException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidSqlException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}