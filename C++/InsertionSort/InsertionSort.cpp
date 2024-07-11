#include "InsertionSort.h"

//sort dataset in ascending order (without using key)
int InsertionSort::SortAscending(int arr[], int size)
{
	int counter = 0;

	for (int i = 1; i < size; i++) 
	{
		counter++;
		int j = i;

		while (j > 0 && arr[j] < arr[j - 1]) 
		{
			int temp = arr[j];
			arr[j] = arr[j - 1];
			arr[j - 1] = temp;
			j--;
		}
	}
	return counter;
}

//sort dataset in descending order (without using key)
int InsertionSort::SortDescending(int arr[], int size)
{
	int counter = 0;

	for (int i = 1; i < size; i++)
	{
		counter++;
		int j = i;

		while (j > 0 && arr[j] > arr[j - 1])
		{
			int temp = arr[j];
			arr[j] = arr[j - 1];
			arr[j - 1] = temp;
			j--;
		}
	}
	return counter;
}

//sort dataset in ascending order (using key)
int InsertionSort::SortAscendingKeyMethod(int arr[], int size)
{
	int counter = 0;

	for (int i = 1; i < size; i++)
	{
		counter++;
		int key = arr[i];
		int j = i - 1;
		while (j >= 0 && key < arr[j])
		{
			arr[j + 1] = arr[j];
			j--;
		}
		arr[j + 1] = key;
	}
	return counter;
}

//sort dataset in descending order (using key)
int InsertionSort::SortDescendingKeyMethod(int arr[], int size)
{
	int counter = 0;

	for (int i = 1; i < size; i++)
	{
		counter++;
		int key = arr[i];
		int j = i - 1;
		while (j >= 0 && key > arr[j])
		{
			arr[j + 1] = arr[j];
			j--;
		}
		arr[j + 1] = key;
	}
	return counter;
}
