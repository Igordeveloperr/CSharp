using _38_ВМ_лаба4;

#region Simpson
/*
Console.WriteLine("Вычислить определенный интеграл с помощью формулы Симпсона");
Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("f(x) = 1 / sqrt(2*x^2+1.3)");
Console.WriteLine("[1;2], E = 0.0001");
var simps = new SimpsonMethod(1,2,100);
var res = simps.CalcSquare();
Console.WriteLine($"Ответ: {Math.Round(res, 6)}");*/
#endregion

Console.WriteLine();

#region Trap
/*
Console.WriteLine("Вычислить определенный интеграл с помощью формулы Трапеций");
Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("f(x) = tg(x^2)/(x^2+1)");
Console.WriteLine("[0.2;1], E = 0.0001");
TrapezoidMethod trap = new TrapezoidMethod(0.2, 1);
Console.WriteLine($"Ответ: {trap.CalcSquare()}");*/
#endregion

Console.WriteLine();

#region Gauss
/*Console.WriteLine("Квадратурная формула Гаусса");
Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine("Для 5 узлов:");
Console.WriteLine("x1 = -0,90618");
Console.WriteLine("x2 = -0,538469");
Console.WriteLine("x3 = 0");
Console.WriteLine("x4 = 0,538469");
Console.WriteLine("x5 = 0,90618");
Console.WriteLine("A1 = A5 = 0,23698");
Console.WriteLine("A2 = A4 = 0,47863");
Console.WriteLine("A3 = 0,56889");
var gaus = new GaussMethod(0.5, 1.6);
Console.WriteLine($"Ответ: { gaus.CalcN5Square()}");
Console.WriteLine();
Console.WriteLine("Для 8 узлов:");
Console.WriteLine("x1 = -0,96028986");
Console.WriteLine("x2 = -0,79666648");
Console.WriteLine("x3 = -0,52553242");
Console.WriteLine("x4 = -0,18343464");
Console.WriteLine("x5 = 0,18343464");
Console.WriteLine("x6 = 0,52553242");
Console.WriteLine("x7 = 0,79666648");
Console.WriteLine("x8 = 0,96028986");
Console.WriteLine("A1 = A8 = 0,10122854");
Console.WriteLine("A2 = A7 = 0,22238103");
Console.WriteLine("A3 = A6 = 0,31370664");
Console.WriteLine("A4 = A5 = 0,36268378");
Console.WriteLine($"Ответ: {gaus.CalcN8Square()}");*/
#endregion

Console.WriteLine();

#region Diff
Console.WriteLine("Дифф уравнение");
Console.WriteLine("---------------------------------------------------------------");
var ali = new AillerMethod(0, 1);
ali.Calc();
#endregion