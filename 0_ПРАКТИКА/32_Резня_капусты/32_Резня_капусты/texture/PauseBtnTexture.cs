using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32_Резня_капусты.texture
{
    internal class PauseBtnTexture : Texture
    {
        private const string TEXT = "Пауза";
        private Button _btn;

        public PauseBtnTexture(Button btn)
        {
            _btn = btn;
        }

        public override void Draw(Panel basePanel)
        {
            _btn.BackColor = Color.LightSeaGreen;
            _btn.Text = TEXT;
        }
    }
}
