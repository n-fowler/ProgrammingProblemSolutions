using NUnit.Framework;
using ProgrammingProblemSolutions.ProgrammingProblemCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class ConcatenationOfArray
    {
        [TestCase()]
        public void ConcatenationOfArrayTestOne()
        {
            int[] input = { 1, 2, 1 };
            int[] expected = { 1, 2, 1, 1, 2, 1 };
            int[] output = new ConcatenationOfArrayProcessor().GetConcatenation(input);
            CollectionAssert.AreEqual(expected, output);
        }

        [TestCase()]
        public void ConcatenationOfArrayTestTwo()
        {
            int[] input = { 1, 3, 2, 1 };
            int[] expected = { 1, 3, 2, 1, 1, 3, 2, 1 };
            int[] output = new ConcatenationOfArrayProcessor().GetConcatenation(input);
            CollectionAssert.AreEqual(expected, output);
        }
    }
}
