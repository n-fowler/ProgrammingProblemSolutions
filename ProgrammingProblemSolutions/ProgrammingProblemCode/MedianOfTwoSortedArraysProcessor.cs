using System;
using System.Collections.Generic;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class MedianOfTwoSortedArraysProcessor
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double answer;

            int[] nums = new int[nums1.Length + nums2.Length];
            Array.Copy(nums1, 0, nums, 0, nums1.Length);
            Array.Copy(nums2, 0, nums, nums1.Length, nums2.Length);
            Array.Sort(nums, Comparer<int>.Default);

            if (nums.Length % 2 == 0) //even
            {
                answer = (nums[(nums.Length / 2) - 1] + nums[(nums.Length / 2)]) / 2.0;
            }
            else //odd
            {
                answer = nums[Convert.ToInt32(Math.Round((nums.Length - 1) / 2.0))];
            }

            return answer;
        }
    }
}
