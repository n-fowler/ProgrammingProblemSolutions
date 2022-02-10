using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class RichestCustomerWealth
    {
        [TestCase(ExpectedResult = 6)]
        public int RichestCustomerWealthTestOne()
        {
            int[][] input = { new int[] { 1,2,3 }, new int[] { 3,2,1 } };
            return new RichestCustomerWealthProcessor().MaximumWealth(input);
        }

        [TestCase(ExpectedResult = 10)]
        public int RichestCustomerWealthTestTwo()
        {
            int[][] input = { new int[] { 1, 5 }, new int[] { 7,3 }, new int[] { 3,5 } };
            return new RichestCustomerWealthProcessor().MaximumWealth(input);
        }

        [TestCase(ExpectedResult = 17)]
        public int RichestCustomerWealthTestThree()
        {
            int[][] input = { new int[] { 2,8,7 }, new int[] { 7,1,3 }, new int[] { 1,9,5 } };
            return new RichestCustomerWealthProcessor().MaximumWealth(input);
        }
    }
}
