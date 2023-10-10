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
using _32_Резня_капусты.math;
using System.Text.RegularExpressions;
using System.Media;
using _32_Резня_капусты.settings;

namespace _32_Резня_капусты
{
    public partial class MainWindow : Form
    {
        private Form2 ColorForm = new Form2();
        private ProgramSpeed _programSpeed;
        private StartBtnTexture _startBtnTexture;
        private StopBtnTexture _stoprBtnTexture;
        private PauseBtnTexture _pauseBtnTexture;
        private ContinueBtnTexture _continueBtnTexture;
        private bool _isStartBtn;
        private bool _isPauseBtn;
        private bool _gameIsActive;
        private bool isNullSpeed;
        private FieldTexture _field;
        public MainWindow()
        { 
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            _startBtnTexture = new StartBtnTexture(startBtn);
            _stoprBtnTexture = new StopBtnTexture(startBtn);
            _pauseBtnTexture = new PauseBtnTexture(pauseBtn);
            _continueBtnTexture = new ContinueBtnTexture(pauseBtn);
            _programSpeed = new ProgramSpeed();
            _field = new FieldTexture(ColorForm.prevColorRange);
            _field.Draw(basePanel);
            _gameIsActive = true;
            _isStartBtn = true;
            _isPauseBtn = true;
            isNullSpeed = false;
            lamp.BackgroundImage = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\offLamp.png"));
        }

