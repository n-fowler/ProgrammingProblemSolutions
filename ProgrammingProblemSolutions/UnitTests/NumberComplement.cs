using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class NumberComplement
    {
        [TestCase(5, ExpectedResult = 2)]
        [TestCase(1, ExpectedResult = 0)]
        public int NumberComplementTest(int num)
        {
            return new NumberComplementProcessor().FindComplement(num);
        }
    }
}
