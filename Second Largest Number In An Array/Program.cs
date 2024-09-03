// using System;
// using System.Linq;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Input array
//         int[] numbers = { 70, 20, 50, 40, 30 };

//         int secondLargest = FindSecondLargest(numbers);

//         Console.WriteLine("The second largest number in the array is: " + secondLargest);
//     }

//     static int FindSecondLargest(int[] arr)
//     {
//         // Sort the array in descending order
//         Array.Sort(arr);
//         Array.Reverse(arr);

//         // Return the second element (index 1) of the sorted array
//         return arr[1];
//     }
// }


using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 3, 4, 5, 0, 2, 9, 8, 7, 6 };

        int firstHighest = int.MinValue;
        int secondHighest = int.MinValue;

        foreach (int number in numbers)
        {
            if (number > firstHighest)
            {
                secondHighest = firstHighest;
                firstHighest = number;
            }
            else if (number > secondHighest && number < firstHighest)
            {
                secondHighest = number;
            }
        }

        Console.WriteLine("The second highest number is: " + secondHighest);
    }
}
