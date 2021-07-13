using _5_Factory.factory;
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

namespace _5_Factory
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateTxtFile(object sender, RoutedEventArgs e)
        {
            FileCreator creator = new TxtFileCreator("gokhlia");
            creator.CreateFile();
        }
        private void CreateRtfFile(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("rtf");
        }
    }
}
