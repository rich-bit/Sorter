using System;
using System.Dynamic;

public class QuickSort
{
    static Random random = new Random();
    public void Sort(int[] a)
    {
        Quicksort(a, 0, a.Length - 1);
    }
    void Quicksort(int[] array, int lo, int hi)
    {
        int i = lo;
        int j = hi;
        if (i >= j || ((i == j - 1) && array[i] < array[j])) { return; }
        int pivot = array[random.Next(lo, hi)];

        while (i <= j)
        {
            while (array[i] < pivot && i <= j) { i++; }
            while (array[j] > pivot && j >= i) { j--; }
            SwapPlaces(array, i, j);
            if (array[i] == array[j]) { i++; }
        }
        Quicksort(array, lo, j - 1);
        Quicksort(array, j, hi);
    }
    static int[] SwapPlaces(int[] array, int indexOne, int indexTwo)//Byter plats på två element i en array...
    {
        int temp = array[indexOne];
        array[indexOne] = array[indexTwo];
        array[indexTwo] = temp;
        return array;
    }
}
