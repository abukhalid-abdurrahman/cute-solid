namespace DependencyInversion.Infrastructure.Payment
{
    public interface IPaymentGateway
    {
        void Debit();
    }
}