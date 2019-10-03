using System;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class EqualSubstringsWithinBudgetProcessor
    {
        public int EqualSubstring(string s, string t, int maxCost)
        {
            int length = s.Length;

            int left = 0;
            int index = 0;

            int sum = 0;
            int max = 0;

            while (index < length)
            {
                int diff = Math.Abs(s[index] - t[index]);

                int current = sum + diff;
                if (current <= maxCost)
                {
                    int newlength = index - left + 1;
                    if (newlength > max)
                    {
                        max = newlength;
                    }

                    sum = current;
                    index++;
                }

                while (current > maxCost && left < length)
                {
                    int leftValue = Math.Abs(s[left] - t[left]);
                    sum -= leftValue;
                    left++;
                    current -= leftValue;
                }
            }

            return max;
        }
    }
}
