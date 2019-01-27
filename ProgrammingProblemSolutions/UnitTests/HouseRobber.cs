using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class HouseRobber
    {
        [TestCase()]
        public void HouseRobberTest1()
        {
            int[] testArray = { 1, 2, 3, 1 };
            Assert.AreEqual(4, new HouseRobberProcessor().Rob(testArray));
        }

        [TestCase()]
        public void HouseRobberTest2()
        {
            int[] testArray = { 2, 7, 9, 3, 1 };
            Assert.AreEqual(12, new HouseRobberProcessor().Rob(testArray));
        }

        [TestCase()]
        public void HouseRobberTest3()
        {
            int[] testArray = { 2, 1, 1, 2 };
            Assert.AreEqual(4, new HouseRobberProcessor().Rob(testArray));
        }

        [TestCase()]
        public void HouseRobberTest4()
        {
            int[] testArray = { 1, 1 };
            Assert.AreEqual(1, new HouseRobberProcessor().Rob(testArray));
        }

        [TestCase()]
        public void HouseRobberTest5()
        {
            int[] testArray = { 1, 2, 1, 0 };
            Assert.AreEqual(2, new HouseRobberProcessor().Rob(testArray));
        }

        [TestCase()]
        public void HouseRobberTest6()
        {
            int[] testArray = { 1, 2, 2, 1 };
            Assert.AreEqual(3, new HouseRobberProcessor().Rob(testArray));
        }

        [TestCase()]
        public void HouseRobberTest7()
        {
            int[] testArray = { 1, 3, 1, 3, 100 };
            Assert.AreEqual(103, new HouseRobberProcessor().Rob(testArray));
        }
    }
}
