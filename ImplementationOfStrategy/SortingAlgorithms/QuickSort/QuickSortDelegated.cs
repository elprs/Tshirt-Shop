using ImplementationOfStrategy.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ImplementationOfStrategy.SortingAlgorithms.Delegation;

namespace ImplementationOfStrategy.SortingAlgorithms
{
    class QuickSortDelegated
    {
        static Tshirt[] PrepareSignature(out int n)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("****************** Quick sort  ****************");
            Console.ForegroundColor = ConsoleColor.White;

            MyDatabase myDatabase = new MyDatabase();

            //prepare signature parameters
            var shirts = myDatabase.tshirts.ToArray();
            n = shirts.Length - 1;

            return shirts;
        }
        // ******************** Delegated methods on Color ************************
        static Tshirt[] ColorAsc()
        {
            Tshirt[] shirts = PrepareSignature(out int n);
            //instatiate the delegate
            QuickSortDelegate sortingDelegate = QuickSortHardCoded.ColorAsc;

            //call the delegate
            sortingDelegate(shirts, 0, n);

            return shirts;
        }
        static Tshirt[] ColorDesc()
        {
            Tshirt[] shirts = PrepareSignature(out int n);
            //instatiate the delegate
            QuickSortDelegate sortingDelegate = QuickSortHardCoded.ColorDesc;

            //call the delegate
            sortingDelegate(shirts, 0, n);

            return shirts;
        }
        // ********************* Delegated methods on Fabric ************************
        static Tshirt[] FabricAsc()
        {
            Tshirt[] shirts = PrepareSignature(out int n);
            //instatiate the delegate
            QuickSortDelegate sortingDelegate = QuickSortHardCoded.FabricAsc;

            //call the delegate
            sortingDelegate(shirts, 0, n);

            return shirts;
        }
        static Tshirt[] FabricDesc()
        {
            Tshirt[] shirts = PrepareSignature(out int n);
            //instatiate the delegate
            QuickSortDelegate sortingDelegate = QuickSortHardCoded.FabricDesc;

            //call the delegate
            sortingDelegate(shirts, 0, n);

            return shirts;
        }
        // ******************** Delegated methods on Size ************************
        static Tshirt[] SizeAsc()
        {
            Tshirt[] shirts = PrepareSignature(out int n);
            //instatiate the delegate
            QuickSortDelegate sortingDelegate = QuickSortHardCoded.SizeAsc;

            //call the delegate
            sortingDelegate(shirts, 0, n);

            return shirts;
        }
        static Tshirt[] SizeDesc()
        {
            Tshirt[] shirts = PrepareSignature(out int n);
            //instatiate the delegate
            QuickSortDelegate sortingDelegate = QuickSortHardCoded.SizeDesc;

            //call the delegate
            sortingDelegate(shirts, 0, n);

            return shirts;
        }

        public static Tshirt[] ChooseSorting(int choice)
        {
            switch (choice)
            {
                case 1: return ColorAsc();
                case 2: return ColorDesc();
                case 3: return FabricAsc();
                case 4: return FabricDesc();
                case 5: return SizeAsc();
                case 6: return SizeDesc();
                default: return ColorAsc();
            }
        }

    }
}
