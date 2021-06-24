using System;
using System.Collections.Generic;
using System.Text;

namespace ServerProjectsFinder
{
    interface IRouter
    {
        IRouterSetting Setting { get; }
        void RecivingRequest();
    }
}
