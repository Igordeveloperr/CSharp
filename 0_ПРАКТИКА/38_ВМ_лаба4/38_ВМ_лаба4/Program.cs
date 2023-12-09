using _38_ВМ_лаба4;

Console.WriteLine("Вычислить определенный интеграл с помощью формулы Симпсона");
Console.WriteLine("---------------------------------------------------------------");
var simps = new SimpsonMethod(1,2,100);
var res = simps.CalcSquare();
Console.WriteLine($"Ответ: {Math.Round(res, 6)}");
