using _16_Gokhlia_Money.chart;
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
    public partial class Graphik : Form
    {
        private ChartWriter Writer;
        private event Action OnOpen;
        public Graphik()
        {
            InitializeComponent();
            OnOpen += OnOpen_Action;
            OnOpen.Invoke();
        }

        private void OnOpen_Action()
        {
            Writer = new ChartWriter(chart);
        }

        private void Graphik_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
