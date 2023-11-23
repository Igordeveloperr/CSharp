using _37_ВМ_ЛАБА_3;

#region Lagrange
Console.WriteLine("Метод Лагранжа");
Console.WriteLine("-------------------------------------");
LagInterpolation lagInterpolation = new LagInterpolation();
double y = Math.Round(lagInterpolation.Interpolate(0.526), 7);
lagInterpolation.PrintTables();
Console.WriteLine($"Ответ: y(x = 0.526) = {y}");
#endregion

Console.WriteLine();

#region Newton
Console.WriteLine("Метод Ньютона");
Console.WriteLine("-------------------------------------");
NewtonInterpolation newtonInterpolation = new NewtonInterpolation();
Console.WriteLine();

Console.WriteLine("P_1:");
double ans1 = Math.Round(newtonInterpolation.CalcPolinom(0.1511), 7);

Console.WriteLine("P_2:");
double ans2 = Math.Round(newtonInterpolation.CalcSecondPolinom(0.6340), 7);

Console.WriteLine("P_3:");
double ans3 = Math.Round(newtonInterpolation.CalcPolinom(0.143), 7);

Console.WriteLine("P_4:");
double ans4 = Math.Round(newtonInterpolation.CalcSecondPolinom(0.673), 7);

Console.WriteLine("Ответ: ");
Console.WriteLine($"y(x = 0.1511) = {ans1}");
Console.WriteLine($"y(x = 0.6340) = {ans2}");
Console.WriteLine($"y(x = 0.143) = {ans3}");
Console.WriteLine($"y(x = 0.673) = {ans4}");
#endregion

Console.WriteLine();

#region Naimensh Kvadrat
var kvadrat = new KvadratMethod();
Console.WriteLine("Метод наименьших квадратов");
Console.WriteLine("-------------------------------------");
Console.WriteLine(" X    Y");
Console.WriteLine("0.1  1.91");
Console.WriteLine("0.2  3.03");
Console.WriteLine("0.3  3.98");
Console.WriteLine("0.4  4.82");
Console.WriteLine("0.5  5.59");
Console.WriteLine("0.6  6.31");
Console.WriteLine("0.7  7.00");
Console.WriteLine("0.8  7.65");
Console.WriteLine("0.9  8.27");
Console.WriteLine("1.0  8.88");
Console.WriteLine();
Console.WriteLine("y = ax + b");
Console.WriteLine();
Console.WriteLine("{0,10}   {1,10}  {2,10}  {3,10}","E x_i*y_i","E (x_i)^2","E x_i","E y_i");
Console.WriteLine("{0,10}   {1,10}  {2,10}  {3,10}",37.843, 3.85, 5.5, 57.44);
Console.WriteLine();
Console.WriteLine("y = 7.5769697*x + 1.57666666");
Console.WriteLine("СКО = 0.4298");
#endregion