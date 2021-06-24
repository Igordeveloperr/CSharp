using System;
using System.Windows;
using System.Windows.Controls;


namespace _1_Начало_работы
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // добавляю обработчик событий на все кнопки
            foreach (UIElement element in LayoutRoot.Children)
            {
                if(element is Button)
                {
                    // подписываю каждую кнопку на событие
                    ((Button)element).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // получаю текст кнопки
            string buttonText = (string)((Button)e.OriginalSource).Content;
            if (buttonText.Equals("CLEAR"))
            {
                textBlock.Text = "";
            }
            else
            {
                // вывожу его
                textBlock.Text += $"{buttonText} ";
            }
        }
    }
}
