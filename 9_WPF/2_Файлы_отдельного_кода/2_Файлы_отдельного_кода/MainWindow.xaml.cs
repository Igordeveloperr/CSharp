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

namespace _2_Файлы_отдельного_кода
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
        // событие, которое я повесил на кнопку в верстке xaml
        private void Button_Down(object sender, RoutedEventArgs e)
        {
            string txt = input.Text;
            if (!string.IsNullOrWhiteSpace(txt))
            {
                MessageBox.Show(txt);
                AddButton(txt);
            }
        }
        // создание UI елемента через код C#
        private void AddButton(string btnText)
        {
            Button button = new Button();
            button.Width = 200;
            button.Height = 200;
            button.Content = btnText;
            button.VerticalAlignment = VerticalAlignment.Bottom;
            button.HorizontalAlignment = HorizontalAlignment.Left;
            gridLayout.Children.Add(button);
        }
    }
}
