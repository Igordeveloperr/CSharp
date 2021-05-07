using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace _22_Банк.encrypt
{
    public class RsaEncrypt : IEncrypt
    {
        private RSACryptoServiceProvider CryptoServiceProvider = new RSACryptoServiceProvider(512);
        private RSAParameters PrivateKey;
        private RSAParameters PublicKey;
        private string ServerPublicKey;
        public RsaEncrypt(string serverPublicKey)
        {
            if (string.IsNullOrWhiteSpace(serverPublicKey))
                throw new ArgumentException(nameof(serverPublicKey));
            ServerPublicKey = serverPublicKey;
            PrivateKey = CryptoServiceProvider.ExportParameters(true);
            PublicKey = CryptoServiceProvider.ExportParameters(false);
        }
        public RsaEncrypt()
        {
            PrivateKey = CryptoServiceProvider.ExportParameters(true);
            PublicKey = CryptoServiceProvider.ExportParameters(false);
        }
        public byte[] Decrypt(byte[] data)
        {
            CryptoServiceProvider.ImportParameters(PrivateKey);
            byte[] decrypteData = CryptoServiceProvider.Decrypt(data, false);
            return decrypteData;
        }
        public byte[] Encrypt(byte[] data)
        {
            //if (string.IsNullOrWhiteSpace(text))
                //throw new ArgumentException(nameof(text));
            RSAParameters key = KeyToRsa(ServerPublicKey);
            CryptoServiceProvider.ImportParameters(key);
            byte[] encryptData = CryptoServiceProvider.Encrypt(data, false);
            return encryptData;
        }
        private RSAParameters KeyToRsa(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentException(nameof(key));
            using (StringReader stringReader = new StringReader(key))
            {
                XmlSerializer xmlDeseriallizer = new XmlSerializer(typeof(RSAParameters));
                RSAParameters rsaKey = (RSAParameters)xmlDeseriallizer.Deserialize(stringReader);
                return rsaKey;
            }
        }
        public string PublicKeyTostring()
        {
            var writer = new StringWriter();
            var serializer = new XmlSerializer(typeof(RSAParameters));
            serializer.Serialize(writer, PublicKey);
            string key = writer.ToString();
            return key;
        }
    }
}
