using _17_ProjectsFinder.Send.Settings;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Sockets;
using System.Text;

namespace ServerProjectsFinder.View
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
