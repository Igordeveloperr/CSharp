using _22_Банк.encrypt;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace _22_Банк.model.request
{
    internal class RequestSendler : IRequestSendler
    {
        private string Json;
        public RequestSendler(string json)
        {
            if (string.IsNullOrWhiteSpace(json))
                throw new ArgumentException(nameof(json));
            Json = json;
        }
        public void SendRequest()
        {
            //TODO: реализовать отправку джасона на сервак
            MessageBox.Show(Json);
        }
    }
}
