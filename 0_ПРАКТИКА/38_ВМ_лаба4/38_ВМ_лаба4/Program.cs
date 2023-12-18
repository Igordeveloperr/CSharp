using _38_ВМ_лаба4;

#region Simpson
Console.WriteLine("Вычислить определенный интеграл с помощью формулы Симпсона");
Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("f(x) = 1 / sqrt(2*x^2+1.3)");
Console.WriteLine("[1;2], E = 0.0001");
var simps = new SimpsonMethod(1,2,100);
var res = simps.CalcSquare();
Console.WriteLine($"Ответ: {Math.Round(res, 6)}");
#endregion

Console.WriteLine();

#region Trap
Console.WriteLine("Вычислить определенный интеграл с помощью формулы Трапеций");
Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("f(x) = tg(x^2)/(x^2+1)");
Console.WriteLine("[0.2;1], E = 0.0001");
TrapezoidMethod trap = new TrapezoidMethod(0.2, 1);
Console.WriteLine($"Ответ: {trap.CalcSquare()}");
#endregion

Console.WriteLine();

#region Gauss

#endregion

Console.ReadLine();