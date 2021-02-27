using _17_ProjectsFinder.Send.response.copyView;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _17_ProjectsFinder.Frontend.search
{
    internal class SearchPost: Search
    {   
        public SearchPost(string word, List<PostView> list) : base(word, list) 
        {
        }
        public override List<PostView> GetSearchResult()
        {
            bool searchResult;
            List<PostView> result = new List<PostView>();
            foreach(var post in List)
            {
                searchResult = Regex.IsMatch(post.Title.ToLower(), $"{Word.ToLower()}");
                if (searchResult)
                {
                    result.Add(post);
                }
            }
            return result;
        }
    }
}
