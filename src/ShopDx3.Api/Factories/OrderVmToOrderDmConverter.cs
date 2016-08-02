using System.Linq;
using AutoMapper;
using ShopDx3.DomainModels;
using ShopDx3.DomainModels.Enums;
using ShopDx3.SharedKernel;
using ShopDx3.ViewModels;

namespace ShopDx3.Api.Factories
{
    public class OrderVmToOrderDmConverter : ITypeConverter<OrderVm, Order>
    {
        public Order Convert(ResolutionContext context)
        {
            var src = (OrderVm)context.SourceValue;
            var servType = Enumeration.FromDisplayName<ServiceType>(src.ServiceType.Replace(" ", ""));
            var pizzas = src.Pizzas.Select(x => Mapper.Map<PizzaVm, Pizza>(x)).ToList();
            var result = new Order(servType, pizzas, src.Name);
            return result;
        }
    }
}