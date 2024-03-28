using System;
using System.Collections.Generic;

public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> romanValues = new Dictionary<char, int>() {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        
        int result = 0;
        for (int i = 0; i < s.Length; i++) {
            if (i > 0 && romanValues[s[i]] > romanValues[s[i - 1]]) {
                result += romanValues[s[i]] - 2 * romanValues[s[i - 1]];
            } else {
                result += romanValues[s[i]];
            }
        }
        
        return result;
    }
}

public class Program {
    public static void Main(string[] args) {
        Solution solution = new Solution();
        string input = "CIV"; 
        int result = solution.RomanToInt(input);
        Console.WriteLine("Integer representation of " + input + " is: " + result);
    }
}
