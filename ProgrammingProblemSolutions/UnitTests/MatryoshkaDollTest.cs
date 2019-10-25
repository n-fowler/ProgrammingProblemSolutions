using NUnit.Framework;
using NUnit.Framework.Internal;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class MatryoshkaDollTest
    {
        [TestCase()]
        public void MatryoshkaDollTesting()
        {
            Assert.AreEqual(1, new MatryoshkaDoll(new MatryoshkaDoll()).NumberOfSmallerDolls);
            Assert.AreEqual(2, new MatryoshkaDoll(new MatryoshkaDoll(new MatryoshkaDoll())).NumberOfSmallerDolls);
        }
    }
}
