using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal struct MyFile
    {
        const int MAX_SIZE = 1024;
        private byte[] _size;
        private string _path;

        public MyFile(string path)
        {
            _size = new byte[MAX_SIZE];
            _path = path;
        }

        public void PrintPath()
        {
            Console.WriteLine(_path);
        }
    }
}
