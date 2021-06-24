using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _22_Банк.model.request
{
    internal interface IRequestSendler
    {
        public Task<string> SendRequest();
    }
}
