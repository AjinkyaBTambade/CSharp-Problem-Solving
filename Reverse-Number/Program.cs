
// Console.WriteLine("Enter your number :");

// int number =int.Parse(Console.ReadLine());
// int reminder,reverse=0;
// while(number!=0){

//     reminder= number % 10;
//     reverse= reverse * 10 + reminder;
//     number = number/10;
    
// }


// Console.WriteLine($"Reverse number : {reverse}");


using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Original array:");
        PrintArray(numbers);

        Array.Reverse(numbers);

        Console.WriteLine("Reversed array:");
        PrintArray(numbers);
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
