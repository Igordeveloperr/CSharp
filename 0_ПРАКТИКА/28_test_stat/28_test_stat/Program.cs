using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_test_stat
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Time = new List<double>() { 14.11, 13.08, 12.86, 12.3 };
            Console.WriteLine("Ведите новый результат:");
            string data = Console.ReadLine().Replace(".",",");
            if (Double.TryParse(data, out double res))
            {
                Progress progress = new Progress();
                ProgressObject obj = progress.GetProgressPercent(user.Time.Last(), res);
                progress.AssessProgress(obj);
                Console.WriteLine(progress.GetMothAverageTime(user.Time));
            }
            else
            {
                Console.WriteLine("Вы ввели не корректные данные!");
            }
            Console.ReadLine();
        }
    }
}
