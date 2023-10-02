using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32_Резня_капусты.texture
{
    internal class ContinueBtnTexture : Texture
    {
        private const string TEXT = "Продолжить";
        private Button _btn;

        public ContinueBtnTexture(Button btn)
        {
            _btn = btn;
        }

        public override void Draw(Panel basePanel)
        {
            _btn.BackColor = Color.DarkGoldenrod;
            _btn.Text = TEXT;
        }
    }
}
