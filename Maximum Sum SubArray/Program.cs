using System;

class Program
{
    static int MaxSubArraySum(int[] nums)
    {
        int maxSoFar = nums[0];
        int maxEndingHere = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            maxEndingHere = Math.Max(nums[i], maxEndingHere + nums[i]);
            maxSoFar = Math.Max(maxSoFar, maxEndingHere);
        }

        return maxSoFar;
    }

    static void Main(string[] args)
    {
        int[] nums1 = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        Console.WriteLine("Maximum sum subarray for [-2, 1, -3, 4, -1, 2, 1, -5, 4]: " + MaxSubArraySum(nums1));

        int[] nums2 = { 1 };
        Console.WriteLine("Maximum sum subarray for [1]: " + MaxSubArraySum(nums2));

        int[] nums3 = { 5, 4, -1, 7, 8 };
        Console.WriteLine("Maximum sum subarray for [5, 4, -1, 7, 8]: " + MaxSubArraySum(nums3));
    }
}
