using System;

namespace ImplementationOfStrategy.Strategies.PaymentStrategy
{
    class BankTransfer  : IPaymentMethodStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Pay {amount} using bank transfer.");
        }
    }
}
