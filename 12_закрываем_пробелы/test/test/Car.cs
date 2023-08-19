using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Car
    {
        private string _mark;
        private DateTime _year;

        public Car(string mark, DateTime year)
        {
            _mark = mark;
            _year = year;
        }

        public void Deconstruct(out string mark, out DateTime year)
        {
            mark = _mark;
            year = _year;
        }
    }
}
