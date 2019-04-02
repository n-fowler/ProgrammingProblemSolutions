using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;
using System.Collections.Generic;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class BinaryPrefixDivisibleByFive
    {
        [TestCase()]
        public void BinaryPrefixDivisibleByFiveTestOne()
        {
            int[] inputArray = { 0, 1, 1 };
            List<bool> expectedResult = new List<bool> { true, false, false };

            Assert.AreEqual(expectedResult, new BinaryPrefixDivisibleByFiveProcessor().PrefixesDivBy5(inputArray));
        }

        [TestCase()]
        public void BinaryPrefixDivisibleByFiveTestTwo()
        {
            int[] inputArray = { 1, 1, 1 };
            List<bool> expectedResult = new List<bool> { false, false, false };

            Assert.AreEqual(expectedResult, new BinaryPrefixDivisibleByFiveProcessor().PrefixesDivBy5(inputArray));
        }

        [TestCase()]
        public void BinaryPrefixDivisibleByFiveTestThree()
        {
            int[] inputArray = { 0, 1, 1, 1, 1, 1 };
            List<bool> expectedResult = new List<bool> { true, false, false, false, true, false };

            Assert.AreEqual(expectedResult, new BinaryPrefixDivisibleByFiveProcessor().PrefixesDivBy5(inputArray));
        }

        [TestCase()]
        public void BinaryPrefixDivisibleByFiveTestFour()
        {
            int[] inputArray = { 1, 1, 1, 0, 1 };
            List<bool> expectedResult = new List<bool> { false, false, false, false, false };

            Assert.AreEqual(expectedResult, new BinaryPrefixDivisibleByFiveProcessor().PrefixesDivBy5(inputArray));
        }

        [TestCase()]
        public void BinaryPrefixDivisibleByFiveTestFive()
        {
            int[] inputArray = { 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 1 };
            List<bool> expectedResult = new List<bool> { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, true, true, true, true, false };

            Assert.AreEqual(expectedResult, new BinaryPrefixDivisibleByFiveProcessor().PrefixesDivBy5(inputArray));
        }
    }
}
