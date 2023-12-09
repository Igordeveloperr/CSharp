using _38_ВМ_лаба4;

#region Simpson
/*Console.WriteLine("Вычислить определенный интеграл с помощью формулы Симпсона");
Console.WriteLine("---------------------------------------------------------------");
var simps = new SimpsonMethod(1,2,100);
var res = simps.CalcSquare();
Console.WriteLine($"Ответ: {Math.Round(res, 6)}");*/
#endregion

#region Trap
TrapezoidMethod trap = new TrapezoidMethod(0.2, 1);
Console.WriteLine(trap.CalcSquare());
#endregion