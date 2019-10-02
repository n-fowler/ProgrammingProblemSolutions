using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class RemoveAllAdjacentDuplicatesInStringTwo
    {
        [TestCase("abcd", 2, ExpectedResult = "abcd")]
        [TestCase("deeedbbcccbdaa", 3, ExpectedResult = "aa")]
        [TestCase("pbbcggttciiippooaais", 2, ExpectedResult = "ps")]
        [TestCase("s", 2, ExpectedResult = "s")]
        public string RemoveDuplicatesTest(string s, int k)
        {
            return new RemoveAllAdjacentDuplicatesInStringTwoProcessor().RemoveDuplicates(s, k);
        }
    }
}
