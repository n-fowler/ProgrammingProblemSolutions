using NUnit.Framework;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture]
    public class MaximumBalloons
    {
        [TestCase("nlaebolko", ExpectedResult = 1)]
        [TestCase("loonbalxballpoon", ExpectedResult = 2)]
        [TestCase("leetcode", ExpectedResult = 0)]
        [TestCase("balon", ExpectedResult = 0)]
        public int MaximumBalloonsTest(string inputText)
        {
            return new MaximumBalloonsProcessor().MaxNumberOfBalloons(inputText);
        }
    }
}
