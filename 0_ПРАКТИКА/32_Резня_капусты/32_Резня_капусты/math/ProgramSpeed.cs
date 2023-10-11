using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Резня_капусты.math
{
    internal class ProgramSpeed
    {
        public int ConvertToMilliseconds(int speed)
        {
            if (speed > 0)
            {
                double res = (1.0 / speed) * 1000;
                return (int)res;
            }
            return 0;
        }
    }
}
