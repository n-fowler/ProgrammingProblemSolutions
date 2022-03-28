using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class SmallerNumbersThanCurrentProcessor
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int smallerCount = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    if(nums[i] > nums[j])
                    {
                        smallerCount++;
                    }
                }

                result[i] = smallerCount;
            }

            return result;
        }
    }
}
