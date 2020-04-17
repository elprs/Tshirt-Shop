using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
