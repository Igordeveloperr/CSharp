using _4_Builder.encrypt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "helll";
            EncryptManager manager = new EncryptManager(new RsaEncrypter());
            manager.EncryptString(test);

            Console.ReadLine();
        }
    }
}
