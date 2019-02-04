using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.InterviewProblems;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class MajorityElement
    {
        [TestCase()]
        public void MajorityElementTest1()
        {
            int[] inputArray = { 3, 2, 3 };

            Assert.AreEqual(3, new MajorityElementProblem().MajorityElement(inputArray));
        }

        [TestCase()]
        public void MajorityElementTest2()
        {
            int[] inputArray = { 2, 2, 1, 1, 1, 2, 2 };

            Assert.AreEqual(2, new MajorityElementProblem().MajorityElement(inputArray));
        }
    }
}
