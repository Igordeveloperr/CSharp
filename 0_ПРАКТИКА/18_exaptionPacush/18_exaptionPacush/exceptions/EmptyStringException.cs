using System;
using System.Collections.Generic;
using System.Text;

namespace _18_exaptionPacush.exceptions
{
    internal class EmptyStringException : Exception
    {
        public EmptyStringException(string message) : base(message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentException();
            }
        }
    }
}
