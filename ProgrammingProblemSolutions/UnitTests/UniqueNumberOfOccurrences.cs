using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class UniqueNumberOfOccurrences
    {
        [TestCase()]
        public void UniqueOccurrencesTestOne()
        {
            int[] testArray = { 1, 2, 2, 1, 1, 3 };
            Assert.IsTrue(new UniqueNumberOfOccurrencesProcessor().UniqueOccurrences(testArray));
        }

        [TestCase()]
        public void UniqueOccurrencesTestTwo()
        {
            int[] testArray = { 1, 2 };
            Assert.IsFalse(new UniqueNumberOfOccurrencesProcessor().UniqueOccurrences(testArray));
        }

        [TestCase()]
        public void UniqueOccurrencesTestThree()
        {
            int[] testArray = { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 };
            Assert.IsTrue(new UniqueNumberOfOccurrencesProcessor().UniqueOccurrences(testArray));
        }
    }
}
