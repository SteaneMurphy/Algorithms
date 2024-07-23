using Algorithms;

/*******************************************************************************
 *                                MERGE SORT                                   *
 *                               SOLUTION BY:                                  *
 *                                 STEANE                                      *
 *******************************************************************************/

// This is a recursive sorting algorithm. The algorithm splits the array into sub-arrays, this process is repeated recursively until the dataset
// reaches an element size of 1, or cannot be split any further.

// For each level of the recursion, a merge function is implemented to sort the two split arrays. This begins at the bottom level of sub-arrays and
// moves upwards until the original array has been sorted.

// This version of MergeSort contains tests for 50,000 numbers and does not break the stack limit. This is because each array is more or less divided
// in half. This prevents large recursion depth, as seen in recusrive QuickSort.

// The following datasets are generated for testing use: random, sorted ascending, sorted descending, nearly sorted and duplicate numbers.

// To use the NergeSort algorithm class outside of the test suite, create a new instance of 'MergeSort' and call the 'Sort' method. You can delegate 
// which order to sort the dataset. For example:

// MergeSort newSort = new MergeSort();
// newSort.Sort(dataSet, desiredOrder);

// All datasets must be integer arrays at this point.

namespace Main
{
    internal class Entry
    {
        static void Main(string[] args)
        {
            //create new sort and testing instances
            MergeSort newSort = new MergeSort();
            Testing testing = new Testing();
            testing.GenerateTests();
        }   
    }
}
