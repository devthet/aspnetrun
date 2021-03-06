using AutoMapper;
using EventBus.Messages.Events;
using Ordering.Application.Feactures.Orders.Commands.CheckoutOrder;


namespace Ordering.API.Mapping
{
    public class OrderingProfile:Profile
    {
        public OrderingProfile()
        {
            CreateMap<CheckoutOrderCommand, BasketCheckoutEvent>().ReverseMap();
        }
    }
}
