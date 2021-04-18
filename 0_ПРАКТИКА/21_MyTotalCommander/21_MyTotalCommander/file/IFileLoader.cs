using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_MyTotalCommander.file
{
    internal interface IFileLoader
    {
        void LoadFileSpace(ListBox output, string path);
    }
}
