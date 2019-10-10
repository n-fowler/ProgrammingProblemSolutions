using System;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class NonDecreasingArrayProcessor
    {
        public bool CheckPossibility(int[] nums)
        {
            bool spike = false;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] - nums[i - 1] < 0)
                {
                    if (spike)
                    {
                        return false;
                    }
                    spike = true;

                    if (i + 1 < nums.Length)
                    {
                        if (nums[i + 1] >= nums[i - 1])
                        {
                            nums[i] = nums[i - 1];
                        }
                        else if (nums[i + 1] < nums[i])
                        {
                            return false;
                        }
                        else
                        {
                            nums[i - 1] = nums[i];
                            i = Math.Max(0, i - 2);
                        }
                    }
                }
            }

            return true;
        }
    }
}
