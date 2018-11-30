using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture]
    public class ToLowerCase
    {
        [TestCase("Hello", ExpectedResult = "hello")]
        [TestCase("here", ExpectedResult = "here")]
        [TestCase("LOVELY", ExpectedResult = "lovely")]
        public string ToLowerCaseTest(string str)
        {
            return new ToLowerCaseProcessor().ToLowerCase(str);
        }
    }
}
