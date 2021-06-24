using System;
using System.Collections.Generic;
using System.Text;

namespace _10_filehelper.create
{
    public abstract class Creator
    {
        protected string Path;

        public Creator(string path)
        {
            if (!string.IsNullOrWhiteSpace(path))
            {
                Path = path;
            }
        }

        public abstract void Create(string name);
    }
}
