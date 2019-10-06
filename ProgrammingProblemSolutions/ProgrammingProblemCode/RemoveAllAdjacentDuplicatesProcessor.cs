namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class RemoveAllAdjacentDuplicatesProcessor
    {
        public string RemoveDuplicates(string S)
        {
            for (int i = 0; i < S.Length - 1; i++)
            {
                if (S[i] == S[i + 1])
                {
                    S = RemoveDuplicates(S.Substring(0, i) + S.Substring(i + 2));
                }
            }

            return S;
        }
    }
}
