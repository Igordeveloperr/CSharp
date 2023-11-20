using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_ВМ_ЛАБА_3
{
    internal class LagInterpolation
    {
        public LagInterpolation()
        {
            
        }

        public void PrintTables()
        {
            Console.WriteLine("{0,10}  {1,10}", "X", "Y");
            Console.WriteLine("{0,10}  {1,10}", 0.35, 2.73951);
            Console.WriteLine("{0,10}  {1,10}", 0.41, 2.30080);
            Console.WriteLine("{0,10}  {1,10}", 0.47, 1.96864);
            Console.WriteLine("{0,10}  {1,10}", 0.51, 1.78776);
            Console.WriteLine("{0,10}  {1,10}", 0.56, 1.59502);
            Console.WriteLine("{0,10}  {1,10}", 0.64, 1.34310);

            Console.WriteLine();

            Console.WriteLine("{0,10}  {1,10}  {2,10}  {3,10}  {4,10}  {5,10}  {6,10}","xi-x1", "xi-x2", "xi-x3", "xi-x4", "xi-x5", "П", "yi/П");
            Console.WriteLine("{0,10}  {1,10}  {2,10}  {3,10}  {4,10}  {5,10}  {6,10}", -0.06, -0.12, -0.16, -0.21, -0.29, -0.0000701568, -39048.3887521);
            Console.WriteLine("{0,10}  {1,10}  {2,10}  {3,10}  {4,10}  {5,10}  {6,10}", 0.06, -0.06, -0.1, -0.15, -0.23, 0.000414, 5557.4879227);
            Console.WriteLine("{0,10}  {1,10}  {2,10}  {3,10}  {4,10}  {5,10}  {6,10}", 0.12, 0.06, -0.04, -0.09, -0.17, -0.0000044064, -446768.3369644);
            Console.WriteLine("{0,10}  {1,10}  {2,10}  {3,10}  {4,10}  {5,10}  {6,10}", 0.16, 0.1, 0.04, -0.05, -0.13, 0.00000416, 429750);
            Console.WriteLine("{0,10}  {1,10}  {2,10}  {3,10}  {4,10}  {5,10}  {6,10}", 0.21, 0.15, 0.09, 0.05, -0.08, -0.00001134, -140654.3209877);
            Console.WriteLine("{0,10}  {1,10}  {2,10}  {3,10}  {4,10}  {5,10}  {6,10}", 0.29, 0.23, 0.17, 0.13, 0.08, 0.0001179256, 11389.3844933);

            Console.WriteLine();
        }

        public double Interpolate(double x)
        {
            return 2.73951 * L1(x) + 2.30080 * L2(x) + 1.96864 * L3(x) + 1.78776 * L4(x) + 1.59502 * L5(x) + 1.34310 * L6(x);
        }

        private double L1(double x)
        {
            return (x-0.41)/(-0.06) * (x-0.47)/(-0.12) * (x-0.51)/(-0.16) * (x-0.56)/(-0.21) * (x-0.64)/(-0.29);
        }

        private double L2(double x)
        {
            return (x - 0.35) / (0.06) * (x - 0.47) / (-0.06) * (x - 0.51) / (-0.1) * (x - 0.56) / (-0.15) * (x - 0.64) / (-0.23);
        }

        private double L3(double x)
        {
            return (x - 0.35) / (0.12) * (x - 0.41) / (0.06) * (x - 0.51) / (-0.04) * (x - 0.56) / (-0.09) * (x - 0.64) / (-0.17);
        }
        private double L4(double x)
        {
            return (x - 0.35) / (0.16) * (x - 0.41) / (0.1) * (x - 0.47) / (0.04) * (x - 0.56) / (-0.05) * (x - 0.64) / (-0.13);
        }
        private double L5(double x)
        {
            return (x - 0.35) / (0.21) * (x - 0.41) / (0.15) * (x - 0.47) / (0.09) * (x - 0.51) / (0.05) * (x - 0.64) / (-0.08);
        }
        private double L6(double x)
        {
            return (x - 0.35) / (0.29) * (x - 0.41) / (0.23) * (x - 0.47) / (0.17) * (x - 0.51) / (0.13) * (x - 0.56) / (0.08);
        }
    }
}
