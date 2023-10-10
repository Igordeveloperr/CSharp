using _32_Резня_капусты.math;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _32_Резня_капусты.texture
{
    internal class FieldTexture : Texture
    {
        private List<Color> colors = new List<Color>(10);
        private List<PictureBox> columnlist = new List<PictureBox>();
        private List<PictureBox> field = new List<PictureBox>();
        private List<PictureBox> fillCells = new List<PictureBox>();
        private List<PictureBox> emptyCells = new List<PictureBox>();
        private Random rnd = new Random(Guid.NewGuid().GetHashCode());
        public int Percent { get; set; } = 5;

        public FieldTexture(List<Color> prevColors)
        {
            colors = prevColors;
        }

        // основная логика работы поля
        public bool ExecuteLogic(Panel lamPanel, System.Windows.Forms.Timer timer)
        {
            columnlist.ForEach(x => x.BackColor = Color.White);
            columnlist.Clear();
            if (emptyCells.Count == 0)
            {
                timer.Enabled = false;
                timer.Stop();
                MessageBox.Show("Игра окончена!");
                return true;
            }
            else if(emptyCells.Count > 0 && !timer.Enabled)
            {
                field.ForEach(x => x.Click -= CellClickHendler);
                return false;
            }
            else
            {
                field.ForEach(x => x.Click -= CellClickHendler);
                PlantCabbage();
                ActivateLampLogic(lamPanel);
                return false;
            }
        }

        // логика аварийной лампы
        private void ActivateLampLogic(Panel lamp)
        {
            MyRandom _random = new MyRandom(Percent);
            if (_random.Randomize())
            {
                lamp.BackgroundImage = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\onLamp.png"));
                ClearColumn();
            }
            else
            {
                lamp.BackgroundImage = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\offLamp.png"));
            }
        }

        // очиста рандомно выбраного столбца
        private void ClearColumn()
        {
            int column = rnd.Next(0, 10);
            int colorIndex = column;
            for (int i = 0; i < 10; i++)
            {
                PictureBox cell = field[column];
                columnlist.Add(cell);
                ClearCellsArr(cell);
                cell.BackColor = colors[colorIndex];
                cell.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\krot.jpg"));
                emptyCells.Add(cell);
                column += 10;
            }
        }

        // садим капусту в выбраную ячейку
        private void PlantCabbage()
        {
            int x = rnd.Next(0, emptyCells.Count);
            PictureBox cell = emptyCells[x];
            emptyCells.Remove(cell);
            cell.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\kacan.jpg"));
            fillCells.Add(cell);
        }

        // удаление яцейки из масиива, в зависимости от того, где она находится
        private void ClearCellsArr(PictureBox cell)
        {
            if (fillCells.Contains(cell))
            {
                fillCells.Remove(cell);
            }
            else
            {
                emptyCells.Remove(cell);
            }
        }
        
        // чистим вспомогательные маcсивы
        public void ClearCache()
        {
            field.Clear();
            emptyCells.Clear();
            fillCells.Clear();
        }

        // отрисвока текстуры
        public override void Draw(Panel panel)
        {
            GenerateField(panel);
        }

        // генерация поля
        private void GenerateField(Panel basePanel)
        {
            basePanel.Controls.Clear();
            for (int i = 0; i < 100; i++)
            {
                PictureBox cell = new PictureBox();
                cell.Width = 65;
                cell.Height = 50;
                cell.SizeMode = PictureBoxSizeMode.CenterImage;
                cell.Name = $"cell{i}";
                SelectImageForCell(cell);
                cell.Click += CellClickHendler;
                field.Add(cell);
                basePanel.Controls.Add(cell);
            }
        }

        // обработка клика по ячейке
        private void CellClickHendler(object sender, EventArgs e)
        {
            PictureBox cell = (PictureBox)sender;

            if(fillCells.Contains(cell))
            {
                fillCells.Remove(cell);
                cell.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\krot.jpg"));
                emptyCells.Add(cell);
            }
            else if (emptyCells.Count > 1 && emptyCells.Contains(cell))
            {
                emptyCells.Remove(cell);
                cell.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\kacan.jpg"));
                fillCells.Add(cell);
            }
            else
            {
                MessageBox.Show("Больше нельзя убирать кротов!");
            }
        }

        // выбор картинки с пмоощью рандома
        private void SelectImageForCell(PictureBox cell)
        {
            long a = rnd.Next(0, 1000000);
            long b = rnd.Next(0, 1000000);
            string path = string.Empty;
            if ((a * b) % 2 == 0)
            {
                path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\kacan.jpg");
                cell.Image = Image.FromFile(path);
                fillCells.Add(cell);
            }
            else
            {
                path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\krot.jpg");
                cell.Image = Image.FromFile(path);
                emptyCells.Add(cell);
            }
        }
    }
}
