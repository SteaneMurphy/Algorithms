using Algorithms;
using System.Threading;

/*******************************************************************************
 *                                QUICK SORT                                   *
 *                               SOLUTION BY:                                  *
 *                                 STEANE                                      *
 *******************************************************************************/

// This is a recursive sorting algorithm that uses a specific index from a dataset as a pivot. All value are arranged
// behind or in front of this pivot based on whether or not they are larger or smaller.
// Once the pivot has reached its final place in the array, the numbers behind and in front of the pivot are sorted recursively
// in sub-arrays. This recurision occurs until there are no sub-arrays left to sort throught (individual numbers).

// Due to the amount of stack space this recursive algorithm uses, I had to create a new CPU thread and expand the stack. This brings the stack size
// upto about 20MB and could cause a crash if you don't have large enough memory. The size of the dataset can be set in the variable 'dataSize'
// inside the Testing class.

// This solution comes with an extensive automated test suite. All forms and edge-cases of the QuickSort algorithm are tested, with their times,
// iterations and list checking provided.

// The following types of QuickSort pivots are used: MedianOfThree, End, Start and Random pivots. Each pivot type is used to sort a dataset in both
// ascending and descending orders.

// The following datasets are generated for testing use: random, sorted ascending, sorted descending, nearly sorted and duplicate numbers.

// To use the QuickSort algorithm class outside of the test suite, create a new instance of 'QuickSort' and call the 'Sort' method. You can delegate 
// which pivot method to use as well as in which order to sort the dataset. For example:

// QuickSort newSort = new QuickSort();
// newSort.Sort(dataSet, pivotType, desiredOrder);

// All datasets must be integer arrays at this point.

namespace Main
{
    internal class Entry
    {
        static void Main(string[] args)
        {
            //must increase stack size to be able to run recursion on 50k numbers
            int stackSize = 1024*1024*64;
            Thread th = new Thread(() =>
            {
                //create new sort and testing instances
                QuickSort newSort = new QuickSort();
                Testing testing = new Testing();
                testing.GenerateTests();
            },
            stackSize);

            th.Start();
            th.Join();
        }
    }
}
