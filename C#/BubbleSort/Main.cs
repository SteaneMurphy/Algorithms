using System;
using Algorithms;
using System.Diagnostics;

/*******************************************************************************
 *                               BUBBLE SORT                                   *
 *                               SOLUTION BY:                                  *
 *                                 STEANE                                      *
 *******************************************************************************/

// This sorting algorithm loops through each element in a data set. Each element is compared to the
// next element and switched based on whether it is ascending or descending output.
// I tried using recursion but that causes a stackoverflow error for this algorithm due to limited stack
// space. On average, each recursion call uses 1000KB of space, this test uses 50k iterations and approximately
// 50MB of stack space, which is over the 1MB limit set by Windows.

// A while loop is more efficient and quicker, it also does not have stackoverflow issues. Because of this
// the while loop structure was chosen to build the BubbleSort algorithm

// The tests below generate a random integer set of 50k numbers and sort both ascending and descending, outputting the
// sorted lists and their respective time taken.

namespace Main
{
    internal class Entry
    {
        static void Main(string[] args)
        {
            //create new sort instance and timers
            BubbleSort newSort = new BubbleSort();
            Stopwatch timer = new Stopwatch();
            Stopwatch timer2 = new Stopwatch();

            //create randomised 50k list of integers
            //have to make seperate copies of the original array as it is referenced
            int[] unsortedArray = RandomSet();
            int[] unsortedCopy1 = new int[unsortedArray.Length];
            int[] unsortedCopy2 = new int[unsortedArray.Length];
            Array.Copy(unsortedArray, unsortedCopy1, unsortedArray.Length);
            Array.Copy(unsortedArray, unsortedCopy2, unsortedArray.Length);


            ////test 1
            timer.Start();
            (int[] sortedArray, int counter) = newSort.SortAscending(unsortedCopy1);
            timer.Stop();

            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.WriteLine(sortedArray[i]);
            }
            bool test = CheckSortedAsc(sortedArray);

            //test 2
            timer2.Start();
            (int[] sortedArray2, int counter2) = newSort.SortDescending(unsortedCopy2);
            timer2.Stop();

            for (int j = 0; j < sortedArray2.Length; j++)
            {
                Console.WriteLine(sortedArray2[j]);
            }
            bool test2 = CheckSortedDesc(sortedArray2);

            //output messaging and timings
            Console.WriteLine("\nBUBBLE SORT (ASCENDING ORDER)");
            Console.WriteLine($"   -> Loop iterations: {counter}");
            Console.WriteLine($"   -> Time taken: {timer.Elapsed.ToString(@"m\:ss\.fff")}ms\n");
            Console.WriteLine($"   -> List order checked: {test}");

            Console.WriteLine("\nBUBBLE SORT (DESCENDING ORDER)");
            Console.WriteLine($"   -> Loop iterations: {counter2}");
            Console.WriteLine($"   -> Time taken: {timer2.Elapsed.ToString(@"m\:ss\.fff")}ms\n");
            Console.WriteLine($"   -> List order checked: {test2}");
        }

        //create random set of 50k numbers to test
        static int[] RandomSet()
        {
            Random rnd = new Random();
            int[] array = new int[50000];

            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = rnd.Next();
            }

            return array;
        }

        //checks list is ordered ascending
        static bool CheckSortedAsc(int[] array) 
        {
            for (int i = 0; i < array.Length - 1; i++) 
            {
                if (array[i] > array[i + 1]) 
                {
                    return false;
                }
            }
            return true;
        }

        //checks list is ordered descending
        static bool CheckSortedDesc(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
