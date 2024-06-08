using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Input array
        int[] numbers = { 70, 20, 50, 40, 30 };

        int secondLargest = FindSecondLargest(numbers);

        Console.WriteLine("The second largest number in the array is: " + secondLargest);
    }

    static int FindSecondLargest(int[] arr)
    {
        // Sort the array in descending order
        Array.Sort(arr);
        Array.Reverse(arr);

        // Return the second element (index 1) of the sorted array
        return arr[1];
    }
}
