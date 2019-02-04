using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class TwoSum
    {
        [TestCase()]
        public void TwoSumTest()
        {
            int[] inputArray = { 2, 7, 11, 15 };
            int target = 9;

            int[] expectedOutput = { 0, 1 };

            Assert.AreEqual(expectedOutput, new TwoSumProcessor().TwoSum(inputArray, target));
        }
    }
}
