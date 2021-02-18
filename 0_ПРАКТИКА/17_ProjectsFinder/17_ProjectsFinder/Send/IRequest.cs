using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace _17_ProjectsFinder.Send
{
    public interface IRequest
    {
        IRequestSettings Setting { get; }
        void SendRequest();
    }
}
