using System;

namespace _2_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var massenger = new Messanger("Igor", "1234");
            massenger.SendMessage("hello C#", "localhost", "first");
        }
    }
}
