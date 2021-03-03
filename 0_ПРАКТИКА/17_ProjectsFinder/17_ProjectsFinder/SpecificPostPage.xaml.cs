using _17_ProjectsFinder.Send;
using _17_ProjectsFinder.Send.response;
using _17_ProjectsFinder.Send.response.copyView;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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
        public string Login { get; }
        public string TitleValue { get; private set; }
        public string TextValue { get; private set; }
        private delegate void MyAction();
        private event MyAction WindowOnLoad;
        public SpecificPostPage(int id, List<PostView> list, string login)
        {
            if (id >= 0 && list != null)
            {
                Id = id;
                PostList = list;
                TitleValue = PostList[Id].Title;
                TextValue = PostList[Id].Text;
                Login = login;
                WindowOnLoad += UpdateUserList;
                WindowOnLoad.Invoke();
            }
            DataContext = this;
            InitializeComponent();
        }

        private async void UpdateUserList()
        {
            List<UpdateUserListView> list = new List<UpdateUserListView>();
            int postId = PostList[Id].Id;
            var request = new UpdateUserListRequest(postId);
            var response = new UpdateUserListResponse();
            await Task.Run(() => { request.SendRequest(); });
            await Task.Run(() => { list = response.GetUserList().Result; });
            AddUserInList(list);
        }

        private async void Connect(object sender, RoutedEventArgs e)
        {   
            int postId = PostList[Id].Id;
            var request = new InsertUserRequest(postId, Login);
            var response = new UserConnectResponse();
            string message = "";
            await Task.Run(()=> { request.SendRequest(); });
            await Task.Run(() => { message = response.GetResponse().Result; });
            MessageBox.Show(message);
        }

        private void AddUserInList(List<UpdateUserListView> list)
        {
            BrushConverter converter = new BrushConverter();
            foreach (var user in list)
            {
                StackPanel panel = new StackPanel();
                TextBlock textBlock = new TextBlock();
                panel.Children.Add(textBlock);
                panel.Background = (Brush)converter.ConvertFrom("#273c75");
                panel.Width = 300;
                textBlock.Padding = new Thickness(10,10,10,10);
                textBlock.FontSize = 16;
                textBlock.Foreground = Brushes.White;
                textBlock.Text = user.Name;
                userList.Items.Add(panel);
            }
        }
    }
}
