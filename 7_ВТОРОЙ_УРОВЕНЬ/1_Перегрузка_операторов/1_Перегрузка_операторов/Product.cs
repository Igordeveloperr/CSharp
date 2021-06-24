using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Перегрузка_операторов
{
    /* 
     * создаю абстрактный класс,
     * от него нельзя создать объект,
     * это просто шаблон для реализации иерархии наследования
     */
    public abstract class Product
    {
        public string Name { get; }
        public int Calories { get; }
        // в граммах
        public int Volume { get; }

        public int Energy
        {
            get
            {
                return Volume * Calories / 100;
            }
        }

        public Product(string name, int calories, int volume)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(nameof(name));
            }
            if (calories < 0)
            {
                throw new ArgumentException(nameof(calories));
            }
            if (volume <= 0)
            {
                throw new ArgumentException(nameof(name));
            }
            Name = name;
            Calories = calories;
            Volume = volume;
        }

        // перегрузка метода toString()
        public override string ToString()
        {
            return $"{Name} - {Calories} - {Volume}";
        }
    }
}
