using System;
using System.Collections.Generic;
using System.Text;

namespace _22_Банк.encrypt
{
    public interface IEncrypt
    {
        public byte[] Encrypt(byte[] text);
        public byte[] Decrypt(byte[] text);
    }
}
