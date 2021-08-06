using _7_Adapter.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Adapter
{
    class SuperUser : IUser
    {
        private SuperUserLib lib = new SuperUserLib();
        public bool Authorization(string name)
        {
            return lib.Login(name);
        }
    }
}
