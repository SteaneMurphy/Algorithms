namespace Algorithms
{
    public class BubbleSort
    {
        //sort given array in ascending order
        public (int[], int) SortAscending(int[] array) 
        {
            bool isSorted = false;
            int counter = 0;

            //iterate over list until sorted
            while (!isSorted) 
            {
                counter++;
                //check if each element is lower/higher than element to its right
                //swap if comparison met
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
                
                //check if list is ordered
                for (int i = 0; i < array.Length - 1; i++) 
                {
                    if (array[i] > array[i + 1])
                    {
                        isSorted = false;
                        break;
                    }
                    else 
                    {
                        isSorted = true;
                    }
                }
            }
            return (array, counter);
        }

        //sort given array in descending order
        public (int[], int) SortDescending(int[] array)
        {
            bool isSorted = false;
            int counter = 0;

            //iterate over list until sorted
            while (!isSorted)
            {
                counter++;
                //check if each element is lower/higher than element to its right
                //swap if comparison met
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        int temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }

                //check if list is ordered
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        isSorted = false;
                        break;
                    }
                    else
                    {
                        isSorted = true;
                    }
                }
            }
            return (array, counter);
        }

        public (int[], int) SortRecursion(int[] _array, int _counter) 
        {
            int counter = _counter;
            int[] array = _array;
            bool isSorted = false;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;
                }
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    isSorted = false;
                    break;
                }
                else
                {
                    isSorted = true;
                }
            }

            if (isSorted)
            {
                return (array, counter);
            }
            else 
            {
                return SortRecursion(array, counter + 1);
            }
        }
    }
}
