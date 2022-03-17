using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.InterviewProblems;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class RomanToInteger
    {
        [TestCase("III", ExpectedResult = 3)]
        [TestCase("IV", ExpectedResult = 4)]
        [TestCase("IX", ExpectedResult = 9)]
        [TestCase("LVIII", ExpectedResult = 58)]
        [TestCase("MDCXCV", ExpectedResult = 1695)]
        [TestCase("MCMXCIV", ExpectedResult = 1994)]
        [TestCase("MCMXCVI", ExpectedResult = 1996)]
        public int RomanToIntegerTest(string input)
        {
            return new RomanToIntegerProblem().RomanToInt(input);
        }
    }
}
