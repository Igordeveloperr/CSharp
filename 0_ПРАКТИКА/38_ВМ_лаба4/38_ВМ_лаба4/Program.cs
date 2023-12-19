using _38_ВМ_лаба4;

#region Trap
Console.WriteLine("Вычислить определенный интеграл с помощью формулы Трапеций");
Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("f(x) = 1/sqrt(x^2+1)");
Console.WriteLine("[0.2;1.2], E = 0.0001");
Console.WriteLine("h = 0.01");
TrapezoidMethod trap = new TrapezoidMethod(0.2, 1.2);
Console.WriteLine($"Ответ: {trap.CalcSquare()}");
#endregion

Console.WriteLine();

#region Simpson
Console.WriteLine("Вычислить определенный интеграл с помощью формулы Симпсона");
Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("f(x) = cos(x)/(x+1)");
Console.WriteLine("[0.6;1.4], E = 0.0001");
var simps = new SimpsonMethod(0.6,1.4,100);
Console.WriteLine();
Console.WriteLine("h = 0.01");
var res1 = simps.CalcSquare();
Console.WriteLine($"Ответ: I1 = {Math.Round(res1, 6)}");
Console.WriteLine();
Console.WriteLine("h/2 = 0.005");
var res2 = simps.CalcSquareWithHDiv2();
Console.WriteLine($"Ответ: I2 = {Math.Round(res2, 6)}");
Console.WriteLine($"|I1 - I2| = {Math.Abs(res1 - res2)}");
Console.WriteLine("|I1 - I2| < E |=> I1 = I2");
#endregion


Console.WriteLine();

#region Gauss
Console.WriteLine("Квадратурная формула Гаусса");
Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine("Для 4 узлов:");
Console.WriteLine("x1 = -0,86114");
Console.WriteLine("x2 = -0,33998");
Console.WriteLine("x3 = 0,33998");
Console.WriteLine("x4 = 0,86114");
Console.WriteLine("A1 = A4 = 0,34785");
Console.WriteLine("A2 = A3 = 0,65215");
var gaus = new GaussMethod(2.2, 3.4);
Console.WriteLine($"Ответ: { gaus.CalcN5Square()}");
Console.WriteLine();
Console.WriteLine("Для 7 узлов:");
Console.WriteLine("x1 = -0,949107912");
Console.WriteLine("x2 = -0,741531186");
Console.WriteLine("x3 = -0,405845151");
Console.WriteLine("x4 = 0");
Console.WriteLine("x5 = 0,405845151");
Console.WriteLine("x6 = 0,741531186");
Console.WriteLine("x7 = 0,949107912");
Console.WriteLine("A1 = A7 = 0,129484966");
Console.WriteLine("A2 = A6 = 0,279705391");
Console.WriteLine("A3 = A5 = 0,381830051");
Console.WriteLine("A4=0,417959184");
Console.WriteLine($"Ответ: {gaus.CalcN8Square()}");
#endregion

Console.WriteLine();

#region Diff
Console.WriteLine("Дифф уравнение");
Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("y' = 2*x^2+3*y");
Console.WriteLine("y(0) = 0.2; h = 0.1; 0<=x<=1; a = 1/2;");
Console.WriteLine("y(x) = 0.348148*e^(3*x) - 0.444444*x - 0.666667*x^(2) - 0.148148");
Console.WriteLine();
var ali = new AillerMethod(0, 1);
Console.WriteLine("h = 0.1");
ali.CalcWithH();
Console.WriteLine();
Console.WriteLine("h = 0.05");
ali.CalcWithHDiv2();
#endregion

Console.ReadLine();
