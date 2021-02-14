using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auturization.news
{
    public class ProgrammingNews : News
    {
        public ProgrammingNews()
        {
        }

        public ProgrammingNews(string title, string description, string type) : base(title, description, type)
        {
        }
    }
}
