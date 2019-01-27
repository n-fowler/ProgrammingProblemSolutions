using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class SortArrayByParity
    {
        [TestCase()]
        public void SortArrayByParityTest()
        {
            int[] inputArray = { 3, 1, 2, 4 };
            int[] expectedOutput = { 2, 4, 3, 1 };

            Assert.AreEqual(expectedOutput, new SortArrayByParityProcessor().SortArrayByParity(inputArray));
        }

    }
}
