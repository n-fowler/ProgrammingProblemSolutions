using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class HammingDistance
    {
        [TestCase(1, 4, ExpectedResult = 2)]
        public int HammingDistanceTest(int x, int y)
        {
            return new HammingDistanceProcessor().CalculateHammingDistance(x, y);
        }
    }
}
