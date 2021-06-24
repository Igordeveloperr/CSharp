using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Интерфейсы
{
    class Reno : ICar
    {
        public void CreateObject()
        {
            throw new NotImplementedException();
        }

        public int Move(int distance, int speed)
        {
            return distance / speed;
        }
    }
}
