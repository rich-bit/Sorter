using System;
using System.Collections.Generic;
using System.Linq;

public class MergeSort
{
    public void Sort(int[] a)
    {
        int[] b = Mergesort(a.ToList()).ToArray();
        Array.Copy(b, a, b.Length);
    }
    List<int> Mergesort(List<int> unSorted)
    {
        if (unSorted.Count <= 1) { return unSorted; }
        List<int> left = new List<int>();
        List<int> right = new List<int>();

        for (int i = 0; i < unSorted.Count / 2; i++)
        {
            left.Add(unSorted[i]);
        }
        for (int i = unSorted.Count / 2; i < unSorted.Count; i++)
        {
            right.Add(unSorted[i]);
        }

        left = Mergesort(left);
        right = Mergesort(right);
        return Merge(left, right);
    }
    List<int> Merge(List<int> listOne, List<int> listTwo)
    {
        List<int> sorted = new List<int>();
        int indexOne = 0;
        int indexTwo = 0;
        while (indexOne < listOne.Count && indexTwo < listTwo.Count)
        {
            if (listOne[indexOne] < listTwo[indexTwo])
            {
                sorted.Add(listOne[indexOne]);
                indexOne++;
            }
            else
            {
                sorted.Add(listTwo[indexTwo]);
                indexTwo++;
            }
        }
        if (indexOne == listOne.Count)
        {
            while (indexTwo < listTwo.Count)
            {
                sorted.Add(listTwo[indexTwo]);
                indexTwo++;
            }
        }
        else
        {
            while (indexOne < listOne.Count)
            {
                sorted.Add(listOne[indexOne]);
                indexOne++;
            }
        }
        return sorted;
    }
}
