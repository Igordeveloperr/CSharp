using _17_ProjectsFinder.Send.response.copyView;
using System;
using System.Collections.Generic;
using System.Text;

namespace _17_ProjectsFinder.FrontendAndBackend.category
{
    internal abstract class CategoryBase
    {
        public List<PostView> LoadCategory(string type, List<PostView> list)
        {
            List<PostView> outList = new List<PostView>();
            foreach (var post in list)
            {
                if (post.Type.Equals(type))
                {
                    outList.Add(post);
                }
            }
            return outList;
        }
    }
}
