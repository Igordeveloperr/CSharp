using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Рефлексия
{
    public class Photo
    { 
        public string Path { get; set; }
        [Geo(2, 211)]
        public string Name { get; set; }
        public Photo(string path, string name)
        {
            Path = path;
            Name = name;
        }
    }
}
