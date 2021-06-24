using System;

namespace _2_Еще_Классы
{
    class Program : Person
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            // проверяю методы get и set
            p.Name = "Bob";
            p.SecondName = "Alexandrovich";
            Console.WriteLine(p.FullName);

            // проверяю работу конструктора
            Animal tiger = new Animal("predator");
            Console.WriteLine(tiger.Type);
        }
    }
}
