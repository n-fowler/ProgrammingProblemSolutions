using System.Text;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class RemoveOutermostParenthesisProcessor
    {
        public string RemoveOuterParentheses(string S)
        {
            StringBuilder result = new StringBuilder();
            StringBuilder substring = new StringBuilder();
            int depth = 0;

            foreach (char chr in S)
            {
                if (chr.Equals('('))
                {
                    depth++;
                }
                else
                {
                    depth--;
                }

                if (depth.Equals(0))
                {
                    result.Append(substring.ToString().Substring(1));
                    substring = new StringBuilder();
                    continue;
                }

                substring.Append(chr);
            }

            return result.ToString();
        }
    }
}
