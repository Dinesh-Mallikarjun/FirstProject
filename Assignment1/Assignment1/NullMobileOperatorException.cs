using System;
using System.Runtime.Serialization;

namespace Assignment1
{
    [Serializable]
    internal class NullMobileOperatorException : Exception
    {
        public NullMobileOperatorException()
        {
        }

        public NullMobileOperatorException(string message) : base(message)
        {
        }

        public NullMobileOperatorException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NullMobileOperatorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}