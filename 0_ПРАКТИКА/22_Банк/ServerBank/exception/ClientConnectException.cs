using System;
using System.Collections.Generic;
using System.Text;

namespace ServerBank.exception
{
    internal class ClientConnectException : Exception
    {
        public ClientConnectException(string message) : base(message)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException(nameof(message));
        }
    }
}
