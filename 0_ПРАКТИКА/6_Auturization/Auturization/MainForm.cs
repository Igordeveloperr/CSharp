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

namespace Auturization
{
    public partial class MainForm : Form
    {
        private bool IsAdmin { get; set; }
        public MainForm(bool isAdmin)
        {
            IsAdmin = isAdmin;
            InitializeComponent();
            new SportNews("Sport", "desc sport", "sport");
            new ProgrammingNews("Programming", "prog desc", "prog");
            NewsSlider.PrintNews(Title, newsText);
        }

        private void next_Click(object sender, EventArgs e)
        {
            NewsSlider.ScrollNewsForward(Title, newsText);
        }

        private void prev_Click(object sender, EventArgs e)
        {
            NewsSlider.ScrollNewsBack(Title, newsText);

        }

        private void send_Click(object sender, EventArgs e)
        {
            NewsSlider.SelectLimitNewsOutput(newsCount.Text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (IsAdmin) addNewsBtn.Visible = true;
        }

        private void addNewsBtn_Click(object sender, EventArgs e)
        {
            new Admin().Show();
        }
    }
}
