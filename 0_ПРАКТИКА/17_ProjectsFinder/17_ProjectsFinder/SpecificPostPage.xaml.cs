using _17_ProjectsFinder.Send.response.copyView;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _17_ProjectsFinder
{
    /// <summary>
    /// Логика взаимодействия для SpecificPostPage.xaml
    /// </summary>
    public partial class SpecificPostPage : Window
    {
        public List<PostView> PostList { get; private set; } = new List<PostView>();
        public int Id { get; }
        public string TitleValue { get; private set; }
        public string TextValue { get; private set; }
        public SpecificPostPage(int id, List<PostView> list)
        {
            if (id >= 0 && list != null)
            {
                Id = id;
                PostList = list;
                TitleValue = PostList[Id].Title;
                TextValue = PostList[Id].Text;
            }
            DataContext = this;
            InitializeComponent();
        }
    }
}
