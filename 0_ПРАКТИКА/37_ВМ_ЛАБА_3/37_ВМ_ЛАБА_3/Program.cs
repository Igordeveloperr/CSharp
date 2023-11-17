using _37_ВМ_ЛАБА_3;

#region Lagrange
/*LagInterpolation lagInterpolation = new LagInterpolation();
double y = Math.Round(lagInterpolation.Interpolate(0.526), 7);
Console.WriteLine($"Ответ: y(0.526) = {y}");*/
#endregion

#region Newton
NewtonInterpolation newtonInterpolation = new NewtonInterpolation();
Console.WriteLine("Ответ: ");
Console.WriteLine($"y(0.1511) = {Math.Round(newtonInterpolation.CalcPolinom(0.1511),7)}");
Console.WriteLine($"y(0.6340) = {Math.Round(newtonInterpolation.CalcPolinom(0.6340),7)}");
Console.WriteLine($"y(0.143) = {Math.Round(newtonInterpolation.CalcPolinom(0.143), 7)}");
Console.WriteLine($"y(0.673) = {Math.Round(newtonInterpolation.CalcPolinom(0.673), 7)}");
#endregion