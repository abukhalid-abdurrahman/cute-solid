using InterfaceSegrigation.Infrastructure.Payment;
using InterfaceSegrigation.UseCases.Order;

namespace InterfaceSegrigation.Interactor.Order
{
    public class CheckoutOrderInteractor : ICheckoutOrderUseCase
    {
        private readonly IPaymentGateway _paymentGateway;

        public CheckoutOrderInteractor(IPaymentGateway paymentGateway)
        {
            _paymentGateway = paymentGateway;
        }
        
        public void Perform()
        {
            throw new System.NotImplementedException();
        }
    }
}