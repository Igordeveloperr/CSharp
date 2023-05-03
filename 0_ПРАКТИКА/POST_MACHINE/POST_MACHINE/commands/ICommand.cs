using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POST_MACHINE.commands
{
    internal interface ICommand
    {
        public void Execute(ref int increment, ref int index, ref string[] commands, ref List<Button> cells);
    }
}
