using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auturization.news;

namespace Auturization.news_create
{
    public class NewsCreator : News
    {
        public NewsCreator(string title, string description, string type) : base(title, description, type)
        {

        }
        private static void SelectCreationalObject(string type)
        {
            if (!string.IsNullOrWhiteSpace(type))
            {
                
            }
        }
    }
}
