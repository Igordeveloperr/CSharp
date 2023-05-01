using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Универсальные_типы
{
    internal class DTObject<T> where T: Response
    {
        public T Response { get; private set; }
        public DTObject(T response)
        {
            Response = response;
        }
    }
}
