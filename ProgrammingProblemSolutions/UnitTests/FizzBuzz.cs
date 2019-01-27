using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.InterviewProblems;
using System.Collections.Generic;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class FizzBuzz
    {
        [TestCase()]
        public void FizzBuzzTest()
        {
            IList<string> expectedResult = new List<string>
            {
                "1",
                "2",
                "Fizz",
                "4",
                "Buzz",
                "Fizz",
                "7",
                "8",
                "Fizz",
                "Buzz",
                "11",
                "Fizz",
                "13",
                "14",
                "FizzBuzz"
            };

            IList<string> actualResult = new FizzBuzzProblem().FizzBuzz(15);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
