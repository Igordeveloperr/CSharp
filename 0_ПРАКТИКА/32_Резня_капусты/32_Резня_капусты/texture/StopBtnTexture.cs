using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32_Резня_капусты.texture
{
    internal class StopBtnTexture : Texture
    {
        private const string TEXT = "СТОП";
        private Button _btn;
        public StopBtnTexture(Button btn)
        {
            _btn = btn;
        }

        public override void Draw(Panel basePanel)
        {
            _btn.BackColor = Color.Red;
            _btn.Text = TEXT;
        }
    }
}
