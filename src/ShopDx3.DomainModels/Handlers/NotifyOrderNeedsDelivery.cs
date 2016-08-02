using Autofac.Events;
using ShopDx3.DomainModels.Events;
using ShopDx3.Interfaces;

namespace ShopDx3.DomainModels.Handlers
{

    public class NotifyOrderNeedsDelivery : IHandleEvent<OrderNeedsDelivery>
    {

        private readonly IMessageService _messageService;

        public NotifyOrderNeedsDelivery(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Handle(OrderNeedsDelivery args)
        {
           _messageService.NotifyDelivery(args.Order);

        }
    }
}