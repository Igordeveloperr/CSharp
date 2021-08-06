using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Adapter.lib
{
    class SuperUserLib
    {
        public bool Login(string name)
        {
            bool flag = false;
            if (string.IsNullOrWhiteSpace(name))
                flag = false;
            if (name.Equals("Gokhlius"))
                flag = true;
            return flag;
        }
    }
}
