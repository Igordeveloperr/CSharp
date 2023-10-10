using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Резня_капусты.settings
{
    [Serializable]
    public class SettingsObj
    {
        public Color Color0 { get; set; }
        public Color Color1 { get; set; }
        public Color Color2 { get; set; }
        public Color Color3 { get; set; }
        public Color Color4 { get; set; }
        public Color Color5 { get; set; }
        public Color Color6 { get; set; }
        public Color Color7 { get; set; }
        public Color Color8 { get; set; }
        public Color Color9 { get; set; }
        public int Speed { get; set; }
        public int Probability { get; set; }
    }
}
