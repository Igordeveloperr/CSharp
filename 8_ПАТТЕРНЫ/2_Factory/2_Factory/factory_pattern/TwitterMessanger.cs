using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Factory.factory_pattern
{
    class TwitterMessanger : MessageBase
    {
        public TwitterMessanger(string txt, string source, string target) : base(txt, source, target) {}
        public override void Send()
        {
            throw new NotImplementedException();
        }
    }
}
