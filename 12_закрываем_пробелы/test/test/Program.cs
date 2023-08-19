using test;

string mark;
DateTime year;

var bmw = new Car("BMW", DateTime.Now);
bmw.Deconstruct(out mark, out year);
Console.WriteLine(mark);
Console.WriteLine(year);