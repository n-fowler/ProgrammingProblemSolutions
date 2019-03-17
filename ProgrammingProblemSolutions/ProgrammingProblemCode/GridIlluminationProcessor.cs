using System;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class GridIlluminationProcessor
    {
        public int[] GridIllumination(int N, int[][] lamps, int[][] queries)
        {
            int[] result = new int[queries.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                result[i] = IsIlluminated(lamps, queries[i]) ? 1 : 0;
            }

            return result;
        }

        private bool IsIlluminated(int[][] lightCoordinates, int[] queryCoordinates)
        {
            bool result = false;

            for (int index = 0; index < lightCoordinates.Length; index++)
            {
                int[] light = lightCoordinates[index];

                //Is the light turned on?
                if (light[0] == -1 || light[1] == -1)
                {
                    //It's turned off...
                    continue;
                }

                int dy = queryCoordinates[1] - light[1];
                int dx = queryCoordinates[0] - light[0];
                if (dx == 0 || dy == 0 || Math.Abs(dx) == Math.Abs(dy))
                {
                    result = true;

                    //Turn the light off if it's adjacent 8-directionally
                    if ((dx == 0 && Math.Abs(dy) <= 1) || (dy == 0 && Math.Abs(dx) <= 1) || (Math.Abs(dx) == Math.Abs(dy) && Math.Abs(dx) <= 1 && Math.Abs(dy) <= 1))
                    {
                        lightCoordinates[index] = new[] { -1, -1 };
                    }
                }
            }

            return result;
        }
    }
}
