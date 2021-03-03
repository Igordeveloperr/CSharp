using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace _17_ProjectsFinder.Send
{
    public class UpdateUserListRequest : Request
    {
        public const string type = "update_user_list";
        public int PostId { get; set; }
        [JsonConstructor]
        public UpdateUserListRequest(int id):base(type)
        {
            PostId = id;
        }
    }
}
