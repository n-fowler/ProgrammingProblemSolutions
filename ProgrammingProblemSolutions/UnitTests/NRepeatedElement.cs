using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture]
    public class NRepeatedElement
    {
        [TestCase]
        public void NRepeatedElementTest()
        {
            int[] testArray1Input = { 1, 2, 3, 3 };
            int testArray1Result = 3;

            int[] testArray2Input = { 2, 1, 2, 5, 3, 2 };
            int testArray2Result = 2;

            int[] testArray3Input = { 5, 1, 5, 2, 5, 3, 5, 4 };
            int testArray3Result = 5;

            Assert.AreEqual(testArray1Result, new NRepeatedElementProcessor().RepeatedNTimes(testArray1Input));
            Assert.AreEqual(testArray2Result, new NRepeatedElementProcessor().RepeatedNTimes(testArray2Input));
            Assert.AreEqual(testArray3Result, new NRepeatedElementProcessor().RepeatedNTimes(testArray3Input));
        }
    }
}
