using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = " HI MOM I AM WITH MY MADAM IN SCHOOL AND DAD IS HERE";
        string output = RemovePalindromes(input);
        Console.WriteLine(output);
    }

    static string RemovePalindromes(string input)
    {
        // Split the input into words
        var words = input.Split(' ');

        // Filter out palindrome words
        var nonPalindromeWords = words.Where(word => !IsPalindrome(word));

        // Join the remaining words into a single string
        return string.Join(" ", nonPalindromeWords);
    }

    static bool IsPalindrome(string word)
    {
        // Convert the word to lowercase for case-insensitive comparison
        word = word.ToLower();
        int length = word.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (word[i] != word[length - i - 1])
            {
                return false;
            }
        }

        return true;hbh
    }
}