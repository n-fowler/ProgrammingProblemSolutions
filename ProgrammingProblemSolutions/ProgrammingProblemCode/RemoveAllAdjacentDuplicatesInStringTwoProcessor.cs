using System.Linq;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class RemoveAllAdjacentDuplicatesInStringTwoProcessor
    {
        public string RemoveDuplicates(string s, int k)
        {
            if (s.Length <= k)
            {
                return s;
            }

            for (int i = 0; i <= s.ToCharArray().Length - k; i++)
            {
                if (s.Substring(i, k).Distinct().Count() == 1)
                {
                    s = s.Remove(i, k);
                    return RemoveDuplicates(s, k);
                }
            }

            return s;
        }
    }
}
