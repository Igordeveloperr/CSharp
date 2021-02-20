using _17_ProjectsFinder.Send.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace _17_ProjectsFinder.Send
{
    public class Request
    {
        public string Type { get; protected set; }
        protected IRequestSettings Setting { get; set; } = new RequestSetting();
        public Request(string type)
        {
            if (!string.IsNullOrWhiteSpace(type))
            {
                Type = type;
            }
        }
    }
}
