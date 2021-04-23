using _22_Банк.command;
using _22_Банк.encrypt;
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
            var aes = new AesEncrypt();
            string requestJson = new AuthorizationRequest(RequestType.authorization, "s", "1").ToJson();
            string data = Convert.ToBase64String(aes.EncryptString(requestJson));
            var sendler = new RequestSendler(data);
            sendler.SendRequest( );
        }
    }
}
