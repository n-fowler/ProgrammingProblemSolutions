using NUnit.Framework;
using ProgrammingProblemSolutions.ProgrammingProblemCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class SmallerNumbersThanCurrent
    {
        [TestCase()]
        public void SmallerNumbersThanCurrentTestOne()
        {
            int[] input = { 8, 1, 2, 2, 3 };
            int[] expectedOutput = { 4, 0, 1, 1, 3 };

            int[] actualOutput = new SmallerNumbersThanCurrentProcessor().SmallerNumbersThanCurrent(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestCase()]
        public void SmallerNumbersThanCurrentTestTwo()
        {
            int[] input = { 6, 5, 4, 8 };
            int[] expectedOutput = { 2, 1, 0, 3 };

            int[] actualOutput = new SmallerNumbersThanCurrentProcessor().SmallerNumbersThanCurrent(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestCase()]
        public void SmallerNumbersThanCurrentTestThree()
        {
            int[] input = { 7, 7, 7, 7 };
            int[] expectedOutput = { 0, 0, 0, 0 };

            int[] actualOutput = new SmallerNumbersThanCurrentProcessor().SmallerNumbersThanCurrent(input);

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
