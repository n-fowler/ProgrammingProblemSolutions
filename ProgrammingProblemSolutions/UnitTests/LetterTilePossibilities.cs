using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class LetterTilePossibilities
    {
        [TestCase("AAB", ExpectedResult = 8)]
        [TestCase("AAABBC", ExpectedResult = 188)]
        public int LetterTilePossibilitiesTest(string tiles)
        {
            return new LetterTilePossibilitiesProcessor().NumTilePossibilities(tiles);
        }
    }
}
