using ShopDx3.DomainModels.BaseTypes;
using System;

namespace ShopDx3.DomainModels
{
    public class Product:DocBase
    {
        public Product() { Id = Guid.NewGuid(); }
        public string ProductName { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }

    }



}
