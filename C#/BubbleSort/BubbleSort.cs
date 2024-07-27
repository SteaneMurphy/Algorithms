using System.Diagnostics;

namespace Algorithms
{
    public class BubbleSort
    {
        //sort given array in ascending order
        public int SortAscending(int[] array) 
        {
            bool isSorted = false;
            int counter = 0;

            //iterate over list until sorted
            while (!isSorted) 
            {
                counter++;
                isSorted = true;
                //check if each element is lower/higher than element to its right
                //swap if comparison met
                for (int i = 0; i < (array.Length - 1) - (counter - 1); i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                        isSorted = false;
                    }
                }
            }
            return counter;
        }

        //sort given array in descending order
        public int SortDescending(int[] array)
        {
            bool isSorted = false;
            int counter = 0;

            //iterate over list until sorted
            while (!isSorted)
            {
                counter++;
                isSorted = true;
                //check if each element is lower/higher than element to its right
                //swap if comparison met
                for (int i = 0; i < (array.Length - 1) - (counter - 1); i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        int temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                        isSorted = false;
                    }
                }
            }
            return counter;
        }
    }
}
