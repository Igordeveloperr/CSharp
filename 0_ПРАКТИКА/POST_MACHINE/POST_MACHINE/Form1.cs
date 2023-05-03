using POST_MACHINE.commands;
using System;

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
                ExecuteProgram(res); 
            }
            else
            {
                MessageBox.Show("Îøèáêà ââîäà óêàçàòåëÿ!!!");
            }
        }

        private void ExecuteProgram(int index)
        {
            string[] commands = codeField.Lines.Select(x => x.Trim()).ToArray();
            try
            {
                for (int i = 1; i <= commands.Length; i++)
                {
                    var cmd = commands[i - 1];
                    CompileCode(cmd, ref i, ref index, ref commands);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CompileCode(string cmd, ref int increment, ref int index, ref string[] commands)
        {
            try
            {
                foreach (var cmdLine in CommandsStore.Store)
                {
                    if (cmd.StartsWith(cmdLine.Key))
                    {
                        cmdLine.Value.Execute(ref increment, ref index, ref commands, ref _cells);
                    }
                }
            }
            catch
            {
                throw new Exception("Îøèáêà â êîäå!!!");
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

        private void ÑlearTapeBtn_Click(object sender, EventArgs e)
        {
            _cells.ForEach(x => x.Text = "0");
        }

    }
}