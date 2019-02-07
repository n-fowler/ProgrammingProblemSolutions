using System;
using System.Collections.Generic;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class SelfDividingNumbersProcessor
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            List<int> results = new List<int>();

            for (int i = left; i <= right; i++)
            {
                if (IsSelfDividing(i))
                {
                    results.Add(i);
                }
            }

            return results;
        }

        private bool IsSelfDividing(int number)
        {
            foreach (char c in number.ToString())
            {
                if (c == '0')
                {
                    return false;
                }

                if (number % (Convert.ToInt32(c) - 48) != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
