using System.Reflection;
using System.Security.Permissions;

namespace Algorithms
{
    public class InsertionSort
    {
        //insertion sort without using a key for comparison (ascending order)
        public (int[], int) SortAscending(int[] array)
        {
            int counter = 0;

            for (int i = 1; i < array.Length; i++)
            {
                counter++;
                int j = i;

                //whilst the focused number is less than number to its right
                //swap numbers and continue until not true
                while (j > 0 && array[j] < array[j - 1]) 
                {
                    int temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                    j--;
                }
            }
            return (array, counter);
        }

        //insertion sort without using a key for comparison (descending order)
        public (int[], int) SortDescending(int[] array)
        {
            int counter = 0;

            for (int i = 1; i < array.Length; i++)
            {
                counter++;
                int j = i;

                //whilst the focused number is less than number to its left
                //swap numbers and continue until not true
                while (j > 0 && array[j] > array[j - 1])
                {
                    int temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                    j--;
                }
            }
            return (array, counter);
        }

        //insertion sort using a key for comparison (ascending order)
        public (int[], int) SortKeyMethodAscending(int[] array)
        {
            int counter = 0;
            for (int i = 1; i < array.Length; i++)
            {
                counter++;
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && key < array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
            return (array, counter);
        }

        //insertion sort using a key for comparison (descending order)
        public (int[], int) SortKeyMethodDescending(int[] array)
        {
            int counter = 0;
            for (int i = 1; i < array.Length; i++)
            {
                counter++;
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && key > array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
            return (array, counter);
        }
    }
}
