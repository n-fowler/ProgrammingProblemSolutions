using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.InterviewProblems;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class MoveZeroes
    {
        [TestCase()]
        public void MoveZeroesTest()
        {
            int[] inputArray = { 0, 1, 0, 3, 12 };
            int[] expectedOutput = { 1, 3, 12, 0, 0 };

            new MoveZeroesProblem().MoveZeroes(inputArray);

            Assert.AreEqual(expectedOutput, inputArray);
        }
    }
}
