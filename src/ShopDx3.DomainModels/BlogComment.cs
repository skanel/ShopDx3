using ShopDx3.DomainModels.BaseTypes;

namespace ShopDx3.DomainModels
{

    public class BlogComment : DocBase
    {

        public BlogComment()
        {

        }
        public BlogComment(string title, string comment)
        {
            this.Title = title;
            this.Comment = comment;
        }

        public string Title { get; set; }
        public string Comment { get; set; }
    }
}
