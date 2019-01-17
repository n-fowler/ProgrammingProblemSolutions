using System.Collections;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class HammingDistanceProcessor
    {
        public int CalculateHammingDistance(int x, int y)
        {
            BitArray xBits = new BitArray(new[] { x });
            BitArray yBits = new BitArray(new[] { y });
            int hammingDistance = 0;

            for (int i = 0; i < xBits.Length; i++)
            {
                if (xBits[i] != yBits[i])
                {
                    hammingDistance++;
                }
            }

            return hammingDistance;
        }
    }
}
