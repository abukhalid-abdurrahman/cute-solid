using DependencyInversion.Infrastructure.Payment;

namespace DependencyInversion.Infrastructure.Implementation.Payment
{
    public class KortiMilliPaymentGateway : IPaymentGateway
    {
        public void Debit()
        {
            throw new System.NotImplementedException();
        }
    }
}