using System;
using System.Collections.Generic;
using System.Text;

namespace _17_ProjectsFinder.Send.Settings
{
    public class RequestSetting : IRequestSettings
    {
        public string Ip { get; } = "127.0.0.1";

        public int Port { get; } = 9000;
    }
}
