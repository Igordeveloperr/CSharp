using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_MyTotalCommander.file
{
    internal class CDLoader : ICDLoader
    {
        public void LoadCdSpace(ComboBox output)
        {
            DriveInfo[] drive = DriveInfo.GetDrives();
            foreach(var d in drive)
            {
                output.Items.Add(d?.Name);
            }
        }
    }
}
