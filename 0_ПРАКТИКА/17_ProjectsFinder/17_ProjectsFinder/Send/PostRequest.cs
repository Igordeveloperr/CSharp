using System;
using System.Collections.Generic;
using System.Text;

namespace _17_ProjectsFinder.Send
{
    public class PostRequest : Request
    {
        public const string type = "posts";
        public PostRequest() : base(type) { }
    }
}
