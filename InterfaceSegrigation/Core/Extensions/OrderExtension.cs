using InterfaceSegrigation.Entity.Entity;
using InterfaceSegrigation.Entity.Enums;

namespace InterfaceSegrigation.Core.Extensions
{
    public static class OrderExtension
    {
        public static string GetOrderState(this Order order)
        {
            return order.OrderState switch
            {
                OrderState.Delivered => "Delivered",
                OrderState.Pending => "Pending",
                OrderState.Canceled => "Canceled",
                _ => "Undefined"
            };
        }
    }
}