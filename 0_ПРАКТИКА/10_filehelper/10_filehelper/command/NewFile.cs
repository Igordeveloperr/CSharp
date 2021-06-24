using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;
using _10_filehelper.create;

namespace _10_filehelper.command
{
    class NewFile : Command
    {
        public override void CallCommand()
        {
            Console.WriteLine("Путь для файла: ");
            string path = Console.ReadLine();

            if (Directory.Exists(path))
            {
                new DirectoryCreator(path).Create("sho");
                var process = Process.Start(new ProcessStartInfo("explorer", path));
            }
        }
    }
}
