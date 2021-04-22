using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace _14_RSA
{
    internal class RsaEnc
    {
        private static RSACryptoServiceProvider csp = new RSACryptoServiceProvider(2048);
        private RSAParameters _privateKey;
        private RSAParameters _publicKey;
        private StringSlicer Slicer;
        public RsaEnc()
        {
            _privateKey = csp.ExportParameters(true);
            _publicKey = csp.ExportParameters(false);
            Slicer = new StringSlicer();
        }
        public List<byte[]> Encrypt(string text)
        {
            List<byte[]> cyperList = new List<byte[]>();
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException("иди нахуй!");
            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(_publicKey);
            List<byte[]> data = Slicer.GetSliceString(text);
            foreach (var item in data)
            {
                Console.WriteLine(Encoding.UTF8.GetString(item));
                Console.WriteLine("---------------------------------------------------");
            }
            for (int i = 0; i < data.Count; i++)
            {
                byte[] cyper = csp.Encrypt(data[i], false);
                cyperList.Add(cyper);
            }
            return cyperList;
        }
        public string Decrypt(string cyperText)
        {
            if (string.IsNullOrWhiteSpace(cyperText))
                throw new ArgumentException("мне определенно поебаать аалее");
            byte[] data = Convert.FromBase64String(cyperText);
            csp.ImportParameters(_privateKey);
            byte[] text = csp.Decrypt(data, false);
            return Encoding.UTF8.GetString(text);
        }
    }
}
