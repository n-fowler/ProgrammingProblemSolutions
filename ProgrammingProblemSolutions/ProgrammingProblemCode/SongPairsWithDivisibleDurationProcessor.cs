namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class SongPairsWithDivisibleDurationProcessor
    {
        public int NumPairsDivisbleBy60(int[] time)
        {
            int result = 0;
            for (int i = 0; i < time.Length; i++)
            {
                for (int j = 0; j < time.Length; j++)
                {
                    if (i >= j)
                    {
                        continue;
                    }

                    if ((time[i] + time[j]) % 60 == 0)
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
