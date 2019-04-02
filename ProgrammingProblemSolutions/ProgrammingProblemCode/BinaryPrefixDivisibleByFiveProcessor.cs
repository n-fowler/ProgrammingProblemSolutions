using System.Collections.Generic;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class BinaryPrefixDivisibleByFiveProcessor
    {
        public IList<bool> PrefixesDivBy5(int[] A)
        {
            List<bool> results = new List<bool>();
            int remainder = 0;
            foreach (int a in A)
            {
                remainder = ((remainder << 1) + a) % 5;
                results.Add(remainder == 0);
            }

            return results;
        }
    }
}
