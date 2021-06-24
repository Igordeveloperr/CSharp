using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace _4_Shop
{
    class Cashier
    {   
        // поле класса
        private static int _money = 0;

        // свойство
        protected static int Money { get; set; } = _money;
        // продает товар
        public static void Sell(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                int price = DataBase.GetPrice(name);
                if(price >= 1)
                {
                    Money += price;
                    Console.WriteLine($"Товар {name} продан!");
                    DataBase.RemoveProduct(name);
                }
            }
        }
        // выводит кол-во денег в кассе
        public static void PrintMoney()
        {
            Console.WriteLine($"В кассе: {Money} рублей");
        }
    }
}
