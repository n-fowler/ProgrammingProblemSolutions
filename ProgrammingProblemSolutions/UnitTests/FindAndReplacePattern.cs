using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class FindAndReplacePattern
    {
        [TestCase()]
        public void FindAndReplacePatternTest()
        {
            string pattern = "abb";
            string[] words = { "abc", "deq", "mee", "aqq", "dkd", "ccc" };
            string[] expectedResult = { "mee", "aqq" };
            string[] actualResult = new FindAndReplacePatternProcessor().FindAndReplacePattern(words, pattern);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase()]
        public void FindAndReplacePatternTest2()
        {
            string pattern = "abc";
            string[] words = { "abc", "cba", "xyx", "yxx", "yyx" };
            string[] expectedResult = { "abc", "cba" };
            string[] actualResult = new FindAndReplacePatternProcessor().FindAndReplacePattern(words, pattern);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase()]
        public void FindAndReplacePatternTest3()
        {
            string pattern = "baba";
            string[] words = { "badc", "abab", "dddd", "dede", "yyxx" };
            string[] expectedResult = { "abab", "dede" };
            string[] actualResult = new FindAndReplacePatternProcessor().FindAndReplacePattern(words, pattern);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
