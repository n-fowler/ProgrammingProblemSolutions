using System;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class SquaresOfSortedArrayProcessor
    {
        public int[] SortedSquares(int[] A)
        {
            int[] B = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                B[i] = A[i] * A[i];
            }

            Array.Sort(B);

            return B;
        }
    }
}
