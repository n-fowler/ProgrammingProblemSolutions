namespace ProgrammingProblemSolutions.InterviewProblems
{
    public class PalindromeProcessor
    {
        public bool IsPalindrome(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
