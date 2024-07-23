using System.Diagnostics;
using System;

namespace Algorithms
{
    public class Testing
    {
        //change dataSize for smaller/larger datasets
        public int dataSize = 50000;
        //nearly sorted list
        public int nearlySortedSwaps = 6;
        //duplicates
        public int minRange = 4000;
        public int maxRange = 10000;

        public void GenerateTests()
        {
            Stopwatch timer = new Stopwatch();
            MergeSort newSort = new MergeSort();

            #region Tests
            //for each type of dataset
            for (int i = 0; i < 5; i++)
            {
                MessageTestType(i);
                int[] unsortedArray = new int[dataSize];

                switch (i)
                {
                    case 0:
                        unsortedArray = RandomSet();
                        break;
                    case 1:
                        unsortedArray = SortedAscending();
                        break;
                    case 2:
                        unsortedArray = SortedDescending();
                        break;
                    case 3:
                        unsortedArray = NearlySorted();
                        break;
                    case 4:
                        unsortedArray = Duplicates();
                        break;
                    default:
                        break;
                }

                //for each type of MergeSort (sort order)
                for (int j = 0; j < 2; j++)
                {
                    MessageAlgorithmType(j);
                    bool test = false;
                    int counter = 0;
                    int[] arrayCopy = new int[unsortedArray.Length];
                    Array.Copy(unsortedArray, arrayCopy, unsortedArray.Length);
                    timer.Reset();
                    timer.Start();

                    switch (j)
                    {
                        //MergeSort, Ascending
                        case 0:
                            newSort.Sort(arrayCopy, 0, arrayCopy.Length - 1, newSort.AscendingComparison);
                            test = CheckSortedAsc(arrayCopy);
                            break;

                        //MergeSort, Descending
                        case 1:
                            newSort.Sort(arrayCopy, 0, arrayCopy.Length - 1, newSort.DescendingComparison);
                            test = CheckSortedDesc(arrayCopy);
                            break;

                        default:
                            throw new Exception("Error: called test does not exist");
                    }
                    //return time taken per test case
                    timer.Stop();
                    Console.WriteLine($"   -> Loop iterations: {counter}");
                    Console.WriteLine($"   -> Time taken: {timer.Elapsed.ToString(@"m\:ss\.fff")}ms");
                    Console.WriteLine($"   -> List order checked: {test}\n");
                }
            }
            #endregion
        }

        #region Output Messaging
        //message indicator so it is known what test is being run
        private void MessageAlgorithmType(int i)
        {
            string[] testMessages = new string[2];
            testMessages[0] = "MergeSort, Ascending starting...";
            testMessages[1] = "MergeSort, Descending starting...";

            Console.WriteLine(testMessages[i]);
        }

        //message indicator so it is known what dataset is being used
        private void MessageTestType(int i)
        {
            string[] testMessages = new string[5];
            testMessages[0] = "\n\n\n--- RANDOM SET TESTING ---\n";
            testMessages[1] = "\n\n\n--- SORTED ASC SET TESTING ---\n";
            testMessages[2] = "\n\n\n--- SORTED DESC SET TESTING ---\n";
            testMessages[3] = "\n\n\n--- NEARLY SORTED SET TESTING ---\n";
            testMessages[4] = "\n\n\n--- DUPLICATES SET TESTING ---\n";

            Console.WriteLine(testMessages[i]);
        }
        #endregion

        #region Generate Test Data
        //create random set of numbers to test
        private int[] RandomSet()
        {
            Random rnd = new Random();
            int[] array = new int[dataSize];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next();
            }

            return array;
        }

        //generate a sorted set of numbers (ascending)
        private int[] SortedAscending()
        {
            int[] array = new int[dataSize];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            return array;
        }

        //generate a sorted set of numbers (descending)
        private int[] SortedDescending()
        {
            int[] array = new int[dataSize];

            for (int i = 0; i < dataSize; i++)
            {
                array[i] = dataSize - 1 - i;
            }

            return array;
        }

        //generate a set of numbers that is *nearly* sorted
        private int[] NearlySorted()
        {

            Random rnd = new Random();
            int[] array = new int[dataSize];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            for (int i = 0; i < nearlySortedSwaps; i++)
            {
                int index1 = rnd.Next(0, dataSize);
                int index2 = rnd.Next(0, dataSize);
                int temp = array[index1];
                array[index1] = array[index2];
                array[index2] = temp;
            }

            return array;
        }

        //generate a set of numbers that has a high amount of duplication
        private int[] Duplicates()
        {
            Random rnd = new Random();
            int[] array = new int[dataSize];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(minRange, maxRange);
            }

            return array;
        }
        #endregion

        #region List Checks
        //checks list is ordered ascending
        private bool CheckSortedAsc(int[] array)
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
        private bool CheckSortedDesc(int[] array)
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
        #endregion
    }
}
