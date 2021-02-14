using System;
using System.Collections.Generic;
using System.Text;

namespace _4_Исключения
{
    public class MyShizException : Exception
    {   
        public string Message { get; private set; }
        public MyShizException(string message)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                Message = message;
            }
        }
    }
}
