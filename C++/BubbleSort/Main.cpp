#include <iostream>
#include "BubbleSort.h"
#include "HelperUtility.h"
#include <cstdlib>
#include <chrono>
using namespace std;
using namespace std::chrono;

int main()
{
    //new instances of sorting class, utility class
    BubbleSort newSort;
    HelperUtility util;
    const int SIZE = 50000;         //array needs initial size

    //test ascending order BubbleSort
    //set array size and initialise with random numbers
    int* arr = new int[SIZE];
    util.GenerateRandomSet(arr, SIZE);

    //timer
    auto start = high_resolution_clock::now();
    int counter = newSort.SortAscending(arr, SIZE);         //run BubbleSort ascending
    auto stop = high_resolution_clock::now();
    auto duration = duration_cast<milliseconds>(stop - start);

    //print results of sorting algorithm
    for (int i = 0; i < SIZE; i++) 
    {
        cout << arr[i] << endl;
    }

    //remove from memory
    delete[] arr;

    //process same as for test 1
    //test descending order BubbleSort
    int* arr2 = new int[SIZE];
    util.GenerateRandomSet(arr2, SIZE);

    auto start2 = high_resolution_clock::now();
    int counter2 = newSort.SortDescending(arr2, SIZE);      //run BubbleSort descending
    auto stop2 = high_resolution_clock::now();
    auto duration2 = duration_cast<milliseconds>(stop2 - start2);

    for (int i = 0; i < SIZE; i++)
    {
        cout << arr2[i] << endl;
    }

    delete[] arr2;

    //test output messaging
    cout << "BUBBLESORT (ASCENDING ORDER)" << endl;
    cout << "    -> Iterations: " << counter << endl;
    cout << "    -> Time Taken: " << duration.count() << "ms" << endl;

    cout << endl;

    cout << "BUBBLESORT (DESCENDING ORDER)" << endl;
    cout << "    -> Iterations: " << counter2 << endl;
    cout << "    -> Time Taken: " << duration2.count() << "ms" << endl;
}
