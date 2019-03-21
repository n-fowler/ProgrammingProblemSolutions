using System;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class ComplimentBaseTenProcessor
    {
        public int BitwiseComplement(int N)
        {
            if (N == 0)
            {
                return 1;
            }

            int mask = (1 << (int)Math.Ceiling((Math.Log(N + 1) / Math.Log(2)))) - 1;
            return ~N & mask;
        }
    }
}
