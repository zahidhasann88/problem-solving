arr = [1, 5, 8, 4, 6, 1, 2]

Find the largest element of arr without using arr.Sort().

Output: The largest element is: 8.
===============================================================================

using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 5, 8, 4, 6, 1, 2 };
        int maxElement = arr[0];

        foreach (int num in arr)
        {
            if (num > maxElement)
            {
                maxElement = num;
            }
        }

        Console.WriteLine("The largest element is: " + maxElement);
    }
}
