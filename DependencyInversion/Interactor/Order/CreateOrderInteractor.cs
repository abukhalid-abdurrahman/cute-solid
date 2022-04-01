using DependencyInversion.Repository;
using DependencyInversion.UseCases.Order;

namespace DependencyInversion.Interactor.Order
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