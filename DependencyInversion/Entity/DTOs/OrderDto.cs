using DependencyInversion.Core.Extensions;
using DependencyInversion.Entity.Entity;

namespace DependencyInversion.Entity.DTOs
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