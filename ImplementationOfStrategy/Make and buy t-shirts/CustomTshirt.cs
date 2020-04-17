using ImplementationOfStrategy.Enums;
using ImplementationOfStrategy.Products;
using ImplementationOfStrategy.Strategies.TshirtVariationStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationOfStrategy.Make_and_buy_t_shirts
{
    class CustomTshirt
    {



        public static List<Tshirt> tshirts = new List<Tshirt>();


        // TODO :  REFACTOR and make it  private static T Choose<T>()  .....................

        public static void BuyShirt()
        {
            //skopos na setarei ta variations
            //TODO refactoring : Naginetai apo tin class
            //naeixes to tshirt kai auto na eixe tshirt.variation kai oxi o cxlient na kathorizei
            //To tshirt na kathorizti ta variations tou 
            // kai stin eshop.SetVariationStrategy(variationStrategies) tha eleges ela kai xose ta (tshirtVariations)
            List<IVariationStrategy> variationStrategies = new List<IVariationStrategy>()
            {
                new ColorVariation(),
                new FabricVariation(),
                new SizeVariation()

             };

            Color color = ChooseColor(); /// ++++++++++++++++++++++
            Size size = ChooseSize();
            Fabric fabric = ChooseFabric();

            Tshirt shirt = new Tshirt(color, size, fabric);

            EshopContext eshop = new EshopContext();

            eshop.SetVariationStrategy(variationStrategies); // mporo n ato apofygo me ctror se EshopContex

            // paymentMethod.

            PaymentMethod paymentMethod = ChoosePaymentMethod();
            eshop.SelectPaymentMethod(paymentMethod);
            eshop.TotalCostShirt(shirt);

            tshirts.Add(shirt);

        }

        //Tis exo private gia na kano mia methodo apo panw pou tha exei tin eksis aksia


        // kathari logiki 
        //kalispera, kalinusta , dose mou variations
        private static Color ChooseColor()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Choose {0}", typeof(Color).Name); // color typr.GetNAME....otan refactor!!!!!!!!!!!!!!!!!
            Console.ForegroundColor = ConsoleColor.White;

            //thelo o xristis na epileksei apo mia lista epilogos olon ton enum alla de 8aleo na katantuso na pigaine gia 1-blue, gia 2-red ktl
            //Thelo aneksartisia giauto 8a po ela kai vale se ena array 
            Array colors = Enum.GetValues(typeof(Color)); //pare tis times me tipo color kai apo8ikeuse tes an yheleisse ena typo AAAAaaaaaarray. den einai array pou exei intex array[] oxi mana mou oxi oxi, einai allos type
            int counter = 0;

            foreach (var color in colors)
            {
                Console.WriteLine("{0} --> {1}", ++counter, color);
            }

            Color userColor = (Color)Convert.ToInt32(Console.ReadLine()); //2  douleis , prpei na spasei., leei choose ala kanei kai alla

            return userColor;

        }


        private static Fabric ChooseFabric()
        {
            Console.WriteLine("Choose fabric");
            //thelo o xristis na epileksei apo mia lista epilogos olon ton enum alla de 8aleo na katantuso na pigaine gia 1-blue, gia 2-red ktl
            //Thelo aneksartisia giauto 8a po ela kai vale se ena array 
            Array fabrics = Enum.GetValues(typeof(Fabric)); //pare tis times me tipo fabric kai apo8ikeuse tes an yheleisse ena typo AAAAaaaaaarray. den einai array pou exei intex array[] oxi mana mou oxi oxi, einai allos type
            int counter = 0;

            foreach (var fabric in fabrics)
            {
                Console.WriteLine("{0} --> {1}", ++counter, fabric);
            }

            Fabric userFabric = (Fabric)Convert.ToInt32(Console.ReadLine());

            return userFabric;

        }



        private static Size ChooseSize()
        {
            Console.WriteLine("Choose size");
            //thelo o xristis na epileksei apo mia lista epilogos olon ton enum alla de 8aleo na katantuso na pigaine gia 1-blue, gia 2-red ktl
            //Thelo aneksartisia giauto 8a po ela kai vale se ena array 
            Array sizes = Enum.GetValues(typeof(Size)); //pare tis times me tipo size kai apo8ikeuse tes an yheleisse ena typo AAAAaaaaaarray. den einai array pou exei intex array[] oxi mana mou oxi oxi, einai allos type
            int counter = 0;

            foreach (var size in sizes)
            {
                Console.WriteLine("{0} --> {1}", ++counter, size);
            }

            Size userSize = (Size)Convert.ToInt32(Console.ReadLine());

            return userSize;

        }










        //=========================choose payment // ktl





        private static PaymentMethod ChoosePaymentMethod()
        {
            Console.WriteLine("Choose payment Method"); // paymentMethod typr.GetNAME....otan refactor!!!!!!!!!!!!!!!!!

            //Thelo aneksartisia giauto 8a po ela kai vale se ena array 
            Array paymentMethods = Enum.GetValues(typeof(PaymentMethod)); //pare tis times me tipo paymentMethod kai apo8ikeuse tes an yheleisse ena typo AAAAaaaaaarray. den einai array pou exei intex array[] oxi mana mou oxi oxi, einai allos type
            int counter = 0;

            foreach (var paymentMethod in paymentMethods)
            {
                Console.WriteLine("{0}    -{1}", ++counter, paymentMethod);
            }

            PaymentMethod userPaymentMethod = (PaymentMethod)Convert.ToInt32(Console.ReadLine()); //2  douleis , prpei na spasei., leei choose ala kanei kai alla

            return userPaymentMethod;

        }









        //// TODO :  REFACTOR and make it  private static T Choose<T>()  .....................

        //public static void BuyShirt()
        //{
        //    //skopos na setarei ta variations
        //    //TODO refactoring : Naginetai apo tin class
        //    //naeixes to tshirt kai auto na eixe tshirt.variation kai oxi o cxlient na kathorizei
        //    //To tshirt na kathorizti ta variations tou 
        //    // kai stin eshop.SetVariationStrategy(variationStrategies) tha eleges ela kai xose ta (tshirtVariations)
        //    List<IVariationStrategy> variationStrategies = new List<IVariationStrategy>()
        //    {
        //        new ColorVariation(),
        //        new FabricVariation(),
        //        new SizeVariation()

        //     };

        //    Color color = ChooseColor(); /// ++++++++++++++++++++++
        //    Size size = ChooseSize();
        //    Fabric fabric = ChooseFabric();

        //    Tshirt shirt = new Tshirt(color, size, fabric);

        //    EshopContext eshop = new EshopContext();

        //    eshop.SetVariationStrategy(variationStrategies); // mporo n ato apofygo me ctror se EshopContex

        //    // paymentMethod.

        //    PaymentMethod paymentMethod = ChoosePaymentMethod();
        //    eshop.SelectPaymentMethod(paymentMethod);
        //    eshop.TotalCostShirt(shirt);

        //    tshirts.Add(shirt);

        //}

        
    }
}
