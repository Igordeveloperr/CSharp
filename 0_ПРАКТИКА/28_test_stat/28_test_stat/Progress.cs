using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_test_stat
{
    internal class Progress
    {
        public ProgressObject GetProgressPercent(double time, double res)
        {
            double all = time+res;
            double difference =time-res;
            double percent = Math.Round(difference * 100 / all,4);
            return new ProgressObject(percent, difference);
        }
        public void AssessProgress(ProgressObject obj)
        {
            if (obj.Difference < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{obj.Percent}% по сравнению с прошлым результатом");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"+{obj.Percent}% по сравнению с прошлым результатом");
            }
        }
        public double GetMothAverageTime(List<double> list)
        {
            double average = Math.Round((list.Sum()) / list.Count,4);
            return average;
        }
    }
}
