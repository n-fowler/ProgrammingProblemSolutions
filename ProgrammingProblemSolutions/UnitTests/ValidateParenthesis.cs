using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    class ValidateParenthesis
    {
        [TestCase("())", ExpectedResult = 1)]
        [TestCase("(((", ExpectedResult = 3)]
        [TestCase("()", ExpectedResult = 0)]
        [TestCase("()))((", ExpectedResult = 4)]
        public int ValidateParenthesisTest(string s)
        {
            return new ValidateParenthesisProcessor().MinAddToMakeValid(s);
        }
    }
}
