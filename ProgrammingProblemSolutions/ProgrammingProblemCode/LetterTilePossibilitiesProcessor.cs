namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class LetterTilePossibilitiesProcessor
    {
        private static int MAX_CHAR = 26;

        public int NumTilePossibilities(string tiles)
        {
            int[] count = new int[MAX_CHAR];

            foreach (char tile in tiles)
            {
                count[tile - 'A']++;
            }

            return Backtrack(count);
        }

        private int Backtrack(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < MAX_CHAR; i++)
            {
                if (arr[i] == 0)
                {
                    continue;
                }

                sum++;
                arr[i]--;
                sum += Backtrack(arr);
                arr[i]++;
            }
            return sum;
        }
    }
}
