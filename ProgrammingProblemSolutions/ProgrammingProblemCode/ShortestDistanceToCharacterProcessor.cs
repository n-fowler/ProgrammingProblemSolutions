using System;
using System.Collections.Generic;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class ShortestDistanceToCharacterProcessor
    {
        public int[] ShortestToCharOld(string S, char C)
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

        public int[] ShortestToChar(string S, char C)
        {
            int[] answer = new int[S.Length];
            for (int i = 0; i < answer.Length; i++)
            {
                int left = S.Substring(0, i).LastIndexOf(C);
                int right = S.Substring(i).IndexOf(C);

                if (left >= 0 && right >= 0)
                {
                    answer[i] = Math.Min(i - left, right);
                }
                else if (left >= 0)
                {
                    answer[i] = i - left;
                }
                else
                {
                    answer[i] = right;
                }
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
