using System;
using System.Linq;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] numbers = { 5, 3, 9, 1, 7 };

//         int smallest = numbers.Min();

//         Console.WriteLine("The smallest element in the array is: " + smallest);
//     }
// }


// using System;


// By USing Loop
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 3, 9, 1, 7, 0 };

        int smallest = numbers[0]; // Assume the first element is the smallest

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < smallest)
            {
                smallest = numbers[i];
            }
        }

        Console.WriteLine("The smallest element in the array is: " + smallest);
    }
}
