using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace _22_Банк.model.request.requests
{
    internal class AuthorizationRequest : Request
    {
        [JsonProperty]
        private string Name;
        [JsonProperty]
        private string Password;
        public AuthorizationRequest(RequestType type, string name, string password) : base(type)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(nameof(name));
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException(nameof(password));
            Name = name;
            Password = password;
        }
    }
}
