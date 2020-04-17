using ImplementationOfStrategy.Products;
using ImplementationOfStrategy.Strategies.PaymentStrategy;
using ImplementationOfStrategy.Strategies.TshirtVariationStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImplementationOfStrategy.Enums;

namespace ImplementationOfStrategy
{
    class EshopContext //oli i douleia tou context einai ela kai dose mou modularity sto business logic.Single responsibility and seperation of comcerns
        //Reponsibility : Business logic
    {
        private IEnumerable<IVariationStrategy> _variations;


        //public EshopContext()
        //{
            //gia na apofygo to eshop.SetVariationStrategy(variationStrategies); sto BuyShirt()
        //}

        public void SetVariationStrategy(List<IVariationStrategy> variations)
        {
            _variations = variations;
        }

        public void TotalCostShirt(Tshirt tshirt) // An eixa polla edw 8a eixa IProduct 
        {
            foreach (var variation in _variations)
            {
                variation.Cost(tshirt);
                Console.WriteLine(variation.GetType().Name + " " + tshirt.Price); //tora prepei kapoiow Client(Front end ot Action method(contrtoller)) na aporrofisei tin katastash, afou 8a to zitisei 
            }
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
