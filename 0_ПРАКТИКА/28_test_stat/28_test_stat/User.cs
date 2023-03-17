using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_test_stat
{
    internal class User
    {
        private List<double> time;
        public List<double> Time
        {
            get
            {
                return time;
            }
            set
            {
                if (value != null)
                {
                    time = value;
                }
            }
        }
    }
}
