using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_MyTotalCommander.file
{
    class FileLoader : IFileLoader
    {
        public void LoadFileSpace(ListBox output, string path)
        {
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                foreach(string file in files)
                {
                    output.Items.Add($"(file): {file}");
                }
            }
        }
    }
}
