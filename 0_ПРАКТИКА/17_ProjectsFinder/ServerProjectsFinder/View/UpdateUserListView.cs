using System;
using System.Collections.Generic;
using System.Text;

namespace ServerProjectsFinder.View
{
    internal class UpdateUserListView
    {
        public string Name { get; }
        public UpdateUserListView(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                Name = name;
            }
        }
    }
}
