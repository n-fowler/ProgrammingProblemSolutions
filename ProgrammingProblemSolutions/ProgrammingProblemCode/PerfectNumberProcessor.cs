using System.Collections.Generic;
using System.Linq;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class PerfectNumberProcessor
    {
        public bool CheckPerfectNumber(int num)
        {
            List<int> divisors = new List<int>();

            if (num <= 0)
            {
                return false;
            }

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    divisors.Add(i);
                }
            }

            int sum = divisors.Sum();

            return sum == num;
        }
    }
}
