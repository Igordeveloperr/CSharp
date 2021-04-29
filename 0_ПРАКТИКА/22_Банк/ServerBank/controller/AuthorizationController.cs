using System;
using System.Collections.Generic;
using System.Text;
using _22_Банк.model.request.requests;

namespace ServerBank.controller
{
    internal class AuthorizationController : Controller
    {
        public AuthorizationController()
        {
            ControllerType = RequestType.authorization;
        }
        public override void ControllerStartWork(string json)
        {
            
            Console.WriteLine("work");
        }
    }
}
