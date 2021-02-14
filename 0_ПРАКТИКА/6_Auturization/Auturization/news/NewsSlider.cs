using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auturization.news
{
    public class NewsSlider : News
    {   
        private static int count = 0;
        public static void PrintNews(Label title, TextBox description)
        {
            title.Text = NewsList[count].Title;
            description.Text = NewsList[count].Description;
        }

        public static void ScrollNewsForward(Label title, TextBox description)
        {
            if (count == NewsList.Count - 1) count = -1;
            count++;
            PrintNews(title, description);
        }

        public static void ScrollNewsBack(Label title, TextBox description)
        {
            if (count == 0) count = NewsList.Count;
            count--;
            PrintNews(title, description);
        }

        public static void SelectLimitNewsOutput(string countNews)
        {
            if (Int32.TryParse(countNews, out int result))
            {
                
            }
        }
    }
}
