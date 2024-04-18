using System;

class Program
{
    static void Main()
    {
    
        Console.WriteLine("Enter the first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = int.Parse(Console.ReadLine());
        
        int sum = AddNumbers(num1, num2);
        Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
        Console.ReadLine();
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
