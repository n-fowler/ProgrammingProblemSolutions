using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.InterviewProblems;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class SingleNumber
    {
        [TestCase()]
        public void SingleNumberTest1()
        {
            int expected = 1;
            int[] inputNumbers = { 2, 2, 1 };
            int actual = new SingleNumberProblem().SingleNumber(inputNumbers);

            Assert.AreEqual(expected, actual);
        }

        [TestCase()]
        public void SingleNumberTest2()
        {
            int expected = 4;
            int[] inputNumbers = { 4, 1, 2, 1, 2 };
            int actual = new SingleNumberProblem().SingleNumber(inputNumbers);

            Assert.AreEqual(expected, actual);
        }

        [TestCase()]
        public void SingleNumberTest3()
        {
            int expected = 16;
            int[] inputNumbers = { 17, 12, 5, -6, 12, 4, 17, -5, 2, -3, 2, 4, 5, 16, -3, -4, 15, 15, -4, -5, -6 };
            int actual = new SingleNumberProblem().SingleNumber(inputNumbers);

            Assert.AreEqual(expected, actual);
        }
    }
}
