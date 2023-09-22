using ConsoleApp3;

Console.ForegroundColor = ConsoleColor.Green;

const string separator = "--------------";
double a = 0.8;
double b = 1.7;
MathFunction function = new MathFunction();

Console.WriteLine($"f(x) = x - sqrt(ln(x+2)) \n {separator}");
Console.WriteLine($"a = {a}, b = {b} \n {separator}");
Console.WriteLine($"f(a) = {function.Calculate(a)}");
Console.WriteLine($"f(b) = {function.Calculate(b)} \n {separator}");
Console.WriteLine($"f``(a) = {function.CalculateSecondDerivative(a)}");
Console.WriteLine($"f``(b) = {function.CalculateSecondDerivative(b)} \n {separator}");

CombinedMethod combinedMethod = new CombinedMethod
(
   function.Calculate(a),
   function.Calculate(b),
   function.CalculateSecondDerivative(a),
   function.CalculateSecondDerivative(b),
   a,
   b
);

combinedMethod.DetermineDirOfCalc();
Console.WriteLine($"Ответ: x = {combinedMethod.CalculateRoot()}");

Console.ForegroundColor = ConsoleColor.White;