using System;
using System.Collections.Generic;
using System.Text;

namespace ServerProjectsFinder
{
    interface IRouterSetting
    {
        string Ip { get; }
        int Port { get; }
    }
}
