using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class CommonCharacters
    {
        [TestCase()]
        public void CommonCharactersTestOne()
        {
            string[] testInput = { "bella", "label", "roller" };
            string[] expectedOutput = { "e", "l", "l" };

            Assert.AreEqual(expectedOutput, new CommonCharacterProcessor().CommonChars(testInput));
        }

        [TestCase()]
        public void CommonCharactersTestTwo()
        {
            string[] testInput = { "cool", "lock", "cook" };
            string[] expectedOutput = { "c", "o" };

            Assert.AreEqual(expectedOutput, new CommonCharacterProcessor().CommonChars(testInput));
        }
    }
}
