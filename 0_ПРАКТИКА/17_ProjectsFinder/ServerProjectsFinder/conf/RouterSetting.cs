using System;
using System.Collections.Generic;
using System.Text;

namespace ServerProjectsFinder.conf
{
    class RouterSetting : IRouterSetting
    {
        public string Ip { get; } = "127.0.0.1";

        public int Port { get; } = 9000;
    }
}
