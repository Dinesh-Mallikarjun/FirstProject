using System;
using System.Runtime.Serialization;

[Serializable]
internal class InvalidStudentNameException : Exception
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