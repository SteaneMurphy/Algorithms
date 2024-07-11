#include "HelperUtility.h"
#include <cstdlib>

//for a given array, populate with random numbers
void HelperUtility::GenerateRandomSet(int arr[], int size)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand();
    }
}

//check is list is sorted ascending
bool HelperUtility::CheckOrderedListAsc(int arr[], int size)
{
    for (int i = 0; i < size - 1; i++) 
    {
        if (i > (i + 1)) 
        {
            return false;
        }
    }
    return true;
}

//check is list is sorted descending
bool HelperUtility::CheckOrderedListDec(int arr[], int size)
{
    for (int i = 0; i < size - 1; i++)
    {
        if (i < (i + 1))
        {
            return false;
        }
    }
    return true;
}
