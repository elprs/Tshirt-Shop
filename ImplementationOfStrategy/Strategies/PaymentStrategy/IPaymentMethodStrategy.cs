using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationOfStrategy.Strategies.PaymentStrategy
{
    interface IPaymentMethodStrategy //tha mporouse na einai abstract 
    {
        void Pay(decimal amount); //exo ftiaksei to interface tis stategy
    }
}
