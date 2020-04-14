using System;
using System.Runtime.Serialization;

namespace Assignment1
{
    [Serializable]
    internal class DuplicatePersonException : Exception
    {
        public DuplicatePersonException()
        {
        }

        public DuplicatePersonException(string message) : base(message)
        {
        }

        public DuplicatePersonException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DuplicatePersonException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}