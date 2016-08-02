using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopDx3.DomainModels.Interfaces;

namespace ShopDx3.Interfaces
{
    public interface IInventoryRepository
    {
        
    }

    public interface IInventoryRepository<T> : IInventoryRepository where T : IInventoryEntity 
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(Guid id);
        Task<T> AddOrUpdate(T obj);
        Task Delete(Guid id);
    }

  
}