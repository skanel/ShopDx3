using System;

namespace ShopDx3.DomainModels.Interfaces
{
    public interface IEntity 
    {
        Guid Id { get;  }
        string Name { get;  }
    }


}
