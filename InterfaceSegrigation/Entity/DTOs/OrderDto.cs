using InterfaceSegrigation.Core.Extensions;
using InterfaceSegrigation.Entity.Entity;

namespace InterfaceSegrigation.Entity.DTOs
{
    public class OrderDto
    {
        public OrderDto(Order order)
        {
            Product = order.Product;
            OrderState = order.GetOrderState();
        }
        
        public string Product { get; set; }
        public string OrderState { get; set; }
    }
}