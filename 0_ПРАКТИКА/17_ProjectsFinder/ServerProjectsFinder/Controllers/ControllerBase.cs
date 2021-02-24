using System;
using System.Collections.Generic;
using System.Text;

namespace ServerProjectsFinder.Controller
{
    public abstract class ControllerBase
    {
        public abstract void Work(string json);
    }
}
