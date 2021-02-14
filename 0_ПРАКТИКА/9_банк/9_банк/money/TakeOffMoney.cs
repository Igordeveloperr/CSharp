using System;
using System.Collections.Generic;
using System.Text;

namespace _9_банк.money
{
    class TakeOffMoney : Money
    {
        public override void CallCommand(decimal value)
        {
            if(value > 0)
            {
                Cache -= value;
            }
        }
    }
}
