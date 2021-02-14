using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_Chaatik
{
    public partial class Form1 : Form
    {
        private Client client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new Client();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text;
            client.SendMessage(message);
            client.ReciveMessage(listBox1);
        }
    }
}
