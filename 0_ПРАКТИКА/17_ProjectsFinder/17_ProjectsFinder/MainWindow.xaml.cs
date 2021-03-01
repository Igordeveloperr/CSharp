using _17_ProjectsFinder.Send;
using _17_ProjectsFinder.Send.response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _17_ProjectsFinder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // кнопка "отправить" вешаю обработу
        private async void StartValidation(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(login.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Пустой логин или пароль!");
                return;
            }
            var request = new AuthorizationRequest(login.Text, password.Text);
            var response = new AuthorizationResponse();
            bool res = false;
            await Task.Run(()=> { request.SendRequest(); });
            await Task.Run(() =>{ res = response.GetAuthorizationResponse().Result;});
            if (res)
            {
                BaseAppWindow baseAppWindow = new BaseAppWindow(login.Text);
                baseAppWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }
    }
}
