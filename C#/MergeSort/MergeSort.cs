using System;

namespace Algorithms 
{
    public class MergeSort
    {
        public int[] SortTopDown(int[] array) 
        {
            if (array.Length <= 1)
                return array;

            int midPoint = array.Length / 2;

            int[] left = new int[midPoint];
            int[] right = new int[array.Length - midPoint];

            for (int i = 0; i < midPoint; i++)
                left[i] = array[i];

            for (int i = midPoint; i < array.Length; i++)
                right[i - midPoint] = array[i];

            SortTopDown(left);
            SortTopDown(right);

            MergeArray(array, left, right);

            return array;
        }

        private void MergeArray(int[] arr, int[] left, int[] right) 
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                    arr[k++] = left[i++];
                else
                    arr[k++] = right[j++];
            }

            while (i < left.Length)
                arr[k++] = left[i++];

            while (j < right.Length)
                arr[k++] = right[j++];
        }
    }
}


