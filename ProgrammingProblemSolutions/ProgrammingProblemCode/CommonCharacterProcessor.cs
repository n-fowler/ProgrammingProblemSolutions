using System.Collections.Generic;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class CommonCharacterProcessor
    {
        public IList<string> CommonChars(string[] A)
        {
            Dictionary<char, int[]> map = new Dictionary<char, int[]>();

            for (int i = 0; i < A.Length; i++)
            {
                foreach (char j in A[i])
                {
                    if (!map.ContainsKey(j))
                    {
                        map.Add(j, new int[A.Length]);
                    }
                    map[j][i]++;
                }
            }

            List<string> result = new List<string>();

            foreach (var kvp in map)
            {
                int[] arr = kvp.Value;
                int count = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < count)
                    {
                        count = arr[i];
                    }
                }

                if (count < 1)
                {
                    continue;
                }

                for (int j = 0; j < count; j++)
                {
                    result.Add(kvp.Key.ToString());
                }
            }
            return result;
        }
    }
}
