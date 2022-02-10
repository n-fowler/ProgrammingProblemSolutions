using NUnit.Framework;
using ProgrammingProblemSolutions.ProgrammingProblemCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class BuildArrayFromPermutation
    {
        [TestCase()]
        public void BuildArrayTestOne()
        {
            int[] input = new int[] { 0, 2, 1, 5, 3, 4 };
            int[] expected = new int[] { 0, 1, 2, 4, 5, 3 };
            int[] output = new BuildArrayFromPermutationProcessor().BuildArray(input);
            
            CollectionAssert.AreEqual(expected, output);
        }

        [TestCase()]
        public void BuildArrayTestTwo()
        {
            int[] input = new int[] { 5, 0, 1, 2, 3, 4 };
            int[] expected = new int[] { 4, 5, 0, 1, 2, 3 };
            int[] output = new BuildArrayFromPermutationProcessor().BuildArray(input);

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
