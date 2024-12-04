// Using Built in Logic

using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "Hello, world!";
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        string reversedStr = new string(charArray);
        Console.WriteLine(reversedStr); // Output: "!dlrow ,olleH"
    }
}

//Using Custom Method

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         string str = "Ajinkya!";
//         string reversedStr = ReverseString(str);
//         Console.WriteLine(reversedStr);
//     }

//     static string ReverseString(string str)
//     {
//         char[] charArray = str.ToCharArray();
//         int left = 0;
//         int right = charArray.Length - 1;

//         while (left < right)
//         {
//             char temp = charArray[left];
//             charArray[left] = charArray[right];
//             charArray[right] = temp;

//             left++;
//             right--;
//         }

//         return new string(charArray);
//     }
// }
