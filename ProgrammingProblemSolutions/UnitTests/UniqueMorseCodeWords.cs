using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture]
    public class UniqueMorseCodeWords
    {
        [Test]
        public void UniqueMorseCodeWordsTest()
        {
            string[] testWords = { "gin", "zen", "gig", "msg" };
            Assert.AreEqual(2, new UniqueMorseCodeWordsProcessor().GetUniqueTransformations(testWords));
        }
    }
}
