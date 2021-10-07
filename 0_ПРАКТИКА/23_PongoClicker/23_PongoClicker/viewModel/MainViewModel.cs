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
        public ICommand TestClick
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    if (isAuthorized)
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
