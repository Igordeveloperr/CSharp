using System;

namespace _1_Связный_список
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(34);
            list.Remove(2);
            list.AppendFirst(3453);
            foreach(var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
