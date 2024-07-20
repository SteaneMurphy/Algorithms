using System;

namespace Algorithms
{
    public class QuickSort
    {
        //main sorting method, user can delegate pivot type and sort order (ascending/descending)
        //Sort() is called recursively for all sets above and below the pivot for each recursion
        //iteration counter is accumlated through Sort() returns
        public (int[], int) Sort(int[] array, int startIndex, int endIndex, PivotType pivotType, Func<int, int, bool> comparisonType) 
        {
            int counter = 1;

            //if there are no more numbers to partition, return array
            if(endIndex <= startIndex) 
            {
                return (array, counter);
            }

            int pivot = PartitionArray(array, startIndex, endIndex, pivotType, comparisonType);
            (int[] arrayTemp1, int counter2) = Sort(array, startIndex, pivot - 1, pivotType, comparisonType);
            (int[] arrayTemp2, int counter3) = Sort(array, pivot + 1, endIndex, pivotType, comparisonType);

            counter += counter2 + counter3;

            return (array, counter);
        }

        public enum PivotType
        {
            MedianOfThree,
            End,
            Random,
            Start
        }

        //median of three, sort the beginning, end and midpoint
        //return middle value as pivot
        private int MedianOfThree(int[] array, int startIndex, int endIndex)
        {
            int start = startIndex;
            int mid = startIndex + (endIndex - startIndex) / 2;
            int end = endIndex;
            if (array[start] > array[mid])
            {
                int temp = array[start];
                array[start] = array[mid];
                array[mid] = temp;
            }
            if (array[start] > array[end])
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;
            }
            if (array[mid] > array[end])
            {
                int temp = array[mid];
                array[mid] = array[end];
                array[end] = temp;
            }

            return mid;
        }

        //sorts the array sent to it from the parent recursive function
        //returns the array once the pivot has reached its final spot in the index
        //pivot type and comparison type passed from parent function. handles multiple types of QuickSort
        private int PartitionArray(int[] array, int startIndex, int endIndex, PivotType pivotType, Func<int, int, bool> comparisonType) 
        {
            int pivotIndex;

            switch (pivotType) 
            {
                case PivotType.MedianOfThree:
                    pivotIndex = MedianOfThree(array, startIndex, endIndex);
                    break;
                case PivotType.End:
                    pivotIndex = endIndex;
                    break;
                case PivotType.Random:
                    pivotIndex = new Random().Next(startIndex, endIndex + 1);
                    break;
                case PivotType.Start:
                    pivotIndex = startIndex;
                    break;
                default:
                    throw new Exception("Pivot Type does not exist");
            }

            //set the pivot based on type of QuickSort
            int pivot = Swap(array, pivotIndex, endIndex);
            int i = startIndex - 1;

            //compare and swap values until pivot is in final position
            for (int j = startIndex; j <= endIndex; j++)
            {
                if (comparisonType(array[j], pivot))
                {
                    i++;
                    Swap(array, i, j);
                }
            }
            i++;
            Swap(array, i, endIndex);

            //return pivot
            return i;
        }

        //swaps two positions in an array using a third temporary variable
        private int Swap(int[] array, int pivotIndex, int endIndex) 
        {
            int temp = array[pivotIndex];
            array[pivotIndex] = array[endIndex];
            array[endIndex] = temp;
            return array[endIndex];
        }

        //function to either compare higher or lower than selected pivot
        public bool AscendingComparison(int a, int b) => a < b;
        public bool DescendingComparison(int a, int b) => a > b;
    }
}
