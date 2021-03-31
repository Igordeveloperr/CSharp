using System;
using System.Collections.Generic;
using System.Text;

namespace _12_LINQ
{
    internal class Product
    {
        public string Name { get; set; }
        public int Energy { get; set; }
        public override string ToString()
        {
            return $"{Name} - {Energy}";
        }
    }
}
