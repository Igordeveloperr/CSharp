using _23_PongoClicker.command;
using _23_PongoClicker.view.pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace _23_PongoClicker.viewModel
{
    internal class BaseViewModel : INotifyPropertyChanged
    {
        protected bool isUserAuthorized = false;
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
