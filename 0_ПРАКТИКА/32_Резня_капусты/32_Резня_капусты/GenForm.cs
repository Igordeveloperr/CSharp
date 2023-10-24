using _32_Резня_капусты.texture;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private List<PictureBox> _cells = new List<PictureBox>(100);
        public GenForm(List<PictureBox> cells)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ControlBox = false;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            FillField(cells);
        }

        // изначальное заполнение поля
        private void FillField(List<PictureBox> cells)
        {
            foreach (var cell in cells)
            {
                PictureBox cellItem = new PictureBox();
                cellItem.Width = 65;
                cellItem.Height = 50;
                cellItem.SizeMode = PictureBoxSizeMode.CenterImage;
                cellItem.Image = cell.Image;
                cellItem.Tag = cell.Tag;
                cellItem.Click += CellClickHendler;
                panel.Controls.Add(cellItem);
            }
        }

        // обработка клика по ячейке
        public void CellClickHendler(object sender, EventArgs e)
        {
            PictureBox cell = (PictureBox)sender;
            MessageBox.Show(Convert.ToString(cell.Tag));
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

        private void GenForm_Shown(object sender, EventArgs e)
        {
           
        }
    }
}
