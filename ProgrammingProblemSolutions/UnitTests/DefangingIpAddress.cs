using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class DefangingIpAddress
    {
        [TestCase("1.1.1.1", ExpectedResult = "1[.]1[.]1[.]1")]
        public string DefangingIpAddressTest(string input)
        {
            return new DefangingIpAddressProcessor().DefangIPaddr(input);
        }
    }
}
