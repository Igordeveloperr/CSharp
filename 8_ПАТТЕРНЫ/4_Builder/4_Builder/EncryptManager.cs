using _4_Builder.data;
using _4_Builder.encrypt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Builder
{
    internal class EncryptManager
    {
        private IEncrypter _encrypter;
        public EncryptManager(IEncrypter encrypter)
        {
            _encrypter = encrypter;
        }
        public void EncryptString(string str)
        {
            byte[] data = Encoding.UTF8.GetBytes(str);
            _encrypter.Encrypt(data);
            _encrypter.SetStatus(StatusEnum.ok);
            EncryptObject encryptObject = _encrypter.GetResult();
            string outStr = Encoding.UTF8.GetString(encryptObject.Data, 0, encryptObject.Data.Length);
            Console.WriteLine(outStr);
        }
    }
}
