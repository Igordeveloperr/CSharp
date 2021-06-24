using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace _17_ProjectsFinder.Send
{
    public class InsertUserRequest : Request
    {
        public int PostId { get; set; }
        public string Login { get; set; }
        public const string type = "insert_user";
        [JsonConstructor]
        public InsertUserRequest(int id, string login) : base(type)
        {
            PostId = id;
            Login = login;
        }
    }
}
