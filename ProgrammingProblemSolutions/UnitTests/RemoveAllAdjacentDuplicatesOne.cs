using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class RemoveAllAdjacentDuplicatesOne
    {
        [TestCase("abbaca", ExpectedResult = "ca")]
        public string RemoveAllAdjacentDuplicatesTest(string input)
        {
            return new RemoveAllAdjacentDuplicatesProcessor().RemoveDuplicates(input);
        }
    }
}
