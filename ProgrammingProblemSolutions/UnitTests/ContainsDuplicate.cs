using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.InterviewProblems;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class ContainsDuplicate
    {
        [TestCase()]
        public void ContainsDuplicateTest1()
        {
            int[] inputArray = { 1, 2, 3, 1 };

            Assert.AreEqual(true, new ContainsDuplicateProblem().ContainsDuplicate(inputArray));
        }

        [TestCase()]
        public void ContainsDuplicateTest2()
        {
            int[] inputArray = { 1, 2, 3, 4 };

            Assert.AreEqual(false, new ContainsDuplicateProblem().ContainsDuplicate(inputArray));
        }

        [TestCase()]
        public void ContainsDuplicateTest3()
        {
            int[] inputArray = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

            Assert.AreEqual(true, new ContainsDuplicateProblem().ContainsDuplicate(inputArray));
        }
    }
}
