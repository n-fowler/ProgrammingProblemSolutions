using NUnit.Framework;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class SubrectangleQueries
    {
        [TestCase()]
        public void SubrectangleQueriesTest()
        {
            int[][] subrectangle = new int[][] 
            {
                new[] { 1, 2, 1 }, 
                new[] { 4, 3, 4 }, 
                new[] { 3, 2, 1 }, 
                new[] { 1, 1, 1 } 
            };
            var subrectangleQueries = new SubrectangleQueriesProcessor(subrectangle);
            Assert.AreEqual(1, subrectangleQueries.GetValue(0, 2));
            subrectangleQueries.UpdateSubrectangle(0, 0, 3, 2, 5);
            Assert.AreEqual(5, subrectangleQueries.GetValue(0, 2));
            Assert.AreEqual(5, subrectangleQueries.GetValue(3, 1));
            subrectangleQueries.UpdateSubrectangle(3, 0, 3, 2, 10);
            Assert.AreEqual(10, subrectangleQueries.GetValue(3, 1));
            Assert.AreEqual(5, subrectangleQueries.GetValue(0, 2));
        }
    }
}
