using System;

namespace _2_Еще_Классы
{
    class Animal
    {
        public string Type { get; }
        // конструктор
        public Animal(string type)
        {
            if (type != "" && type != null)
            {
                this.Type = type;
            }
        }
    }
}
