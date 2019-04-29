using System;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class MovingStonesUntilConsecutiveProcessor
    {
        public int[] NumMovesStones(int a, int b, int c)
        {
            int[] inputArray = { a, b, c };
            Array.Sort(inputArray);
            a = inputArray[0];
            b = inputArray[1];
            c = inputArray[2];
            int maxstep = Math.Abs(c - a) - 2;
            int minstep;

            if (Math.Abs(b - a) == 1 && Math.Abs(c - b) == 1)
            {
                minstep = 0;
            }
            else if (Math.Abs(b - a) < 3 || Math.Abs(c - b) < 3)
            {
                minstep = 1;
            }
            else
            {
                minstep = 2;
            }

            return new[] { minstep, maxstep };
        }
    }
}
