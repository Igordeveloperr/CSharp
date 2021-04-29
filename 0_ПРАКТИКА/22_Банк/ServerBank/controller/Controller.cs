using _22_Банк.model.request.requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ServerBank.controller
{
    internal abstract class Controller
    {
        public RequestType ControllerType { get; protected set; }
        public abstract void ControllerStartWork(string json);
        public static IEnumerable<Type> GetAllControllers()
        {
            Type baseType = typeof(Controller);
            IEnumerable<Type> list = Assembly.GetAssembly(baseType).GetTypes()
                .Where(type => type.IsSubclassOf(baseType));
            return list;
        }
    }
}
