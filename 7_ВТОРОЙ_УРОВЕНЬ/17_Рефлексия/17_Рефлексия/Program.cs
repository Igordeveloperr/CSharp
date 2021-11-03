using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _17_Рефлексия
{
    class Program
    {
        static void Main(string[] args)
        {
            Photo photo = new Photo("https://gokhlia/sho.img", "gokhlia jpeg");
            Type type = typeof(Photo);
            // получаю свой созданный аттрибут шо
            object[] attributes = type.GetCustomAttributes(false);
            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute);
            }
            // получаю поля класса у которых задан аттрибут
            PropertyInfo[] properties = type.GetProperties();
            foreach(var property in properties)
            {
                // сама логика сортировки свойств и аттрибутов
                var attrbts = property.GetCustomAttributes(false);
                var currentProp = attrbts.Any(a => a.GetType() == typeof(GeoAttribute));
                if (currentProp)
                {
                    Console.WriteLine(property.Name);
                }
            }
            Console.ReadLine();
        }
    }
}
