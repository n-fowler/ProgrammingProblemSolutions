using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class MaxIncreaseToKeepCitySkyline
    {
        [TestCase()]
        public void MaxIncreaseToKeepCitySkylineTest()
        {
            int[][] grid =
            {
                new[] { 3, 0, 8, 4 },
                new[] { 2, 4, 5, 7 },
                new[] { 9, 2, 6, 3 },
                new[] { 0, 3, 1, 0 }
            };

            Assert.AreEqual(35, new MaxIncreaseToKeepCitySkylineProcessor().MaxIncreaseKeepingSkyline(grid));
        }
    }
}
