using _23_PongoClicker.command;
using _23_PongoClicker.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace _23_PongoClicker.viewModel
{
    internal class GoAuthorizationViewModel : BaseViewModel
    {
        public ICommand OpenAuthorizationWindow
        {
            get
            {
                return new DelegateCommand((obj)=>
                {
                    new AuthorizationWindow().Show();
                });
            }
        }
    }
}
