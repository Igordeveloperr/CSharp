using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14_RSA
{
    internal class StringSlicer
    {
        private const int SliceIndex = 5;
        private List<byte[]> Strings = new List<byte[]>();
        public List<byte[]> GetSliceString(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException("хахах неет");
            if (text.Length < 5)
                throw new ArgumentException("сообщение должно быть больше 5 символов");
            Slice(text);
            return Strings;
        }
        private void Slice(string txt)
        {
            for(int i = 0; i < txt.Length; i++)
            {
                if(i == 5 || i == 10)
                {
                    var item = txt.Take(SliceIndex).ToArray();
                    string str = new string(item);
                    byte[] data = Encoding.UTF8.GetBytes(str);
                    Strings.Add(data);
                    txt = txt.Substring(SliceIndex);
                }
            }
        }
    }
}
