using System;
using System.Numerics;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class SortArrayByParityProcessor
    {
        public int[] SortArrayByParity(int[] A)
        {
            int[] B = new int[A.Length];

            A.CopyTo(B, 0);
            Array.Sort(B, (a, b) => BigInteger.Compare(a % 2, b % 2));

            return B;
        }
    }
}
