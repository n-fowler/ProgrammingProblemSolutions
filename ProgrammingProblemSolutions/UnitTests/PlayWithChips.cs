using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class PlayWithChips
    {
        [TestCase()]
        public void PlayWithChipsTestOne()
        {
            int[] chips = { 1, 2, 3 };
            Assert.AreEqual(1, new PlayWithChipsProcessor().MinCostToMoveChips(chips));
        }

        [TestCase()]
        public void PlayWithChipsTestTwo()
        {
            int[] chips = { 2, 2, 2, 3, 3 };
            Assert.AreEqual(2, new PlayWithChipsProcessor().MinCostToMoveChips(chips));
        }
    }
}
