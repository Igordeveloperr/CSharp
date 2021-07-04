using _4_Builder.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _4_Builder.encrypt
{
    internal class RsaEncrypter : IEncrypter
    {
        private RSACryptoServiceProvider _cryptoServiceProvider = new RSACryptoServiceProvider(512);
        private RSAParameters _privateKey;
        private RSAParameters _publicKey;
        private EncryptObject _obj = new EncryptObject();
        public RsaEncrypter()
        {
            _privateKey = _cryptoServiceProvider.ExportParameters(true);
            _publicKey = _cryptoServiceProvider.ExportParameters(false);
        }
        public void SetStatus(StatusEnum status)
        {
            _obj.Status = status;
        }

        public void Encrypt(byte[] data)
        {
            _cryptoServiceProvider.ImportParameters(_publicKey);
            byte[] encryptData = _cryptoServiceProvider.Encrypt(data, false);
            _obj.Data = encryptData;
        }

        public EncryptObject GetResult()
        {
            return _obj;
        }
    }
}
