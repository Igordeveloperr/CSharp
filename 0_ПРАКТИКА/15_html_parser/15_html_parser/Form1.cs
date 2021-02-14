using _15_html_parser.core.habr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_html_parser
{
    public partial class Form1 : Form
    {
        ParserWorker<string[]> parser;
        public Form1()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(new Parser());
            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            foreach(string str in arg2)
            {
                titlesList.Items.Add($"Заголовок-{str}");
            }
        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("парсинг окончен!");
        }

        private void StartPoint_TextChanged(object sender, EventArgs e)
        {

        }

        private void parseBtn_Click(object sender, EventArgs e)
        {
            parser.Settings = new Settings(Convert.ToInt32(StartPoint.Text), Convert.ToInt32(EndPoint.Text));
            parser.Start();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            parser.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
