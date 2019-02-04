using NUnit.Framework;
using NUnit.Framework.Internal;
using ProgrammingProblemSolutions.ProgrammingProblemCode;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class SubdomainVisitCount
    {
        [TestCase()]
        public void SubDomainVisitCountTest1()
        {
            string[] inputArray = { "9001 discuss.leetcode.com" };
            string[] expectedOutput = { "9001 discuss.leetcode.com", "9001 leetcode.com", "9001 com" };

            Assert.AreEqual(expectedOutput, new SubdomainVisitCountProcessor().SubdomainVisits(inputArray));
        }

        [TestCase()]
        public void SubDomainVisitCountTest2()
        {
            string[] inputArray = { "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" };
            string[] expectedOutput = { "900 google.mail.com", "901 mail.com", "951 com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org", "5 org" };

            Assert.AreEqual(expectedOutput, new SubdomainVisitCountProcessor().SubdomainVisits(inputArray));
        }
    }
}
