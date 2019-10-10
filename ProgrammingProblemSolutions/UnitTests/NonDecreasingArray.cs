using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class NonDecreasingArray
    {
        [TestCase()]
        public void NonDecreasingArrayTestOne()
        {
            int[] input = { 4, 2, 3 };
            Assert.IsTrue(new NonDecreasingArrayProcessor().CheckPossibility(input));
        }

        [TestCase()]
        public void NonDecreasingArrayTestTwo()
        {
            int[] input = { 4, 2, 1 };
            Assert.IsFalse(new NonDecreasingArrayProcessor().CheckPossibility(input));
        }

        [TestCase()]
        public void NonDecreasingArrayTestThree()
        {
            int[] input = { 3, 4, 2, 3 };
            Assert.IsFalse(new NonDecreasingArrayProcessor().CheckPossibility(input));
        }

        [TestCase()]
        public void NonDecreasingArrayTestFour()
        {
            int[] input = { -1, 4, 2, 3 };
            Assert.IsTrue(new NonDecreasingArrayProcessor().CheckPossibility(input));
        }

        [TestCase()]
        public void NonDecreasingArrayTestFive()
        {
            int[] input = { 1, 3, 2 };
            Assert.IsTrue(new NonDecreasingArrayProcessor().CheckPossibility(input));
        }
    }
}
