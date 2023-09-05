// анонимные методы

MsgDelegate func = delegate (string message)
{
    Console.WriteLine(message);
};
func("hello");

// лямбды
Action print = () => Console.WriteLine("ЛЯмбдыа");
print();

MathDelegate sum = (int x, int y) => x + y;
int res = sum(10, 67);
Console.WriteLine(res);

MathDelegate div = (int x, int y) => 
{
    if (y == 0) throw new DivideByZeroException("Делитель равен нулю!");
    return x / y;
};
res = div(10, 3);
Console.WriteLine(res);

delegate void MsgDelegate(string text);
delegate int MathDelegate(int x, int y);