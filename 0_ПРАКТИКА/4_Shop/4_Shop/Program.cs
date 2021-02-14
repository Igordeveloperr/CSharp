using System;

namespace _4_Shop
{
    class Program
    {
        static void Main(string[] args)
        {   
            DataBase.AddProduct("F1", 500);
            DataBase.AddProduct("M16", 1500);
            DataBase.AddProduct("AK-74", 7898);
            DataBase.AddProduct("Helmet", 789);
            while (true)
            {
                DataBase.ShowAllProducts();
                Console.Write("Введите название товара: ");
                string str = Console.ReadLine();
                Cashier.Sell(str);
                Cashier.PrintMoney();
            }
        }
    }
}
