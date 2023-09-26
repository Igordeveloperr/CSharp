using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32_Резня_капусты.texture
{
    internal abstract class ITexture
    {
        public const int MAX_X = 1172;
        public const int MAX_Y = 670;
        public abstract void Draw(Graphics graphics);
    }
}
