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
Console.WriteLine("y = ax^b");
Console.WriteLine();
kvadrat.PrintTable();
Console.WriteLine();
Console.WriteLine("y = 8.8771963612802 * x^0.667119338850096");
kvadrat.SKO();
#endregion

Console.ReadLine();