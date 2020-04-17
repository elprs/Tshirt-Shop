using ImplementationOfStrategy.Products;
using System.Collections.Generic;
using static ImplementationOfStrategy.SortingAlgorithms.Delegation;

namespace ImplementationOfStrategy.SortingAlgorithms
{
    class BubbleSort
    {

        //  ===================   Create methods for the delegate to use. =======================

        // Size-Color-Fablic Ascending
        public static void SizeColorFablicAsc(List<Tshirt> tshirts)
        {
            //instantiate the delegate
            BubbleDelegate sortingDelegate = BubbleSort.FabricAsc;
            // Call the delegate.
            sortingDelegate(tshirts);

            //Repeat for the other 2 variations
            sortingDelegate = BubbleSort.ColorAsc;
            sortingDelegate(tshirts);
            sortingDelegate = BubbleSort.SizeAsc;
            sortingDelegate(tshirts);
        }
        
        // Size-Color-Fablic Descending
        public static void SizeColorFablicDesc(List<Tshirt> tshirts)
        {
            //instantiate the delegate
            Delegation.BubbleDelegate sortingDelegate = BubbleSort.FabricDesc;
            // Call the delegate.
            sortingDelegate(tshirts);

            //Repeat for the other 2 variations
            sortingDelegate = BubbleSort.ColorDesc;
            sortingDelegate(tshirts);
            sortingDelegate = BubbleSort.SizeDesc;
            sortingDelegate(tshirts);
        }


        //Size ascending
        public static void SizeAsc(List<Tshirt> tshirts)
        {
            Tshirt temp;
            for (int j = 0; j <= tshirts.Count - 2; j++)
            {
                for (int i = 0; i <= tshirts.Count - 2; i++)
                {
                    if (tshirts[i].Size > tshirts[i + 1].Size)
                    {
                        temp = tshirts[i + 1];
                        tshirts[i + 1] = tshirts[i];
                        tshirts[i] = temp;
                    }
                }
            }
        }
      //Color ascending
       public static void ColorAsc(List<Tshirt> tshirts)
        {
            Tshirt temp;
            for (int j = 0; j <= tshirts.Count - 2; j++)
            {
                for (int i = 0; i <= tshirts.Count - 2; i++)
                {
                    if (tshirts[i].Color > tshirts[i + 1].Color)
                    {
                        temp = tshirts[i + 1];
                        tshirts[i + 1] = tshirts[i];
                        tshirts[i] = temp;
                    }
                }
            }
        }
      //Fabric ascending
       public static void FabricAsc(List<Tshirt> tshirts)
        {
            Tshirt temp;
            for (int j = 0; j <= tshirts.Count - 2; j++)
            {
                for (int i = 0; i <= tshirts.Count - 2; i++)
                {
                    if (tshirts[i].Fabric > tshirts[i + 1].Fabric)
                    {
                        temp = tshirts[i + 1];
                        tshirts[i + 1] = tshirts[i];
                        tshirts[i] = temp;
                    }
                }
            }
        }
     
        


      //Size descending
       public static void SizeDesc(List<Tshirt> tshirts)
        {
            Tshirt temp;
            for (int j = 0; j <= tshirts.Count - 2; j++)
            {
                for (int i = 0; i <= tshirts.Count - 2; i++)
                {
                    if (tshirts[i].Size < tshirts[i + 1].Size)
                    {
                        temp = tshirts[i + 1];
                        tshirts[i + 1] = tshirts[i];
                        tshirts[i] = temp;
                    }
                }
            }
        }
      //Color descending
       public static void ColorDesc(List<Tshirt> tshirts)
        {
            Tshirt temp;
            for (int j = 0; j <= tshirts.Count - 2; j++)
            {
                for (int i = 0; i <= tshirts.Count - 2; i++)
                {
                    if (tshirts[i].Color < tshirts[i + 1].Color)
                    {
                        temp = tshirts[i + 1];
                        tshirts[i + 1] = tshirts[i];
                        tshirts[i] = temp;
                    }
                }
            }
        }
      //Fabric descending
       public static void FabricDesc(List<Tshirt> tshirts)
        {
            Tshirt temp;
            for (int j = 0; j <= tshirts.Count - 2; j++)
            {
                for (int i = 0; i <= tshirts.Count - 2; i++)
                {
                    if (tshirts[i].Fabric < tshirts[i + 1].Fabric)
                    {
                        temp = tshirts[i + 1];
                        tshirts[i + 1] = tshirts[i];
                        tshirts[i] = temp;
                    }
                }
            }
        }
     




    }
}
