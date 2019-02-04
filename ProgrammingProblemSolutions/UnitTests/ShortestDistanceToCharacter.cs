using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class ShortestDistanceToCharacter
    {
        [TestCase()]
        public void ShortestDistanceToCharacterTest1()
        {
            string inputString = "loveleetcode";
            char inputChar = 'e';

            int[] expectedOutput = { 3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0 };

            Assert.AreEqual(expectedOutput, new ShortestDistanceToCharacterProcessor().ShortestToChar(inputString, inputChar));
        }

        [TestCase()]
        public void ShortestDistanceToCharacterTest2()
        {
            string inputString = "aaba";
            char inputChar = 'b';

            int[] expectedOutput = { 2, 1, 0, 1 };

            Assert.AreEqual(expectedOutput, new ShortestDistanceToCharacterProcessor().ShortestToChar(inputString, inputChar));
        }

        [TestCase()]
        public void ShortestDistanceToCharacterTest3()
        {
            string inputString = "abaa";
            char inputChar = 'b';

            int[] expectedOutput = { 1, 0, 1, 2 };

            Assert.AreEqual(expectedOutput, new ShortestDistanceToCharacterProcessor().ShortestToChar(inputString, inputChar));
        }
    }
}
