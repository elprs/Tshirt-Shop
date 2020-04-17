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
using ImplementationOfStrategy.GeneralUseItems;

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



            Print.SortingMenu();
            Print.CustomTshirtMenu();






            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Press enter");
            Console.ReadLine();
        }
    }
       
}
