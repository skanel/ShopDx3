using ShopDx3.DomainModels;

namespace ShopDx3.Interfaces
{
    public interface IMessageService
    {
        void NotifyDelivery(Order order);
    }
}
