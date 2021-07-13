using _5_Factory.files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Factory.factory
{
    internal abstract class FileCreator
    {
        private MyFile _file;
        protected string _fileName;
        public FileCreator(string fileName)
        {
            _fileName = fileName;
        }
        public abstract MyFile CreateFile();
    }
}
