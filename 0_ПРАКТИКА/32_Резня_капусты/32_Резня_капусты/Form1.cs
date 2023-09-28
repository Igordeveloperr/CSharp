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
        private StartBtnTexture _startBtnTexture;
        private StopBtnTexture _stoprBtnTexture;
        private bool _isStartBtn;
        private bool _gameIsActive;
        private FieldTexture _field;
        public Form1()
        { 
            InitializeComponent();
            _field = new FieldTexture();
            _field.Draw(basePanel);
            _gameIsActive = false;
            _isStartBtn = true;
        }

        private async void startBtn_Click(object sender, EventArgs e)
        {
            // кнопка старт
            if (_isStartBtn)
            {
                _stoprBtnTexture = new StopBtnTexture(startBtn);
                _stoprBtnTexture.Draw(basePanel);
                _isStartBtn = false;
                await ActivateGame();
            }
            else
            {
                // кнопка стоп
                if (_isStartBtn == false && _gameIsActive == true)
                {
                    _isStartBtn = true;
                    _startBtnTexture = new StartBtnTexture(startBtn);
                    _startBtnTexture.Draw(basePanel);
                }
            }
        }

        private async Task ActivateGame()
        {
            while (!_gameIsActive)
            {
                _gameIsActive = await _field.ExecuteLogic(panel1, 500);
            }
        }
    }
}
