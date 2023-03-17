using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_test_stat
{
    internal class ProgressObject
    {
        public double Percent { get; set; }
        public double Difference { get; set; }
        public ProgressObject(double percent, double difference)
        {
            Percent = percent;
            Difference = difference;
        }
    }
}
