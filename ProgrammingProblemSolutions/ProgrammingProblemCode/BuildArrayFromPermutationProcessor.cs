﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class BuildArrayFromPermutationProcessor
    {
        public int[] BuildArray(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[nums[i]];
            }

            return result;
        }
    }
}
