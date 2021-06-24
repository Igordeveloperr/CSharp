using System;
using System.Collections.Generic;
using System.Text;

namespace ServerProjectsFinder.myException
{
    public class StreamException : Exception
    {
        public StreamException(string message):base(message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentException(nameof(message));
            }
        }
    }
}
