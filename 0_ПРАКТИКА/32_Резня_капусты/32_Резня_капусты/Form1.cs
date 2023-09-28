using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using _32_Резня_капусты.texture;

namespace _32_Резня_капусты
{
    public partial class Form1 : Form
    {
        private bool _gameIsActive;
        private FieldTexture _field;
        public Form1()
        { 
            InitializeComponent();
            _field = new FieldTexture();
            _field.Draw(basePanel);
            _gameIsActive = false;
        }

        private async void startBtn_Click(object sender, EventArgs e)
        {
            startBtn.Enabled = false;
            while(!_gameIsActive)
            {
                _gameIsActive = await _field.ExecuteLogic(startBtn, panel1, 500);
            }
        }
    }
}
