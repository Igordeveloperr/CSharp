using _4_Builder.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Builder.encrypt
{
    internal interface IEncrypter
    {
        void Encrypt(byte[] data);
        void SetStatus(StatusEnum status);
        EncryptObject GetResult();
    }
}
