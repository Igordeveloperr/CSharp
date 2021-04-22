using System;
using System.Collections.Generic;
using System.Text;

namespace _13_Методы_Расширения
{
    internal static class Helper
    {
        public static bool IsEven(this int i)
        {
            if (i % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
