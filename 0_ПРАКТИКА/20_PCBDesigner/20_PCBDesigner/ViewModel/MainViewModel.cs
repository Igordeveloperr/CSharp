using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _20_PCBDesigner.ViewModel
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        private int _Click;
        public int Click
        {
            get { return _Click; }
            set
            {
                _Click = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
        }
        public void ClickBtn()
        {
            MessageBox.Show("1");
            Click++;
        }
    }
}
