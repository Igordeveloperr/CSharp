using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POST_MACHINE.commands
{
    internal class StopCommand : ICommand
    {
        public readonly static string Pattern = "s";
        public void Execute(ref int increment, ref int index, ref string[] commands, ref List<Button> cells)
        {
            increment = commands.Length;
            MessageBox.Show("Машина остановлена!");
        }
    }
}
