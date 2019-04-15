using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class RemoveOutermostParenthesis
    {
        [TestCase("(()())(())", ExpectedResult = "()()()")]
        [TestCase("(()())(())(()(()))", ExpectedResult = "()()()()(())")]
        [TestCase("()()", ExpectedResult = "")]
        public string RemoveOutermostParenthesisTest(string input)
        {
            return new RemoveOutermostParenthesisProcessor().RemoveOuterParentheses(input);
        }
    }
}
