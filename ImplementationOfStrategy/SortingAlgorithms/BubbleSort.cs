using ImplementationOfStrategy.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationOfStrategy.SortingAlgorithms
{
    class BubbleSort
    {
        //CHALLENGE
        //TODO stin bubble sort uparxei hard coded gnosi
        //Na fiaxtei mia pio general katastasi, 8a pernei ena delegate kai 8a anaplironei ti hard coded logic. *a ginei genikeysi autou   for (int i = 0; i <= tshirts.Count - 2; i++)


        public static void SizeColorFablic(List<Tshirt> tshirts)
        {
            BubbleSort.SizeAsc(tshirts);// kai oi alles 3 
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
     
        


      //Size ascending
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
      //Color ascending
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
      //Fabric ascending
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
