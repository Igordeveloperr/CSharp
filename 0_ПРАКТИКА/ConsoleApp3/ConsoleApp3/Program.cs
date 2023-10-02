List<int> list = new List<int>();

void AddNTimes(int value, int n)
{
    for (int i = 0; i < n; i++)
    {
        list.Add(value);
    }
}

AddNTimes(0, 5);
AddNTimes(1, 95);

int i = 0;
while (i < 1000)
{
    i++;
    Random rnd = new Random();
    int index = rnd.Next(0, list.Count);
    if (list[index]==0)
    {
        Console.WriteLine($"Bingo! {i}");
    }
}