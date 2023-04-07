using BooruSharp.Booru;
using BooruSharp.Booru.Template;
using BooruSharp.Search.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_BooruParser.Parser
{
    internal class BooruParser
    {
        const int MAX_LIMIT = 20;
        const int MIN_ID = 1;
        private ABooru _booru;

        public BooruParser(ABooru booru)
        {
            if (booru != null)
            {
                _booru = booru;
            }
            else
            {
                _booru = new Atfbooru();
            }
        }

        public async Task<string> ParseById(int id)
        {
            if (id >= MIN_ID)
            {
                var response = await _booru.GetPostByIdAsync(id);
                if (response.FileUrl != null)
                {
                   return response.FileUrl.AbsoluteUri;
                }
                else
                {
                    return string.Empty;
                }
            }
            else
            {
                throw new ArgumentException(Answer.ArgumentError);
            }
        }

        public async Task<List<string>> ParseByTag(int limit, string tag)
        {
            if (limit <= MAX_LIMIT)
            {
                List<string> list = new List<string>();
                var response = await _booru.GetRandomPostsAsync(limit, tag);
                foreach (var post in response)
                {
                    if (post.FileUrl != null)
                    {
                        list.Add(post.FileUrl.AbsoluteUri);
                    }
                }
                return list;
            }
            else
            {
                throw new ArgumentException(Answer.ArgumentError);
            }
        }
    }
}
