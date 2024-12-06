using System;

namespace CREAR_API.Exceptions
{
    public class PubliserNameException : Exception
    {
        public string PublisherName { get; set; }

        public PubliserNameException()
        {

        }

        public PubliserNameException(string message) : base(message)
        {

        }

        public PubliserNameException(string message, Exception inner) : base(message, inner)
        {

        }

        public PubliserNameException(string message, string publisherName) : this(message)
        {
            PublisherName = publisherName;
        }
    }
}
