using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Еще_Классы
{
    public class Person
    {
        // сокращенные версии свойств
        public string SecondName { get;  set; }

        // переменная
        private string name;
        // свойства
        public string Name
        {   
            // getter
            get
            {
                return name;
            }
            //setter
            set
            {
                name = value;
            }
        }

        // вычисляемое свойство
        public string FullName
        {
            get
            {
                return $"{this.Name} - {this.SecondName}";
            }
        }
    }
}
