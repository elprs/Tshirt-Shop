using ImplementationOfStrategy.Enums;
using ImplementationOfStrategy.Products;
using ImplementationOfStrategy.Strategies.TshirtVariationStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImplementationOfStrategy.SortingAlgorithms;
using static ImplementationOfStrategy.SortingAlgorithms.Delegation;
using ImplementationOfStrategy.Make_and_buy_t_shirts;

namespace ImplementationOfStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClientApp.BuyShirt();

            ////leipei mia do while edo gia panta 
            ////eg 
            //while (true)
            //{
            //    ClientApp.PrintShirts();
            //}



            //Print.SortingMenu();
           //
            Print.CustomTshirtMenu();


            int n = ChooseVariation<Color>();



            Console.WriteLine("Press enter");
            Console.ReadLine();
        }


        //Tis exo private gia na kano mia methodo apo panw pou tha exei tin eksis aksia


        // kathari logiki 
        //kalispera, kalinusta , dose mou variations
        public static int ChooseVariation<T>()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Choose {0}", typeof(T).Name); // color typr.GetNAME....otan refactor!!!!!!!!!!!!!!!!!
            Console.ForegroundColor = ConsoleColor.White;

            //thelo o xristis na epileksei apo mia lista epilogos olon ton enum alla de 8aleo na katantuso na pigaine gia 1-blue, gia 2-red ktl
            //Thelo aneksartisia giauto 8a po ela kai vale se ena array 
            Array colors = Enum.GetValues(typeof(T)); //pare tis times me tipo color kai apo8ikeuse tes an yheleisse ena typo AAAAaaaaaarray. den einai array pou exei intex array[] oxi mana mou oxi oxi, einai allos type
            int counter = 0;

            foreach (var color in colors)
            {
                Console.WriteLine("{0} --> {1}", ++counter, color);
            }

            int number = Convert.ToInt32(Console.ReadLine()); //2  douleis , prpei na spasei., leei choose ala kanei kai alla
                                                              //T userColor = (T)number;

            // return userColor;
            return number;


        }


    }


    class ClientApp


    {


        //public static void PrintShirts()
        //{
        //    foreach (var shirt in tshirts)
        //    {
        //        Console.WriteLine("{0, -7}{1, -7}{2, -7}", shirt.Color, shirt.Fabric, shirt.Size );
        //    }
           
        //}

        
    }

   
}
