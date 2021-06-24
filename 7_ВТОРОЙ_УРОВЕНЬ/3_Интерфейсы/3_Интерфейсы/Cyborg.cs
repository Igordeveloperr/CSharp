using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Интерфейсы
{
    class Cyborg : ICar, IPerson
    {
        public void CreateObject()
        {
            throw new NotImplementedException();
        }

        // явная реализация интерфейса
        int ICar.Move(int distance, int speed)
        {
            return distance / speed;
        }

        int IPerson.Move(int distance, int speed)
        {
            int result = (distance) / speed * 2;
            return result;
        }
    }
}
