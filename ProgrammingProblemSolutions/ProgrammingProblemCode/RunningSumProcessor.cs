using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class RunningSumProcessor
    {
        public int[] RunningSum(int[] nums)
        {            
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }

            return nums;
        }
    }
}
