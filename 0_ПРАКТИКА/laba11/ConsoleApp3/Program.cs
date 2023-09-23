using ConsoleApp3;

Console.ForegroundColor = ConsoleColor.Green;

double a = 0.8;
double b = 1.7;
MathFunction function = new MathFunction();

Console.WriteLine("f(x) = x - sqrt(ln(x+2))");
Logger.DrawSeparator();
Console.WriteLine("f`(x) = 1 - 1 / (2ln(sqrt(x+2)) * (x+2))");
Logger.DrawSeparator();
Console.WriteLine("f``(x) = (2ln(sqrt(x+2)) + 1) / (4ln^2(sqrt(x+2)) * (x+2)^2)");
Logger.DrawSeparator();
Console.WriteLine($"f(a) = {function.Calculate(a)}");
Console.WriteLine($"f(b) = {function.Calculate(b)}");
Logger.DrawSeparator();
Console.WriteLine($"f``(a) = {function.CalculateSecondDerivative(a)}");
Console.WriteLine($"f``(b) = {function.CalculateSecondDerivative(b)}");
Logger.DrawSeparator();

CombinedMethod combinedMethod = new CombinedMethod
(
   function.Calculate(a),
   function.Calculate(b),
   function.CalculateSecondDerivative(a),
   function.CalculateSecondDerivative(b),
   a,
   b
);

combinedMethod.SelectDirOfCalc();
double result = combinedMethod.CalculateRoot();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Ответ: x = {result}");
Console.ForegroundColor = ConsoleColor.Green;

Console.ForegroundColor = ConsoleColor.White;