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
            int index = Convert.ToInt32(cursorIndex.Text);
            var commands = codeField.Lines.ToList();
            commands.ForEach(x => {
                if(x == "r")
                {
                    index++;
                }
                if (x == "l")
                {
                    index--;
                }
                if(x == "p")
                {
                    _cells[index].Text = "X";
                }
                if(x == "e")
                {
                    _cells[index].Text = "0";
                }
                if (x.StartsWith("j"))
                {
                    var arr = x.Split(" ");
                    if (_cells[index].Text == "X")
                    {

                    }
                }
                if(x == "s")
                {
                    MessageBox.Show("Ìàøèíà îñòàíîâëåíà!");
                }
            });
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

        private void ÑlearTapeBtn_Click(object sender, EventArgs e)
        {
            _cells.ForEach(x => x.Text = "0");
        }

    }
}