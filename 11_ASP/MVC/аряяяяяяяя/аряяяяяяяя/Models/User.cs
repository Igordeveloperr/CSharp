using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace аряяяяяяяя.Models
{
    public class User
    {
        public double Time { get; set; }
        public string Name { get; set; }
        public List<double> Times { get; set; }
        public User(double time, string name, List<double> times)
        {
            Time = time;
            Name = name;
            Times = times;
        }
    }
}
