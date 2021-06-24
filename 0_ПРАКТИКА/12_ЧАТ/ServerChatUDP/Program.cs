using System;

namespace ServerChatUDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Server start...");
            Server server = new Server("127.0.0.1", 9000);
            while (true)
            {
                server.ProcessingRequest();
            }
        }
    }
}
