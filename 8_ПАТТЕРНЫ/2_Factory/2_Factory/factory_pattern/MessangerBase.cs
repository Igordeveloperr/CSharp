using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Factory.factory_pattern
{
    abstract class MessangerBase : IMessanger
    {
        public string UserName { get; }

        public string Password { get; }

        public bool Connected { get; }
        public MessangerBase(string name, string password)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password))
            {
                Connected = false;
                throw new ArgumentException("argument exc");
            }
            UserName = name;
            Password = password;
            Connected = Authorize();
        }
        public abstract bool Authorize();

        public abstract IMessage CreateMessage(string text, string source, string target);

    }
}
