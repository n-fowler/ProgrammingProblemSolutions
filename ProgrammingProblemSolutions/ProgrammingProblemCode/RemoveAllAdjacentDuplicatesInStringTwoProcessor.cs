namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class RemoveAllAdjacentDuplicatesInStringTwoProcessor
    {
        public string RemoveDuplicates(string s, int k)
        {
            int count = 1;
            for (int i = 0; i < s.Length - 1; i++)
            {

                if (s[i] == s[i + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count == k)
                {
                    s = RemoveDuplicates(s.Substring(0, i - k + 2) + s.Substring(i + 2), k);
                }
            }

            return s;
        }
    }
}
