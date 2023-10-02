using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32_Резня_капусты.texture
{
    internal class StartBtnTexture : Texture
    {
        private const string TEXT = "Старт";
        private Button _btn;
        public StartBtnTexture(Button btn)
        {
            _btn = btn;
        }

        public override void Draw(Panel basePanel)
        {
            _btn.BackColor = Color.ForestGreen;
            _btn.Text = TEXT;
        }
    }
}
