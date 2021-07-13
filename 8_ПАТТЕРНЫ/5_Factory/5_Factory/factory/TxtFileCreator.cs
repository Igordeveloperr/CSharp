using _5_Factory.files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _5_Factory.factory
{
    internal class TxtFileCreator : FileCreator
    {
        public TxtFileCreator(string fileName) : base(fileName)
        {

        }
        public override MyFile CreateFile()
        {
            MessageBox.Show(_fileName);
            return new TxtFile(_fileName);
        }
    }
}
