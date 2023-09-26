using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _32_Резня_капусты
{
    public partial class Form1 : Form
    {
        // полe
        private List<PictureBox> field = new List<PictureBox>();
        private Random rnd = new Random(Guid.NewGuid().GetHashCode());
        public Form1()
        { 
            InitializeComponent();
            GenerateField();
        }

        private void GenerateField()
        {
            for(int i = 0; i < 100; i++)
            {
                PictureBox box = new PictureBox();
                box.Width = 65;
                box.Height = 50;
                box.Name = $"cell{i}";
                field.Add(box);
                string path = string.Empty;

                long a = rnd.Next(0, 1000000);
                long b = rnd.Next(0, 1000000);
                if ((a*b) % 2 == 0)
                {
                    path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\kacan.jpg");
                }
                else
                {
                    path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\krot.jpg");
                }
                box.Image = Image.FromFile(path);
                basePanel.Controls.Add(box);
            }
        }
    }
}
