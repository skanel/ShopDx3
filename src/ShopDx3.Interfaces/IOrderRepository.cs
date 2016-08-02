using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopDx3.DomainModels;
using ShopDx3.DomainModels.Enums;
using ShopDx3.Interfaces;

namespace ShopDx3.Interfaces
{
    public interface IOrderRepository : IInventoryRepository
    {

        Task<IEnumerable<Order>> GetAllByStatus(ServiceType type);
        Task<IEnumerable<Order>> GetAll();
        Task<IEnumerable<Order>> GetAllCurrentOrders();
        Task<IEnumerable<Order>> GetAllPastOrders();
        Task<long> GetAllPending();
        Task<Order> GetById(Guid id);
        Task<Order> Add(Order order);

    }
}
