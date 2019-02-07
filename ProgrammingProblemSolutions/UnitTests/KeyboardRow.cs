using NUnit.Framework;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture]
    public class KeyboardRow
    {
        [TestCase()]
        public void KeyboardRowTest()
        {
            string[] inputArray = { "Hello", "Alaska", "Dad", "Peace" };
            string[] expectedOutput = { "Alaska", "Dad" };

            Assert.AreEqual(expectedOutput, new KeyboardRowProcessor().FindWords(inputArray));
        }
    }
}
