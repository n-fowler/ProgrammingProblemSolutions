using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class SquaresOfSortedArray
    {
        [TestCase()]
        public void SquaresOfSortedArrayTest1()
        {
            int[] inputArray = { -4, -1, 0, 3, 10 };
            int[] expectedOutput = { 0, 1, 9, 16, 100 };

            Assert.AreEqual(expectedOutput, new SquaresOfSortedArrayProcessor().SortedSquares(inputArray));
        }

        [TestCase()]
        public void SquaresOfSortedArrayTest2()
        {
            int[] inputArray = { -7, -3, 2, 3, 11 };
            int[] expectedOutput = { 4, 9, 9, 49, 121 };

            Assert.AreEqual(expectedOutput, new SquaresOfSortedArrayProcessor().SortedSquares(inputArray));
        }
    }
}
