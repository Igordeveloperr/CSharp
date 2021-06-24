using System;

namespace _1_Классы
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаю инстанс класса Person
            Person person = new Person();
            // обращаюсь к свойствам объекта person
            person.FirstName = "Ded";
            person.LastName = "Inside";
            Console.WriteLine(person.FirstName + " " + person.LastName);

            // создаю еще один объект и также задаю значения свойствам объекта
            Person p2 = new Person();
            p2.FirstName = "Ivan";
            p2.LastName = "Ban";

            // проверка унаследования свойст доктору
            Doctor doc = new Doctor();
            doc.FirstName = "Bob";
            doc.LastName = "Serevanov";

            // полеморфизм
            Person doctor = new Doctor();
            Doctor docwork = (Doctor)doctor;
            docwork.City = "Moscow";
            Console.WriteLine(docwork.City);
        }
    }
}
