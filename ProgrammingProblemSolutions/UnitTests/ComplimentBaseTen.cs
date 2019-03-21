using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class ComplimentBaseTen
    {
        [TestCase(5, ExpectedResult = 2)]
        [TestCase(7, ExpectedResult = 0)]
        [TestCase(10, ExpectedResult = 5)]
        public int ComplimentBaseTenTest(int num)
        {
            return new ComplimentBaseTenProcessor().BitwiseComplement(num);
        }
    }
}
