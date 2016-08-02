using System;
using ShopDx3.DomainModels.BaseTypes;
using ShopDx3.DomainModels.Interfaces;

namespace ShopDx3.DomainModels
{
    public class Topping : InventoryBase, IInventoryEntity
    {

        public Topping(string name, decimal price) : base(name, price)
        {

        }

        public Topping(Guid id, string name, decimal price)
            : base(id, name, price)
        {
       
        }
   
    }
} 