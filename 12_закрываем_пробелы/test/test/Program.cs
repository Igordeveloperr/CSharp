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
// разрешаю присваивать null типу
int? age = null; // ЧЗХ ЭТО РЕАЛЬНО
// операции с nullable-типами
age = 12;
int? x = age + 10; // результатом всегда должен быть nullable-тип
#endregion