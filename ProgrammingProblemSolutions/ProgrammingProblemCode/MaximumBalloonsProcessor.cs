using System.Linq;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class MaximumBalloonsProcessor
    {
        public int MaxNumberOfBalloons(string text)
        {
            int a = 0;
            int b = 0;
            int l = 0;
            int n = 0;
            int o = 0;

            foreach (char c in text)
            {
                switch (c)
                {
                    case 'a':
                        a++;
                        break;
                    case 'b':
                        b++;
                        break;
                    case 'l':
                        l++;
                        break;
                    case 'n':
                        n++;
                        break;
                    case 'o':
                        o++;
                        break;
                }
            }

            int[] result = { a, b, l / 2, n, o / 2 };
            return result.Min();
        }
    }
}
