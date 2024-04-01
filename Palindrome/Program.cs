using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your input:");
        string input = Console.ReadLine();
        
        bool isPalindrome = IsPalindrome(input);

        if (isPalindrome)
        {
            Console.WriteLine("Given string is a palindrome.");
        }
        else
        {
            Console.WriteLine("Given string is not a palindrome.");
        }
    }

    static bool IsPalindrome(string str)
    {
        int left = 0;
        int right = str.Length - 1;
        
        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
