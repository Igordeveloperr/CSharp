
using System;
using System.Collections.Generic;
using System.Text;

namespace _17_ProjectsFinder.Send
{
    public interface IRequestSettings
    {
        string Ip { get; }
        int Port { get; }
    }
}
