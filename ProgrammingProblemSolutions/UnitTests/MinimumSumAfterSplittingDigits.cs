using NUnit.Framework;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class MinimumSumAfterSplittingDigits
    {
        [TestCase(2932, ExpectedResult = 52)]
        [TestCase(4009, ExpectedResult = 13)]
        public int MinimumSumAfterSplittingDigitsTestOne(int input)
        {
            return new MinimumSumAfterSplittingDigitsProcessor().MinimumSum(input);
        }
    }
}
