using ShopDx3.DomainModels.BaseTypes;
using System.Collections.Generic;

namespace ShopDx3.DomainModels
{
    public class ProductCategory:DocBase
    {
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
