using System;

namespace Algorithms 
{
    public class MergeSort
    {
        //main sorting algorithm, called recursively
        //splits main array into sub-arrays before merging
        //split point calculated by determining the mid-point of each array/sub-array
        public void Sort(int[] array, int startIndex, int endIndex, Func<int, int, bool> comparisonType)
        {
            if (startIndex >= endIndex)
            {
                return;
            }

            int midPoint = startIndex + (endIndex - startIndex) / 2;
            Sort(array, startIndex, midPoint, comparisonType);
            Sort(array, midPoint + 1, endIndex, comparisonType);
            MergeArray(array, startIndex, midPoint, endIndex, comparisonType);
        }

        //merges two sub-arrays at the same level on the same recursion leg
        //compares each value from the left array with each value from the right array and orders them correctly
        //array is sorted in-place, so nothing is returned
        private void MergeArray(int[] array, int startIndex, int midPoint, int endIndex, Func<int, int, bool> comparisonType)
        {
            int leftLength = midPoint - startIndex + 1;
            int rightLength = endIndex - midPoint;

            //temp arrays to assist with copying to main array (in-place) and avoid overwriting
            int[] left = new int[leftLength];
            int[] right = new int[rightLength];

            Array.Copy(array, startIndex, left, 0, leftLength);
            Array.Copy(array, midPoint + 1, right, 0, rightLength);

            //keep track of length of left/right arrays
            int l = 0, r = 0, i = startIndex;

            // Merge elements from left and right arrays
            while (l < leftLength && r < rightLength)
            {
                if (comparisonType(left[l], right[r]))
                {
                    array[i] = left[l];
                    l++;
                }
                else
                {
                    array[i] = right[r];
                    r++;
                }
                i++;
            }

            //Copy any remaining elements from left array
            while (l < leftLength)
            {
                array[i] = left[l];
                l++;
                i++;
            }

            //Copy any remaining elements from right array
            while (r < rightLength)
            {
                array[i] = right[r];
                r++;
                i++;
            }
        }

        //function to either compare higher or lower than selected pivot
        public bool AscendingComparison(int a, int b) => a <= b;
        public bool DescendingComparison(int a, int b) => a >= b;
    }
}


