using System;
using Algorithms;
using System.Diagnostics;

/*******************************************************************************
 *                              INSERTION SORT                                 *
 *                               SOLUTION BY:                                  *
 *                                 STEANE                                      *
 *******************************************************************************/

// This alogirthm starts at index 1 of an array or dataset. This number is then checked with the number to its left
// (or right) depending on order of sort. For ascending ordered sort, if the comparison is lower than the leftmost number,
// the focused number is swapped. It is then checked again until can no longer be swapped to the left.

// This solution provides ascending and descending methods for Insertion Sort. One method uses a key (focused value) and iterates it,
// the other version simply moves a number down/up the array until it cannot anymore. The Key method is more efficient as it will
// move the number to its spot before moving onto the next number to sort.

namespace Main
{
    internal class Entry
    {
        static void Main(string[] args)
        {
            InsertionSort newSort = new InsertionSort();
            Stopwatch timer = new Stopwatch();
            Stopwatch timer2 = new Stopwatch();
            Stopwatch timer3 = new Stopwatch();
            Stopwatch timer4 = new Stopwatch();

            int[] unsortedArray = RandomSet();
            int[] unsortedCopy1 = new int[unsortedArray.Length];
            int[] unsortedCopy2 = new int[unsortedArray.Length];
            int[] unsortedCopy3 = new int[unsortedArray.Length];
            int[] unsortedCopy4 = new int[unsortedArray.Length];
            Array.Copy(unsortedArray, unsortedCopy1, unsortedArray.Length);
            Array.Copy(unsortedArray, unsortedCopy2, unsortedArray.Length);
            Array.Copy(unsortedArray, unsortedCopy3, unsortedArray.Length);
            Array.Copy(unsortedArray, unsortedCopy4, unsortedArray.Length);

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

            //test 3
            timer3.Start();
            (int[] sortedArray3, int counter3) = newSort.SortKeyMethodAscending(unsortedCopy3);
            timer3.Stop();

            for (int j = 0; j < sortedArray3.Length; j++)
            {
                Console.WriteLine(sortedArray3[j]);
            }
            bool test3 = CheckSortedAsc(sortedArray3);

            //test 4
            timer4.Start();
            (int[] sortedArray4, int counter4) = newSort.SortKeyMethodDescending(unsortedCopy4);
            timer4.Stop();

            for (int j = 0; j < sortedArray4.Length; j++)
            {
                Console.WriteLine(sortedArray4[j]);
            }
            bool test4 = CheckSortedDesc(sortedArray4);

            //output messaging and timings
            Console.WriteLine("\nINSERTION SORT (ASCENDING ORDER)");
            Console.WriteLine($"   -> Loop iterations: {counter}");
            Console.WriteLine($"   -> Time taken: {timer.Elapsed.ToString(@"m\:ss\.fff")}ms\n");
            Console.WriteLine($"   -> List order checked: {test}");

            Console.WriteLine("\nINSERTION SORT (DESCENDING ORDER)");
            Console.WriteLine($"   -> Loop iterations: {counter2}");
            Console.WriteLine($"   -> Time taken: {timer2.Elapsed.ToString(@"m\:ss\.fff")}ms\n");
            Console.WriteLine($"   -> List order checked: {test2}");

            Console.WriteLine("\nINSERTION SORT/KEY METHOD (ASCENDING ORDER)");
            Console.WriteLine($"   -> Loop iterations: {counter3}");
            Console.WriteLine($"   -> Time taken: {timer3.Elapsed.ToString(@"m\:ss\.fff")}ms\n");
            Console.WriteLine($"   -> List order checked: {test3}");

            Console.WriteLine("\nINSERTION SORT/KEY METHOD (DESCENDING ORDER)");
            Console.WriteLine($"   -> Loop iterations: {counter4}");
            Console.WriteLine($"   -> Time taken: {timer4.Elapsed.ToString(@"m\:ss\.fff")}ms\n");
            Console.WriteLine($"   -> List order checked: {test4}");
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
