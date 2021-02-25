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
        private List<PostView> PostList = new List<PostView>();
        private int Id;
        private delegate void BaseDelegat();
        private event BaseDelegat OnLoadWindow;
        public SpecificPostPage(int id, List<PostView> list)
        {
            if (id > 0 && list != null)
            {
                Id = id;
                PostList = list;
                OnLoadWindow += ShowContent;
                OnLoadWindow.Invoke();
            }
            InitializeComponent();
        }

        private void ShowContent()
        {
            PostList.Reverse();
            MessageBox.Show($"{PostList[Id].Id} - {Id}");
        }
    }
}
