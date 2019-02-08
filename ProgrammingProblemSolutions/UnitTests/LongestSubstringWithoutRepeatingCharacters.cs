using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class LongestSubstringWithoutRepeatingCharacters
    {
        [TestCase("abcabcbb", ExpectedResult = 3)]
        [TestCase("bbbbb", ExpectedResult = 1)]
        [TestCase("pwwkew", ExpectedResult = 3)]
        [TestCase(" ", ExpectedResult = 1)]
        [TestCase("aab", ExpectedResult = 2)]
        [TestCase("dvdf", ExpectedResult = 3)]
        public int LongestSubstringWithoutRepeatingCharactersTest(string s)
        {
            return new LongestSubstringWithoutRepeatingCharactersProcessor().LengthOfLongestSubstring(s);
        }
    }
}
