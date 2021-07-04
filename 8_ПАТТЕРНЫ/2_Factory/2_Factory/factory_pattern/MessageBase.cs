using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Factory.factory_pattern
{
    abstract class MessageBase : IMessage
    {
        public string Text { get; protected set; }

        public string Source { get; protected set; }

        public string Target { get; protected set; }

        public MessageBase(string txt, string source, string target)
        {
            if (string.IsNullOrWhiteSpace(txt)) throw new ArgumentException(nameof(txt));
            if (string.IsNullOrWhiteSpace(source)) throw new ArgumentException(nameof(source));
            if (string.IsNullOrWhiteSpace(target)) throw new ArgumentException(nameof(target));
            Text = txt;
            Source = source;
            Target = target;
        }
        public abstract void Send();
    }
}
