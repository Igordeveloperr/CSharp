using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Factory.files
{
    internal abstract class MyFile
    {
        protected string _fileName;
        public MyFile(string fileName)
        {
            _fileName = fileName;
        }
    }
}
