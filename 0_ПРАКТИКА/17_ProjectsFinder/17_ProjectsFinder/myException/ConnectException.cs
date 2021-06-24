using System;
using System.Collections.Generic;
using System.Text;

namespace ServerProjectsFinder.myException
{
    public class ConnectException : Exception
    {
        public ConnectException(string message) : base(message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentException("пустышка:"+nameof(message));
            }
        }
    }
}
