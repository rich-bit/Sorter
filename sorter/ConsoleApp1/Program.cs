using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomNumbers = GetRandomNumbers(15);

            Console.Write("[{0}]", string.Join(", ", randomNumbers));//Display random numbers
            new QuickSort().Sort(randomNumbers);//sort those numbers with quicksort
            Console.WriteLine("\n\n--QuickSort--");
            Console.Write("[{0}]", string.Join(", ", randomNumbers));//Print result
            
            Console.Write("\n____________________________________________________\n\n");

            randomNumbers = GetRandomNumbers(15);

            Console.Write("[{0}]", string.Join(", ", randomNumbers));
            new MergeSort().Sort(randomNumbers);
            Console.WriteLine("\n\n--Mergesort--");
            Console.Write("[{0}]", string.Join(", ", randomNumbers));//Same with mergesort

            Console.Write("\n____________________________________________________\n\n");

            Console.ReadLine();
        }
        static int[] GetRandomNumbers(int amount)
        {
            Random random = new Random();

            int[] intArray = new int[amount];

            for(int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = random.Next(1,15);
            }

            return intArray;
        }
    }
}
