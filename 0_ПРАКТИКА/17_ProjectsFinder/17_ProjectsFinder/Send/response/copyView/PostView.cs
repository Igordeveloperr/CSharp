using System;
using System.Collections.Generic;
using System.Text;

namespace _17_ProjectsFinder.Send.response.copyView
{
    public class PostView
    {
        public int Id { get; }
        public string Title { get; }
        public string Text { get; }
        public int Status { get; }
        public string Type { get; }
        public PostView(int id, string title, string text, int status, string type)
        {
            Id = id;
            Title = title;
            Text = text;
            Status = status;
            Type = type;
        }
    }
}
