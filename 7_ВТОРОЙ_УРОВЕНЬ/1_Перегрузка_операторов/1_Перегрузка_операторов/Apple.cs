using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Перегрузка_операторов
{
    public class Apple : Product
    {   
        // base - вызывает конструктор базового класса
        public Apple(string name, int calories, int volume) : base(name, calories, volume)
        {

        }

        public static Apple Add(Apple apple1, Apple apple2)
        {
            int calories = (int)Math.Round(((apple1.Calories + apple2.Calories) / 2.0));
            var volume = apple1.Volume + apple2.Volume;
            Apple apple = new Apple("Яблоко", calories, volume);
            return apple;
        }
        // перегрузка оператора сложения
        public static Apple operator + (Apple apple1, Apple apple2)
        {
            int calories = (int)Math.Round(((apple1.Calories + apple2.Calories) / 2.0));
            var volume = apple1.Volume + apple2.Volume;
            Apple apple = new Apple("Яблоко", calories, volume);
            return apple;
        }
        // перегрузка логических операторов
        public static bool operator == (Apple apple, Apple apple2)
        {
            if(apple.Volume == apple2.Volume)
            {
                return true;
            }
            return false;
        }

        public static bool operator != (Apple apple, Apple apple2)
        {
            if(apple.Volume != apple2.Volume)
            {
                return true;
            }
            return false;
        }
    }
}
