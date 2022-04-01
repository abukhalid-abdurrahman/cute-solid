using InterfaceSegrigation.Entity.DTOs;
using InterfaceSegrigation.Entity.Enums;

namespace InterfaceSegrigation.Entity.Entity
{
    public class Order
    {
        public string User { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public OrderState OrderState { get; set; }

        public static implicit operator OrderDto(Order order) => new(order);
    }
}