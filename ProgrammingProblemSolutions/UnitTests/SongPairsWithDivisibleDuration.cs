using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class SongPairsWithDivisibleDuration
    {
        [TestCase()]
        public void SongPairsWithDivisbleDurationTestOne()
        {
            int[] inputArray = { 30, 20, 150, 100, 40 };

            Assert.AreEqual(3, new SongPairsWithDivisibleDurationProcessor().NumPairsDivisbleBy60(inputArray));
        }

        [TestCase()]
        public void SongPairsWithDivisbleDurationTestTwo()
        {
            int[] inputArray = { 60, 60, 60 };

            Assert.AreEqual(3, new SongPairsWithDivisibleDurationProcessor().NumPairsDivisbleBy60(inputArray));
        }

        [TestCase()]
        public void SongPairsWithDivisbleDurationTestThree()
        {
            int[] inputArray = { 15, 63, 451, 213, 37, 209, 343, 319 };

            Assert.AreEqual(1, new SongPairsWithDivisibleDurationProcessor().NumPairsDivisbleBy60(inputArray));
        }
    }
}
