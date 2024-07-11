#include "BubbleSort.h"
#include <vector>
using namespace std;

//sorts given array using BubbleSort algorithm in ascending order
int BubbleSort::SortAscending(int arr[], int size)
{
	bool isSorted = false;
	int counter = 0;

	//repeat algorithm until array is sorted
	while (!isSorted) 
	{
		counter++;
		isSorted = true;
		//for each elements in array, compare element to its next element and adjust
		//position in array based on comparison (low/high)
		for (int i = 0; i < (size - 1) - (counter - 1); i++)
		{
			if (arr[i] > arr[i + 1]) 
			{
				swap(arr[i], arr[i + 1]);
				isSorted = false;
			}
		}
	}
	return counter;
}

//sorts given array using BubbleSort algorithm in descending order
int BubbleSort::SortDescending(int arr[], int size)
{
	bool isSorted = false;
	int counter = 0;

	//repeat algorithm until array is sorted
	while (!isSorted)
	{
		counter++;
		isSorted = true;
		//for each elements in array, compare element to its next element and adjust
		//position in array based on comparison (low/high)
		for (int i = 0; i < (size - 1) - (counter - 1); i++)
		{
			if (arr[i] < arr[i + 1])
			{
				swap(arr[i], arr[i + 1]);
				isSorted = false;
			}
		}
	}
	return counter;
}
