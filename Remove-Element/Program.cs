using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int indexToRemove = 2; // Index of the element to remove
        array[indexToRemove] = 0; // Set the value to 0 or some sentinel value

        Console.WriteLine("Array after removing element at index " + indexToRemove + ":");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
       
    }
}





// using System;

// public class Solution {
//     public int RemoveElement(int[] nums, int val) {
//         int k = 0;
//         for (int i = 0; i < nums.Length; i++) {
//             if (nums[i] != val) {
//                 nums[k] = nums[i];
//                 k++;
//             }
//         }
//         return k;
//     }

//     static void Main(string[] args) {
//         Solution solution = new Solution();
        
//         int[] nums = { 0,1,2,2,3,0,4,2};
//         int val = 2;
        
//         int result = solution.RemoveElement(nums, val);
        
//         Console.WriteLine("Number of elements after removing " + val + ": " + result);
//         Console.Write("Modified array: ");
//         for (int i = 0; i < result; i++) {
//             Console.Write(nums[i] + " ");
//         }
//         Console.WriteLine();
//     }
// }
