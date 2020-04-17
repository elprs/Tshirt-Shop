using ImplementationOfStrategy.Enums;
using ImplementationOfStrategy.GeneralUseItems;
using ImplementationOfStrategy.Products;
using ImplementationOfStrategy.Strategies.TshirtVariationStrategies;
using System;
using System.Collections.Generic;

namespace ImplementationOfStrategy.Make_and_buy_t_shirts
{
    class CustomTshirt
    {
        public static List<Tshirt> tshirts = new List<Tshirt>();

        public static void BuyShirt()
        {
            List<IVariationStrategy> variationStrategies = new List<IVariationStrategy>()
            {
                new ColorVariation(),
                new FabricVariation(),
                new SizeVariation()

             };

            Color color = ChooseVariation<Color>(); 
            Size size = ChooseVariation<Size>();
            Fabric fabric = ChooseVariation<Fabric>();

            Tshirt shirt = new Tshirt(color, size, fabric);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Your order is a {color}, {fabric}, {size} t-shirt");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            EshopContext eshop = new EshopContext();

            eshop.SetVariationStrategy(variationStrategies);

            // Payment Method

            PaymentMethod paymentMethod = ChoosePaymentMethod();
            eshop.SelectPaymentMethod(paymentMethod);
            eshop.TotalCostShirt(shirt);

            tshirts.Add(shirt);

        }

        // ***************** Use of generics to let the user choose from the 3 Enum variations *********************** 
         static T ChooseVariation<T>()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Choose {0}", typeof(T).Name);
            Console.ForegroundColor = ConsoleColor.White;

            //Using an Array for flexibility
            Array items = Enum.GetValues(typeof(T));

            int counter = 0;
            foreach (var item in items)
            {
                Console.WriteLine("{0}  -->  {1}", ++counter, item);
            }

            //let the user choose a number for the menu
            int number = UserInput.AskNumber();

            //Parse the generic Enum type
            T choice = (T)Enum.Parse(typeof(T), number.ToString());

            // return user choice
            return choice;
        }

        //========================= Choose payment (non-enum choices) ==============================

         static PaymentMethod ChoosePaymentMethod()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Choose payment Method");
            Console.ForegroundColor = ConsoleColor.White;

            //Use of Array for flexibility. 
            Array paymentMethods = Enum.GetValues(typeof(PaymentMethod)); 

            int counter = 0;
            foreach (var paymentMethod in paymentMethods)
            {
                Console.WriteLine("{0}    -{1}", ++counter, paymentMethod);
            }

            //let the user choose a number for the menu
            int number = UserInput.AskNumber();

            PaymentMethod userPaymentMethod = (PaymentMethod)number; 

            return userPaymentMethod;
        }
    }
}
