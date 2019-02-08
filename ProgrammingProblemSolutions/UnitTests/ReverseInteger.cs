using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class ReverseInteger
    {
        [TestCase(123, ExpectedResult = 321)]
        [TestCase(-123, ExpectedResult = -321)]
        [TestCase(120, ExpectedResult = 21)]
        [TestCase(1534236469, ExpectedResult = 0)]
        public int ReverseIntegerTest(int number)
        {
            return new ReverseIntegerProcessor().Reverse(number);
        }
    }
}
