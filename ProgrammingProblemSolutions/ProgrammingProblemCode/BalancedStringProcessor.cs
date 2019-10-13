namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class BalancedStringProcessor
    {
        public int BalancedStringSplit(string s)
        {
            int lCount = 0;
            int rCount = 0;
            int splitCount = 0;

            foreach (char c in s)
            {
                if (c == 'L')
                {
                    lCount++;
                }
                else
                {
                    rCount++;
                }

                if (lCount == rCount)
                {
                    splitCount++;
                    lCount = 0;
                    rCount = 0;
                }
            }

            return splitCount;
        }
    }
}
