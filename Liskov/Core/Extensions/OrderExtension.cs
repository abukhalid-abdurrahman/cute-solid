using Liskov.Entity.Entity;
using Liskov.Entity.Enums;

namespace Liskov.Core.Extensions
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