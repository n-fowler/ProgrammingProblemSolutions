using System;

namespace ProgrammingProblemSolutions.InterviewProblems
{
    public class MissingNumberProblem
    {
        public int MissingNumber(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length + 1; i++)
            {
                if (i == nums.Length)
                {
                    return nums.Length;
                }

                if (nums[i] != i)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
