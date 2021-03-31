using System;
using System.Collections.Generic;
using System.Linq;

namespace _12_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            // linq запрос
            var result = from item in list where item < 5 select item;
            //linq запрос с помощью метода расширения
            var secondResult = list.Where(item => item < 5);
            /////////////////////////////////////////////
            var rnd = new Random();
            List<Product> products = new List<Product>();
            for(int i = 0; i < 10; i++)
            {
                var producxt = new Product { Name = $"{i} Продукт", Energy = rnd.Next(300, 800) };
                products.Add(producxt);
            }
            var prodRes = products.Where(item => item.Energy < 500 || item.Energy > 300);
            // сортировка по возрастанию -- (OrderByDescending() - от большего к меньшему)
            var order = prodRes.OrderBy(product => product.Energy);
            // преобразование одного типа в другой(ебаный пиздец все объекты заменятся на числа)
            var selectCollection = products.Select(product => product.Energy)
                .OrderBy(product => product)
                .ThenBy(product => product % 2 == 0);

            // группировка
            var group = products.GroupBy(item => item.Energy);
            // разворачивание списка
            group.Reverse();
            foreach (var item in group)
            {
                Console.WriteLine($"ключ {item.Key}");
                foreach(var d in item)
                {
                    Console.WriteLine(d);
                }
            }
            // условие - у всех элементов коллекции значение Energy должно быть 10 иначе получим false
            Console.WriteLine(products.All(item => item.Energy == 10));
            //условие - если хотя бы один элемент в коллеккции имеет значение Energy == 525 или 550 то возвращаем true
            Console.WriteLine(products.Any(item => item.Energy == 525 || item.Energy == 550));
            // проверка нахождения элемента в коллекции
            Console.WriteLine(products.Contains(products[5]));
            // удаление повторяющихся элементов коллекции
            List<int> nums = new List<int> { 3,4,5, 3,4,5, 1,2, 1,2};
            var clearNums = nums.Distinct();
            foreach(var a in clearNums)
            {
                Console.WriteLine(a);
            }
            // сумма всех элементов
            var sum = clearNums.Sum();
            Console.WriteLine(sum);
            // минимальное значение
            var min = clearNums.Min();
            Console.WriteLine(min);
            // максимальное значение
            var max = clearNums.Max();
            Console.WriteLine(max);
            // произведение всех элементов коллекции
            var agg = clearNums.Aggregate((x,y)=> x*y);
            Console.WriteLine(agg);
            // обработки какой-то части коллекции(пропускаем определенный дипозон элементов)
            var sum2 = clearNums.Skip(1).Take(2).Sum(); // в данном случае я пропускаю один элемент коллекции и беру только 2 после пропуска
            Console.WriteLine(sum2);
            // получение конкретного элемента коллекции
            var first = clearNums.FirstOrDefault(); // получаю первыйэлемент коллекции
            Console.WriteLine(first);
            var last = clearNums.LastOrDefault(); // получаю последний элемент коллекции
            Console.WriteLine(last);
            var sin = clearNums.Single(a => a == 1);// получаю элемент с конкретным значением
            Console.WriteLine(sin);
            var element = clearNums.ElementAt(0); // получение элемента по индексу
            Console.WriteLine(element);
        }
    }
}
