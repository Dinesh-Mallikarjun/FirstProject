using System;
using System.Runtime.Serialization;

namespace PresentationLayer.Controllers
{
    [Serializable]
    internal class EnterValidAmountException : Exception
    {
        public EnterValidAmountException()
        {
        }

        public EnterValidAmountException(string message) : base(message)
        {
        }

        public EnterValidAmountException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EnterValidAmountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}