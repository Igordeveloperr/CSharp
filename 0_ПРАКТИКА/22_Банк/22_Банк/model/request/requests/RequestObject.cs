using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace _22_Банк.model.request.requests
{
    public class RequestObject
    {
        [JsonProperty]
        public byte[] Iv { get; private set; }
        [JsonProperty]
        public byte[] Key { get; private set; }
        [JsonProperty]
        public byte[] Data { get; private set; }
        [JsonProperty]
        public RequestType Type { get; private set; }
        public RequestObject(RequestType type)
        {
            Type = type;
        }
        [JsonConstructor]
        public RequestObject(byte[] key, byte[] iv, byte[] data, RequestType type)
        {
            Key = key;
            Iv = iv;
            Type = type;
            Data = data;
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
        public static RequestObject ToRequestObject(string json)
        {
            if (string.IsNullOrWhiteSpace(json))
                throw new ArgumentException("json пуст");
            RequestObject obj = null;
            try
            {obj = JsonConvert.DeserializeObject<RequestObject>(json);}
            catch (JsonException e)
            {MessageBox.Show(e.Message);}
            return obj;
        }
    }
}
