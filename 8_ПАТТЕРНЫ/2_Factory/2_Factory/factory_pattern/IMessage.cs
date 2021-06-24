using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Factory.factory_pattern
{
    interface IMessage
    {
        string Text { get; }
        string Source { get; }
        string Target { get; }
        void Send();
    }
}
