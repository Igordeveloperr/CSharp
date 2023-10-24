using _32_Резня_капусты.texture;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32_Резня_капусты
{
    public partial class GenForm : Form
    {
        private int genCount = 1;
        private List<PictureBox> arr = new List<PictureBox>(100);
        private List<PictureBox> _cells = new List<PictureBox>(100);
        private List<PictureBox> _emptyCells = new List<PictureBox>(100);
        private List<PictureBox> _fillCells = new List<PictureBox>(100);
        private FieldTexture _texture;
        public GenForm(List<PictureBox> cells, FieldTexture texture)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ControlBox = false;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            FillField(cells);
            arr = cells;
            _texture = texture;
        }

        // изначальное заполнение поля
        public void FillField(List<PictureBox> cells)
        {
            panel.Controls.Clear();
            _cells.Clear();
            _emptyCells.Clear();
            _fillCells.Clear();
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

                if((string)cellItem.Tag == "krot")
                {
                    _emptyCells.Add(cellItem);
                }
                else
                {
                    _fillCells.Add(cellItem);
                }
                _cells.Add(cellItem);
            }
        }

        // обработка клика по ячейке
        public void CellClickHendler(object sender, EventArgs e)
        {
            PictureBox cell = (PictureBox)sender;
            if(_fillCells.Contains(cell))
            {
                _fillCells.Remove(cell);
                cell.Tag = "krot";
                cell.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\krot.png"));
                _emptyCells.Add(cell);
            }
            else if (_emptyCells.Count > 1 && _emptyCells.Contains(cell))
            {
                _emptyCells.Remove(cell);
                cell.Tag = "kacan";
                cell.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\kacan.png"));
                _fillCells.Add(cell);
            }
            else
            {
                MessageBox.Show("Больше нельзя убирать кротов!");
            }
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            GenerateField(panel, genCount);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Hide();
            FillField(arr);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Hide();
            _texture.UpdateField(_cells);
        }


        // генерация поля
        public void GenerateField(Panel basePanel, int count)
        {
            var rnd = new Random();
            basePanel.Controls.Clear();
            _cells.Clear();
            _emptyCells.Clear();
            _fillCells.Clear();
            for (int i = 0; i < 100; i++)
            {
                PictureBox cell = new PictureBox();
                cell.Width = 65;
                cell.Height = 50;
                cell.SizeMode = PictureBoxSizeMode.CenterImage;
                cell.Name = $"cell{i}";
                cell.Click += CellClickHendler;
                string path = string.Empty;
                if (i < count)
                {
                    cell.Tag = "krot";
                    path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\krot.png");
                    cell.Image = Image.FromFile(path);
                    _emptyCells.Add(cell);
                }
                else
                {
                    cell.Tag = "kacan";
                    path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\kacan.png");
                    cell.Image = Image.FromFile(path);
                    _fillCells.Add(cell);
                }
                _cells.Add(cell);
            }

            for (int i = 0; i < 100; i++)
            {
                int j = rnd.Next(100);
                var tmp = _cells[i];
                _cells[i] = _cells[j];
                _cells[j] = tmp;
            }

            for (int i = 0; i < 100; i++)
            {
                basePanel.Controls.Add(_cells[i]);
            }
        }

        private void speedValue_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textbox.Text, "^[0-9]+$"))
            {
                int x = int.Parse(textbox.Text);
                if(x >= 1 && x <= 99)
                {
                    genCount = x;
                }
                else
                {
                    textbox.Text = $"{genCount}";
                    SystemSounds.Beep.Play();
                }
            }
            else if(textbox.Text == string.Empty)
            {
                SystemSounds.Beep.Play();
            }
            else
            {
                textbox.Text = $"{genCount}";
                SystemSounds.Beep.Play();
            }
        }

        private void GenForm_Shown(object sender, EventArgs e)
        {
            
        }
    }
}
