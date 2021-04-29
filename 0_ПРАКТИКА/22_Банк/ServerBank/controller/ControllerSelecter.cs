using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ServerBank.controller
{
    internal class ControllerSelecter
    {
        private IEnumerable<Type> Controllers;
        private string Json;
        public ControllerSelecter(string json)
        {
            Controllers = Controller.GetAllControllers();
            if (string.IsNullOrWhiteSpace(json))
                throw new ArgumentException("json пустой");
            Json = json;
        }
        public void SelectController()
        {
            foreach (Type item in Controllers)
            {
                PropertyInfo[] property = item?.GetProperties();
                bool flag = CheckProperty(property, item);
            }
        }
        private bool CheckProperty(PropertyInfo[] property, Type classItem)
        {
            Controller a = new AuthorizationController();
            foreach(var item in property)
            {
                Console.WriteLine(item?.GetValue(a));
            }
            return true;
        }
    }
}
