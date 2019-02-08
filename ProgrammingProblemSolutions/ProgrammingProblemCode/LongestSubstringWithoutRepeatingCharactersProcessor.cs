using System.Collections.Generic;
using System.Linq;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class LongestSubstringWithoutRepeatingCharactersProcessor
    {
        public int LengthOfLongestSubstring(string s)
        {
            List<char> chars = new List<char>();
            foreach (char c in s)
            {
                chars.Add(c);
                if (chars.Distinct().Count() < chars.Count)
                {
                    chars.RemoveAt(0);
                }
            }

            return chars.Count;
        }
    }
}
