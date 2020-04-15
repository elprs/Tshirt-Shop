using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            MySort.BubbleSort();
            Console.Read();
        }
    
    }

    class MySort
    {
        //Bubble sorting
        //Trekse gi ato pli8os - 2
        //an... ==> antimeta8esi
        //bale mia bool . ksekina tin os true === > break;
        public static void BubbleSort()
        {
            int[] arr = { 78, 55, 45, 98, 13 }; //pinakasa akeraivn antikeimenon
            //eg: int[] arr = { new Int32(), new Int32(),  new Int32(), new Int32(),  new Int32() };
            // new Int32().value = 78 ktl
            //O int32 einai O struct

            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (int p in arr)
                Console.Write(p + " ");
            Console.Read();
        }
    }
}
    

