using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace _22_Банк.encrypt
{
    public class AesEncrypt : IEncrypt
    {
        /// <summary>
        /// Создает объект от класса с входными ключами
        /// </summary>
        /// <param name="inputKey"></param>
        /// <param name="inputIV"></param>
        public AesEncrypt(byte[] inputKey, byte[] inputIV)
        {
            Key = inputKey;
            IV = inputIV;
        }
        /// <summary>
        /// Создает объект от класса с сгенерированными Aes ключами
        /// </summary>
        public AesEncrypt()
        {
            Key = GenerateKey();
            IV = GenerateIV();
        }
        public byte[] Key { get; private set; }
        public byte[] IV { get; private set; }

        /// <summary>
        /// Генерирует новый шифровальный ключ и подставляет в свойства
        /// </summary>
        /// <returns>Aes Key</returns>
        private byte[] GenerateKey()
        {
            var aes = new AesManaged();
            aes.GenerateKey();
            return aes.Key;
        }
        /// <summary>
        /// Генерирует новый шифровальный IV ключ и подставляет в свойства
        /// </summary>
        /// <returns>Aes IV</returns>
        private byte[] GenerateIV()
        {
            var aes = new AesManaged();
            aes.GenerateIV();
            return aes.IV;
        }
        /// <summary>
        /// Шифрует входящий массив байт, используя ключи, заданные в свойства
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Encrypted input data</returns>
        public byte[] Encrypt(byte[] text)
        {
            using (var aes = System.Security.Cryptography.Aes.Create())
            {
                aes.KeySize = 64;
                aes.BlockSize = 64;
                aes.Padding = PaddingMode.Zeros;

                aes.Key = Key;
                aes.IV = IV;

                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                {
                    return PerformCryptography(text, encryptor);
                }
            }
        }
        /// <summary>
        /// Расшифровывает входящий массив байт, используя ключи, заданные в свойства
        /// </summary>
        /// <param name="encryptedData"></param>
        /// <returns>Decrypted input data</returns>
        public byte[] Decrypt(byte[] text)
        {
            using (var aes = System.Security.Cryptography.Aes.Create())
            {
                aes.KeySize = 128;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.Zeros;

                aes.Key = Key;
                aes.IV = IV;

                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                {
                    return PerformCryptography(text, decryptor);
                }
            }
        }
        /// <summary>
        /// Шифрует входную строку в массив байт
        /// </summary>
        /// <param name="raw"></param>
        /// <returns>Encrypted input raw</returns>
        public byte[] EncryptString(string raw)
        {
            byte[] encrypted;
            using (AesManaged aes = new AesManaged())
            {
                ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                            sw.Write(raw);
                        encrypted = ms.ToArray();
                    }
                }
            }
            return encrypted;
        }
        /// <summary>
        /// Расшифровывает зикодированную строку
        /// </summary>
        /// <param name="encryptString"></param>
        /// <returns>Decrypted input data</returns>
        public string DecryptString(byte[] encryptString)
        {
            string plaintext = null;
            using (AesManaged aes = new AesManaged())
            {
                ICryptoTransform decryptor = aes.CreateDecryptor(Key, IV);
                using (MemoryStream ms = new MemoryStream(encryptString))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader reader = new StreamReader(cs))
                            plaintext = reader.ReadToEnd();
                    }
                }
            }
            return plaintext;
        }
        /// <summary>
        /// Тупа код со стака, нужен походу для чего то важного
        /// </summary>
        /// <param name="data"></param>
        /// <param name="cryptoTransform"></param>
        /// <returns></returns>
        private byte[] PerformCryptography(byte[] data, ICryptoTransform cryptoTransform)
        {
            using (var ms = new MemoryStream())
            using (var cryptoStream = new CryptoStream(ms, cryptoTransform, CryptoStreamMode.Write))
            {
                cryptoStream.Write(data, 0, data.Length);
                cryptoStream.FlushFinalBlock();

                return ms.ToArray();
            }
        }
        /// <summary>
        /// Кодирует ключ в кодировку base64
        /// </summary>
        /// <returns>byte[] Key as base64</returns>
        public string KeyToBase64()
        {
            return Convert.ToBase64String(Key);
        }
        /// <summary>
        /// Раскодирует base64 в byte[] Key
        /// </summary>
        /// <param name="base64Key"></param>
        /// <returns>base64 Key as byte[] Key</returns>
        public byte[] FromBase64ToKey(string base64Key)
        {
            return Convert.FromBase64String(base64Key);
        }
        /// <summary>
        /// Кодирует IV ключ в кодировку base64
        /// </summary>
        /// <returns>byte[] IV as base64</returns>
        public string IVToBase64()
        {
            return Convert.ToBase64String(IV);
        }
        /// <summary>
        /// Раскодирует base64 в byte[] Key
        /// </summary>
        /// <param name="base64Key"></param>
        /// <returns>base64 Key as byte[] Key</returns>
        public byte[] FromBase64ToIV(string base64IV)
        {
            return Convert.FromBase64String(base64IV);
        }
    }
}
