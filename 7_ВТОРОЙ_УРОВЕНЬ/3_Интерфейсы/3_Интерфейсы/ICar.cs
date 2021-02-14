using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Интерфейсы
{
    interface ICar : IObject
    {   
        // Выполнить перемещение, и вернуть время движения
        int Move(int distance, int speed);

    }
}
