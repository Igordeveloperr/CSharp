using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Factory.factory_pattern
{
    class TwitterMessanger : MessangerBase
    {
        public TwitterMessanger(string name, string password) : base(name, password) { }
        public override bool Authorize()
        {
            if(UserName.Equals("igor") && Password.Equals("123"))
            {
                Console.WriteLine($"Connect user - {UserName}");
                return true;
            }
            return false;
        }

        public override IMessage CreateMessage(string text, string source, string target)
        {
            if (string.IsNullOrWhiteSpace(text)) throw new ArgumentException(nameof(text));
            if (string.IsNullOrWhiteSpace(source)) throw new ArgumentException(nameof(source));
            if (string.IsNullOrWhiteSpace(target)) throw new ArgumentException(nameof(target));
            var message = new TwitterMessage(text, source, target);
            return message;
        }
    }
}
