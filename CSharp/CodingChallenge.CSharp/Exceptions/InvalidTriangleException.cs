using System;

namespace Exceptions
{
    public class InvalidTriangleException : Exception
    {
        public InvalidTriangleException(string message) : base(message)
        {
            //using the base 
        }
    }
}
