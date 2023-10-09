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
        public List<Color> colorRange { get; private set; }
        private List<ComboBox> defList;

        public Form2()
         {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ControlBox = false;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Setup();
        }

        private void Setup()
        {
            colorRange = new List<Color>
            {
                Color.Red, Color.Blue, Color.Yellow, Color.Green, Color.Purple,
                Color.LightBlue, Color.Pink, Color.Brown, Color.Black, Color.Silver
            };

            colorBox1.Text = "Красный";
            colorBox2.Text = "Синий";
            colorBox3.Text = "Желтый";
            colorBox4.Text = "Зеленый";
            colorBox5.Text = "Фиолетовый";
            colorBox6.Text = "Голубой";
            colorBox7.Text = "Розовый";
            colorBox8.Text = "Коричневый";
            colorBox9.Text = "Черный";
            colorBox10.Text = "Серебряный";
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
            Hide();
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
