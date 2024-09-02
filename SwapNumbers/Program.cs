// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int a = 5;
//         int b = 10;

//         // Swap without temp variable
//         a = a + b; // a now becomes 15
//         b = a - b; // b now becomes 5
//         a = a - b; // a now becomes 10

//         Console.WriteLine("After swap: a = " + a + ", b = " + b);
//     }
// }

using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;

        // Swap using a temp variable
        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine("After swap: a = " + a + ", b = " + b);
    }
}
