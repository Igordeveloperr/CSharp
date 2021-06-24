using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Factory.factory_pattern
{
    class TwitterMessage : MessageBase
    {
        public TwitterMessage(string txt, string source, string target) : base(txt, source, target) 
        {
            if(txt.Length <= 140)
            {
                Text = txt;    
            }
            else
            {
                Text = txt.Substring(0, 140);
            }
        }
        public override void Send()
        {
            Console.WriteLine($"Твит от {Source} для {Target}: {Text}");
        }
    }
}
