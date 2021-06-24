using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Методы
{
    class Person
    {
        private int x, y = 0;

        public string Name { get; set; }
        
        public Person(string name)
        {
            this.Name = name;
        }
        // еще метод
        public string Run()
        {
            // генератор случайных чисел
            Random rnd = new Random();
            // от -2 до 30
            this.x = rnd.Next(-2, 30);
            // от -10 до 23
            this.y = rnd.Next(-10, 23);
            // возвращаю результат
            return $"{this.Name} - x: {this.x}; y: {this.y}";
        }

        // перегрузка метода
        public string Run(int x, int y)
        {
            return $"{this.Name} - x: {x}; y: {y}";
        }

        // рекурсивный метод: факториал числа
        public int GetFactorial(int value)
        {
            if(value <= 1)
            {
                return 1;
            }
            else
            {
                return value * this.GetFactorial(value - 1);
            }
        }
    }
}
