using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class ConcatenationOfArrayProcessor
    {
        public int[] GetConcatenation(int[] nums)
        {
            int[] result = new int[nums.Length * 2];
            
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[i];
                result[i + nums.Length] = nums[i];
            }

            return result;
        }
    }
}
