using System;

namespace ImplementationOfStrategy.Strategies.PaymentStrategy
{
    class Cash : IPaymentMethodStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Pay {amount} using cash.");
        }
    }
}
