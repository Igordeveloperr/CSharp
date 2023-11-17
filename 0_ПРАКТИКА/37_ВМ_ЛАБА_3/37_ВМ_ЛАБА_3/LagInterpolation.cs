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
