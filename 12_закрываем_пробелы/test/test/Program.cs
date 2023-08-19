using test;

#region Destructor
/*string mark;
DateTime year;

var bmw = new Car("BMW", DateTime.Now);
bmw.Deconstruct(out mark, out year);
Console.WriteLine(mark);
Console.WriteLine(year);*/
#endregion

#region Structure
/*MyFile file = new MyFile("./data.txt");
file.PrintPath();

// копирование структуры
MyFile secondFile = new MyFile();
secondFile = file;
secondFile.PrintPath();*/
#endregion

#region Null-type
/*// разрешаю присваивать null типу
int? age = null; // ЧЗХ ЭТО РЕАЛЬНО
// операции с nullable-типами
age = 12;
int? x = age + 10; // результатом всегда должен быть nullable-тип*/
#endregion

#region operation ??
/*string? token = null;
string accessToken = token ?? "ah11dao921kl2j1g";
Console.WriteLine(accessToken);

int? x = 299;
int y = x ?? 1488;
Console.WriteLine(x);*/
#endregion

#region operation ?.
/*void PrintInfo(Person? person)
{
    if(person != null)
    {
        Console.WriteLine($"{person.Work?.Length}");
        Console.WriteLine(person.Age);
    }
}

Person person = new Person("microsoft",23);
PrintInfo(person);*/
#endregion