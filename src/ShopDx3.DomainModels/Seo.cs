using ShopDx3.DomainModels.BaseTypes;
namespace ShopDx3.DomainModels
{
    public class Seo : DocBase
    {
        public Seo()
        {

        }

        public Seo(string metaTitle, string metaKeyword, string metaDescription, string slug)
        {
            this.metaDescription = metaDescription;
            this.metaTitle = metaTitle;
            this.metaKeyword = metaKeyword;
            this.slug = slug;
        }

        public string metaTitle { get; set; }
        public string metaKeyword { get; set; }
        public string metaDescription { get; set; }
        public string slug { get; set; }
    }
}
