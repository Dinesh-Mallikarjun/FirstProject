using System;
using System.Runtime.Serialization;

namespace PresentationLayer.Controllers
{
    [Serializable]
    internal class NameAlreadyPresent : Exception
    {
        public NameAlreadyPresent()
        {
        }

        public NameAlreadyPresent(string message) : base(message)
        {
        }

        public NameAlreadyPresent(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NameAlreadyPresent(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}