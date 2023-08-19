using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Person
    { 
        public string? Work { get; private set; }
        public int Age { get; private set; }

        public Person(int age)
        {
            Age = age;
        }
        public Person(string work, int age)
        {
            Work = work;
            Age = age;
        }
    }
}
