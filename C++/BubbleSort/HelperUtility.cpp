#include "HelperUtility.h"
#include <cstdlib>
using namespace std;

//for a given array, populate with random numbers
void HelperUtility::GenerateRandomSet(int arr[], int size)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand();
    }
}
