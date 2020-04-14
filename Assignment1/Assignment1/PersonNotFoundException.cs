using System;
using System.Runtime.Serialization;

namespace Assignment1
{
    [Serializable]
    internal class PersonNotFoundException : Exception
    {
        public PersonNotFoundException()
        {
        }

        public PersonNotFoundException(string message) : base(message)
        {
        }

        public PersonNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PersonNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}