using System;
using System.Collections.Generic;
using System.Text;

namespace _18_exaptionPacush.exceptions
{
    internal class SimpleStringException : Exception
    {
        public SimpleStringException(string message) : base(message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentException();
            }
        }
    }
}
