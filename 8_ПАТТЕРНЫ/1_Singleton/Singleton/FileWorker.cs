using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Singleton
{
    internal sealed class FileWorkerSingleton
    {
        // реализация синглетона
        private static readonly FileWorkerSingleton instance = new FileWorkerSingleton();
        internal static FileWorkerSingleton Instance { get { return instance; } }
        internal string FilePath { get; }
        internal string Text { get; private set; }
        private FileWorkerSingleton()
        {
            FilePath = "E:/Igor/r.txt";
        }
        // читаем файл
        internal void ReadTextFromFile()
        {
            string text = "";
            if (File.Exists(FilePath))
            {
                using (var reader = new StreamReader(FilePath))
                {
                    text += reader.ReadToEnd();
                }
                Console.WriteLine(text);
            }
        }
        // записывем шонить в файл
        internal void WriteToFile(string text)
        {
            Text += text;
        }
        // сохраняем изменения
        internal void Save()
        {
            if (!File.Exists(FilePath)) throw new FileNotFoundException("File is't found");
            using(var writer = new StreamWriter(FilePath))
            {
                writer.WriteLine(Text);
            }
        }
    }
}
