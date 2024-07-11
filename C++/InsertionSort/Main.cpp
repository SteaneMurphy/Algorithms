#include <iostream>
#include "HelperUtility.h"
#include "InsertionSort.h"
#include <chrono>
using namespace std;
using namespace std::chrono;

int main()
{
    //new instances of sorting class, utility class
    InsertionSort newSort;
    HelperUtility util;
    const int SIZE = 50000;         //array needs initial size

    //test ascending order InsertionSort
    //set array size and initialise with random numbers
    int* arr = new int[SIZE];
    util.GenerateRandomSet(arr, SIZE);

    //timer
    auto start = high_resolution_clock::now();
    int counter = newSort.SortAscending(arr, SIZE);         //run InsertionSort ascending
    auto stop = high_resolution_clock::now();
    auto duration = duration_cast<milliseconds>(stop - start);

    //print results of sorting algorithm
    for (int i = 0; i < SIZE; i++)
    {
        cout << arr[i] << endl;
    }

    bool test1 = util.CheckOrderedListAsc(arr, SIZE);

    //remove from memory
    delete[] arr;

    //process same as for test 1
    //test descending order InsertionSort
    int* arr2 = new int[SIZE];
    util.GenerateRandomSet(arr2, SIZE);

    auto start2 = high_resolution_clock::now();
    int counter2 = newSort.SortDescending(arr2, SIZE);      //run InsertionSort descending
    auto stop2 = high_resolution_clock::now();
    auto duration2 = duration_cast<milliseconds>(stop2 - start2);

    for (int i = 0; i < SIZE; i++)
    {
        cout << arr2[i] << endl;
    }

    bool test2 = util.CheckOrderedListAsc(arr2, SIZE);

    delete[] arr2;

    //process same as for test 3
    //test descending order InsertionSort
    int* arr3 = new int[SIZE];
    util.GenerateRandomSet(arr3, SIZE);

    auto start3 = high_resolution_clock::now();
    int counter3 = newSort.SortAscendingKeyMethod(arr3, SIZE);      //run InsertionSort (key method) descending
    auto stop3 = high_resolution_clock::now();
    auto duration3 = duration_cast<milliseconds>(stop3 - start3);

    for (int i = 0; i < SIZE; i++)
    {
        cout << arr3[i] << endl;
    }

    bool test3 = util.CheckOrderedListAsc(arr3, SIZE);

    delete[] arr3;

    //process same as for test 4
    //test descending order InsertionSort
    int* arr4 = new int[SIZE];
    util.GenerateRandomSet(arr4, SIZE);

    auto start4 = high_resolution_clock::now();
    int counter4 = newSort.SortDescendingKeyMethod(arr4, SIZE);      //run InsertionSort (key method) descending
    auto stop4 = high_resolution_clock::now();
    auto duration4 = duration_cast<milliseconds>(stop4 - start4);

    for (int i = 0; i < SIZE; i++)
    {
        cout << arr4[i] << endl;
    }

    bool test4 = util.CheckOrderedListAsc(arr4, SIZE);

    delete[] arr4;

    //test output messaging
    cout << "INSERTION SORT (ASCENDING ORDER)" << endl;
    cout << "    -> Iterations: " << counter << endl;
    cout << "    -> Time Taken: " << duration.count() << "ms" << endl;
    cout << "    -> List Check: " << std::boolalpha << test1 << endl;

    cout << endl;

    cout << "INSERTION SORT (DESCENDING ORDER)" << endl;
    cout << "    -> Iterations: " << counter2 << endl;
    cout << "    -> Time Taken: " << duration2.count() << "ms" << endl;
    cout << "    -> List Check: " << std::boolalpha << test2 << endl;

    cout << endl;

    cout << "INSERTION SORT KEY METHOD (ASCENDING ORDER)" << endl;
    cout << "    -> Iterations: " << counter3 << endl;
    cout << "    -> Time Taken: " << duration3.count() << "ms" << endl;
    cout << "    -> List Check: " << std::boolalpha << test3 << endl;

    cout << endl;

    cout << "INSERTION SORT KEY METHOD (DESCENDING ORDER)" << endl;
    cout << "    -> Iterations: " << counter4 << endl;
    cout << "    -> Time Taken: " << duration4.count() << "ms" << endl;
    cout << "    -> List Check: " << std::boolalpha << test4 << endl;
}
