using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_свои_сервисы.Services
{
    public class TimeService
    {
        public string GetTime()
        {
            return DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
