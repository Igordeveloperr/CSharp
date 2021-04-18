using _21_MyTotalCommander.file;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_MyTotalCommander
{
    public partial class Form1 : Form
    {
        string[] cutWord = { "(dir): ", "(file): " };
        private CDLoader LoaderCD;
        private FileLoader LoaderFile;
        private DirectoryLoader DirLoader;
        public Form1()
        {
            InitializeComponent();
            LoaderCD = new CDLoader();
            LoaderFile = new FileLoader();
            DirLoader = new DirectoryLoader();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoaderCD.LoadCdSpace(comboBox1);
            LoaderCD.LoadCdSpace(comboBox2);
        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem?.ToString();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox2.Text = comboBox2.SelectedItem?.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string path = textBox1.Text;
            DirLoader.LoadFileSpace(listBox1, path);
            LoaderFile.LoadFileSpace(listBox1, path);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string path = textBox2.Text;
            DirLoader.LoadFileSpace(listBox2, path);
            LoaderFile.LoadFileSpace(listBox2, path);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string root = listBox1.SelectedItem?.ToString();
            string path = "";
            foreach(string word in cutWord)
            {
                path = root?.Replace(word, "");
                if (!File.Exists(path) && Directory.Exists(path))
                {
                    listBox1.Items.Clear();
                    textBox1.Text = path;
                    DirLoader.LoadFileSpace(listBox1, path);
                    LoaderFile.LoadFileSpace(listBox1, path);
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string root = listBox2.SelectedItem?.ToString();
            string path = "";
            foreach (string word in cutWord)
            {
                path = root?.Replace(word, "");
                if (!File.Exists(path) && Directory.Exists(path))
                {
                    listBox2.Items.Clear();
                    textBox2.Text = path;
                    DirLoader.LoadFileSpace(listBox2, path);
                    LoaderFile.LoadFileSpace(listBox2, path);
                }
            }
        }
    }
}
