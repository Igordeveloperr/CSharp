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
using System.Threading;

namespace _32_Резня_капусты
{
    public partial class Form1 : Form
    {
        private List<PictureBox> field = new List<PictureBox>();
        private List<PictureBox> fillCells = new List<PictureBox>();
        private List<PictureBox> emptyCells = new List<PictureBox>();
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
                string path = string.Empty;

                long a = rnd.Next(0, 1000000);
                long b = rnd.Next(0, 1000000);
                if ((a*b) % 2 == 0)
                {
                    path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\kacan.jpg");
                    box.Image = Image.FromFile(path);
                    fillCells.Add(box);
                }
                else
                {
                    path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\krot.jpg");
                    box.Image = Image.FromFile(path);
                    emptyCells.Add(box);
                }
                field.Add(box);
                basePanel.Controls.Add(box);
            }
        }

        private async void startBtn_Click(object sender, EventArgs e)
        {
            startBtn.Enabled = false;
            while(true)
            {
                if (emptyCells.Count == 0)
                {
                    MessageBox.Show("Игра окончена!");
                    startBtn.Enabled = true;
                    break;
                }
                else
                {
                    int x = rnd.Next(0, emptyCells.Count);
                    PictureBox box = emptyCells[x];
                    emptyCells.Remove(box);
                    box.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\kacan.jpg"));
                    fillCells.Add(box);
                    await Task.Delay(2000);

                    long a = rnd.Next(0, 1000000);
                    long b = rnd.Next(0, 1000000);
                    // лампа горит
                    if ((a * b) % 2 == 1 && (b % 3 == 0))
                    {
                        panel1.BackColor = Color.Red;
                        await Task.Delay(2000);
                        panel1.BackColor = Color.White;
                        int column = rnd.Next(0, 9);
                        for(int i = 0; i < 10; i++)
                        {
                            PictureBox cell = field[column];
                            ClearCellsArr(cell);
                            cell.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\krot.jpg"));
                            emptyCells.Add(cell);
                            column += 10;
                            await Task.Delay(200);
                        }
                    }
                }
            }
        }

        private void ClearCellsArr(PictureBox cell)
        {
            if(fillCells.Contains(cell))
            {
                fillCells.Remove(cell);
            }
            else
            {
                emptyCells.Remove(cell);
            }
        }
    }
}
