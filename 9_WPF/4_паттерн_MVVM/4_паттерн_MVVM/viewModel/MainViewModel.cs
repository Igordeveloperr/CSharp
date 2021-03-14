using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace _4_паттерн_MVVM.viewModel
{
    public class MainViewModel : BaseViewModel
    {
        private string name;
        private string password;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged();
            }
        }
        public ICommand Authorisation
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    // TODO залупасить регистратион шо
                });
            }
        }
    }
}
