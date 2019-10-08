using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class DayOfTheWeek
    {
        [TestCase(31, 8, 2019, ExpectedResult = "Saturday")]
        [TestCase(18, 7, 1999, ExpectedResult = "Sunday")]
        [TestCase(15, 8, 1993, ExpectedResult = "Sunday")]
        public string DayOfTheWeekTest(int day, int month, int year)
        {
            return new DayOfTheWeekProcessor().DayOfTheWeek(day, month, year);
        }
    }
}
