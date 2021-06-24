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
        private string name = string.Empty;
        private string password = string.Empty;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged();
            }
        }
        public ICommand LoginIn
        {
            get
            {
                return new MyCommand(async(obj)=>
                {
                    bool isReady = CheckUserData();
                    if (isReady)
                    {
                        string response = await GetServerPublicKey();
                        await Task.Run(() => SendData(response));
                    }
                });
            }
        }
        public MainViewModel()
        {
        }
        private bool CheckUserData()
        {
            if(string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Заполните все поля!");
                return false;
            }
            return true;
        }
        private async Task<string> GetServerPublicKey()
        {
            var request = new RequestObject(RequestType.authorization);
            byte[] data = request.ToByteArray();
            var sendler = new RequestSendler(data);
            string response = await sendler.SendRequest();
            return response;
        }
        private async void SendData(string response)
        {
            var rsa = new RsaEncrypt(response);
            var aes = new AesEncrypt();
            var request = new AuthorizationRequest(RequestType.authorization, name, password);
            byte[] encRequest = aes.EncryptString(request.ToJson());
            byte[] data = new RequestObject(rsa.Encrypt(aes.Key), rsa.Encrypt(aes.IV), encRequest, RequestType.authorization).ToByteArray();
            response = await new RequestSendler(data).SendRequest();
        }
    }
}
