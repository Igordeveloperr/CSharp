using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace _22_Банк.model.request.requests
{
    public class RequestObject
    {
        [JsonProperty]
        private byte[] Data;
        [JsonProperty]
        private byte[] Key;
        [JsonProperty]
        private byte[] IV;
        public RequestObject(byte[] data, byte[] key, byte[] iv)
        {
            if (data == null || key == null || iv == null)
                throw new ArgumentException("error!");
            Data = data;
            Key = key;
            IV = iv;
        }
        public string ToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }
        public byte[] ToByteArray()
        {
            return Encoding.UTF8.GetBytes(this.ToJson());
        }
    }
}
