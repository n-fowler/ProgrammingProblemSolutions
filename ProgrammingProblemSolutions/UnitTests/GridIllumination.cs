using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class GridIllumination
    {
        [TestCase]
        public void GridIlluminationTestOne()
        {
            int gridSize = 5;
            int[][] lamps = { new[] { 0, 0 }, new[] { 4, 4 } };
            int[][] queries = { new[] { 1, 1 }, new[] { 1, 0 } };

            int[] expectedResult = { 1, 0 };

            Assert.AreEqual(expectedResult, new GridIlluminationProcessor().GridIllumination(gridSize, lamps, queries));
        }

        [TestCase]
        public void GridIlluminationTestTwo()
        {
            int gridSize = 5;
            int[][] lamps = { new[] { 0, 0 }, new[] { 1, 0 } };
            int[][] queries = { new[] { 1, 1 }, new[] { 1, 1 } };

            int[] expectedResult = { 1, 0 };

            Assert.AreEqual(expectedResult, new GridIlluminationProcessor().GridIllumination(gridSize, lamps, queries));
        }

        [TestCase]
        public void GridIlluminationTestThree()
        {
            int gridSize = 5;
            int[][] lamps = { new[] { 0, 0 }, new[] { 4, 4 } };
            int[][] queries = { new[] { 1, 1 }, new[] { 1, 1 } };

            int[] expectedResult = { 1, 1 };

            Assert.AreEqual(expectedResult, new GridIlluminationProcessor().GridIllumination(gridSize, lamps, queries));
        }

        [TestCase]
        public void GridIlluminationTestFour()
        {
            int gridSize = 5;
            int[][] lamps = { new[] { 0, 0 }, new[] { 0, 4 } };
            int[][] queries = { new[] { 0, 4 }, new[] { 0, 1 }, new[] { 1, 4 } };

            int[] expectedResult = { 1, 1, 0 };

            Assert.AreEqual(expectedResult, new GridIlluminationProcessor().GridIllumination(gridSize, lamps, queries));
        }
    }
}
