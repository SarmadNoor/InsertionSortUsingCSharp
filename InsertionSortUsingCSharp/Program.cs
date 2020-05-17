using System;
using System.Buffers;

namespace InsertionSortUsingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = { 41, 31, 59, 26, 48, 37 };
            Console.WriteLine("Unsorted array");
            foreach (int unSortedElement in unsortedArray)
            {
                Console.WriteLine(unSortedElement);
            }
            Console.WriteLine("Insertion Sort begins !");
            int[] sortedArray = InsertionSortAlgorithm(unsortedArray);
            Console.WriteLine("Insertion sort ends !");
            Console.WriteLine("Sorted Array");
            foreach (int sortedElement in sortedArray)
            {
                Console.WriteLine(sortedElement);
            }
            Console.ReadKey();
        }
        private static int[] InsertionSortAlgorithm(int[] unsortedArray)
        {
            for(int j=1; j < unsortedArray.Length; j++)
            {
                int key = unsortedArray[j];
                int i = j-1;
                while( i >= 0 && unsortedArray[i] > key)
                {
                    unsortedArray[i + 1] = unsortedArray[i];
                    i--;
                }
                unsortedArray[i+1] = key;
            }
            return unsortedArray;
        }

    }
}
