using _17_ProjectsFinder.Send;
using Newtonsoft.Json;
using ServerProjectsFinder.Controller;
using ServerProjectsFinder.Model;
using ServerProjectsFinder.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServerProjectsFinder.Controllers
{
    internal class UpdateUserListController : ControllerBase
    {
        private UpdateUserListModel Model = new UpdateUserListModel();
        public override void Work(string json)
        {
            var obj = JsonConvert.DeserializeObject<UpdateUserListRequest>(json);
            List<UpdateUserListView> list = Model.LoadUserListByPostId(obj.PostId).Result;
            Model.SendUserToClient(list);
        }
    }
}
