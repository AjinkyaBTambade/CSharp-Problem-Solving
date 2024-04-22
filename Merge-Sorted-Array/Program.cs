﻿// using System;

// public class Solution{
//     public void Merge(int[] nums1,int m, int[] nums2, int n){
//         int i = m - 1;
//         int j = n - 1;
//         int k = m + n - 1;

//         while (i >= 0 && j >= 0){
//             if (nums1[i] > nums2[j]){
//                 nums1[k--] = nums1[i--];
//             }
//             else{
//                 nums1[k--] = nums2[j--];
//             }
//         }
//         while (j >= 0){
//             nums1[k--] = nums2[j--];

//         }
//     }
// }

//     public class Program{
//         static void Main (string[] args){
//             int[] nums1 = {1,2,3,0,0,0};
//             int[] nums2 = {4,5,6};
//             int m=3;
//             int n=3;

//             Solution solution=new Solution();
//             solution.Merge(nums1, m, nums2, n);

//         Console.WriteLine("Merged Array:");
//         foreach (int num in nums1) {
//             Console.Write(num + " ");
//         }
//         Console.WriteLine();
//     }
// }
        
using System;

namespace MergeSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = {1, 2, 3, 0, 0, 0};
            int m = 3;
            int[] nums2 = {2, 5, 6};
            int n = 3;

            int[] mergedArray = Merge(nums1, m, nums2, n);

            Console.WriteLine("Merged Array:");
            foreach (int num in mergedArray)
            {
                Console.Write(num + " ");
            }
        }

        static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] result = new int[m + n];
            int i = 0, j = 0, k = 0;

            while (i < m && j < n)
            {
                if (nums1[i] <= nums2[j])
                {
                    result[k++] = nums1[i++];
                }
                else
                {
                    result[k++] = nums2[j++];
                }
            }

            while (i < m)
            {
                result[k++] = nums1[i++];
            }

            while (j < n)
            {
                result[k++] = nums2[j++];
            }

            return result;
        }
    }
}
