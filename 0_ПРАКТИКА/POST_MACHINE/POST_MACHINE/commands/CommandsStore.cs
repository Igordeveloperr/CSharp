using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POST_MACHINE.commands
{
    internal static class CommandsStore
    {
        public static readonly Dictionary<string, ICommand> Store = new Dictionary<string, ICommand>
        {
            { RightCommand.Pattern, new RightCommand() },
            { LeftCommand.Pattern, new LeftCommand() },
            { PointCommand.Pattern, new PointCommand() },
            { ErasePointCommand.Pattern, new ErasePointCommand() },
            { SwitchCommand.Pattern, new SwitchCommand() },
            { StopCommand.Pattern, new StopCommand() },
        };
    }
}
