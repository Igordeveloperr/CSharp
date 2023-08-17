using System.Text;

string path = "./data.txt";
// using - создает локальную область видимости и удаляет объект через Dispose после выхода из нее
using(var writer = new StreamWriter(path, true, Encoding.UTF8))
{
    // записываем данные в файл
    writer.WriteLine("Я ХОЧУ ПИЦЦЫ");
}

using(var reader = new StreamReader(path))
{
    // читаем данные из файла
    Console.WriteLine(reader.ReadToEnd());
}