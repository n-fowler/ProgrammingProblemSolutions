using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    class UglyNumber
    {
        [TestCase(3, 2, 3, 5, ExpectedResult = 4)]
        [TestCase(4, 2, 3, 4, ExpectedResult = 6)]
        [TestCase(5, 2, 11, 13, ExpectedResult = 10)]
        [TestCase(1000000000, 2, 217983653, 336916467, ExpectedResult = 1999999984)]
        public int UglyNumberTest(int n, int a, int b, int c)
        {
            return new UglyNumberProcessor().NthUglyNumber(n, a, b, c);
        }
    }
}
