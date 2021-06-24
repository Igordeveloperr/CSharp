using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Factory
{
    class Message
    {
        internal string Text { get; }
        private string Source { get; }
        private string Target { get; }

        internal Message(string text, string source, string target)
        {
            Text = text;
            Source = source;
            Target = target;
        }
    }
}
