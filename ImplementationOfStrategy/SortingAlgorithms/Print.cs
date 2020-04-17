using ImplementationOfStrategy.Make_and_buy_t_shirts;
using ImplementationOfStrategy.Products;
using ImplementationOfStrategy.SortingAlgorithms.BubbleSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationOfStrategy.SortingAlgorithms
{
    public class Print
    {
        static void AllItems(IEnumerable<Tshirt> shirts)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("All Clothes");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0,-15}{1,-15}{2,-15}", "Color", "Size", "Fabric");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var shirt in shirts)
            {
                shirt.Output();
            }
        }


         static void UserChoice(int algorithmChoice, int sortingChoice )
        {
            switch (algorithmChoice)
            {
                case 1:  AllItems(QuickSortDelegated.ChooseSorting(sortingChoice)); break;
                case 2: AllItems(BubbleSortDelegated.ChooseSorting(sortingChoice)); break;
                default: AllItems(BubbleSortDelegated.ChooseSorting(sortingChoice)); break;
            }
        }

        public static void SortingMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("How do you want to see you items sorted?");
            Console.WriteLine("1: Quick Sort");
            Console.WriteLine("2: Bubble Sort");
            Console.WriteLine("Any other number: Bubble Sort");
            Console.ForegroundColor = ConsoleColor.White;

            int algorithmChoice = Convert.ToInt32(Console.ReadLine());

            if (algorithmChoice == 1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("What do you want to see you items sorted by?");
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("1: Color Ascending");
                Console.WriteLine("2: Color Descending");
                Console.WriteLine("3: Fabric Ascending");
                Console.WriteLine("4: Fabric Descending");
                Console.WriteLine("5: Size Ascending");
                Console.WriteLine("6: Size Descending");
                Console.WriteLine("Any other number: Color Ascending");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("How do you want to see you items sorted by?");
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("1: Color Ascending");
                Console.WriteLine("2: Color Descending");
                Console.WriteLine("3: Fabric Ascending");
                Console.WriteLine("4: Fabric Descending");
                Console.WriteLine("5: Size Ascending");
                Console.WriteLine("6: Size Descending");
                Console.WriteLine("7: Size-Color-Fablic Ascending");
                Console.WriteLine("8: Size-Color-Fablic Descending");
                Console.WriteLine("Any other number: Color Ascending");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
            int variationChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            UserChoice(algorithmChoice, variationChoice);
        }

        public static void CustomTshirtMenu()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Make and buy your own T-shirt");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            CustomTshirt.BuyShirt();
            Console.WriteLine();

        }
    }
}
