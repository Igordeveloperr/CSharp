using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProg
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] arrLogins = new string[,]
        {
            {"Sparrow14", "1234"},
            {"Goblin", "12333"},
            {"Yury88", "2281488"}
        };

            string a = Console.ReadLine();

            //height arr
            for (int i = 0; i < arrLogins.GetLength(0); i++)
            {
                    if (arrLogins[i, 0] == a)
                    {
                        Console.WriteLine(a);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("yt ghjitk");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
