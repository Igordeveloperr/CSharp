#region Thread
/*void CountFactorial(object? number)
{
    int result = 1;
    for(int i = 1; i <= (int)number; i++)
    {
        result *= i;
    }
    Console.WriteLine($"Factorial: {result}");
}

void CountDividers(object? number)
{
    int result = 0;
    for(int i = 1; i <= (int)number; i++)
    {
        if((int)number % i == 0)
        {
            result++;
        }
    }
    Console.WriteLine($"Dividers: {result}");
}

// создаем потоки
Thread factorialTh = new Thread(new ParameterizedThreadStart(CountFactorial));
Thread dividerTh = new Thread(new ParameterizedThreadStart(CountDividers));
// запускаем вычисления
factorialTh.Start(5);
dividerTh.Start(30000);*/
#endregion

#region Async/Await

async Task CountFactorialAsync(int number)
{
    int result = 1;
    await Task.Run(()=>
    {
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
    });
    Console.WriteLine($"Factorial: {result}");
}

async Task<int> CountDividersAsync(int number)
{
    int result = 0;
    await Task.Run(async () =>
    {
        for (int i = 1; i <= number; i++)
        {
            if ((int)number % i == 0)
            {
                result++;
            }
        }
    });
    return result;
}

async Task Run()
{
    int answer = await CountDividersAsync(number: 40);
    await CountFactorialAsync(number: 5);
    Console.WriteLine($"Dividers: {answer}");
}

Run();
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
    Thread.Sleep(1000);
}
#endregion