using ShopDx3.DomainModels.BaseTypes;
using System.Collections.Generic;

namespace ShopDx3.DomainModels
{
    public class BlogPost : DocBase
    {   
        public string Description { get; set; }
        public List<Title> Title { get; set; }
        public List<BlogComment> Blogcomments { get; set; }
        public string Name { get; set; }
  
        public BlogPost()
        {

        }
        public BlogPost (List<Title> title, string desc,List<BlogComment> commentList)
        {
            
            Blogcomments = commentList;
            Description = desc;
            Title = title;
            
        }
           
    }

   
}
