using System;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    class UglyNumberProcessor
    {
        public int NthUglyNumber(int n, int a, int b, int c)
        {
            int low = 1, high = Int32.MaxValue, mid;

            while (low < high)
            {
                mid = low + (high - low) / 2;

                if (Count((a), b, c, mid) < n)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }

            return high;
        }

        private long GreatestCommonDivisor(long a, long b)
        {
            return a == 0 ? b : GreatestCommonDivisor(b % a, a);
        }

        private long LowestCommonDenominator(long a, long b)
        {
            return (a * b) / GreatestCommonDivisor(a, b);
        }

        private int Count(long a, long b, long c, long number)
        {
            return (int)((number / a) + (number / b) + (number / c)
                          - (number / LowestCommonDenominator(a, b))
                          - (number / LowestCommonDenominator(b, c))
                          - (number / LowestCommonDenominator(a, c))
                          + (number / LowestCommonDenominator(a, LowestCommonDenominator(b, c))));
        }
    }
}
