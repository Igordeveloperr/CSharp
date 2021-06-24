using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_MyTotalCommander.file
{
    class DirectoryLoader : IFileLoader
    {
        public void LoadFileSpace(ListBox output, string path)
        {
            if (Directory.Exists(path) && !File.Exists(path))
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach(string dir in dirs)
                {
                    output.Items.Add($"(dir): {dir}");
                }
            }
        }
    }
}
