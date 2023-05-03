using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POST_MACHINE.commands
{
    internal class RightCommand : ICommand
    {
        public readonly string Cmd = @"r\s\d[0-9]\s\d[0-9]";
        public void Execute(ref int increment, ref int index, ref string[] commands, ref List<Button> cells)
        {
            throw new NotImplementedException();
        }
    }
}
