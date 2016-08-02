using System;
using ShopDx3.DomainModels.BaseTypes;
using ShopDx3.DomainModels.Interfaces;

namespace ShopDx3.DomainModels
{

    public class Sauce : InventoryBase, IInventoryEntity
    {
        public Sauce(string name) : base(name)
        {
        }

        public Sauce(Guid id, string name) : base(id, name)
        {
        }

        public override bool ShouldSerializePrice()
        {
            return false;
        }

    }
}