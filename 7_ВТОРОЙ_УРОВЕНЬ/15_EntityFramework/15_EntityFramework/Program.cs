using System;
using System.Data.SqlClient;

namespace _15_EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new DataBaseContext())
            {
                var news = new UserNews
                {
                    Title = "Test1",
                    Description = "sasad",
                    Date = "23-12-11",
                    Status = 1
                };
                context.News.Add(news);
                context.SaveChanges();
                Console.WriteLine(context.News.Local.ToString());

            }
        }
    }
}
