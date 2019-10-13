using NUnit.Framework;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture]
    public class BalancedString
    {
        [TestCase("RLRRLLRLRL", ExpectedResult = 4)]
        [TestCase("RLLLLRRRLR", ExpectedResult = 3)]
        [TestCase("LLLLRRRR", ExpectedResult = 1)]
        public int BalancedStringTest(string input)
        {
            return new BalancedStringProcessor().BalancedStringSplit(input);
        }
    }
}
