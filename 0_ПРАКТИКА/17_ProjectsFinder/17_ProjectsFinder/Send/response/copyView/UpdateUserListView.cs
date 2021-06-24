using System;
using System.Collections.Generic;
using System.Text;

namespace _17_ProjectsFinder.Send.response.copyView
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
