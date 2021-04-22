using System;
using System.Collections.Generic;
using System.Text;

namespace _14_RSA
{
    class Program
    {
        static void Main(string[] args)
        {
            RsaEnc rsa = new RsaEnc();
            List<byte[]> code = new List<byte[]>();
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(text))
            {
                code = rsa.Encrypt(text);
                /*foreach(var item in code)
                {
                    Console.WriteLine(Encoding.UTF8.GetString(item));
                    Console.WriteLine("---------------------------------------------------");
                }*/
            }
            //Console.WriteLine($"DEC: {rsa.Decrypt(code)}");
            Console.ReadLine();
        }
    }
}
