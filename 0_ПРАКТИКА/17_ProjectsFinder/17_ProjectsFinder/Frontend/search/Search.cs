using _17_ProjectsFinder.Send.response.copyView;
using System;
using System.Collections.Generic;
using System.Text;

namespace _17_ProjectsFinder.Frontend.search
{
    internal abstract class Search
    {
        protected string Word;
        protected List<PostView> List;
        public Search(string word, List<PostView> list)
        {
            Word = word;
            List = list;
        }
        public abstract List<PostView> GetSearchResult();
    }
}
