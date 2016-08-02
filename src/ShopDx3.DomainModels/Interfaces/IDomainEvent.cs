using System;

namespace ShopDx3.DomainModels.Interfaces
{
    public interface IDomainEvent
    {
        DateTime DateOccurred { get; }
    }
}
