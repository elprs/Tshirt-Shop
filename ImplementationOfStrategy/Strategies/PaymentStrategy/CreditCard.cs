using System;

namespace ImplementationOfStrategy.Strategies.PaymentStrategy
{
    class CreditCard : IPaymentMethodStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Pay {amount} using Credit card.");
        }
    }
}
