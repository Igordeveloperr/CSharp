using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Auturization.news;
using Auturization.news_create;

namespace Auturization
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            foreach(var category in News.NewsType.Keys)
            {
                type.Items.Add(category);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            new NewsCreator(title.Text, text.Text, type.Text);
        }
    }
}
