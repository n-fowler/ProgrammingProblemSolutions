using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class EqualSubstringsWithinBudget
    {
        [TestCase("abcd", "bcdf", 3, ExpectedResult = 3)]
        [TestCase("abcd", "cdef", 3, ExpectedResult = 1)]
        [TestCase("abcd", "acde", 0, ExpectedResult = 1)]
        [TestCase("abcd", "cdef", 1, ExpectedResult = 0)]
        [TestCase("pxezla", "loewbi", 25, ExpectedResult = 4)]
        [TestCase("jzmhzdq", "rymuemg", 17, ExpectedResult = 3)]
        public int EqualSubstringsWithinBudgetTest(string s, string t, int maxCost)
        {
            return new EqualSubstringsWithinBudgetProcessor().EqualSubstring(s, t, maxCost);
        }
    }
}