        // обработка кнопки формы
        private void startBtn_Click(object sender, EventArgs e)
        {
            // кнопка старт
            if (_isStartBtn && !isNullSpeed)
            {
                _gameIsActive = false;
                _stoprBtnTexture.Draw(basePanel);
                _isStartBtn = false;
                mainTimer.Enabled = true;
                mainTimer.Start();
            }
            else if(_isStartBtn && isNullSpeed)
            {
                _gameIsActive = false;
                _stoprBtnTexture.Draw(basePanel);
                _isStartBtn = false;
                mainTimer_Tick(sender , e);
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
                lamp.BackgroundImage = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"img\offLamp.png"));
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
                // скидываю снопу паузы
                _isPauseBtn = true;
                _pauseBtnTexture.Draw(basePanel);
            }
        }

        // прерывание по таймеру
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            _gameIsActive = _field.ExecuteLogic(lamp, mainTimer);
        }

        // обработка кнопки паузы и продолжить
        private void pauseBtn_Click(object sender, EventArgs e)
        {
            if (!_isPauseBtn && !_gameIsActive && !isNullSpeed)
            {
                _isPauseBtn = true;
                _pauseBtnTexture.Draw(basePanel);
                mainTimer.Start();
            }
            else if (!_isPauseBtn && !_gameIsActive && isNullSpeed)
            {
                _isPauseBtn = true;
                _pauseBtnTexture.Draw(basePanel);
            }
            else if (_isPauseBtn && !_gameIsActive)
            {
                _isPauseBtn = false;
                _continueBtnTexture.Draw(basePanel);
                mainTimer.Stop();
            }
            else
            {
                MessageBox.Show("Нажмите кнопку 'Старт'");
            }
        }

        // обработка кнопки выхода
        private void exitBtn_Click(object sender, EventArgs e)
        {

        }

        // ввод % вероятности для лампы
        private void probTrack_Scroll(object sender, EventArgs e)
        {
            probValue.Text = probTrack.Value.ToString();
            _field.Percent = probTrack.Value;
        }

        // ввод скорости
        private void speedTrack_Scroll(object sender, EventArgs e)
        {
            int res = _programSpeed.ConvertToMilliseconds(speedTrack.Value);
            speedValue.Text = $"{speedTrack.Value}";

            if(res == 0)
            {
                isNullSpeed = true;
                mainTimer.Stop();
            }
            else if(res > 0 && isNullSpeed && !_gameIsActive && _isPauseBtn)
            {
                mainTimer.Start();
                isNullSpeed = false;
                mainTimer.Interval = res;
            }
            else
            {
                isNullSpeed = false;
                mainTimer.Interval = res;
            }
        }

        // обработка вводa пользователем скорости
        private void speedValue_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(speedValue.Text, "^[0-9]+$"))
            {
                int speed = int.Parse(speedValue.Text);
                ValidateSpeedvalue(ref speed);
                speedTrack.Value = speed;
                speedTrack_Scroll(sender, e);
                speedValue.SelectionStart = speedValue.Text.Length;
            }
            else if(speedValue.Text == string.Empty)
            {
                SystemSounds.Beep.Play();
            }
            else
            {
                SystemSounds.Beep.Play();
                speedTrack.Value = speedTrack.Minimum;
                speedTrack_Scroll(sender, e);
                speedValue.SelectionStart = speedValue.Text.Length;
            }
        }

        // валидация cкорости
        private void ValidateSpeedvalue(ref int speed)
        {
            if (speed < speedTrack.Minimum)
            {
                SystemSounds.Beep.Play();
                speed = speedTrack.Minimum;
            }

            if (speed > speedTrack.Maximum)
            {
                SystemSounds.Beep.Play();
                speed = speedTrack.Maximum;
            }
        }

        // обработка вводa пользователем вероятности
        private void probValue_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(probValue.Text, "^[0-9]+$"))
            {
                int prob = int.Parse(probValue.Text);
                ValidateProbvalue(ref prob);
                probTrack.Value = prob;
                probTrack_Scroll(sender, e);
                probValue.SelectionStart = probValue.Text.Length;
            }
            else if (probValue.Text == string.Empty)
            {
                SystemSounds.Beep.Play();
            }
            else
            {
                SystemSounds.Beep.Play();
                probTrack.Value = probTrack.Minimum;
                probTrack_Scroll(sender, e);
                probValue.SelectionStart = probValue.Text.Length;
            }
        }

        // валидация вероятности
        private void ValidateProbvalue(ref int prob)
        {
            if (prob < probTrack.Minimum)
            {
                SystemSounds.Beep.Play();
                prob = probTrack.Minimum;
            }

            if (prob > probTrack.Maximum)
            {
                SystemSounds.Beep.Play();
                prob = probTrack.Maximum;
            }
        }

        // вызов формы для настройки цветов
        private void colorMenuItem_Click(object sender, EventArgs e)
        {            
            if (!ColorForm.Visible)
            {
                ColorForm.Show();
            }
        }

        // кнопка сохранить
        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            SettingManager manager = new SettingManager();
            manager.SaveSettings(ColorForm.prevColorRange, int.Parse(speedValue.Text), int.Parse(probValue.Text));
        }

        // кнопка открыть
        private void openMenuItem_Click(object sender, EventArgs e)
        {
            SettingManager manager = new SettingManager();
            SettingsObj settings = manager.OpenSettings();
            if (settings != null)
            {
                speedValue.Text = $"{settings.Speed}";
                probValue.Text = $"{settings.Probability}";
                ColorForm.prevColorRange[0] = settings.Color0;
                ColorForm.prevColorRange[1] = settings.Color1;
                ColorForm.prevColorRange[2] = settings.Color2;
                ColorForm.prevColorRange[3] = settings.Color3;
                ColorForm.prevColorRange[4] = settings.Color4;
                ColorForm.prevColorRange[5] = settings.Color5;
                ColorForm.prevColorRange[6] = settings.Color6;
                ColorForm.prevColorRange[7] = settings.Color7;
                ColorForm.prevColorRange[8] = settings.Color8;
                ColorForm.prevColorRange[9] = settings.Color9;
                ColorForm._cacheColors.Clear();
                ColorForm.colorRange.Clear();
                for (int i = 0; i < ColorForm.prevColorRange.Count; i++)
                {
                    ColorForm.colorRange.Add(ColorForm.prevColorRange[i]);
                }
                ColorForm.FillComboboxs(ColorForm.prevColorRange);
            }
        }
    }
}
