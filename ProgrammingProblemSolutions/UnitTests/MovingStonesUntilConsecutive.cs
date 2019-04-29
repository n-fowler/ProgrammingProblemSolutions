using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class MovingStonesUntilConsecutive
    {
        [TestCase()]
        public void MovingStonesUntilConsecutiveTestOne()
        {
            int a = 1, b = 2, c = 5;
            int[] expectedOutput = { 1, 2 };

            Assert.AreEqual(expectedOutput, new MovingStonesUntilConsecutiveProcessor().NumMovesStones(a, b, c));
        }

        [TestCase()]
        public void MovingStonesUntilConsecutiveTestTwo()
        {
            int a = 4, b = 3, c = 2;
            int[] expectedOutput = { 0, 0 };

            Assert.AreEqual(expectedOutput, new MovingStonesUntilConsecutiveProcessor().NumMovesStones(a, b, c));
        }

        [TestCase()]
        public void MovingStonesUntilConsecutiveTestThree()
        {
            int a = 2, b = 4, c = 1;
            int[] expectedOutput = { 1, 1 };

            Assert.AreEqual(expectedOutput, new MovingStonesUntilConsecutiveProcessor().NumMovesStones(a, b, c));
        }
    }
}
