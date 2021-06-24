using _17_ProjectsFinder.Send;
using Newtonsoft.Json;
using ServerProjectsFinder.Controller;
using ServerProjectsFinder.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServerProjectsFinder.Controllers
{
    internal class InsertUserController : ControllerBase
    {
        private InsertUserModel Model = new InsertUserModel();
        public override void Work(string json)
        {
            InsertUserRequest obj = JsonConvert.DeserializeObject<InsertUserRequest>(json);
            Model.InsertUser(obj.Login, "fff", obj.PostId);
        }
    }
}
