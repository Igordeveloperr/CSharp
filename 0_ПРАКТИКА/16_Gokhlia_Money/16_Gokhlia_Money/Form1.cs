using _16_Gokhlia_Money.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_Gokhlia_Money
{
    public partial class Form1 : Form
    {
        private ParserInterface<string[]> parserInterface;
        private Parser Parser;
        private ParserSettings Settings;
        public Form1()
        {
            InitializeComponent();
            Parser = new Parser();
            Settings = new ParserSettings();
            parserInterface = new ParserInterface<string[]>(Parser, Settings);
            parserInterface.listBox = richTextBox1;
            parserInterface.OnNewData += Parser_OnNewData;
            parserInterface.OnClose += Parser_OnClose;
        }

        private void Parser_OnClose(object obj)
        {
            MessageBox.Show("Обновление завершино!");
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            MessageBox.Show("Начинается обнавление таблицы!");
            foreach (var item in arg2)
            {
                table.Items.Add($"Цена акции: {item}руб");
            }
        }

        private void updateTableBtn_Click(object sender, EventArgs e)
        {
            parserInterface.Start();
        }

        private void graphikBtn_Click(object sender, EventArgs e)
        {
            new Graphik().Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void table_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stateBtn_Click(object sender, EventArgs e)
        {

        }

        private void selectUrlBtn_Click(object sender, EventArgs e)
        {

        }

        private void updateListBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
