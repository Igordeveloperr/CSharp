using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32_Резня_капусты
{
    public partial class Form2 : Form
    {
        private Dictionary<string, Color> _colors = new Dictionary<string, Color>()
        {
            { "Красный", Color.Red },
            { "Синий", Color.Blue },
            { "Желтый", Color.Yellow },
            { "Зеленый", Color.Green },
            { "Фиолетовый", Color.Purple },
            { "Голубой", Color.LightBlue },
            { "Розовый", Color.Pink },
            { "Коричневый", Color.Brown },
            { "Черный", Color.Black },
            { "Серебряный", Color.Silver },
            { "Золотой", Color.Gold },
            { "Ораньжевый", Color.Orange },
            { "Серый", Color.Gray },
            { "Малиновый", Color.Crimson },
            { "Белый", Color.White }
        };

        public Form2()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        // обработка полей для выбора цвета
        private void colorBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void colorBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void colorBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void colorBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void colorBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void colorBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void colorBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void colorBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void colorBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void colorBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
