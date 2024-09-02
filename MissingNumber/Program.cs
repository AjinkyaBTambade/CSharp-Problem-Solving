using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[99]; // Array with one number missing
        int missingNumber = 0;

        int index = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i !=99 )
            {
                numbers[index] = i;
                index++;
            }
        }

        // Calculate the expected sum of numbers from 1 to 100
        int expectedSum = 100 * (100 + 1) / 2; // Formula for the sum of first n natural numbers

        // Calculate the actual sum of numbers in the array
        int actualSum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            actualSum += numbers[i];
        }

        // The missing number is the difference between the expected sum and the actual sum
        missingNumber = expectedSum - actualSum;

        Console.WriteLine("The missing number is: " + missingNumber);
    }
}
