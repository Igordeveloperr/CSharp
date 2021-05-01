using _22_Банк.command;
using _22_Банк.encrypt;
using _22_Банк.model.request;
using _22_Банк.model.request.requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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
                return new MyCommand(async(obj)=>
                {
                    var request = new RequestObject(RequestType.encrypt);
                    byte[] data = request.ToByteArray();
                    var sendler = new RequestSendler(data);
                    string response = await sendler.SendRequest();
                    var rsa = new RsaEncrypt(response);
                    var aes = new AesEncrypt();
                    byte[] login = aes.EncryptString("Bob");
                    data = new RequestObject(rsa.Encrypt(aes.KeyToBase64()), rsa.Encrypt(aes.IVToBase64()), login, RequestType.encrypt).ToByteArray();
                    response = await new RequestSendler(data).SendRequest();
                });
            }
        }
        public MainViewModel()
        {

        }
    }
}
