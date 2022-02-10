using NUnit.Framework;
using ProgrammingProblemSolutions.ProgrammingProblemCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class FinalValueAfterPerformingOperations
    {
        
        [TestCase(ExpectedResult = 1)]
        public int FinalValueTestOne()
        {
            string[] operations = { "--X", "X++", "X++" };
            return new FinalValueAfterPerformingOperationsProcessor().FinalValueAfterOperations(operations);
        }

        [TestCase(ExpectedResult = 3)]
        public int FinalValueTestTwo()
        {
            string[] operations = { "++X", "++X", "X++" };
            return new FinalValueAfterPerformingOperationsProcessor().FinalValueAfterOperations(operations);
        }

        [TestCase(ExpectedResult = 0)]
        public int FinalValueTestThree()
        {
            string[] operations = { "X++", "++X", "--X", "X--" };
            return new FinalValueAfterPerformingOperationsProcessor().FinalValueAfterOperations(operations);
        }
    }
}
