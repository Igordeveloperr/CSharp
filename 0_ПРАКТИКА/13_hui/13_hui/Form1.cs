using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_hui
{
    public partial class Form1 : Form
    {
        private List<Color> colors = new List<Color>
        {
            Color.Olive,
            Color.Red,
            Color.AliceBlue,
            Color.BlanchedAlmond,
            Color.Aqua,
            Color.Gold,
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseHover_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var index = rnd.Next(0, colors.Count);

            label1.BackColor = colors[index];
            label2.BackColor = colors[index];
            label3.BackColor = colors[index];
            label4.BackColor = colors[index];
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.White;
            label2.BackColor = Color.White;
            label3.BackColor = Color.White;
            label4.BackColor = Color.White;
        }
    }
}
