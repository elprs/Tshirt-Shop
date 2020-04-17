using ImplementationOfStrategy.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using static ImplementationOfStrategy.SortingAlgorithms.Delegation;

namespace ImplementationOfStrategy.SortingAlgorithms.BubbleSort
{
    class BubbleSortDelegated
    {
        static List<Tshirt> PrepareSignature()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("****************** Bubble sort  ****************");
            Console.ForegroundColor = ConsoleColor.White;

            MyDatabase myDatabase = new MyDatabase();

            //prepare signature parameters
            var shirts = myDatabase.tshirts.ToList();

            return shirts;
        }

        // ******************** Delegated methods on 3 variations simultaneously ************************
        static List<Tshirt> SizeColorFablicAsc()
        {
            List<Tshirt> shirts = PrepareSignature();
            //instatiate the delegate
            BubbleDelegate sortingDelegate = BubbleSortHardCoded.SizeColorFablicAsc;

            //call the delegate
            sortingDelegate(shirts);

            return shirts;
        }

         static List<Tshirt> SizeColorFablicDesc()
        {
            List<Tshirt> shirts = PrepareSignature();
            //instatiate the delegate
            BubbleDelegate sortingDelegate = BubbleSortHardCoded.SizeColorFablicDesc;

            //call the delegate
            sortingDelegate(shirts);

            return shirts;
        }

        // ****************************** Delegated methods on Color ****************************
        static List<Tshirt> ColorAsc()
        {
            List<Tshirt> shirts = PrepareSignature();
            //instatiate the delegate
            BubbleDelegate sortingDelegate = BubbleSortHardCoded.ColorAsc;

            //call the delegate
            sortingDelegate(shirts);

            return shirts;
        }


        static List<Tshirt> ColorDesc()
        {
            List<Tshirt> shirts = PrepareSignature();
            //instatiate the delegate
            BubbleDelegate sortingDelegate = BubbleSortHardCoded.ColorDesc;

            //call the delegate
            sortingDelegate(shirts);

            return shirts;
        }
        // ********************* Delegated methods on Fabric ************************************
        static List<Tshirt> FabricAsc()
        {
            List<Tshirt> shirts = PrepareSignature();
            //instatiate the delegate
            BubbleDelegate sortingDelegate = BubbleSortHardCoded.FabricAsc;

            //call the delegate
            sortingDelegate(shirts);

            return shirts;
        }
        static List<Tshirt> FabricDesc()
        {
            List<Tshirt> shirts = PrepareSignature();
            //instatiate the delegate
            BubbleDelegate sortingDelegate = BubbleSortHardCoded.FabricDesc;

            //call the delegate
            sortingDelegate(shirts);

            return shirts;
        }
        // ******************** Delegated methods on Size ******************************************
        static List<Tshirt> SizeAsc()
        {
            List<Tshirt> shirts = PrepareSignature();
            //instatiate the delegate
            BubbleDelegate sortingDelegate = BubbleSortHardCoded.SizeAsc;

            //call the delegate
            sortingDelegate(shirts);

            return shirts;
        }
        static List<Tshirt> SizeDesc()
        {
            List<Tshirt> shirts = PrepareSignature();
            //instatiate the delegate
            BubbleDelegate sortingDelegate = BubbleSortHardCoded.SizeDesc;

            //call the delegate
            sortingDelegate(shirts);

            return shirts;
        }

        //Choose sorting
        public static List<Tshirt> ChooseSorting(int choice)
        {
            switch (choice)
            {
                case 1: return ColorAsc();
                case 2: return ColorDesc();
                case 3: return FabricAsc();
                case 4: return FabricDesc();
                case 5: return SizeAsc();
                case 6: return SizeDesc();
                case 7: return SizeColorFablicAsc();
                case 8: return SizeColorFablicDesc();
                default: return ColorAsc();
            }
        }

    }
}

    