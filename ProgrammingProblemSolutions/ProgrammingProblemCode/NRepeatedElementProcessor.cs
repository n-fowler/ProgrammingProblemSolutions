using System.Collections.Generic;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class NRepeatedElementProcessor
    {
        public int RepeatedNTimes(int[] A)
        {
            List<int> uniqueInts = new List<int>();

            foreach (int i in A)
            {
                if (uniqueInts.Contains(i))
                {
                    return i;
                }

                uniqueInts.Add(i);
            }
            return -1;
        }
    }
}
