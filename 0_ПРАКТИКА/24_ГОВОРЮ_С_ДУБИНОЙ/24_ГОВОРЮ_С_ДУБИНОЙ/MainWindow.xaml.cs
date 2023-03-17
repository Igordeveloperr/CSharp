using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using Microsoft.Win32;
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

namespace _24_ГОВОРЮ_С_ДУБИНОЙ
{
    public partial class MainWindow : Window
    {
        List<string> info = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            SelectData("Win32_Processor");
        }
        private void SelectData(string key)
        {
            string Q = $"SELECT * FROM {key}";
            string result = String.Empty;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(Q);
            foreach (ManagementObject obj in searcher.Get())
            {
                foreach(var prop in obj.Properties)
                {
                    MessageBox.Show(prop.Name);
                    MessageBox.Show(prop.Value.ToString());
                }
            }
        }
    }
}
