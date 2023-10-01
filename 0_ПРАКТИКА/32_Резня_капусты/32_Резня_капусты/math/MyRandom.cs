using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Резня_капусты.math
{
    internal class MyRandom
    {
        private const int MAX_LEN = 100;
        private List<int> _list = new List<int>();
        private int _percent;

        public MyRandom(int percent)
        {
            _percent = percent;
        }

        // добавить число n раз
        private void AddNTimes(int value, int n)
        {
            for (int i = 0; i < n; i++)
            {
                _list.Add(value);
            }
        }

        // выдаем true или false с заданным процентом вероятности
        public bool Randomize()
        {
            AddNTimes(0, _percent);
            AddNTimes(1, MAX_LEN - _percent);
            Random rnd = new Random();
            int index = rnd.Next(0, _list.Count);
            if (_list[index] == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
