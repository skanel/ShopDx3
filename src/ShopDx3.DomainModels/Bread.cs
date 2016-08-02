using System;
using ShopDx3.DomainModels.BaseTypes;
using ShopDx3.DomainModels.Interfaces;

namespace ShopDx3.DomainModels
{
    public class Bread : InventoryBase, IInventoryEntity
    {
        public Bread(string name) : base(name)
        {

        }

        public Bread(Guid id, string name) : base(id, name)
        {
        }

        public override bool ShouldSerializePrice()
        {
            return false;
        }
    }
}