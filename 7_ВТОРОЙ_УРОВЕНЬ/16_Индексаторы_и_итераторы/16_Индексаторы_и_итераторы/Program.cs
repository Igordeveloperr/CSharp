using System;
using System.Collections;
using System.Collections.Generic;

namespace _16_Индексаторы_и_итераторы
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Car(){Name="Ford", Number="A01B"},
                new Car(){Name="Audi", Number="BCC4"},
                new Car(){Name="Lada", Number="F12A"},
            };
            var parking = new Parking();
            foreach(var car in cars)
            {
                parking.Add(car);
            }
            // обращение к индексатору -> к элементу коллекции -> к свойству Name
            Console.WriteLine(parking["F12A"]?.Name);
            // обращение к перегруженному индексатору
            Console.WriteLine(parking[1]?.Name);
            Console.WriteLine("------------------");
            // вывод всех авто
            foreach(var car in parking)
            {
                Console.WriteLine(car.Name);
            }
            var nums = parking.GetNumbers(10);
            foreach(int i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
}
