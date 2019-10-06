using System;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class PlayWithChipsProcessor
    {
        public int MinCostToMoveChips(int[] chips)
        {
            int odd = 0, even = 0;

            foreach (int chip in chips)
            {
                if (chip % 2 == 1)
                {
                    odd++;
                }
                else
                {
                    even++;
                }
            }

            return Math.Min(odd, even);
        }
    }
}
