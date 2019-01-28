using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.InterviewProblems;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class SumOfTwoIntegers
    {
        [TestCase(1, 2, ExpectedResult = 3)]
        [TestCase(-2, 3, ExpectedResult = 1)]
        public int SumOfTwoIntegersTest(int a, int b)
        {
            return new SumOfTwoIntegersProblem().GetSum(a, b);
        }
    }
}
