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
            _startBtnTexture = new StartBtnTexture(startBtn);
            _stoprBtnTexture = new StopBtnTexture(startBtn);
            _field = new FieldTexture();
            _field.Draw(basePanel);
            _gameIsActive = false;
            _isStartBtn = true;
        }

        // обработка кнопки формы
        private void startBtn_Click(object sender, EventArgs e)
        {
            // кнопка старт
            if (_isStartBtn)
            {
                _gameIsActive = false;
                _stoprBtnTexture.Draw(basePanel);
                _isStartBtn = false;
                mainTimer.Enabled = true;
                mainTimer.Start();
            }
            else
            {
                ValidateStopBtn();
            }
        }

        // обработка кнопки стоп
        private void ValidateStopBtn()
        {
            // кнопка стоп
            if (_isStartBtn == false)
            {
                // откатываем лампу
                lamp.BackColor = Color.White;
                // сброс таймера
                mainTimer.Enabled = false;
                mainTimer.Stop();
                // чистим вспомогательные массивы
                _field.ClearCache();
                // игра доступна
                _gameIsActive = true;
                // регенерация поля
                _field.Draw(basePanel);
                // колдуем кнопкой
                _isStartBtn = true;
                _startBtnTexture.Draw(basePanel);
            }
        }

        // прерывание по таймеру
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            _gameIsActive = _field.ExecuteLogic(lamp, mainTimer);
        }
    }
}
