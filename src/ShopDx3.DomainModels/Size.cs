using System;
using ShopDx3.DomainModels.BaseTypes;
using ShopDx3.DomainModels.Interfaces;

namespace ShopDx3.DomainModels
{
    public class Size : InventoryBase, IInventoryEntity
    {

        public Size(string name, decimal price)
            : base(name, price)
        {
        
        }

        public Size(Guid id, string name, decimal price)
            : base(id, name, price)
        {

        }


    }
}