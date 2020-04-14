using System;
using System.Runtime.Serialization;

namespace Assignment1
{
    [Serializable]
    internal class DuplicateOperatorNameException : Exception
    {
        public DuplicateOperatorNameException()
        {
        }

        public DuplicateOperatorNameException(string message) : base(message)
        {
        }

        public DuplicateOperatorNameException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DuplicateOperatorNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}