using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class PerfectNumber
    {
        [TestCase(28, ExpectedResult = true)]
        public bool PerfectNumberTest1(int number)
        {
            return new PerfectNumberProcessor().CheckPerfectNumber(number);
        }
    }
}
