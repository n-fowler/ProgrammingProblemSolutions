using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class ArrayPartition
    {
        [TestCase()]
        public void ArrayPartitionTest()
        {
            int[] input = { 1, 4, 3, 2 };
            Assert.AreEqual(4, new ArrayPartitionProcessor().ArrayPairSum(input));
        }
    }
}
