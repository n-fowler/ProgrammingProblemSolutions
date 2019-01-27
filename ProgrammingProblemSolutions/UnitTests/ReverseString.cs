using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.InterviewProblems;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class ReverseString
    {
        [TestCase()]
        public void ReverseStringTest()
        {
            char[] inputArray = { 'h', 'e', 'l', 'l', 'o' };
            char[] expectedOutput = { 'o', 'l', 'l', 'e', 'h' };

            new ReverseStringProblem().ReverseString(inputArray);

            Assert.AreEqual(expectedOutput, inputArray);
        }
    }
}
