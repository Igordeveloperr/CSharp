using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32_Резня_капусты.texture
{
    internal class FieldTexture : Texture
    {
        private List<PictureBox> field = new List<PictureBox>();
        private List<PictureBox> fillCells = new List<PictureBox>();
        private List<PictureBox> emptyCells = new List<PictureBox>();
        private Random rnd = new Random(Guid.NewGuid().GetHashCode());

        public async Task<bool> ExecuteLogic(Button sender, Panel lamPanel, int delay)
        {
            if (emptyCells.Count == 0)
            {
                MessageBox.Show("Игра окончена!");
                sender.Enabled = true;
                return true;
            }
            else
            {
                await PlantCabbage(delay);
                await ActivateLampLogic(lamPanel, delay);
                return false;
            }
        }

        // логика аварийной лампы
        private async Task ActivateLampLogic(Panel lamp, int delay)
        {
            long a = rnd.Next(0, 1000000);
            long b = rnd.Next(0, 1000000);
            // лампа горит
            if ((a * b) % 2 == 1 && (b % 3 == 0))
            {
                lamp.BackColor = Color.Red;
                await Task.Delay(delay);
                lamp.BackColor = Color.White;
                ClearColumn();
            }
        }

        // очиста рандомно выбраного столбца
        private void ClearColumn()
        {
            int column = rnd.Next(0, 9);
            for (int i = 0; i < 10; i++)
            {
                PictureBox cell = field[column];
                ClearCellsArr(cell);
                cell.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\krot.jpg"));
                emptyCells.Add(cell);
                column += 10;
            }
        }

        // садим капусту в выбраную ячейку
        private async Task PlantCabbage(int delay)
        {
            int x = rnd.Next(0, emptyCells.Count);
            PictureBox cell = emptyCells[x];
            emptyCells.Remove(cell);
            cell.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\kacan.jpg"));
            fillCells.Add(cell);
            await Task.Delay(delay);
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

        // отрисвока текстуры
        public override void Draw(Panel panel)
        {
            GenerateField(panel);
        }

        // генерация поля
        private void GenerateField(Panel basePanel)
        {
            for (int i = 0; i < 100; i++)
            {
                PictureBox cell = new PictureBox();
                cell.Width = 65;
                cell.Height = 50;
                cell.Name = $"cell{i}";
                SelectImageForCell(cell);
                field.Add(cell);
                basePanel.Controls.Add(cell);
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
