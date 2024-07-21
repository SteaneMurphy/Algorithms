using System;
using Algorithms;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;

/*******************************************************************************
 *                                MERGE SORT                                   *
 *                               SOLUTION BY:                                  *
 *                                 STEANE                                      *
 *******************************************************************************/



namespace Main
{
    internal class Entry
    {
        static void Main(string[] args)
        {
            MergeSort newSort = new MergeSort();
            Stopwatch timer = new Stopwatch();

            //create randomised 50k list of integers
            //have to make seperate copies of the original array as it is referenced
            int[] unsortedArray = RandomSet();
            int[] unsortedCopy1 = new int[unsortedArray.Length];
            //int[] unsortedCopy2 = new int[unsortedArray.Length];
            Array.Copy(unsortedArray, unsortedCopy1, unsortedArray.Length);
            //Array.Copy(unsortedArray, unsortedCopy2, unsortedArray.Length);

            ////test 1
            timer.Start();
            int[] sortedArray = newSort.SortTopDown(unsortedCopy1);
            timer.Stop();

            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.WriteLine(sortedArray[i]);
            }
            //bool test = CheckSortedAsc(sortedArray);

            //output messaging and timings
            Console.WriteLine("\n MERGE SORT (RECURSIVE TOP DOWN)");
            //Console.WriteLine($"   -> Loop iterations: {counter}");
            Console.WriteLine($"   -> Time taken: {timer.Elapsed.ToString(@"m\:ss\.fff")}ms\n");
            //Console.WriteLine($"   -> List order checked: {test}");
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
    }
}
