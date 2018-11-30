using NUnit.Framework;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase("aA", "aAAbbbb", ExpectedResult = 3)]
        [TestCase("z", "ZZ", ExpectedResult = 0)]
        public int JewelsAndStonesTest(string j, string s)
        {
            return new JewelsAndStonesProcessor().GetNumberOfStones(j, s);
        }
    }
}