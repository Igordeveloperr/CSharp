using _17_ProjectsFinder.Frontend.search;
using _17_ProjectsFinder.FrontendAndBackend.category;
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
        private List<PostView> SpecificPost = new List<PostView>();
        private List<PostView> SearchPost = new List<PostView>();
        private MainWindow AuthorizationWindow = new MainWindow();
        private PostRequest PostRequestObj;
        private PostResponse PostResponseObj;
        private event Action OnLoadForm;
        private List<PostView> Posts;
        private Dictionary<string, CategoryBase> CategoryObjects = new Dictionary<string, CategoryBase>
        {
            {"php", new PhpCategory() },
            {"plus", new PlusCategory() },
            {"sharp", new SharpCategory() },
            {"ts", new TypeScriptCategory() },
            {"js", new JavaScriptCategory()},
        };
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
            string type = (sender as Button).Name;
            SpecificPost = CategoryObjects[type].LoadCategory(type, Posts);
            postBox.Items.Clear();
            AddPost(SpecificPost);
        }

        private void ConnectBtnClick(object sender, RoutedEventArgs e)
        {
            int id = (sender as Button).TabIndex;
            SpecificPostPage page;
            if(SpecificPost.Count == 0 && SearchPost.Count == 0)
            {
                page = new SpecificPostPage(id, Posts);
            }
            else if(SearchPost.Count >= 0 && SpecificPost.Count == 0)
            {
                page = new SpecificPostPage(id, SearchPost);
            }
            else
            {
                page = new SpecificPostPage(id, SpecificPost);
            }
            page.Show();
        }

        private void ShowAllCategory(object sender, RoutedEventArgs e)
        {
            SpecificPost.Clear();
            SearchPost.Clear();
            postBox.Items.Clear();
            AddPost(Posts);
        }

        private void CloseApp(object sender, RoutedEventArgs e)
        {
            this.Close();
            AuthorizationWindow.Show();
        }
        private void Search(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBox.Text))
            {
                MessageBox.Show("Заполните строку поиска!");
            }
            else
            {
                SearchPost search = new SearchPost(searchBox.Text, Posts);
                SpecificPost.Clear();
                postBox.Items.Clear();
                SearchPost = search.GetSearchResult();
                AddPost(SearchPost);
            }
            searchBox.Text = "";
        }
        private void AddPost(List<PostView> list)
        {
            BrushConverter converter = new BrushConverter();
            for (int i = 0; i < list.Count; i++)
            {
                StackPanel panel = new StackPanel();
                panel.Name = list[i].Type;
                TextBlock textBlock = new TextBlock();
                Button btn = new Button();
                textBlock.Text = list[i].Title;
                textBlock.Width = 700;
                textBlock.Height = 40;
                textBlock.FontSize = 30;
                textBlock.Foreground = Brushes.White;
                btn.Content = "Присоединиться";
                btn.Width = 150;
                btn.Height = 30;
                btn.Background = (Brush)converter.ConvertFrom("#c56cf0");
                btn.FontSize = 16;
                btn.TabIndex = i;
                btn.Click += ConnectBtnClick;
                btn.Margin = new Thickness(0, 10, 0, 10);
                btn.HorizontalAlignment = HorizontalAlignment.Left;
                btn.Foreground = (Brush)converter.ConvertFrom("#d1d8e0");
                panel.Children.Add(textBlock);
                panel.Children.Add(btn);
                postBox.Items.Add(panel);
            }
        }
    }
}
