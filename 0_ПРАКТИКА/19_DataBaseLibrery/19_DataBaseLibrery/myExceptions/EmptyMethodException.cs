using System;
using System.Collections.Generic;
using System.Text;

namespace _19_DataBaseLibrery.myExceptions
{
    internal class EmptyMethodException : Exception
    {
        public EmptyMethodException(string message) : base(message)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException(nameof(message));
        }
    }
}
