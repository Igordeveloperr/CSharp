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
    class PostController : ControllerBase
    {
        private PostModel Model = new PostModel();
        public override void Work(string json)
        {
            var result = Model.LoadAllPost();
            Model.SendAllPostToClient(result);
        }
    }
}
