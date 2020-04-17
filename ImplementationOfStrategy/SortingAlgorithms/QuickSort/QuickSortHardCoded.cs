using ImplementationOfStrategy.Products;

namespace ImplementationOfStrategy.SortingAlgorithms
{
    class QuickSortHardCoded
    {
        //  ===================   Create methods for the delegate to use. ======================= //

        //=================================  Sort by Color =======================================//

        // Partitioning
        static int partitionColorAsc(Tshirt[] tshirts, int low, int high)
        {
            Tshirt shirt = tshirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (tshirts[j].Color < shirt.Color)
                {
                    i++;

                    // swap tshirts[i] and tshirts[j] 
                    Tshirt temp = tshirts[i];
                    tshirts[i] = tshirts[j];
                    tshirts[j] = temp;
                }
            }

            // swap tshirts[i+1] and tshirts[high] (or pivot) 
            Tshirt temp1 = tshirts[i + 1];
            tshirts[i + 1] = tshirts[high];
            tshirts[high] = temp1;

            return i + 1;
        }


        // The main function that implements QuickSortHardCoded() 
        public static void ColorAsc(Tshirt[] tshirts, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, tshirts[pi] is  
                now at right place */
                int pi = partitionColorAsc(tshirts, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                ColorAsc(tshirts, low, pi - 1);
                ColorAsc(tshirts, pi + 1, high);
            }
        }
        
        // Partitioning
        static int partitionColorDesc(Tshirt[] tshirts, int low, int high)
        {
            Tshirt shirt = tshirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (tshirts[j].Color > shirt.Color)
                {
                    i++;

                    // swap tshirts[i] and tshirts[j] 
                    Tshirt temp = tshirts[i];
                    tshirts[i] = tshirts[j];
                    tshirts[j] = temp;
                }
            }

            // swap tshirts[i+1] and tshirts[high] (or pivot) 
            Tshirt temp1 = tshirts[i + 1];
            tshirts[i + 1] = tshirts[high];
            tshirts[high] = temp1;

            return i + 1;
        }


        /* The main function that implements QuickSortHardCoded() */
        public static void ColorDesc(Tshirt[] tshirts, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, tshirts[pi] is  
                now at right place */
                int pi = partitionColorDesc(tshirts, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                ColorDesc(tshirts, low, pi - 1);
                ColorDesc(tshirts, pi + 1, high);
            }
        }

        //================================= Sort by Fabric ======================================//
        // Partitioning
        static int partitionFabricAsc(Tshirt[] tshirts, int low, int high)
        {
            Tshirt shirt = tshirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (tshirts[j].Fabric < shirt.Fabric)
                {
                    i++;

                    // swap tshirts[i] and tshirts[j] 
                    Tshirt temp = tshirts[i];
                    tshirts[i] = tshirts[j];
                    tshirts[j] = temp;
                }
            }

            // swap tshirts[i+1] and tshirts[high] (or pivot) 
            Tshirt temp1 = tshirts[i + 1];
            tshirts[i + 1] = tshirts[high];
            tshirts[high] = temp1;

            return i + 1;
        }


        /* The main function that implements QuickSortHardCoded()  */
        public static void FabricAsc(Tshirt[] tshirts, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, tshirts[pi] is  
                now at right place */
                int pi = partitionFabricAsc(tshirts, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                FabricAsc(tshirts, low, pi - 1);
                FabricAsc(tshirts, pi + 1, high);
            }
        }
        
        // Partitioning
        static int partitionFabricDesc(Tshirt[] tshirts, int low, int high)
        {
            Tshirt shirt = tshirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (tshirts[j].Fabric > shirt.Fabric)
                {
                    i++;

                    // swap tshirts[i] and tshirts[j] 
                    Tshirt temp = tshirts[i];
                    tshirts[i] = tshirts[j];
                    tshirts[j] = temp;
                }
            }

            // swap tshirts[i+1] and tshirts[high] (or pivot) 
            Tshirt temp1 = tshirts[i + 1];
            tshirts[i + 1] = tshirts[high];
            tshirts[high] = temp1;

            return i + 1;
        }


        /* The main function that implements QuickSortHardCoded()  */
        public static void FabricDesc(Tshirt[] tshirts, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, tshirts[pi] is  
                now at right place */
                int pi = partitionFabricDesc(tshirts, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                FabricDesc(tshirts, low, pi - 1);
                FabricDesc(tshirts, pi + 1, high);
            }
        }

        //================================= Sort by Size ==========================================//
        static int partitionSizeAsc(Tshirt[] tshirts, int low, int high)
        {
            Tshirt shirt = tshirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (tshirts[j].Size < shirt.Size)
                {
                    i++;

                    // swap tshirts[i] and tshirts[j] 
                    Tshirt temp = tshirts[i];
                    tshirts[i] = tshirts[j];
                    tshirts[j] = temp;
                }
            }

            // swap tshirts[i+1] and tshirts[high] (or pivot) 
            Tshirt temp1 = tshirts[i + 1];
            tshirts[i + 1] = tshirts[high];
            tshirts[high] = temp1;

            return i + 1;
        }

        /* The main function that implements QuickSortHardCoded()  */
        public static void SizeAsc(Tshirt[] tshirts, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, tshirts[pi] is  
                now at right place */
                int pi = partitionSizeAsc(tshirts, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                SizeAsc(tshirts, low, pi - 1);
                SizeAsc(tshirts, pi + 1, high);
            }
        }
        
        // Partitioning
        static int partitionSizeDesc(Tshirt[] tshirts, int low, int high)
        {
            Tshirt shirt = tshirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (tshirts[j].Size > shirt.Size)
                {
                    i++;

                    // swap tshirts[i] and tshirts[j] 
                    Tshirt temp = tshirts[i];
                    tshirts[i] = tshirts[j];
                    tshirts[j] = temp;
                }
            }

            // swap tshirts[i+1] and tshirts[high] (or pivot) 
            Tshirt temp1 = tshirts[i + 1];
            tshirts[i + 1] = tshirts[high];
            tshirts[high] = temp1;

            return i + 1;
        }


        /* The main function that implements QuickSortHardCoded() */
        public static void SizeDesc(Tshirt[] tshirts, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, tshirts[pi] is  
                now at right place */
                int pi = partitionSizeDesc(tshirts, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                SizeDesc(tshirts, low, pi - 1);
                SizeDesc(tshirts, pi + 1, high);
            }
        }
    }
}
