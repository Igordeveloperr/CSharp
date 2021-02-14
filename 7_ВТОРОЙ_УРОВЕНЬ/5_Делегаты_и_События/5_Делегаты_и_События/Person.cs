using System;
using System.Collections.Generic;
using System.Text;

namespace _5_Делегаты_и_События
{
    public class Person
    {
        public event Action GoToSleep;
        public event EventHandler GoToSchool;
        public string Name { get; set; }
        public int Calories { get; set; } = 200;
        public void TakeTime(DateTime now)
        {
            if(now.Hour <= 8)
            {
                GoToSleep?.Invoke();
                Calories += 100;
            }
            else
            {
                var args = new EventArgs();
                GoToSchool?.Invoke(this, args);
            }
        }
    }
}
