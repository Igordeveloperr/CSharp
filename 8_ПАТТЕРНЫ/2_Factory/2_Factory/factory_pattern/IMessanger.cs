using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Factory.factory_pattern
{
    interface IMessanger
    {
        string UserName { get; }
        string Password { get; }
        bool Connected { get; }

        IMessage CreateMessage(string text, string source, string target);
        bool Authorize();
    }
}
