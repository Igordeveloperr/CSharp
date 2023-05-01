using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2_Универсальные_типы
{
    internal class Response
    {
        public int Status { get; private set; }
        public string Json { get; private set; }

        public Response(int status, string json)
        {
            Status = status;
            Json = json;
        }
    }
}
