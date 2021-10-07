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
        private int _c = 0;
        public int C
        {
            get
            {
                return _c;
            }
            set
            {
                _c = value;
                OnPropertyChanged();
            }
        }
        public ICommand TestClick
        {
            get
            {
                return new DelegateCommand((obj) =>
                {
                    CurrentPage = new GamePage();
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
