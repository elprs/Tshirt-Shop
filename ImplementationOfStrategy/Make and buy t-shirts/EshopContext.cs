using ImplementationOfStrategy.Products;
using ImplementationOfStrategy.Strategies.PaymentStrategy;
using ImplementationOfStrategy.Strategies.TshirtVariationStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImplementationOfStrategy.Enums;
using System.Diagnostics.CodeAnalysis;

namespace ImplementationOfStrategy
{
    class EshopContext 
    {
        private IEnumerable<IVariationStrategy> _variations;

        public void SetVariationStrategy(List<IVariationStrategy> variations)
        {
            _variations = variations;
        }

        public void TotalCostShirt(Tshirt tshirt) // An eixa polla edw 8a eixa IProduct 
        {
            decimal sum = 0;
            foreach (var variation in _variations)
            {
                variation.Cost(tshirt);
                Console.WriteLine(variation.GetType().Name + " " + tshirt.Price);
                sum += tshirt.Price;
                Console.WriteLine();
                           
                //Tora prepei kapoiow Client(Front end ot Action method(contrtoller)) na aporrofisei tin katastash, afou 8a to zitisei 
            }
            Console.WriteLine("The total cost is {0:c}", sum);
        }






        //==========================1 context me 2 statigikes!!!!!!!!!!!!!!!!!11==================================
        //gaiti edo mesa eklpironetai to business logic
        //mplekontai ta paterns

        //protoimasia gia payments

        private IPaymentMethodStrategy _paymentMethod; //auto einai property, 8a paei panw, alla gia katanoisi to ebala edw

        public void SelectPaymentMethod(PaymentMethod paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethod.DebitCard: _paymentMethod = new CreditCard();
                    break;
                case PaymentMethod.BankTransfer: _paymentMethod = new BankTransfer();
                    break;
                case PaymentMethod.Cash: _paymentMethod = new Cash();
                    break;
                default:
                    _paymentMethod = new Cash();
                    break;
            }
        }



    }
}
