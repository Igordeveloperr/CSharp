using System;
using System.Collections.Generic;
using System.Text;

namespace ServerBank.exception
{
    internal class StartTcpListenerException : Exception
    {
        private static string Info = "Ошибка запуска сервера";
        public StartTcpListenerException(string message) : base(Info)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException(nameof(message));
            Info = message;
        }
    }
}
