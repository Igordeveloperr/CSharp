namespace POST_MACHINE
{
    public partial class MainWindow : Form
    {
        private List<Button> _cells;
        private const int CELLS_COUNT = 50;

        public MainWindow()
        {
            _cells = new List<Button>();
            InitializeComponent();
        }

        private void OnMainWindowLoad(object sender, EventArgs e)
        {
            for (int i = 0; i < CELLS_COUNT; i++)
            {
                var cell = CreateCell();

                var lbl = new Label();
                lbl.Text = $"{i}";
                lbl.Dock = DockStyle.Bottom;
                lbl.TextAlign = ContentAlignment.MiddleCenter;

                var panel = new Panel();
                panel.Controls.Add(cell);
                panel.Controls.Add(lbl);

                _cells.Add(cell);

                tape.Controls.Add(panel);
                tape.Cursor = Cursor.Current;
            }
        }

        private void CompileBtn_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(cursorIndex.Text, out int res))
            {
                int index = res;
                string[] commands = codeField.Lines.Select(x => x.Trim()).ToArray();
                for (int i = 1; i <= commands.Length; i++)
                {
                    var x = commands[i - 1];
                    var arr = x.Split(" ");

                    if (x.StartsWith("r"))
                    {
                        index++;
                        i = Convert.ToInt32(arr[1]);
                        i -= 1;
                    }
                    if (x.StartsWith("l"))
                    {
                        index--;
                        i = Convert.ToInt32(arr[1]);
                        i -= 1;
                    }
                    if (x.StartsWith("p"))
                    {
                        _cells[index].Text = "X";
                        i = Convert.ToInt32(arr[1]);
                        i -= 1;
                    }
                    if (x.StartsWith("e"))
                    {
                        _cells[index].Text = "0";
                        i = Convert.ToInt32(arr[1]);
                        i -= 1;
                    }
                    if (x.StartsWith("j"))
                    {
                        if (_cells[index].Text == "X")
                        {
                            i = Convert.ToInt32(arr[1]);
                        }
                        else
                        {
                            i = Convert.ToInt32(arr[2]);
                        }
                        i -= 1;
                    }
                    if (x == "s")
                    {
                        i = commands.Length;
                        MessageBox.Show("Машина остановлена!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Ошибка ввода указателя!!!");
            }
        }

        private Button CreateCell()
        {
            var btn = new Button();
            btn.Text = "0";
            btn.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold);
            btn.Dock = DockStyle.Fill;
            btn.Click += OnCellClick;
            return btn;
        }

        private void OnCellClick(object? sender, EventArgs e)
        {
            var btn = (Button)sender!;
            btn.Text = "X";
        }

        private void СlearTapeBtn_Click(object sender, EventArgs e)
        {
            _cells.ForEach(x => x.Text = "0");
        }

    }
}