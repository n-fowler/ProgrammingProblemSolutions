using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.InterviewProblems;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class Palindrome
    {
        [TestCase("dog", ExpectedResult = false)]
        [TestCase("redivider", ExpectedResult = true)]
        [TestCase("deified", ExpectedResult = true)]
        [TestCase("civic", ExpectedResult = true)]
        public bool PalindromeTest(string word)
        {
            return new PalindromeProcessor().IsPalindrome(word);
        }
    }
}
