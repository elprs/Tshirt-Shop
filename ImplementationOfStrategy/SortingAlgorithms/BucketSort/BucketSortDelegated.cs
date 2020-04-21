using ImplementationOfStrategy.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using static ImplementationOfStrategy.SortingAlgorithms.Delegation;

namespace ImplementationOfStrategy.SortingAlgorithms.BucketSort
{
    class BucketSortDelegated
    {
        static Tshirt[] PrepareSignature()
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("****************** Bucket sort  ****************");
                Console.ForegroundColor = ConsoleColor.White;

                MyDatabase myDatabase = new MyDatabase();

                //prepare signature parameters
                var shirts = myDatabase.tshirts.ToList();

                return shirts.ToArray();
            }


        // ****************************** Delegated methods on Color ****************************
       public static List<Tshirt> ColorAsc()
        {
                Tshirt[] shirts = PrepareSignature();

                //instatiate the delegate
                BucketDelegate sortingDelegate = BucketSortHardCoded.ColorAsc;

                //call the delegate
               return sortingDelegate(shirts);
        }


        static List<Tshirt> ColorDesc()
        {
            Tshirt[] shirts = PrepareSignature();
            //instatiate the delegate
            BucketDelegate sortingDelegate = BucketSortHardCoded.ColorDesc;

            //call the delegate
            sortingDelegate(shirts);

            return sortingDelegate(shirts);
        }  
        
        // ****************************** Delegated methods on Fabric ****************************
       public static List<Tshirt> FabricAsc()
        {
                Tshirt[] shirts = PrepareSignature();

                //instatiate the delegate
                BucketDelegate sortingDelegate = BucketSortHardCoded.FabricAsc;

                //call the delegate
               return sortingDelegate(shirts);
        }


        static List<Tshirt> FabricDesc()
        {
            Tshirt[] shirts = PrepareSignature();
            //instatiate the delegate
            BucketDelegate sortingDelegate = BucketSortHardCoded.FabricDesc;

            //call the delegate
            sortingDelegate(shirts);

            return sortingDelegate(shirts);
        } 
        
        // ****************************** Delegated methods on Size ****************************
       public static List<Tshirt> SizeAsc()
        {
                Tshirt[] shirts = PrepareSignature();

                //instatiate the delegate
                BucketDelegate sortingDelegate = BucketSortHardCoded.SizeAsc;

                //call the delegate
               return sortingDelegate(shirts);
        }


        static List<Tshirt> SizeDesc()
        {
            Tshirt[] shirts = PrepareSignature();
            //instatiate the delegate
            BucketDelegate sortingDelegate = BucketSortHardCoded.SizeDesc;

            //call the delegate
            sortingDelegate(shirts);

            return sortingDelegate(shirts);
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
                default: return ColorAsc();
                }
            }

        }
    }


