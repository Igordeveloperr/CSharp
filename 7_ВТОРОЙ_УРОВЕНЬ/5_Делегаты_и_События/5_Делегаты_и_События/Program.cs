using System;

namespace _5_Делегаты_и_События
{
    class Program
    {   // объявление делегата
        public delegate void MyDelegate();
        public delegate int NumberDelegate(int i);
        // создание события
        public event MyDelegate Event;
        static void Main(string[] args)
        {
            MyDelegate myDelegate = Method1;
            // добавление метода в делегат
            myDelegate += Method2;
            myDelegate();

            MyDelegate myDelegate1 = new MyDelegate(Method3);
            myDelegate1();

            var numDel = new NumberDelegate(MethodValue);
            numDel(new Random().Next(0, 100));

            // уже готовые делегаты
            var action = new Action(Method2);
            Predicate<int> predicate;

            Func<int,int> func = MethodValue;
            // работа с событием
            var person = new Person();
            person.Name = "Вася";
            // подписываюсь на событие и вешаю обработчик
            person.GoToSleep += Person_GoToSleep;
            person.TakeTime(DateTime.Parse("21.11.2020 8:36:12"));
            
            // еще событие
            person.GoToSchool += Person_GoToSchool;
            person.GoToSchool += Eat_Before_School;
            person.TakeTime(DateTime.Parse("21.11.2020 21:45:9"));
        }
        private static void Eat_Before_School(object sender, EventArgs e)
        {
            if(sender is Person)
            {   
                
                var obj = (Person)sender;
                obj.Calories += 239;
                Console.WriteLine($"Похавал: {obj.Calories}");
            }
        }
        private static void Person_GoToSchool(object sender, EventArgs e)
        {   
            if(sender is Person)
            {
                var obj = (Person)sender;
                obj.Calories -= 79;
                Console.WriteLine($"{obj.Name} работает!");
                Console.WriteLine($"Потратил: {obj.Calories}");
            }
        }

        private static void Person_GoToSleep()
        {
            Console.WriteLine("Человек ушел спать");
            Console.ReadLine();
        }

        public static int MethodValue(int i)
        {
            Console.WriteLine(i);
            return i;
        }
        public static void Method1()
        {
            Console.WriteLine("глухой метод 1");
        }
        public static int Method4()
        {
            return 10 * 8 - 1;
        }
        public static void Method2()
        {
            Console.WriteLine("глухой метод 2");
        }
        public static void Method3()
        {
            Console.WriteLine("глухой метод 3");
        }
    }
}
