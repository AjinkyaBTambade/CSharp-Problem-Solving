using System;
using System.Text;

public class Solution {
    public string solution(string S) {
        int[] digitCount = new int[10];
        foreach (char c in S) {
            digitCount[c - '0']++;
        }

        StringBuilder leftPart = new StringBuilder();
        char middleDigit = '\0';
        
        // Build the left part of the palindrome
        for (int i = 9; i >= 0; i--) {
            int pairs = digitCount[i] / 2;
            if (pairs > 0) {
                leftPart.Append(new string((char)('0' + i), pairs));
            }

            // Select the middle digit (highest odd frequency digit)
            if (digitCount[i] % 2 == 1 && middleDigit == '\0') {
                middleDigit = (char)('0' + i);
            }
        }

        // Handle the special case where all digits are zeros
        if (leftPart.Length == 0 && middleDigit == '0') {
            return "0";
        }

        // Form the right part by reversing the left part
        StringBuilder rightPart = new StringBuilder(leftPart.ToString());
        for (int i = leftPart.Length - 1; i >= 0; i--) {
            rightPart.Append(leftPart[i]);
        }

        // Construct and return the final palindrome
        return leftPart.ToString() + 
               (middleDigit != '\0' ? middleDigit.ToString() : "") + 
               rightPart.ToString();
    }
}

class Program {
    static void Main(string[] args) {
        Solution sol = new Solution();
        
        // Test cases
        Console.WriteLine(sol.solution("39878")); // Should print "898"
        Console.WriteLine(sol.solution("00900")); // Should print "9"
        Console.WriteLine(sol.solution("0000"));  // Should print "0"
        Console.WriteLine(sol.solution("54321")); // Should print "5"
    }
}
