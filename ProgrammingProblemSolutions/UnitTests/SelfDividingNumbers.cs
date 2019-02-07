using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class SelfDividingNumbers
    {
        [TestCase()]
        public void SelfDividingNumbersTest()
        {
            int left = 1;
            int right = 22;
            int[] expectedOutput = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22 };

            Assert.AreEqual(expectedOutput, new SelfDividingNumbersProcessor().SelfDividingNumbers(left, right));
        }
    }
}
