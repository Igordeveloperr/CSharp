using _2_Factory.factory_pattern;
using System;

namespace _2_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var twitter = new TwitterMessanger("igor", "123");
            var twit = twitter.CreateMessage("hello C#", "@Gokhlia", "@Valentin");
            twit.Send();
        }
    }
}
