namespace InterfaceSegrigation.Infrastructure.Payment
{
    public interface IPaymentGateway
    {
        void Debit();
    }
}