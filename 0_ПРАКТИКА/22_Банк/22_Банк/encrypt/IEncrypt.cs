using System;
using System.Collections.Generic;
using System.Text;

namespace _22_Банк.encrypt
{
    public interface IEncrypt
    {
        public byte[] Encrypt(string text);
        public byte[] Decrypt(string text);
    }
}
