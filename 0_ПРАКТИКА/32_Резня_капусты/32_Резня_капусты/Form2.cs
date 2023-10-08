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
            { "Белый", Color.White },
        };

        private List<Color> _cacheColors = new List<Color>();
        private List<Color> colorRange = new List<Color>(new Color[10]);

        public Form2()
         {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        // обработка полей для выбора цвета
        private void SelectColor(ComboBox sender)
        {
            if(sender.Text != string.Empty)
            {
                Color color = _colors[sender.Text];
                if (!colorRange.Contains(color) && _cacheColors.Contains(color))
                {
                    _cacheColors.Remove(color);
                }

                if (_cacheColors.Contains(color))
                {
                    MessageBox.Show("Такой цвет уже выбран!");
                    int index = Convert.ToInt32(sender.Tag);
                    colorRange[index] = Color.Empty;
                    sender.Text = string.Empty;
                }
                else
                {
                    _cacheColors.Add(color);
                    int index = Convert.ToInt32(sender.Tag);
                    colorRange[index] = color;
                }
            }
        }

        // клик по кнопе ОК
        private void okBtn_Click(object sender, EventArgs e)
        {

        }

        // клик по кнопке Отмена
        private void noBtn_Click(object sender, EventArgs e)
        {

        }

        private void colorBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectColor((ComboBox)sender);
        }

        private void colorBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectColor((ComboBox)sender);
        }

        private void colorBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectColor((ComboBox)sender);
        }

        private void colorBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectColor((ComboBox)sender);
        }

        private void colorBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectColor((ComboBox)sender);
        }

        private void colorBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectColor((ComboBox)sender);
        }

        private void colorBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectColor((ComboBox)sender);
        }

        private void colorBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectColor((ComboBox)sender);
        }

        private void colorBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectColor((ComboBox)sender);
        }

        private void colorBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectColor((ComboBox) sender);
        }
    }
}
