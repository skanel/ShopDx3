using System;
using ShopDx3.DomainModels.BaseTypes;
using ShopDx3.DomainModels.Interfaces;

namespace ShopDx3.DomainModels
{
    public class Cheese : InventoryBase, IInventoryEntity
    {
        public Cheese(string name) : base(name)
        {
        }

        public Cheese(Guid id, string name) : base(id, name)
        {
        }


        public override bool ShouldSerializePrice()
        {
            return false;
        }

    }

  
}