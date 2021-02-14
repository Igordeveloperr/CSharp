using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_Gokhlia_Money.chart
{
    internal class ChartProperties
    {
        internal double[] XPoints { get; }
        internal double[] YPoints { get; }
        public ChartProperties(string[] x, string[] y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentException("null argument");
            }
            XPoints = ParseToDoublePoint(x);
            YPoints = ParseToDoublePoint(y);
        }

        private double[] ParseToDoublePoint(string[] array)
        {
            List<double> resultPoints = new List<double>();
            for (int i = 0; i < array.Length; i++)
            {
                if (Double.TryParse(array[i], out double res))
                {
                    resultPoints.Add(res);
                }
            }
            return resultPoints.ToArray();
        }
    }
}
