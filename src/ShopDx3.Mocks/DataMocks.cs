using System.Collections.Generic;
using System.Collections.ObjectModel;
using ShopDx3.DomainModels;

namespace ShopDx3.Mocks
{
    public static class DataMocks
    {
        public static ICollection<BlogComment> CommentMocks()
        {
            return new Collection<BlogComment>
            {
                new BlogComment("title1", "my comment1"),
                new BlogComment("title2", "my comment2")
            };
        }

        public static ICollection<Title> TitleMocks()
        {
            return new Collection<Title>
            {
                new Title("en","need to translate to english"),
                new Title("km","need to translate to khmer")
            };
        }

        public static ICollection<Seo> SeoMocks()
        {
            return new Collection<Seo>
            {
              new Seo("metaKeyword", "metaTitle", "metaKeyword","#")

             };
        }
        
        
    }
}
