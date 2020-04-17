using ImplementationOfStrategy.Enums;
using ImplementationOfStrategy.Products;
using ImplementationOfStrategy.Strategies.PaymentStrategy;
using ImplementationOfStrategy.Strategies.TshirtVariationStrategies;
using System;
using System.Collections.Generic;

namespace ImplementationOfStrategy
{
    class EshopContext 
    {
        private IEnumerable<IVariationStrategy> _variations;
        private IPaymentMethodStrategy _paymentMethod;

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
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(variation.GetType().Name + " " + tshirt.Price);
                Console.ForegroundColor = ConsoleColor.White;

                sum += tshirt.Price;
                Console.WriteLine();
                           
                //Tora prepei kapoiow Client(Front end ot Action method(contrtoller)) na aporrofisei tin katastash, afou 8a to zitisei 
            }

            Console.WriteLine("The total cost is {0:c}", sum);
        }

        //Choice of payment methods

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
