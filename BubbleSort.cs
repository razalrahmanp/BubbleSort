
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of elements in the array:");
        int length = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[length];

        Console.WriteLine("Enter the elements of the array:");

        for (int i = 0; i < length; i++)
        {
            Console.Write($"Element {i + 1}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        BubbleSort(array);

        Console.WriteLine("Sorted array:");
        foreach (int element in array)
        {
            Console.Write($"{element} ");
        }
    }

    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Swap array[j] and array[j + 1]
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swapped = true;
                }
            }

            // If no two elements were swapped in the inner loop, the array is already sorted
            if (!swapped)
                break;
        }
    }
}