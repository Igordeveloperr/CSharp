using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                На взгляд у нас 2 инстанса класса FileWorkerSingleton, 
                но на самом деле они ссылаются на один и тот же единственный
                объект класса, который хранится в свойстве Instance. В этом и заключается
                паттерн Singleton - единство объекта
             */
            FileWorkerSingleton singleton = FileWorkerSingleton.Instance;
            FileWorkerSingleton singleton1 = FileWorkerSingleton.Instance;
            singleton.WriteToFile("Hello from first!");
            singleton1.WriteToFile("Kaavo from second!");
            singleton1.WriteToFile("Beat ybit..........");
            singleton.Save();
            var singleton2 = FileWorkerSingleton.Instance;
            singleton2.ReadTextFromFile();
        }
    }
}
