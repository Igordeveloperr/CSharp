using System;
using System.Collections.Generic;
using System.Text;

namespace _22_Банк.exception
{
    internal class StreamException : Exception
    {
        public StreamException(string message) : base(message)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException(nameof(message));
        }
    }
}
