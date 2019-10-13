using System;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class ArrayPartitionProcessor
    {
        public int ArrayPairSum(int[] nums)
        {
            int sum = 0;

            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum += nums[i];
                }
            }

            return sum;
        }
    }
}
