using System;
using System.Collections.Generic;
using System.Text;

namespace _9_банк.money
{
    class AddMoney : Money
    {
        public override void CallCommand(decimal value)
        {
            if(value > 0)
            {
                Cache += value;
            }
        }
    }
}
