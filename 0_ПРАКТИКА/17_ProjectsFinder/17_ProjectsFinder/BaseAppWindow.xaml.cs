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
    /// Логика взаимодействия для BaseAppWindow.xaml
    /// </summary>
    public partial class BaseAppWindow : Window
    {
        private PostRequest PostRequestObj;
        private PostResponse PostResponseObj;
        private event Action OnLoadForm;
        private List<PostView> Posts;
        public BaseAppWindow()
        {
            InitializeComponent();
            OnLoadForm += Update_Post;
            OnLoadForm.Invoke();
        }

        private async void Update_Post()
        {
            PostRequestObj = new PostRequest();
            PostResponseObj = new PostResponse();
            await Task.Run(()=> { PostRequestObj.SendRequest(); });
            await Task.Run(()=> { Posts = PostResponseObj.GetPostResponse().Result; });
            AddPost(Posts);
        }

        private void Select_Category(object sender, RoutedEventArgs e)
        {
            string clickBtnType = (sender as Button).Name;
            
        }

        private void AddPost(List<PostView> list)
        {
            BrushConverter converter = new BrushConverter();
            foreach (var post in list)
            {
                StackPanel panel = new StackPanel();
                TextBlock textBlock = new TextBlock();
                Button btn = new Button();
                textBlock.Text = post.Title;
                textBlock.Width = 700;
                textBlock.Height = 40;
                textBlock.FontSize = 30;
                textBlock.Foreground = Brushes.White;
                btn.Content = "Присоединиться";
                btn.Width = 150;
                btn.Height = 30;
                btn.Background = (Brush) converter.ConvertFrom("#c56cf0");
                btn.FontSize = 16;
                btn.Margin = new Thickness(0,10,0,10);
                btn.HorizontalAlignment = HorizontalAlignment.Left;
                btn.Foreground = (Brush)converter.ConvertFrom("#d1d8e0");                
                panel.Children.Add(textBlock);
                panel.Children.Add(btn);
                postBox.Items.Add(panel);
            }
        }
    }
}
