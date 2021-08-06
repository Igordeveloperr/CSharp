using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Adapter
{
    class DefaultUser : IUser
    {
        public bool Authorization(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length < 2)
                return false;
            return true;
        }
    }
}
