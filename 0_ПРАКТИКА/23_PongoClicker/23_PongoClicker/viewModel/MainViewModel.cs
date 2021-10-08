using _23_PongoClicker.command;
using _23_PongoClicker.view.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace _23_PongoClicker.viewModel
{
    internal class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            if (isUserAuthorized)
            {
                CurrentPage = new GamePage();
            }
            else
            {
                MenuActivation = false;
                CurrentPage = new AuthorizationPage();
            }
        }
        private bool _menuActivation = true;
        public bool MenuActivation
        {
            get
            {
                return _menuActivation;
            }
            set
            {
                _menuActivation = value;
                OnPropertyChanged();
            }
        }
        public ICommand TestClick
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    if (isUserAuthorized)
                    {
                        CurrentPage = new GamePage();
                    }
                    else
                    {
                        CurrentPage = new AuthorizationPage();
                    }
                });
            }
        }
        private Page _currentPage;
        public Page CurrentPage
        {
            get
            {
                return _currentPage;
            }
            set
            {
                _currentPage = value;
                OnPropertyChanged();
            }
        }
    }
}
