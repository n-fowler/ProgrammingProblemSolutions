using System.Collections.Generic;
using System.Linq;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class FirstUniqueCharacterProcessor
    {
        public int FirstUniqChar(string s)
        {
            char[] sChars = s.ToCharArray();
            Dictionary<char, int> resultDictionary = new Dictionary<char, int>();

            for (int i = 0; i < sChars.Length; i++)
            {
                char c = sChars[i];
                if (resultDictionary.ContainsKey(c))
                {
                    resultDictionary[c] += 1;
                }
                else
                {
                    resultDictionary.Add(c, 1);
                }
            }

            KeyValuePair<char, int> result = resultDictionary.FirstOrDefault(dict => dict.Value == 1);
            if (!result.Equals(default(KeyValuePair<char, int>)))
            {
                return s.IndexOf(result.Key);
            }

            return -1;
        }
    }
}
