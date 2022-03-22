using NUnit.Framework;
using ProgrammingProblemSolutions.ProgrammingProblemCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class ShuffleTheArray
    {
        [TestCase()]
        public void ShuffleTheArrayTestOne()
        {
            int[] input = new int[] { 2, 5, 1, 3, 4, 7 };
            int inputN = 3;
            int[] expectedOutput = new int[] { 2, 3, 5, 4, 1, 7 };

            int[] actualOutput = new ShuffleTheArrayProcessor().Shuffle(input, inputN);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestCase()]
        public void ShuffleTheArrayTestTwo()
        {
            int[] input = new int[] { 1, 2, 3, 4, 4, 3, 2, 1 };
            int inputN = 4;
            int[] expectedOutput = new int[] { 1, 4, 2, 3, 3, 2, 4, 1 };

            int[] actualOutput = new ShuffleTheArrayProcessor().Shuffle(input, inputN);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestCase()]
        public void ShuffleTheArrayTestThree()
        {
            int[] input = new int[] { 1, 1, 2, 2 };
            int inputN = 2;
            int[] expectedOutput = new int[] { 1, 2, 1, 2 };

            int[] actualOutput = new ShuffleTheArrayProcessor().Shuffle(input, inputN);

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
