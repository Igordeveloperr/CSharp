using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auturization.news
{
    public abstract class News
    {
        public static Dictionary<string, News> NewsType { get; private set; } = new Dictionary<string, News>
        {
            {"программирование", new ProgrammingNews()},
            {"спорт", new SportNews()}
        };
        public string Title { get; protected set; }
        public string Description { get; protected set; }
        public string Type { get; protected set; }
        protected static List<News> NewsList { get; set; } = new List<News>();
        public News() { }
        public News(string title, string description, string type)
        {
            if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException(nameof(title));
            if (string.IsNullOrWhiteSpace(description)) throw new ArgumentException(nameof(description));
            if (string.IsNullOrWhiteSpace(type)) throw new ArgumentException(nameof(type));
            Title = title;
            Description = description;
            Type = type;
            NewsList.Add(this);
        }

        public override string ToString()
        {
            return $"{Title} - {Description} - {Type}";
        }
    }
}
