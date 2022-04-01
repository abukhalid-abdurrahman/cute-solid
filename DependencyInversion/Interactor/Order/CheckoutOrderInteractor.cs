using DependencyInversion.Infrastructure.Payment;
using DependencyInversion.UseCases.Order;

namespace DependencyInversion.Interactor.Order
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