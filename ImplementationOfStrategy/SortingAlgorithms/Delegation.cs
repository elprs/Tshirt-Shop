using ImplementationOfStrategy.Products;
using System.Collections.Generic;

namespace ImplementationOfStrategy.SortingAlgorithms
{
    class Delegation
    {
        //Create a delegate for the bubble sort choices

        public delegate void BubbleDelegate(List<Tshirt> tshirts);

        //Create a delegate for the quick sort choices

        public delegate void QuickSortDelegate(Tshirt[] tshirts, int low, int high);
    }
    //Source: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates
}
