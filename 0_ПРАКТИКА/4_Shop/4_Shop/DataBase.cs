using System;
using System.Collections.Generic;
using System.Text;

namespace _4_Shop
{   
    class DataBase
    {   
        // эмуляция БД
        private static Dictionary<string, int> _products = new Dictionary<string, int>();
        
        // выводит все товары
        public static void ShowAllProducts()
        {
            string output = "";
            foreach (var elem in _products.Keys)
            {
                output += $"{elem} - {_products[elem]}руб\n";
            }
            Console.WriteLine("Товары: ");
            Console.WriteLine(output);
        }
        // добавляет продукт
        public static void AddProduct(string name, int price)
        {
            if (!string.IsNullOrWhiteSpace(name) && price >= 1)
            {
                _products.Add(name, price);
            }
        }
        // удаляет продукт
        public static void RemoveProduct(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                _products.Remove(name);
            }
        }
        // возвращает цену товара
        public static int GetPrice(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                return _products[name];
            }
            return 0;
        }
    }
}
