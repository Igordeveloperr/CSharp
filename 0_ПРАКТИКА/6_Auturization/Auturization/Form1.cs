using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auturization
{
    public partial class Form1 : Form
    {

        string[,] arrLogins = new string[,]
        { 
            {"Sparrow14", "1234"}, 
            {"Goblin", "12333"}, 
            {"Yury88", "2281488"},
            { "a", "1" },
            { "igor", "111" }
        };
        private static Dictionary<string, string> admins = new Dictionary<string, string>
        {
            { "igor", "111" },
            { "a", "1" },
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // проверка на админа
            bool resultOfAdminCheck = CheckAndminData(textBox1.Text, textBox2.Text);
            label3.Text = Convert.ToString(resultOfAdminCheck);
            //переменная для получения столбца массива (см.далее)
            uint indexLog = 0;
            //чиста по приколу (см.далее)
            bool autorizationCompl = false;

            //перебор двухмерного массива
            //https://www.youtube.com/watch?v=hJR0LHKw1oY&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=47
            
            //Проверка существования логина
            for (uint i = 0; i < arrLogins.GetLength(0); i++)
            {
                  if (textBox1.Text == arrLogins[i, 0])
                  {
                    indexLog = i;
                    autorizationCompl = true;
                    label3.Text = $"ЛогинВерный {i}";
                    break;
                  }
                  else
                  {
                    label3.Text = "Логин не существует";
                  }
            }

            //Сверяемся с паролем, присоединенным к логину
            if (textBox2.Text == arrLogins[indexLog, 1] && autorizationCompl == true)
            {
                label3.Text = $"Прошел! {arrLogins[indexLog, 1]}";
                MainForm mainForm = new MainForm(resultOfAdminCheck);
                mainForm.Show();
            }
            else
            {
                label3.Text = "Неверный пароль или логин";
            }

            //Ошибка, если оба textbox пустые
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                label3.Text = "Введите логин и пароль!";
            }
        }

        //private void checkBox1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    textBox2.PasswordChar = '\0';
        //}

        //private void checkBox1_MouseUp(object sender, MouseEventArgs e)
        //{
        //    textBox2.PasswordChar = '*';
        //}

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
        
        private static bool CheckAndminData(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login)) throw new ArgumentException(nameof(login));
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException(nameof(password));
            foreach(var admin in admins.Keys)
            {
                if (login.Equals(admin) && password.Equals(admins[admin])) return true;
            }
            return false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
