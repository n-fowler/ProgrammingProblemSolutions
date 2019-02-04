using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class MedianOfTwoSortedArrays
    {
        [TestCase()]
        public void MedianOfTwoSortedArraysTest1()
        {
            int[] inputArrayOne = { 1, 3 };
            int[] inputArrayTwo = { 2 };

            Assert.AreEqual(2.0, new MedianOfTwoSortedArraysProcessor().FindMedianSortedArrays(inputArrayOne, inputArrayTwo));
        }

        [TestCase()]
        public void MedianOfTwoSortedArraysTest2()
        {
            int[] inputArrayOne = { 1, 2 };
            int[] inputArrayTwo = { 3, 4 };

            Assert.AreEqual(2.5, new MedianOfTwoSortedArraysProcessor().FindMedianSortedArrays(inputArrayOne, inputArrayTwo));
        }

        [TestCase()]
        public void MedianOfTwoSortedArraysTest3()
        {
            int[] inputArrayOne = { };
            int[] inputArrayTwo = { 1 };

            Assert.AreEqual(1.0, new MedianOfTwoSortedArraysProcessor().FindMedianSortedArrays(inputArrayOne, inputArrayTwo));
        }

        [TestCase()]
        public void MedianOfTwoSortedArraysTest4()
        {
            int[] inputArrayOne = { 3 };
            int[] inputArrayTwo = { -2, -1 };

            Assert.AreEqual(-1.0, new MedianOfTwoSortedArraysProcessor().FindMedianSortedArrays(inputArrayOne, inputArrayTwo));
        }
    }
}
