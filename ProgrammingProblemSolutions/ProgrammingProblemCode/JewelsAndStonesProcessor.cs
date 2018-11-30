namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class JewelsAndStonesProcessor
    {
        public int GetNumberOfStones(string j, string s)
        {
            if (string.IsNullOrEmpty(j) || string.IsNullOrEmpty(s))
            {
                return 0;
            }

            char[] jewels = j.ToCharArray();
            char[] stones = s.ToCharArray();
            int numberOfJewels = 0;

            foreach (char jewel in jewels)
            {
                foreach (char stone in stones)
                {
                    if (jewel == stone)
                    {
                        numberOfJewels++;
                    }
                }
            }

            return numberOfJewels;
        }
    }
}
