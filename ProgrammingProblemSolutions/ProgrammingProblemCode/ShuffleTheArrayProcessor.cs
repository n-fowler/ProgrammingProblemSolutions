using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class ShuffleTheArrayProcessor
    {
        public int[] Shuffle(int[] nums, int n)
        {
            int[] result = new int[nums.Length];

            for (int i = 0, j = 0; i < nums.Length/2; i++)
            {
                result[j++] = nums[i];
                result[j++] = nums[n];
                n++;
            }

            return result;
        }
    }
}
