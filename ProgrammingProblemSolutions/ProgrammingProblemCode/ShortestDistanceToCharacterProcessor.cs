using System.Collections.Generic;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class ShortestDistanceToCharacterProcessor
    {
        public int[] ShortestToChar(string S, char C)
        {
            char[] schar = S.ToCharArray();
            int[] answer = new int[schar.Length];
            List<int> charIndexes = GetCharIndexes(S, C, schar);

            for (int i = 0; i < schar.Length; i++)
            {
                int minDistance = schar.Length;
                foreach (int charIndex in charIndexes)
                {
                    if (charIndex - i < minDistance && charIndex - i >= 0)
                    {
                        minDistance = charIndex - i;
                    }

                    if (-1 * (charIndex - i) < minDistance && -1 * (charIndex - i) >= 0)
                    {
                        minDistance = -1 * (charIndex - i);
                    }
                }

                answer[i] = minDistance;
            }

            return answer;
        }

        private List<int> GetCharIndexes(string S, char C, char[] schar)
        {
            int startIndex = 0;
            List<int> charIndexes = new List<int>();

            while (S.IndexOf(C, startIndex, schar.Length - startIndex) != -1)
            {
                startIndex = S.IndexOf(C, startIndex, schar.Length - startIndex);
                charIndexes.Add(startIndex);
                startIndex++;
            }

            return charIndexes;
        }
    }
}
