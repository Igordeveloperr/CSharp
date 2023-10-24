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
    public class FieldTexture : Texture
    {
        private List<PictureBox> cachedEmptyCells = new List<PictureBox>(100);
        private List<PictureBox> cachedFillCells = new List<PictureBox>(100);
        private List<Color> colors = new List<Color>(10);
        private List<PictureBox> columnlist = new List<PictureBox>();
        public List<PictureBox> field = new List<PictureBox>(100);
        private List<PictureBox> fillCells = new List<PictureBox>(100);
        private List<PictureBox> emptyCells = new List<PictureBox>(100);
        private List<PictureBox> setField = new List<PictureBox>(100);
        private List<PictureBox> setFillCells = new List<PictureBox>(100);
        private List<PictureBox> setEmptyCells = new List<PictureBox>(100);
        private Random rnd = new Random(Guid.NewGuid().GetHashCode());
        public int Percent { get; set; } = 5;

        public FieldTexture(List<Color> prevColors)
        {
            colors = prevColors;
        }

        public FieldTexture()
        {
            
        }

        // основная логика работы поля
        public bool ExecuteLogic(Panel lamPanel, System.Windows.Forms.Timer timer)
        {
            columnlist.ForEach(x => x.BackColor = Color.Empty);
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
                cell.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\krot.png"));
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
            cell.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\kacan.png"));
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
            
        }

        // генерация поля
        public void GenerateField(Panel basePanel, int count)
        {
            var rnd = new Random();
            basePanel.Controls.Clear();
            for (int i = 0; i < 100; i++)
            {
                PictureBox cell = new PictureBox();
                cell.Width = 65;
                cell.Height = 50;
                cell.SizeMode = PictureBoxSizeMode.CenterImage;
                cell.Name = $"cell{i}";
                string path = string.Empty;
                if (i < count)
                {
                    path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\krot.png");
                    cell.Image = Image.FromFile(path);
                    emptyCells.Add(cell);
                }
                else
                {
                    path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\kacan.png");
                    cell.Image = Image.FromFile(path);
                    fillCells.Add(cell);
                }
                field.Add(cell);                
            }

            for (int i = 0; i < 100; i++)
            {
                int j = rnd.Next(100);
                var tmp = field[i];
                field[i] = field[j];
                field[j] = tmp;
            }

            for (int i = 0; i < 100; i++)
            {
                basePanel.Controls.Add(field[i]);
            }
            emptyCells.ForEach(x => cachedEmptyCells.Add(x));
            fillCells.ForEach(x => cachedFillCells.Add(x));
        }

        // возвращаемся к начальному состоянию
        public void GetStartState()
        {
            emptyCells.Clear();
            fillCells.Clear();
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\krot.png");
            foreach (var cell in cachedEmptyCells)
            {
                emptyCells.Add(cell);
                cell.Image = Image.FromFile(path);
            }

            path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\kacan.png");
            foreach (var cell in cachedFillCells)
            {
                fillCells.Add(cell);
                cell.Image = Image.FromFile(path);
            }
        }

        // генерация для настроек
        public void GenSettingField(Panel panel, int count)
        {
            var rnd = new Random();
            panel.Controls.Clear();
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
                    path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\krot.png");
                    cell.Image = Image.FromFile(path);
                    emptyCells.Add(cell);
                }
                else
                {
                    path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\kacan.png");
                    cell.Image = Image.FromFile(path);
                    fillCells.Add(cell);
                }
                field.Add(cell);
            }

            for (int i = 0; i < 100; i++)
            {
                int j = rnd.Next(100);
                var tmp = field[i];
                field[i] = field[j];
                field[j] = tmp;
            }

            for (int i = 0; i < 100; i++)
            {
                panel.Controls.Add(field[i]);
            }
        }

        // обработка клика по ячейке
        public void CellClickHendler(object sender, EventArgs e)
        {
            PictureBox cell = (PictureBox)sender;

            if(fillCells.Contains(cell))
            {
                fillCells.Remove(cell);
                cell.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\krot.png"));
                cell.Tag = "krot";
                emptyCells.Add(cell);
            }
            else if (emptyCells.Count > 1 && emptyCells.Contains(cell))
            {
                emptyCells.Remove(cell);
                cell.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\kacan.png"));
                cell.Tag = "kacan";
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
            MyRandom rnd = new MyRandom(50);
            Random f = new Random();
            string path = string.Empty;
            if (f.Next(1, 11)%2==0)
            {
                path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\kacan.png");
                cell.Image = Image.FromFile(path);
                fillCells.Add(cell);
            }
            else
            {
                path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\krot.png");
                cell.Image = Image.FromFile(path);
                emptyCells.Add(cell);
            }
        }
    }
}
