using _22_Банк.model.request.requests;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Reflection;
using System.Text;

namespace ServerBank.controller
{
    internal class ControllerSelecter
    {
        private IEnumerable<Type> Controllers;
        private string Json;
        private RequestObject DataObject;
        private Controller Controller;
        private TcpClient Client;
        public ControllerSelecter(string json, TcpClient client)
        {
            Controllers = Controller.GetAllControllers();
            if (string.IsNullOrWhiteSpace(json))
                throw new ArgumentException("json пустой");
            Json = json;
            DataObject = RequestObject.ToRequestObject(Json);
            Client = client;
        }
        public void SelectController()
        {
            foreach (Type item in Controllers)
            {
                
                PropertyInfo[] property = item?.GetProperties();
                Controller instance = (Controller)item?.Assembly.CreateInstance(item.FullName);
                Controller = GetController(property, instance);
                if (!(Controller is EmptyController))
                    return;
            }
        }
        private Controller GetController(PropertyInfo[] property, Controller instance)
        {
            Controller currentController = new EmptyController();
            foreach(var item in property)
            {
                var value = item?.GetValue(instance);
                RequestType currentType = DataObject.Type;
                if((RequestType)value == currentType)
                {
                    currentController = instance;
                }
            }
            return currentController;
        }
        public void StartSelectedController()
        {
            if (Controller == null)
                throw new ArgumentException("контроллер пустой");
            Controller.ControllerStartWork(Json, Client);
        }
    }
}
