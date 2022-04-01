using InterfaceSegrigation.Repository;
using InterfaceSegrigation.UseCases.Order;

namespace InterfaceSegrigation.Interactor.Order
{
    public class CreateOrderInteractor : ICreateOrderUseCase
    {
        private readonly IOrderRepository _orderRepository;

        public CreateOrderInteractor(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        
        public void Perform()
        {
            throw new System.NotImplementedException();
        }
    }
}