using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _10_filehelper.create
{
    class DirectoryCreator : Creator
    {
        public DirectoryCreator(string path) : base(path){}
        public override void Create(string name)
        {
            Directory.CreateDirectory(@$"{Path}\{name}");
        }
    }
}
