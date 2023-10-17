using _32_Резня_капусты.texture;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32_Резня_капусты
{
    public partial class GenForm : Form
    {
        private int genCount = 1;
        FieldTexture field;
        public GenForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            //field = new FieldTexture(mainWindow.ColorForm.prevColorRange);
            //field.Draw(basePanel);
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void speedValue_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textbox.Text, "^[0-9]+$"))
            {
                genCount = int.Parse(textbox.Text);
            }
            else
            {
                MessageBox.Show("Некорретный ввод!");
            }
        }
    }
}
