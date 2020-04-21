using ImplementationOfStrategy.Enums;
using ImplementationOfStrategy.Products;
using System;
using System.Collections.Generic;

namespace ImplementationOfStrategy.SortingAlgorithms.BucketSort
{
    public  class BucketSortHardCoded
    {
        // ============================= Color sort ======================================

        public static List<Tshirt> ColorAsc( params Tshirt[] x)
        {
            List<Tshirt> sortedList = new List<Tshirt>();

            int numOfBuckets = Enum.GetValues(typeof(Color)).Length;

            //Create buckets
            List<Tshirt>[] buckets = new List<Tshirt>[numOfBuckets];
            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<Tshirt>();
            }

            //Iterate through the passed array and add each integer to the appropriate bucket
            for (int i = 0; i < x.Length; i++)
            {
                int bucket = ((int)x[i].Color);
                buckets[bucket].Add(x[i]);
            }

            //Sort each bucket and add it to the result List
            for (int i = 0; i < numOfBuckets; i++)
            {
                List<Tshirt> temp =buckets[i];
                sortedList.AddRange(temp);
            }

            return sortedList;
        }
        public static List<Tshirt> ColorDesc( params Tshirt[] x)
        {
            List<Tshirt> sortedList = new List<Tshirt>();

            int numOfBuckets = Enum.GetValues(typeof(Color)).Length;

            //Create buckets
            List<Tshirt>[] buckets = new List<Tshirt>[numOfBuckets];
            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<Tshirt>();
            }

            //Iterate through the passed array and add each integer to the appropriate bucket
            for (int i = 0; i < x.Length; i++)
            {
                int bucket = ((int)x[i].Color);
                buckets[numOfBuckets - 1 - bucket].Add(x[i]);
            }

            //Sort each bucket and add it to the result List
            for (int i = 0; i < numOfBuckets; i++)
            {
                List<Tshirt> temp =buckets[i];
                sortedList.AddRange(temp);
            }
            return sortedList;
        }

        // ============================= size sort ======================================
        public static List<Tshirt> SizeAsc( params Tshirt[] x)
        {
            List<Tshirt> sortedList = new List<Tshirt>();

            int numOfBuckets = Enum.GetValues(typeof(Size)).Length;

            //Create buckets
            List<Tshirt>[] buckets = new List<Tshirt>[numOfBuckets];
            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<Tshirt>();
            }

            //Iterate through the passed array and add each integer to the appropriate bucket
            for (int i = 0; i < x.Length; i++)
            {
                int bucket = ((int)x[i].Size);
                buckets[bucket].Add(x[i]);
            }

            //Sort each bucket and add it to the result List
            for (int i = 0; i < numOfBuckets; i++)
            {
                List<Tshirt> temp =buckets[i];
                sortedList.AddRange(temp);
            }
            return sortedList;
        }
        public static List<Tshirt> SizeDesc( params Tshirt[] x)
        {
            List<Tshirt> sortedList = new List<Tshirt>();

            int numOfBuckets = Enum.GetValues(typeof(Size)).Length;

            //Create buckets
            List<Tshirt>[] buckets = new List<Tshirt>[numOfBuckets];
            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<Tshirt>();
            }

            //Iterate through the passed array and add each integer to the appropriate bucket
            for (int i = 0; i < x.Length; i++)
            {
                int bucket = ((int)x[i].Size);
                buckets[numOfBuckets - 1 - bucket].Add(x[i]);
            }

            //Sort each bucket and add it to the result List
            for (int i = 0; i < numOfBuckets; i++)
            {
                List<Tshirt> temp =buckets[i];
                sortedList.AddRange(temp);
            }
            return sortedList;
        }
        // ========================== Fabric sort ==============================================
        public static List<Tshirt> FabricAsc( params Tshirt[] x)
        {
            List<Tshirt> sortedList = new List<Tshirt>();

            int numOfBuckets = Enum.GetValues(typeof(Fabric)).Length;

            //Create buckets
            List<Tshirt>[] buckets = new List<Tshirt>[numOfBuckets];
            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<Tshirt>();
            }

            //Iterate through the passed array and add each integer to the appropriate bucket
            for (int i = 0; i < x.Length; i++)
            {
                int bucket = ((int)x[i].Fabric);
                buckets[bucket].Add(x[i]);
            }

            //Sort each bucket and add it to the result List
            for (int i = 0; i < numOfBuckets; i++)
            {
                List<Tshirt> temp =buckets[i];
                sortedList.AddRange(temp);
            }
            return sortedList;
        }
        public static List<Tshirt> FabricDesc( params Tshirt[] x)
        {
            List<Tshirt> sortedList = new List<Tshirt>();

            int numOfBuckets = Enum.GetValues(typeof(Fabric)).Length;

            //Create buckets
            List<Tshirt>[] buckets = new List<Tshirt>[numOfBuckets];
            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<Tshirt>();
            }

            //Iterate through the passed array and add each integer to the appropriate bucket
            for (int i = 0; i < x.Length; i++)
            {
                int bucket = ((int)x[i].Fabric);
                buckets[numOfBuckets - 1 - bucket].Add(x[i]);
            }

            //Sort each bucket and add it to the result List
            for (int i = 0; i < numOfBuckets; i++)
            {
                List<Tshirt> temp =buckets[i];
                sortedList.AddRange(temp);
            }
            return sortedList;
        }
    }
}
