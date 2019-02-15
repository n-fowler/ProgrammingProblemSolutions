using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.InterviewProblems;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class MissingNumber
    {
        [TestCase()]
        public void MissingNumberTest1()
        {
            int[] inputArray = { 3, 0, 1 };
            int expectedResult = 2;

            Assert.AreEqual(expectedResult, new MissingNumberProblem().MissingNumber(inputArray));
        }

        [TestCase()]
        public void MissingNumberTest2()
        {
            int[] inputArray = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            int expectedResult = 8;

            Assert.AreEqual(expectedResult, new MissingNumberProblem().MissingNumber(inputArray));
        }

        [TestCase()]
        public void MissingNumberTest3()
        {
            int[] inputArray = { 0 };
            int expectedResult = 1;

            Assert.AreEqual(expectedResult, new MissingNumberProblem().MissingNumber(inputArray));
        }

        [TestCase()]
        public void MissingNumberTest4()
        {
            int[] inputArray = { 0, 1 };
            int expectedResult = 2;

            Assert.AreEqual(expectedResult, new MissingNumberProblem().MissingNumber(inputArray));
        }
    }
}
