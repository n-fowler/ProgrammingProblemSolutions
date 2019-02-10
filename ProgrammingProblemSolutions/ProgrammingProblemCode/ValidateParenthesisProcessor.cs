using System;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class ValidateParenthesisProcessor
    {
        public int MinAddToMakeValid(string S)
        {
            while (S.IndexOf("()", StringComparison.Ordinal) > -1)
            {
                S = S.Remove(S.IndexOf("()", StringComparison.Ordinal), 2);
            }

            return S.Length;
        }
    }
}
