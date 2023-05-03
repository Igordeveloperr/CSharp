using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POST_MACHINE.commands
{
    internal class SwitchCommand : ICommand
    {
        public readonly static string Pattern = "j";
        public void Execute(ref int increment, ref int index, ref string[] commands, ref List<Button> cells)
        {
            var arr = commands[increment - 1].Split(" ");
            if (cells[index].Text == "X")
            {
                increment = Convert.ToInt32(arr[1]);
            }
            else
            {
                increment = Convert.ToInt32(arr[2]);
            }
            increment -= 1;
        }
    }
}
