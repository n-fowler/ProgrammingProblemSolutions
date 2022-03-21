using NUnit.Framework;
using ProgrammingProblemSolutions.ProgrammingProblemCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class RunningSum
    {
        [TestCase()]
        public void RunningSumTestOne()
        {
            int[] input = { 1, 2, 3, 4 };
            int[] output = new RunningSumProcessor().RunningSum(input);

            int[] expectedOutput = new int[] { 1, 3, 6, 10 };

            Assert.AreEqual(expectedOutput, output);
        }

        [TestCase()]
        public void RunningSumTestTwo()
        {
            int[] input = { 1, 1, 1, 1, 1 };
            int[] output = new RunningSumProcessor().RunningSum(input);

            int[] expectedOutput = new int[] { 1, 2, 3, 4, 5 };

            Assert.AreEqual(expectedOutput, output);
        }

        [TestCase()]
        public void RunningSumTestThree()
        {
            int[] input = { 3, 1, 2, 10, 1 };
            int[] output = new RunningSumProcessor().RunningSum(input);

            int[] expectedOutput = new int[] { 3, 4, 6, 16, 17 };

            Assert.AreEqual(expectedOutput, output);
        }
    }
}
