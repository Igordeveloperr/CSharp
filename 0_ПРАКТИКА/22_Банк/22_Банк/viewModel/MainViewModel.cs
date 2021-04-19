using _22_Банк.command;
using _22_Банк.model.request;
using _22_Банк.model.request.requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace _22_Банк.viewModel
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        private string str;
        public string Str
        {
            get
            {
                return str;
            }
            set
            {
                str = value;
                OnPropertyChanged();
            }
        }
        public ICommand ClickAdd
        {
            get
            {
                return new MyCommand((obj)=>
                {
                    Str = "ЧЕ";
                });
            }
        }
        public MainViewModel()
        {
            string requestJson = new AuthorizationRequest(RequestType.authorization, "BOB", "123").ToJson();
            var sendler = new RequestSendler(requestJson);
            sendler.SendRequest();
        }
    }
}
