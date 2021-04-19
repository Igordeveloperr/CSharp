using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace _22_Банк.model.request.requests
{
    internal abstract class Request
    {
        private string Json;
        [JsonProperty]
        private RequestType RequestType;
        public Request(RequestType type)
        {
            RequestType = type;
        }
        public string ToJson()
        {
            Json = JsonConvert.SerializeObject(this);
            return Json;
        }
    }
}
