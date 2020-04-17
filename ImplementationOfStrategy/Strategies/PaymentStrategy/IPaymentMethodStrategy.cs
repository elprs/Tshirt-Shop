namespace ImplementationOfStrategy.Strategies.PaymentStrategy
{
    interface IPaymentMethodStrategy
    {
        void Pay(decimal amount);
    }
}
