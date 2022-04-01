using OpenClosed.Entity.Entity;
using OpenClosed.Entity.Enums;

namespace OpenClosed.Core.Extensions
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